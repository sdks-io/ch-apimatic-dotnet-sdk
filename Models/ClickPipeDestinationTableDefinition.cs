using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeDestinationTableDefinition
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("engine")]
    public ClickPipeDestinationTableEngine? Engine { get; init; }

    /// <summary>
    /// Sorting key of the destination table. List of columns.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sortingKey")]
    public IReadOnlyList<string>? SortingKey { get; init; }

    /// <summary>
    /// Partition key SQL expression.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partitionBy")]
    public string? PartitionBy { get; init; }

    /// <summary>
    /// Primary key of SQL expression.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; init; }

    /// <summary>
    /// TTL SQL expression of the destination table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ttl")]
    [MinLength(1)]
    public string? Ttl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
