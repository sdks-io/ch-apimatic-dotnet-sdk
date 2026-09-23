using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimSchemaExtension
{
    /// <summary>
    /// The URI of a schema extension.
    /// </summary>
    [JsonPropertyName("schema")]
    public required string Schema { get; init; }

    /// <summary>
    /// Whether the schema extension is required.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
