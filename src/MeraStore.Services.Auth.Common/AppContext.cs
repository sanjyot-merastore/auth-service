using MeraStore.Shared.Kernel.Context;

namespace MeraStore.Services.Auth.Common;

/// <inheritdoc />
public class AppContext(string serviceName) : AppContextBase(serviceName)
{
  
  public static new AppContext Current => (AppContext)AppContextScope.Current;
}