using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackLineRawSqlChartConfig
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
    /// Display as a line time-series chart.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "line";

    /// <summary>
    /// Overlay the equivalent previous time period for comparison.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("compareToPreviousPeriod")]
    public bool? CompareToPreviousPeriod { get; init; }

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

    /// <summary>
    /// Set the y-axis lower bound to the minimum of the displayed data instead of zero, making small fluctuations between series easier to see.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fitYAxisToData")]
    public bool? FitYAxisToData { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
