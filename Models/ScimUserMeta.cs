using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimUserMeta
{
    /// <summary>
    /// The name of the resource type of the resource.
    /// </summary>
    [JsonPropertyName("resourceType")]
    public required string ResourceType { get; init; }

    /// <summary>
    /// The DateTime the Resource was added to the Service Provider.
    /// </summary>
    [JsonPropertyName("created")]
    public required DateTimeOffset Created { get; init; }

    /// <summary>
    /// The most recent DateTime the details of this Resource were updated.
    /// </summary>
    [JsonPropertyName("lastModified")]
    public required DateTimeOffset LastModified { get; init; }

    /// <summary>
    /// The URI of the resource being returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public string? Location { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
