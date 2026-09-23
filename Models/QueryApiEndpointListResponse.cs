using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenApiSpecForClickHouseCloud.Models;

public record QueryApiEndpointListResponse
{
    /// <summary>
    /// Active Query API endpoints for the service, including both owner types.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<PublicQueryApiEndpointListItem> Items { get; init; }

    [JsonPropertyName("pagination")]
    public required PaginationModel Pagination { get; init; }
}
