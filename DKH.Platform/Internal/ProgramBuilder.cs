namespace DKH.Platform.Internal;

internal class ProgramBuilder : IProgramBuilder
{
    private readonly HostApplicationBuilder _applicationBuilder;
    private List<Action<IHost>> _hostConfigurations = [];

    public ProgramBuilder(HostApplicationBuilder applicationBuilder)
    {
        _applicationBuilder = applicationBuilder;
    }

    public IProgramBuilder ConfigureServices(Action<IHostApplicationBuilder> configure)
    {
        configure(_applicationBuilder);

        return this;
    }

    public IProgramBuilder ConfigureApp(Action<IHost> configure)
    {
        _hostConfigurations.Add(configure);

        return this;
    }

    public Task RunAsync()
    {
        var host = _applicationBuilder.Build();
        foreach (var configureHost in _hostConfigurations)
        {
            configureHost(host);
        }

        return host.RunAsync();
    }
}
