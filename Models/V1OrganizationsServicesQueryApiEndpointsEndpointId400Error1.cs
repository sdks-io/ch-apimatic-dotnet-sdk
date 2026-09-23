using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
