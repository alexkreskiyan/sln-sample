namespace DKH.Platform.Grpc;

public static class ProgramBuilderExtensions
{
    public static IProgramBuilder AddGrpcServer(this IProgramBuilder builder)
    {
        // // WebApplication.CreateSlimBuilder(new WebApplicationOptions(){})
        // builder.ConfigureServices(b => b.Services.AddControllers());
        // builder.ConfigureApp(b => b.MapControllers());

        return builder;
    }
}
