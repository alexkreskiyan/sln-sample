using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DKH.Platform.Http;

public static class ProgramBuilderExtensions
{
    public static IWebProgramBuilder AddHttpServer(this IWebProgramBuilder builder, int port)
    {
        builder.ConfigureServices(hostBuilder =>
        {
            var services = hostBuilder.Services;

            hostBuilder.WebHost.UseKestrel(options =>
            {
                //
                options.ListenAnyIP(port);
            });

            services.AddControllers();
        });

        builder.ConfigureApp(app =>
        {
            app.MapControllers();
        });

        return builder;
    }
}
