using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePatchMongoDbPipeRemoveTableMapping
{
    /// <summary>
    /// MongoDB source database name.
    /// </summary>
    [JsonPropertyName("sourceDatabaseName")]
    public required string? SourceDatabaseName { get; init; }

    /// <summary>
    /// MongoDB source collection name.
    /// </summary>
    [JsonPropertyName("sourceCollection")]
    public required string? SourceCollection { get; init; }

    /// <summary>
    /// ClickHouse target table name. The table will be created automatically if it does not exist.
    /// </summary>
    [JsonPropertyName("targetTable")]
    public required string? TargetTable { get; init; }

    /// <summary>
    /// ClickHouse table engine: "ReplacingMergeTree" (handles updates/deletes), "MergeTree" (append-only), or "Null" (forward data to materialized views without storing it).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableEngine")]
    public TableEngine? TableEngine { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
