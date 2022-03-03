namespace DependencyInjectionConsoleApp;

public class ServiceOne
{
    private readonly ServiceTwo _serviceTwo;

    public ServiceOne(ServiceTwo serviceTwo)
    {
        _serviceTwo = serviceTwo;
    }

    public void DoSomething() => _serviceTwo.DoSomething();
}