using Testcontainers.MsSql;

namespace WeatherForecast;

public sealed class DatabaseContainer : IHostedService
{
  private readonly MsSqlContainer _sqlEdgeContainer = new MsSqlBuilder().Build();

  public Task StartAsync(CancellationToken cancellationToken)
  {
    return _sqlEdgeContainer.StartAsync(cancellationToken);
  }

  public Task StopAsync(CancellationToken cancellationToken)
  {
    return _sqlEdgeContainer.StopAsync(cancellationToken);
  }

  public string GetConnectionString()
  {
    return _sqlEdgeContainer.GetConnectionString();
  }
}
