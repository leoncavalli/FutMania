using FutMania.Application.Interfaces;
using FutMania.Application.Repositories;
using FutMania.Persistance.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FutMania.Persistance;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection collection)
    {
        collection.AddScoped<ITeamReadRepository, TeamReadRepository>();
        collection.AddScoped<ITeamWriteRepository, TeamWriteRepository>();
        collection.AddScoped<IPlayerReadRepository, PlayerReadRepository>();
        collection.AddScoped<IPlayerWriteRepository, PlayerWriteRepository>();
        collection.AddScoped<ISeasonReadRepository, SeasonReadRepository>();
        collection.AddScoped<ISeasonWriteRepository, SeasonWriteRepository>();
        collection.AddScoped<ILeagueReadRepository, LeagueReadRepository>();
        collection.AddScoped<ILeagueWriteRepository, LeagueWriteRepository>();
    }
}
