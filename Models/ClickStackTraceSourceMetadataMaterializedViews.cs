using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackTraceSourceMetadataMaterializedViews
{
    /// <summary>
    /// ClickHouse table name for the key rollup (field discovery).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("keyRollupTable")]
    public string? KeyRollupTable { get; init; }

    /// <summary>
    /// ClickHouse table name for the key-value rollup (value autocomplete).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kvRollupTable")]
    public string? KvRollupTable { get; init; }

    /// <summary>
    /// The time granularity of the rollup tables.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("granularity")]
    public string? Granularity { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
