using System;
using System.Text.Json.Serialization;

namespace OpenApiSpecForClickHouseCloud.Models;

public record V1OrganizationsUdfsResponse1
{
    /// <summary>
    /// HTTP status code.
    /// </summary>
    [JsonPropertyName("status")]
    public required int Status { get; init; }

    /// <summary>
    /// Unique id assigned to every request. UUIDv4
    /// </summary>
    [JsonPropertyName("requestId")]
    public required Guid RequestId { get; init; }

    [JsonPropertyName("result")]
    public required UdfListResponse Result { get; init; }
}
