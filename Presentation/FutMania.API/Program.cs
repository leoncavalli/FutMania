using FutMania.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using FutMania.Persistance;
using FutMania.Application;
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("PostgreSQL");
builder.Services.AddDbContext<FutManiaDbContext>(options => options.UseNpgsql(connectionString));
builder.Services.AddApplicationServices();

builder.Services.AddPersistenceServices();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
