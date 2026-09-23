using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackBackgroundChart
{
    /// <summary>
    /// Sparkline shape.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type19 Type { get; init; }

    /// <summary>
    /// Optional palette-token override for the sparkline. When unset the sparkline inherits the tile's static color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color")]
    public Color? Color { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
