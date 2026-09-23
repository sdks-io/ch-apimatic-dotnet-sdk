using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeSchemaDiscoveryRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source")]
    public ClickPipeSchemaDiscoverySource? Source { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
