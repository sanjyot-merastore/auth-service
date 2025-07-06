using MeraStore.Services.Auth.Application;
using MeraStore.Services.Auth.Persistence;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MeraStore.Services.Auth.Infrastructure;

public static class ServiceRegistrations
{
  public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
  {

    services.AddApplicationServices(configuration);
    services.AddPersistenceServices(configuration);
    return services;
  }
}