using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackLineBuilderChartConfig
{
    /// <summary>
    /// Display type discriminator. Must be "line" for line charts.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "line";

    /// <summary>
    /// ID of the data source to query.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// One or more aggregated values to plot. When asRatio is true, exactly two select items are required.
    /// </summary>
    [JsonPropertyName("select")]
    public required IReadOnlyList<ClickStackSelectItem> Select { get; init; }

    /// <summary>
    /// Field expression to group results by (creates separate lines per group value).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupBy")]
    public string? GroupBy { get; init; }

    /// <summary>
    /// Plot select[0] / select[1] as a ratio. Requires exactly two select items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("asRatio")]
    public bool? AsRatio { get; init; }

    /// <summary>
    /// Expand date range boundaries to the query granularity interval.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alignDateRangeToGranularity")]
    public bool? AlignDateRangeToGranularity { get; init; }

    /// <summary>
    /// Fill missing time buckets with zero instead of leaving gaps.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fillNulls")]
    public bool? FillNulls { get; init; }

    /// <summary>
    /// Set the y-axis lower bound to the minimum of the displayed data instead of zero, making small fluctuations between series easier to see.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fitYAxisToData")]
    public bool? FitYAxisToData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    /// <summary>
    /// Overlay the equivalent previous time period for comparison.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("compareToPreviousPeriod")]
    public bool? CompareToPreviousPeriod { get; init; }

    /// <summary>
    /// Maximum number of series rendered (top-N by value). Omit to use the default render cap, set 0 for unlimited, or a positive N to keep the top N series.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seriesLimit")]
    public int? SeriesLimit { get; init; }

    /// <summary>
    /// Derived series computed from the select items via letter-ref arithmetic ("A" = select[0], "B" = select[1], ...). Metric, log, and trace sources only. Cannot be combined with asRatio.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formulas")]
    public IReadOnlyList<ClickStackFormula>? Formulas { get; init; }

    /// <summary>
    /// Only meaningful with formulas. When false, only the formula series are returned; the raw operand series are hidden.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("showOperandSeries")]
    public bool? ShowOperandSeries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
