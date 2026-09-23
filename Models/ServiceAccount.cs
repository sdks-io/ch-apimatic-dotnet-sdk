using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ServiceAccount
{
    /// <summary>
    /// Google Cloud service account JSON key file content, base64 encoded.
    /// </summary>
    [JsonPropertyName("serviceAccountFile")]
    public required string ServiceAccountFile { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
