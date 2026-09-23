using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackAggregatedColumn
{
    /// <summary>
    /// Source column name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceColumn")]
    public string? SourceColumn { get; init; }

    /// <summary>
    /// Aggregation function (e.g., count, sum, avg)
    /// </summary>
    [JsonPropertyName("aggFn")]
    public required string AggFn { get; init; }

    /// <summary>
    /// Materialized view column name
    /// </summary>
    [JsonPropertyName("mvColumn")]
    public required string MvColumn { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
