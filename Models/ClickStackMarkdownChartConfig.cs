using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackMarkdownChartConfig
{
    /// <summary>
    /// Display type discriminator. Must be "markdown" for markdown text tiles.
    /// </summary>
    [JsonPropertyName("displayType")]
    public string DisplayType { get; } = "markdown";

    /// <summary>
    /// Markdown content to render inside the tile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("markdown")]
    public string? Markdown { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
