using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePatchMySqlPipeRemoveTableMapping
{
    /// <summary>
    /// MySQL source database name.
    /// </summary>
    [JsonPropertyName("sourceSchemaName")]
    public required string? SourceSchemaName { get; init; }

    /// <summary>
    /// MySQL source table name.
    /// </summary>
    [JsonPropertyName("sourceTable")]
    public required string? SourceTable { get; init; }

    /// <summary>
    /// ClickHouse target table name, optionally prefixed with schema name (e.g., "my_database_my_table"). The table will be created automatically if it does not exist. For snapshot mode, the target table must be empty.
    /// </summary>
    [JsonPropertyName("targetTable")]
    public required string? TargetTable { get; init; }

    /// <summary>
    /// ClickHouse table engine: "ReplacingMergeTree" (handles updates/deletes), "MergeTree" (append-only), or "Null" (forward data to materialized views without storing it).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableEngine")]
    public TableEngine? TableEngine { get; init; }

    /// <summary>
    /// Custom partitioning column used for parallel snapshotting. Must be an indexed column of an integer, date, datetime or timestamp type. Unrelated to ClickHouse partitioning.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; init; }

    /// <summary>
    /// ClickHouse PARTITION BY expression applied to the destination table when ClickPipes creates it.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partitionByExpr")]
    public string? PartitionByExpr { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
