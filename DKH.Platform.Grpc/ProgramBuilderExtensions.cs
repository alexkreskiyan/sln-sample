using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace DKH.Platform.Grpc;

public static class ProgramBuilderExtensions
{
    public static IWebProgramBuilder AddGrpcServer(this IWebProgramBuilder builder, int port)
    {
        builder.ConfigureServices(hostBuilder =>
        {
            hostBuilder.Services.AddKestrelEndpoint(port, HttpProtocols.Http2);
        });

        builder.ConfigureApp(app =>
        {
            // configure grpc
        });

        return builder;
    }
}
