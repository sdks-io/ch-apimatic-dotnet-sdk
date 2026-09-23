using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UdfVersionListResponse
{
    [JsonPropertyName("items")]
    public required IReadOnlyList<Udf> Items { get; init; }

    [JsonPropertyName("pagination")]
    public required PaginationModel Pagination { get; init; }
}
