using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackBarRawSqlChartConfig
{
    /// <summary>
    /// Must be "sql" to use the Raw SQL chart config variant.
    /// </summary>
    [JsonPropertyName("configType")]
    public string ConfigType { get; } = "sql";

    /// <summary>
    /// ID of the ClickHouse connection to execute the query against.
    /// </summary>
    [JsonPropertyName("connectionId")]
    public required string ConnectionId { get; init; }

    /// <summary>
    /// SQL query template to execute. Supports HyperDX template variables.
    /// </summary>
    [JsonPropertyName("sqlTemplate")]
    public required string SqlTemplate { get; init; }

    /// <summary>
    /// Optional ID of the data source associated with this Raw SQL chart. Used for applying dashboard filters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceId")]
    public string? SourceId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    /// <summary>
    /// Display as a stacked-bar time-series chart.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "stacked_bar";

    /// <summary>
    /// Fill missing time buckets with zero instead of leaving gaps.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fillNulls")]
    public bool? FillNulls { get; init; }

    /// <summary>
    /// Expand date range boundaries to the query granularity interval.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alignDateRangeToGranularity")]
    public bool? AlignDateRangeToGranularity { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
