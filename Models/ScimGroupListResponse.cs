using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimGroupListResponse
{
    /// <summary>
    /// Must be ["urn:ietf:params:scim:api:messages:2.0:ListResponse"].
    /// </summary>
    [JsonPropertyName("schemas")]
    public required IReadOnlyList<string> Schemas { get; init; }

    /// <summary>
    /// Total number of Groups matching the query.
    /// </summary>
    [JsonPropertyName("totalResults")]
    public required int TotalResults { get; init; }

    /// <summary>
    /// 1-based index of the first result in the current set.
    /// </summary>
    [JsonPropertyName("startIndex")]
    public required int StartIndex { get; init; }

    /// <summary>
    /// Number of resources returned in this response.
    /// </summary>
    [JsonPropertyName("itemsPerPage")]
    public required int ItemsPerPage { get; init; }

    /// <summary>
    /// Array of SCIM Group resources.
    /// </summary>
    [JsonPropertyName("Resources")]
    public required IReadOnlyList<ScimGroup> Resources { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
