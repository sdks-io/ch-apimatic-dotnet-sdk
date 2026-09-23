using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimServiceProviderConfigBulk
{
    /// <summary>
    /// Whether bulk operations are supported.
    /// </summary>
    [JsonPropertyName("supported")]
    public required bool Supported { get; init; }

    /// <summary>
    /// Maximum number of bulk operations per request.
    /// </summary>
    [JsonPropertyName("maxOperations")]
    public required int MaxOperations { get; init; }

    /// <summary>
    /// Maximum payload size for bulk requests in bytes.
    /// </summary>
    [JsonPropertyName("maxPayloadSize")]
    public required int MaxPayloadSize { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
