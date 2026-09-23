using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeMongoDbPipeSettings
{
    /// <summary>
    /// Interval in seconds to sync data from MongoDB during CDC replication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("syncIntervalSeconds")]
    [Minimum(1)]
    public int? SyncIntervalSeconds { get; init; }

    /// <summary>
    /// Number of rows to pull in each batch during CDC replication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pullBatchSize")]
    [Minimum(1)]
    public int? PullBatchSize { get; init; }

    /// <summary>
    /// Replication mode: "cdc" (change data capture with initial snapshot), "snapshot" (one-time snapshot only), or "cdc_only" (CDC without initial snapshot).
    /// </summary>
    [JsonPropertyName("replicationMode")]
    public required ReplicationMode ReplicationMode { get; init; }

    /// <summary>
    /// Number of parallel workers to use per collection in the initial snapshot phase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initialLoadParallelism")]
    [Minimum(1)]
    public int? InitialLoadParallelism { get; init; }

    /// <summary>
    /// Number of rows per partition during the snapshot phase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snapshotNumRowsPerPartition")]
    [Minimum(1000)]
    public int? SnapshotNumRowsPerPartition { get; init; }

    /// <summary>
    /// Number of collections to snapshot in parallel during the initial load phase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snapshotNumberOfParallelTables")]
    [Minimum(1)]
    public int? SnapshotNumberOfParallelTables { get; init; }

    /// <summary>
    /// Enable hard delete behavior in ReplacingMergeTree for MongoDB DELETE operations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deleteOnMerge")]
    public bool? DeleteOnMerge { get; init; }

    /// <summary>
    /// Store JSON values in native ClickHouse JSON format. When disabled, JSON data is stored as String.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useJsonNativeFormat")]
    public bool? UseJsonNativeFormat { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
