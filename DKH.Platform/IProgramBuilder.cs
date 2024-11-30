namespace DKH.Platform;

public interface IProgramBuilder
{
    IProgramBuilder ConfigureServices(Action<IHostApplicationBuilder> configure);
    IProgramBuilder ConfigureApp(Action<IHost> configure);
    Task RunAsync();
}
