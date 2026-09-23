using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UdfListResponse
{
    /// <summary>
    /// Latest version of each UDF in the organization.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<Udf> Items { get; init; }

    [JsonPropertyName("pagination")]
    public required PaginationModel Pagination { get; init; }
}
