using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackPieBuilderChartConfig
{
    /// <summary>
    /// Display type discriminator. Must be "pie" for pie charts.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "pie";

    /// <summary>
    /// ID of the data source to query.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// Exactly one aggregated value used to size each pie slice.
    /// </summary>
    [JsonPropertyName("select")]
    public required IReadOnlyList<ClickStackSelectItem> Select { get; init; }

    /// <summary>
    /// Field expression to group results by (one slice per group value).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groupBy")]
    public string? GroupBy { get; init; }

    /// <summary>
    /// Optional custom SQL ORDER BY expression (raw SQL). Overrides the default value-descending ordering and, when combined with "limit", controls which slices are kept.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("orderBy")]
    public string? OrderBy { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    /// <summary>
    /// Maximum number of slices (SQL LIMIT). Without a custom "orderBy" the query keeps the groups with the largest aggregated values; with an "orderBy" it keeps the first slices in that order. Omit or set 0 to fetch all groups.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
