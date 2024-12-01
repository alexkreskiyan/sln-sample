using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;

namespace DKH.Platform;

public static class ServiceCollectionExtensions
{
    public static void AddKestrelEndpoint(
        this IServiceCollection services,
        int port,
        HttpProtocols protocol
    )
    {
        services.AddSingleton(new KestrelEndpoint(port, protocol));
    }
}
