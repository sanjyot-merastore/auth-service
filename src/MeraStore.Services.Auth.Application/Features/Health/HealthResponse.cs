namespace MeraStore.Services.Auth.Application.Features.Health;

public class HealthResponse
{
  public string Status { get; set; } = "Healthy";
  public string Service { get; set; } = default!;
  public DateTime Timestamp { get; set; }
}