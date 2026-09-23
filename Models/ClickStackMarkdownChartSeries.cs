using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackMarkdownChartSeries
{
    /// <summary>
    /// Series type discriminator. Must be "markdown" for markdown text widgets.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "markdown";

    /// <summary>
    /// Markdown content to render inside the widget.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
