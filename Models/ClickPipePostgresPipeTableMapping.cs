using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePostgresPipeTableMapping
{
    /// <summary>
    /// PostgreSQL source schema name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceSchemaName")]
    public string? SourceSchemaName { get; init; }

    /// <summary>
    /// PostgreSQL source table name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceTable")]
    public string? SourceTable { get; init; }

    /// <summary>
    /// ClickHouse target table name, optionally prefixed with schema name (e.g., "my_schema_my_table"). The table will be created automatically if it does not exist. For snapshot mode, the target table must be empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetTable")]
    public string? TargetTable { get; init; }

    /// <summary>
    /// List of column names to exclude from replication. Column names must be unique within this list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excludedColumns")]
    [UniqueItems]
    public IReadOnlyList<string>? ExcludedColumns { get; init; }

    /// <summary>
    /// Whether to use a custom sorting key. If true, sortingKeys must be provided. If false or omitted, the default sorting key is the PostgreSQL primary key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useCustomSortingKey")]
    public bool? UseCustomSortingKey { get; init; }

    /// <summary>
    /// Ordered list of column names to use as the sorting (ORDER BY) key in ClickHouse. Only used when useCustomSortingKey is true. Column names must be unique within this list.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sortingKeys")]
    [UniqueItems]
    public IReadOnlyList<string>? SortingKeys { get; init; }

    /// <summary>
    /// ClickHouse table engine: "ReplacingMergeTree" (handles updates/deletes), "MergeTree" (append-only), or "Null" (forward data to materialized views without storing it).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableEngine")]
    public TableEngine? TableEngine { get; init; }

    /// <summary>
    /// Custom partitioning column used for parallel snapshotting. Only beneficial for PostgreSQL 13 (no benefit for PG14+, which supports indexed ctid scans). Must be an indexed column of type: <c>smallint</c>, <c>integer</c>, <c>bigint</c>, <c>timestamp without time zone</c>, or <c>timestamp with time zone</c>. Unrelated to ClickHouse partitioning.
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
