using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace DKH.Platform;

public sealed record KestrelEndpoint(int Port, HttpProtocols Protocol);
