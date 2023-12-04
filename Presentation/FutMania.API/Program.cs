using FutMania.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using FutMania.Persistance.Repositories;
using FutMania.Application.Repositories;
var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("PostgreSQL");
builder.Services.AddDbContext<FutManiaDbContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddScoped<ITeamReadRepository,TeamReadRepository>();
builder.Services.AddScoped<ITeamWriteRepository,TeamWriteRepository>();
builder.Services.AddScoped<IPlayerReadRepository,PlayerReadRepository>();
builder.Services.AddScoped<IPlayerWriteRepository,PlayerWriteRepository>();
builder.Services.AddScoped<ISeasonReadRepository,SeasonReadRepository>();
builder.Services.AddScoped<ISeasonWriteRepository,SeasonWriteRepository>();
builder.Services.AddScoped<ILeagueReadRepository,LeagueReadRepository>();
builder.Services.AddScoped<ILeagueWriteRepository,LeagueWriteRepository>();

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
