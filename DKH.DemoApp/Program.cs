using DKH.Platform;
using DKH.Platform.Grpc;
using DKH.Platform.Http;

await PlatformProgram
    .CreateWeb(args)
    .AddGrpcServer(5060)
    .AddHttpServer(5070)
    .Build()
    .RunAsync();
