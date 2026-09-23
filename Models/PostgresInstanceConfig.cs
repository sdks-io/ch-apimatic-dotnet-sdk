using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresInstanceConfig
{
    /// <summary>
    /// Postgres <see href="https://www.postgresql.org/docs/current/runtime-config.html">runtime configuration</see> configuration.
    /// </summary>
    [JsonPropertyName("pgConfig")]
    public required PostgresConfiguration PgConfig { get; init; }

    /// <summary>
    /// PgBouncer <see href="https://www.pgbouncer.org/config.html">runtime configuration</see> configuration.
    /// </summary>
    [JsonPropertyName("pgBouncerConfig")]
    [MinProperties(1)]
    [MaxProperties(64)]
    public required IReadOnlyDictionary<string, string> PgBouncerConfig { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
