using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimServiceProviderConfigPatch
{
    /// <summary>
    /// Whether PATCH is supported.
    /// </summary>
    [JsonPropertyName("supported")]
    public required bool Supported { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
