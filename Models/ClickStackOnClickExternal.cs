using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackOnClickExternal
{
    /// <summary>
    /// OnClick variant discriminator. Must be "external" for external link-outs.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "external";

    /// <summary>
    /// Handlebars template rendered against the clicked row; supports <c>{{column}}</c> variables. The rendered value must be an absolute http(s) URL.
    /// </summary>
    [JsonPropertyName("urlTemplate")]
    public required string UrlTemplate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
