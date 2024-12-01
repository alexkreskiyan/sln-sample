using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;

namespace DKH.Platform.Http;

public static class ProgramBuilderExtensions
{
    public static IWebProgramBuilder AddHttpServer(this IWebProgramBuilder builder, int port)
    {
        builder.ConfigureServices(hostBuilder =>
        {
            var services = hostBuilder.Services;
            services.AddKestrelEndpoint(port, HttpProtocols.Http1);
            services.AddControllers();
        });

        builder.ConfigureApp(app =>
        {
            app.MapControllers();
        });

        return builder;
    }
}
