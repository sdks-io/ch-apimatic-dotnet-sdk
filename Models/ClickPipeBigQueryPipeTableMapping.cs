using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeBigQueryPipeTableMapping
{
    /// <summary>
    /// Source BigQuery dataset name.
    /// </summary>
    [JsonPropertyName("sourceDatasetName")]
    public required string SourceDatasetName { get; init; }

    /// <summary>
    /// Source table name.
    /// </summary>
    [JsonPropertyName("sourceTable")]
    public required string SourceTable { get; init; }

    /// <summary>
    /// Target ClickHouse table name.
    /// </summary>
    [JsonPropertyName("targetTable")]
    public required string TargetTable { get; init; }

    /// <summary>
    /// Columns to exclude from the target table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("excludedColumns")]
    public IReadOnlyList<string>? ExcludedColumns { get; init; }

    /// <summary>
    /// Whether to use a custom sorting key for the target table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useCustomSortingKey")]
    public bool? UseCustomSortingKey { get; init; }

    /// <summary>
    /// Ordered list of columns to use as sorting key for the target table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sortingKeys")]
    public IReadOnlyList<string>? SortingKeys { get; init; }

    /// <summary>
    /// Table engine to use for the target table.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableEngine")]
    public TableEngine4? TableEngine { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
