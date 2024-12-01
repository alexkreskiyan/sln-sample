using Microsoft.AspNetCore.Builder;

namespace DKH.Platform;

public interface IWebProgramBuilder
{
    IWebProgramBuilder ConfigureServices(Action<WebApplicationBuilder> configure);
    IWebProgramBuilder ConfigureApp(Action<WebApplication> configure);
    WebApplication Build();
}
