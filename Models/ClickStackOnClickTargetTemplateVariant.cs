using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackOnClickTargetTemplateVariant
{
    /// <summary>
    /// Target is matched by name against the template.
    /// </summary>
    [JsonPropertyName("mode")]
    public string Mode { get; } = "template";

    /// <summary>
    /// Name template rendered against the clicked row; supports <c>{{column}}</c> variables.
    /// </summary>
    [JsonPropertyName("template")]
    public required string Template { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
