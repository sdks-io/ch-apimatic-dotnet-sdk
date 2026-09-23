using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackCategoricalBarBuilderChartConfig
{
    /// <summary>
    /// Display type discriminator. Must be "bar" for categorical bar charts.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "bar";

    /// <summary>
    /// ID of the data source to query.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// Exactly one aggregated value used to size each bar.
    /// </summary>
    [JsonPropertyName("select")]
    public required IReadOnlyList<ClickStackSelectItem> Select { get; init; }

    /// <summary>
    /// Field expression to group results by (one bar per group value).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupBy")]
    public string? GroupBy { get; init; }

    /// <summary>
    /// Optional custom SQL ORDER BY expression (raw SQL). Overrides the default value-descending ordering and, when combined with "limit", controls which bars are kept.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    /// <summary>
    /// Maximum number of bars (SQL LIMIT). Without a custom "orderBy" the query keeps the groups with the largest aggregated values; with an "orderBy" it keeps the first bars in that order. Omit or set 0 to fetch all groups.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
