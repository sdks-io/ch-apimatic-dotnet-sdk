using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScimSchemaListResponse
{
    /// <summary>
    /// SCIM schema URIs.
    /// </summary>
    [JsonPropertyName("schemas")]
    public required IReadOnlyList<string> Schemas { get; init; }

    /// <summary>
    /// Total number of schemas.
    /// </summary>
    [JsonPropertyName("totalResults")]
    public required int TotalResults { get; init; }

    /// <summary>
    /// Number of schemas per page.
    /// </summary>
    [JsonPropertyName("itemsPerPage")]
    public required int ItemsPerPage { get; init; }

    /// <summary>
    /// 1-based start index.
    /// </summary>
    [JsonPropertyName("startIndex")]
    public required int StartIndex { get; init; }

    /// <summary>
    /// Array of schema definitions.
    /// </summary>
    [JsonPropertyName("Resources")]
    public required IReadOnlyList<ScimSchema> Resources { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
