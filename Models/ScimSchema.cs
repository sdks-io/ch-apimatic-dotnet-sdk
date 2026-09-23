using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimSchema
{
    /// <summary>
    /// SCIM schema URIs.
    /// </summary>
    [JsonPropertyName("schemas")]
    public required IReadOnlyList<string> Schemas { get; init; }

    /// <summary>
    /// The unique URI of the schema.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The schema name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A description of the schema.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// Service provider attributes comprising the schema.
    /// </summary>
    [JsonPropertyName("attributes")]
    public required IReadOnlyList<ScimSchemaAttribute> Attributes { get; init; }

    [JsonPropertyName("meta")]
    public required ScimSchemaMeta Meta { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
