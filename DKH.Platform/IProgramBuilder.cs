namespace DKH.Platform;

public interface IProgramBuilder
{
    IProgramBuilder ConfigureServices(Action<WebApplicationBuilder> webBuilder);
    IProgramBuilder ConfigureApp(Action<WebApplication> webBuilder);
    Task<int> RunAsync();
}
