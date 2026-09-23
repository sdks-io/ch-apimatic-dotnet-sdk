using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackTableBuilderChartConfig
{
    /// <summary>
    /// Display type discriminator. Must be "table" for table charts.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "table";

    /// <summary>
    /// ID of the data source to query.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// One or more aggregated values to display as table columns. When asRatio is true, exactly two select items are required.
    /// </summary>
    [JsonPropertyName("select")]
    public required IReadOnlyList<ClickStackSelectItem> Select { get; init; }

    /// <summary>
    /// Field expression to group results by (one row per group value).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupBy")]
    public string? GroupBy { get; init; }

    /// <summary>
    /// Post-aggregation SQL HAVING condition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("having")]
    public string? Having { get; init; }

    /// <summary>
    /// SQL ORDER BY expression for sorting table rows.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; init; }

    /// <summary>
    /// Display select[0] / select[1] as a ratio. Requires exactly two select items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("asRatio")]
    public bool? AsRatio { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    /// <summary>
    /// When true, render Group By columns to the left of series columns in the table. Defaults to false (Group By columns on the right).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupByColumnsOnLeft")]
    public bool? GroupByColumnsOnLeft { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("onClick")]
    public ClickStackOnClick? OnClick { get; init; }

    /// <summary>
    /// Derived columns computed from the select items via letter-ref arithmetic ("A" = select[0], "B" = select[1], ...). Metric, log, and trace sources only. Cannot be combined with asRatio.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("formulas")]
    public IReadOnlyList<ClickStackFormula>? Formulas { get; init; }

    /// <summary>
    /// Only meaningful with formulas. When false, only the formula columns are returned; the raw operand columns are hidden.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("showOperandSeries")]
    public bool? ShowOperandSeries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
