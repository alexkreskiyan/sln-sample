using DKH.Platform;
using DKH.Platform.Http;

await PlatformProgram
    .CreateWeb(args)
    .AddHttpServer(5070)
    .Build()
    .RunAsync();
