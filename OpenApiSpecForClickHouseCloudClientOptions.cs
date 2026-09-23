using System.Collections.Generic;
using OpenApiSpecForClickHouseCloud.Core.Authentication.Basic;
using OpenApiSpecForClickHouseCloud.Core.Configuration;
using OpenApiSpecForClickHouseCloud.Core.Hooks;
using OpenApiSpecForClickHouseCloud.Servers;

namespace OpenApiSpecForClickHouseCloud;

public class OpenApiSpecForClickHouseCloudClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    /// <summary>
    /// Use key ID and key secret obtained in ClickHouse Cloud console: https://clickhouse.com/docs/cloud/manage/openapi
    /// </summary>
    public BasicAuthCredentials? BasicAuth { get; set; }
}
