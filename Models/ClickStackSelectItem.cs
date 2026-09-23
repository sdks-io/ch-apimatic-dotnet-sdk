using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackSelectItem
{
    /// <summary>
    /// Aggregation function to apply. "count" does not require a valueExpression; "quantile" requires a level field indicating the desired percentile (e.g., 0.95).
    /// </summary>
    [JsonPropertyName("aggFn")]
    public required AggFn3 AggFn { get; init; }

    /// <summary>
    /// Expression for the column or value to aggregate. Must be omitted when aggFn is "count"; required for all other aggFn values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("valueExpression")]
    public string? ValueExpression { get; init; }

    /// <summary>
    /// Display alias for this select item in chart legends.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alias")]
    public string? Alias { get; init; }

    /// <summary>
    /// Percentile level; only valid when aggFn is "quantile".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("level")]
    public Level? Level { get; init; }

    /// <summary>
    /// SQL or Lucene filter condition applied before aggregation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("where")]
    public string? Where { get; init; }

    /// <summary>
    /// Query language for the where clause.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whereLanguage")]
    public WhereLanguage4? WhereLanguage { get; init; }

    /// <summary>
    /// Name of the metric to aggregate; only applicable when the source is a metrics source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metricName")]
    public string? MetricName { get; init; }

    /// <summary>
    /// Metric type; only applicable when the source is a metrics source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metricType")]
    public MetricType? MetricType { get; init; }

    /// <summary>
    /// Optional period aggregation function for Gauge metrics (e.g., compute the delta over the period).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("periodAggFn")]
    public PeriodAggFn? PeriodAggFn { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
