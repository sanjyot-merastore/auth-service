using MeraStore.Services.Auth.Api.Filters;
using MeraStore.Services.Auth.Application;
using MeraStore.Services.Auth.Common;
using MeraStore.Services.Auth.Domain.Entities;

using System.Reflection;

namespace MeraStore.Services.AuthArchitectureTests;

public class BaseTests
{
  protected static readonly Assembly DomainAssembly = typeof(SampleEntity).Assembly;
  protected static readonly Assembly CommonAssembly = typeof(KeyStore).Assembly;
  protected static readonly Assembly ApplicationAssembly = typeof(ServiceRegistrations).Assembly;
  protected static readonly Assembly InfrastructureAssembly = typeof(Auth.Infrastructure.ServiceRegistrations).Assembly;
  protected static readonly Assembly PersistenceAssembly = typeof(Auth.Persistence.ServiceRegistrations).Assembly;
  protected static readonly Assembly ApiAssembly = typeof(MaskingFilterFactory).Assembly;


  protected static readonly string? DomainAssemblyName = "MeraStore.Services.Auth.Domain";
  protected static readonly string? CommonAssemblyName = CommonAssembly.GetName().Name;
  protected static readonly string? ApplicationAssemblyName = "MeraStore.Services.Auth.Application";
  protected static readonly string? InfrastructureAssemblyName = InfrastructureAssembly.GetName().Name;
  protected static readonly string? PersistenceAssemblyName = PersistenceAssembly.GetName().Name;
  protected static readonly string? ApiAssemblyName = ApiAssembly.GetName().Name;
}