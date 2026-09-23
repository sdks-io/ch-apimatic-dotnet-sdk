using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackOnClickTargetIdVariant
{
    /// <summary>
    /// Target is a single dashboard or log/trace source
    /// </summary>
    [JsonPropertyName("mode")]
    public string Mode { get; } = "id";

    /// <summary>
    /// ID of the target source (for search) or dashboard (for dashboard).
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
