using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackHeatmapChartConfig
{
    /// <summary>
    /// Display type discriminator. Must be "heatmap" for heatmap tiles.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "heatmap";

    /// <summary>
    /// ID of the data source to query.
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; init; }

    /// <summary>
    /// Exactly one heatmap select item.
    /// </summary>
    [JsonPropertyName("select")]
    public required IReadOnlyList<ClickStackHeatmapSelectItem> Select { get; init; }

    /// <summary>
    /// Row-level filter (syntax depends on whereLanguage).
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberFormat")]
    public ClickStackNumberFormat? NumberFormat { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
