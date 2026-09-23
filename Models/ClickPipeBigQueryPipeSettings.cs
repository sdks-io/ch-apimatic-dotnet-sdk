using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeBigQueryPipeSettings
{
    /// <summary>
    /// Replication mode. BigQuery only supports snapshot mode.
    /// </summary>
    [JsonPropertyName("replicationMode")]
    public string ReplicationMode { get; } = "snapshot";

    /// <summary>
    /// Allow nullable columns in the destination table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowNullableColumns")]
    public bool? AllowNullableColumns { get; init; }

    /// <summary>
    /// Number of parallel workers during initial load.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initialLoadParallelism")]
    public double? InitialLoadParallelism { get; init; }

    /// <summary>
    /// Number of rows to snapshot per partition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snapshotNumRowsPerPartition")]
    public double? SnapshotNumRowsPerPartition { get; init; }

    /// <summary>
    /// Number of parallel tables to snapshot.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snapshotNumberOfParallelTables")]
    public double? SnapshotNumberOfParallelTables { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
