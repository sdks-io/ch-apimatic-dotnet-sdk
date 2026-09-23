using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PaginationModel
{
    /// <summary>
    /// Total number of records available.
    /// </summary>
    [JsonPropertyName("totalRecords")]
    public required int TotalRecords { get; init; }

    /// <summary>
    /// Cursor for the current page. Null for the first page.
    /// </summary>
    [JsonPropertyName("currentCursor")]
    public required CurrentCursor CurrentCursor { get; init; }

    /// <summary>
    /// Cursor for the next page. Null if there are no more results.
    /// </summary>
    [JsonPropertyName("nextCursor")]
    public required NextCursor NextCursor { get; init; }

    /// <summary>
    /// Maximum number of records returned per page.
    /// </summary>
    [JsonPropertyName("limit")]
    public required int Limit { get; init; }
}
