using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimResourceTypeListResponse
{
    /// <summary>
    /// SCIM schema URIs.
    /// </summary>
    [JsonPropertyName("schemas")]
    public required IReadOnlyList<string> Schemas { get; init; }

    /// <summary>
    /// Total number of resource types.
    /// </summary>
    [JsonPropertyName("totalResults")]
    public required int TotalResults { get; init; }

    /// <summary>
    /// Number of resources per page.
    /// </summary>
    [JsonPropertyName("itemsPerPage")]
    public required int ItemsPerPage { get; init; }

    /// <summary>
    /// 1-based start index.
    /// </summary>
    [JsonPropertyName("startIndex")]
    public required int StartIndex { get; init; }

    /// <summary>
    /// Array of resource type definitions.
    /// </summary>
    [JsonPropertyName("Resources")]
    public required IReadOnlyList<ScimResourceType> Resources { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
