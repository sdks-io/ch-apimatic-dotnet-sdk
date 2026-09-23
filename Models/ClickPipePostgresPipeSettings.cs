using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePostgresPipeSettings
{
    /// <summary>
    /// Interval in seconds to sync data from Postgres during CDC replication.
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
    /// PostgreSQL publication name to use for CDC replication. If not provided, ClickPipes will create one automatically.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publicationName")]
    public string? PublicationName { get; init; }

    /// <summary>
    /// Replication mode: "cdc" (change data capture with initial snapshot), "snapshot" (one-time snapshot only), or "cdc_only" (CDC without initial snapshot).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicationMode")]
    public ReplicationMode? ReplicationMode { get; init; }

    /// <summary>
    /// PostgreSQL replication slot name. Only valid for "cdc_only" mode. For "cdc" mode, ClickPipes creates the slot automatically.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicationSlotName")]
    public string? ReplicationSlotName { get; init; }

    /// <summary>
    /// Preserve nullability from Postgres in the destination ClickHouse table. When true, columns without NOT NULL constraints are created as Nullable(...). When false, all columns are non-nullable and NULL values are replaced with the default value for the type. Note: Nullable types have performance overhead in ClickHouse.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowNullableColumns")]
    public bool? AllowNullableColumns { get; init; }

    /// <summary>
    /// Number of parallel workers to use per table in the initial snapshot phase.
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
    /// Number of tables to snapshot in parallel during the initial load phase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snapshotNumberOfParallelTables")]
    [Minimum(1)]
    public int? SnapshotNumberOfParallelTables { get; init; }

    /// <summary>
    /// Enable failover support for the replication slot on PG17 and newer. Only applicable when ClickPipes creates the replication slot (i.e., replicationSlotName is NOT provided).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableFailoverSlots")]
    public bool? EnableFailoverSlots { get; init; }

    /// <summary>
    /// Enable hard delete behavior in ReplacingMergeTree for PostgreSQL DELETE operations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deleteOnMerge")]
    public bool? DeleteOnMerge { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
