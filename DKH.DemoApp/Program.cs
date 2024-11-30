using DKH.Platform;
using DKH.Platform.Redis;

await PlatformProgram
    .Create(args)
    .ConfigureServices(_ => { })
    .ConfigureApp(_ => { })
    .AddRedis(new RedisSettings())
    .RunAsync();
