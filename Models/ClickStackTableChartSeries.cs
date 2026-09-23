using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackTableChartSeries
{
    /// <summary>
    /// Series type discriminator. Must be "table" for table charts.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "table";

    /// <summary>
    /// ID of the data source to query
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// Aggregation function to apply to the field or metric value
    /// </summary>
    [JsonPropertyName("aggFn")]
    public required AggFn AggFn { get; init; }

    /// <summary>
    /// Percentile level for quantile aggregations (e.g., 0.95 for p95)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("level")]
    public double? Level { get; init; }

    /// <summary>
    /// Column or expression to aggregate (required for most aggregation functions except count)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public string? Field { get; init; }

    /// <summary>
    /// Display name for the series
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alias")]
    public string? Alias { get; init; }

    /// <summary>
    /// Filter query for the data (syntax depends on whereLanguage)
    /// </summary>
    [JsonPropertyName("where")]
    public required string Where { get; init; }

    /// <summary>
    /// Query language for the where clause
    /// </summary>
    [JsonPropertyName("whereLanguage")]
    public required WhereLanguage WhereLanguage { get; init; }

    /// <summary>
    /// Fields to group results by (creates separate rows for each group)
    /// </summary>
    [JsonPropertyName("groupBy")]
    public required IReadOnlyList<string> GroupBy { get; init; }

    /// <summary>
    /// Sort order for table rows
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sortOrder")]
    public SortOrder? SortOrder { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    /// <summary>
    /// Metric data type, only for metrics data sources.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metricDataType")]
    public MetricDataType? MetricDataType { get; init; }

    /// <summary>
    /// Metric name for metrics data sources
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metricName")]
    public string? MetricName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
