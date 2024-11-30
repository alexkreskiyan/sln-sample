using Microsoft.Extensions.DependencyInjection;

namespace DKH.Platform.Redis;

public static class ProgramBuilderExtensions
{
    public static IProgramBuilder AddRedis(
        this IProgramBuilder builder,
        RedisSettings redisSettings
    )
    {
        return builder.ConfigureServices(b => b.Services.AddSingleton(redisSettings));
    }
}
