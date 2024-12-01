using Microsoft.Extensions.Hosting;

namespace DKH.Platform.Internal;

internal class ProgramBuilder : IProgramBuilder
{
    private readonly HostApplicationBuilder _applicationBuilder;
    private readonly List<Action<IHost>> _hostConfigurations = [];

    public ProgramBuilder(string[] args)
    {
        _applicationBuilder = Host.CreateApplicationBuilder(args);
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

    public IHost Build()
    {
        var host = _applicationBuilder.Build();
        foreach (var configureHost in _hostConfigurations)
        {
            configureHost(host);
        }

        return host;
    }
}
