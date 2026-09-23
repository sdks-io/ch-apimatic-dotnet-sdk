using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimBooleanFeature
{
    /// <summary>
    /// Whether the feature is supported.
    /// </summary>
    [JsonPropertyName("supported")]
    public required bool Supported { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
