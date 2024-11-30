using Microsoft.Extensions.DependencyInjection;

namespace DKH.Platform.Http;

public static class ProgramBuilderExtensions
{
    public static IProgramBuilder AddHttpServer(this IProgramBuilder builder)
    {
        builder.ConfigureServices(b => b.Services.AddControllers());
        builder.ConfigureApp(b => b.MapControllers());

        return builder;
    }
}
