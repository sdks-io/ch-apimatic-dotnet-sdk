using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using OpenApiSpecForClickHouseCloud.Core.Hooks;

namespace OpenApiSpecForClickHouseCloud.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
