using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimServiceProviderConfigFilter
{
    /// <summary>
    /// Whether filter is supported.
    /// </summary>
    [JsonPropertyName("supported")]
    public required bool Supported { get; init; }

    /// <summary>
    /// Maximum number of results per filter query.
    /// </summary>
    [JsonPropertyName("maxResults")]
    public required int MaxResults { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
