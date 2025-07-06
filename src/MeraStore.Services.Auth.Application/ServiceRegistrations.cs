using MediatR;
using MeraStore.Services.Auth.Application.Behaviours;
using MeraStore.Services.Auth.Application.Features.Health;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MeraStore.Services.Auth.Application;

public static class ServiceRegistrations
{
  public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
  {

    services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetHealthQuery).Assembly));
    services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
    return services;
  }
}