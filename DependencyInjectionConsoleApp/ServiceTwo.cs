using Microsoft.Extensions.Logging;

namespace DependencyInjectionConsoleApp;

public class ServiceTwo
{
    private readonly ILogger<ServiceTwo> _logger;

    public ServiceTwo(ILogger<ServiceTwo> logger)
    {
        _logger = logger;
    }

    public void DoSomething() => _logger.LogInformation("Service Two is doing something.");
}