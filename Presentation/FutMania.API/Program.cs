using FutMania.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using FutMania.Persistance;
using FutMania.Application;
using FutMania.Infrastructure;
using FutMania.Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("PostgreSQL");
builder.Services.AddDbContext<FutManiaDbContext>(options => options.UseNpgsql(connectionString));
builder.Services.AddIdentityApiEndpoints<AppUser>().AddEntityFrameworkStores<FutManiaDbContext>();

builder.Services.AddApplicationServices();

builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer("Admin",options=>{
    options.TokenValidationParameters = new(){
        ValidateAudience= true,
        ValidateIssuer  = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidAudience = builder.Configuration["Token:Audience"],
        ValidIssuer=builder.Configuration["Token:Issuer"],
        IssuerSigningKey= new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
    };
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
