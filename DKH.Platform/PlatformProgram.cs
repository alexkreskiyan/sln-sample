using DKH.Platform.Internal;

namespace DKH.Platform;

public static class PlatformProgram
{
    public static IProgramBuilder Create(string[] args)
    {
        return new ProgramBuilder(args);
    }

    public static IWebProgramBuilder CreateWeb(string[] args)
    {
        return new WebProgramBuilder(args);
    }
}
