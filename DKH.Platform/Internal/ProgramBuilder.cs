namespace DKH.Platform.Internal;

internal class ProgramBuilder : IProgramBuilder
{
    public IProgramBuilder ConfigureServices(Action<WebApplicationBuilder> webBuilder)
    {
        throw new NotImplementedException();
    }

    public IProgramBuilder ConfigureApp(Action<WebApplication> webBuilder)
    {
        throw new NotImplementedException();
    }

    public Task<int> RunAsync()
    {
        throw new NotImplementedException();
    }
}
