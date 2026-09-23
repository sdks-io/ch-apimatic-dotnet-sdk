using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresServiceReadReplicaRequest
{
    /// <summary>
    /// Name of the Postgres service. Alphanumerical string with whitespaces up to 50 characters.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(50, MinimumLength = 1)]
    public required string Name { get; init; }

    /// <summary>
    /// Postgres <see href="https://www.postgresql.org/docs/current/runtime-config.html">runtime configuration</see> configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pgConfig")]
    public PostgresConfiguration? PgConfig { get; init; }

    /// <summary>
    /// PgBouncer <see href="https://www.pgbouncer.org/config.html">runtime configuration</see> configuration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pgBouncerConfig")]
    [MinProperties(1)]
    [MaxProperties(64)]
    public IReadOnlyDictionary<string, string>? PgBouncerConfig { get; init; }

    /// <summary>
    /// Tags associated with the Postgres service. Tag keys starting with “chc_” are reserved for internal use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    [MaxLength(50)]
    public IReadOnlyList<ResourceTagsV1>? Tags { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
