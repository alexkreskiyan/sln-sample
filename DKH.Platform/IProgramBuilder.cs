using Microsoft.Extensions.Hosting;

namespace DKH.Platform;

public interface IProgramBuilder
{
    IProgramBuilder ConfigureServices(Action<IHostApplicationBuilder> configure);
    IProgramBuilder ConfigureApp(Action<IHost> configure);
    IHost Build();
}
