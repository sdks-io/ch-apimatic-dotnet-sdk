using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenApiSpecForClickHouseCloud.Models;

public record V1OrganizationsUdfUploadsUrl400Error
{
    /// <summary>
    /// Error message.
    /// </summary>
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    /// <summary>
    /// Validation issues that caused the request to be rejected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issues")]
    public IReadOnlyList<Issue>? Issues { get; init; }

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
}
