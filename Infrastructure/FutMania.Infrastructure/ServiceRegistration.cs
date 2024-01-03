using FutMania.Application.Interfaces;
using FutMania.Application.Repositories;
using FutMania.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FutMania.Infrastructure;

public static class ServiceRegistration
{
    public static void AddInfrastructureServices(this IServiceCollection collection)
    {
        collection.AddScoped<ITokenHandler,TokenHandler>();
    }
}
