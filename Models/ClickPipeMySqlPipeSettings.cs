using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeMySqlPipeSettings
{
    /// <summary>
    /// Interval in seconds to sync data from MySQL during CDC replication.
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
    /// MySQL replication mechanism: "GTID" (Global Transaction Identifier) or "FILE_POS" (binary log file and position). Defaults to "GTID" if not specified. MariaDB supports "GTID" only. For "FILE_POS" on MySQL, contact support.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicationMechanism")]
    public ReplicationMechanism? ReplicationMechanism { get; init; }

    /// <summary>
    /// Enable compression for the MySQL connection.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useCompression")]
    public bool? UseCompression { get; init; }

    /// <summary>
    /// Preserve nullability from MySQL in the destination ClickHouse table. When true, columns without NOT NULL constraints are created as Nullable(...). When false, all columns are non-nullable and NULL values are replaced with the default value for the type. Note: Nullable types have performance overhead in ClickHouse.
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
    /// Enable hard delete behavior in ReplacingMergeTree for MySQL DELETE operations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deleteOnMerge")]
    public bool? DeleteOnMerge { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
