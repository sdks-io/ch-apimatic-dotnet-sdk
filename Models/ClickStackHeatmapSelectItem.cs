using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackHeatmapSelectItem
{
    /// <summary>
    /// SQL expression for the value being bucketed on the y-axis. Must be non-empty.
    /// </summary>
    [JsonPropertyName("valueExpression")]
    public required string ValueExpression { get; init; }

    /// <summary>
    /// SQL expression for the count contributing to each bucket. Defaults to "count()" in the editor when omitted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countExpression")]
    public string? CountExpression { get; init; }

    /// <summary>
    /// Scale type used to bucket values on the y-axis.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("heatmapScaleType")]
    public HeatmapScaleType? HeatmapScaleType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
