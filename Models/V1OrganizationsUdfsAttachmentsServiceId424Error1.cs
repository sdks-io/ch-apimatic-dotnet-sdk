using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record V1OrganizationsUdfsAttachmentsServiceId424Error1
{
    /// <summary>
    /// Human-readable error message.
    /// </summary>
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    /// <summary>
    /// Reason the attachment could not be started.
    /// </summary>
    [JsonPropertyName("code")]
    public required Code Code { get; init; }

    /// <summary>
    /// Current state of the service.
    /// </summary>
    [JsonPropertyName("serviceState")]
    public required ServiceState ServiceState { get; init; }

    /// <summary>
    /// Whether the service can be woken before retrying the attachment.
    /// </summary>
    [JsonPropertyName("canWake")]
    public required bool CanWake { get; init; }

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
