using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UdfAttachmentListResponse
{
    [JsonPropertyName("items")]
    public required IReadOnlyList<UdfAttachment> Items { get; init; }

    [JsonPropertyName("pagination")]
    public required PaginationModel Pagination { get; init; }
}
