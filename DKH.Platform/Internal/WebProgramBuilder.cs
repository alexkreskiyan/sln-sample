using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DKH.Platform.Internal;

internal class WebProgramBuilder : IWebProgramBuilder
{
    private readonly WebApplicationBuilder _applicationBuilder;
    private readonly List<Action<WebApplication>> _hostConfigurations = [];

    public WebProgramBuilder(string[] args)
    {
        _applicationBuilder = WebApplication.CreateBuilder(args);
    }

    public IWebProgramBuilder ConfigureServices(Action<WebApplicationBuilder> configure)
    {
        configure(_applicationBuilder);

        return this;
    }

    public IWebProgramBuilder ConfigureApp(Action<WebApplication> configure)
    {
        _hostConfigurations.Add(configure);

        return this;
    }

    public WebApplication Build()
    {
        _applicationBuilder.WebHost.UseKestrel(options =>
        {
            var endpoints = options.ApplicationServices.GetRequiredService<
                IEnumerable<KestrelEndpoint>
            >();
            foreach (var endpoint in endpoints)
            {
                Console.WriteLine($"Listening on port {endpoint.Port} ({endpoint.Protocol})");
                options.ListenAnyIP(endpoint.Port, opts => opts.Protocols = endpoint.Protocol);
            }
        });

        var host = _applicationBuilder.Build();
        foreach (var configureHost in _hostConfigurations)
        {
            configureHost(host);
        }

        return host;
    }
}
