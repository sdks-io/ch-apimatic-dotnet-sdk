using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimResourceType
{
    /// <summary>
    /// SCIM schema URIs.
    /// </summary>
    [JsonPropertyName("schemas")]
    public required IReadOnlyList<string> Schemas { get; init; }

    /// <summary>
    /// The resource type ID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The resource type name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The endpoint path for this resource type.
    /// </summary>
    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; init; }

    /// <summary>
    /// A description of the resource type.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The primary schema URI for this resource type.
    /// </summary>
    [JsonPropertyName("schema")]
    public required string Schema { get; init; }

    /// <summary>
    /// Optional schema extensions for this resource type.
    /// </summary>
    [JsonPropertyName("schemaExtensions")]
    public required IReadOnlyList<ScimSchemaExtension> SchemaExtensions { get; init; }

    [JsonPropertyName("meta")]
    public required ScimResourceTypeMeta Meta { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
