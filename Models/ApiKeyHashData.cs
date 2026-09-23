using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ApiKeyHashData
{
    /// <summary>
    /// Hash of the key ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("keyIdHash")]
    public string? KeyIdHash { get; init; }

    /// <summary>
    /// Last 4 digits of the key ID. Algorithm: echo -n "yourpassword" | sha256sum | tr -d '-' | xxd -r -p | base64
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("keyIdSuffix")]
    public string? KeyIdSuffix { get; init; }

    /// <summary>
    /// Hash of the key secret. Algorithm: echo -n "yourpassword" | sha256sum | tr -d '-' | xxd -r -p | base64
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("keySecretHash")]
    public string? KeySecretHash { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
