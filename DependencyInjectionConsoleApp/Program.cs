using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DependencyInjectionConsoleApp
{
    public class Program
    {
        private readonly ILogger<Program> _logger;
        private readonly ServiceOne _serviceOne;

        public Program(ILogger<Program> logger, ServiceOne serviceOne)
        {
            _logger = logger;
            _serviceOne = serviceOne;
        }

        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Program>().Run();
        }

        private void Run()
        {
            _logger.LogInformation("Program is running.");
            _serviceOne.DoSomething();
            _logger.LogInformation("Program is completed.");
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Program>();
                    services.AddTransient<ServiceOne>();
                    services.AddTransient<ServiceTwo>();
                });
        }
    }
}