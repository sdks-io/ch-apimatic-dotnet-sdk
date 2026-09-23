using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePubSubSource
{
    /// <summary>
    /// Format of messages in the Pub/Sub topic. GCP Pub/Sub ClickPipes are in limited preview — contact support to enable this feature for your organization.
    /// </summary>
    [JsonPropertyName("format")]
    public required Format6 Format { get; init; }

    /// <summary>
    /// GCP project ID that owns the Pub/Sub topic.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// Pub/Sub topic name (not the fully-qualified path).
    /// </summary>
    [JsonPropertyName("topic")]
    public required string Topic { get; init; }

    /// <summary>
    /// Authentication method to use with GCP Pub/Sub. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources.
    /// </summary>
    [JsonPropertyName("authentication")]
    public required Authentication17 Authentication { get; init; }

    /// <summary>
    /// Starting position strategy for consuming the subscription. The seekTimestamp companion is required only when seekType is "timestamp"; setting it for a mismatched seek type is rejected.
    /// </summary>
    [JsonPropertyName("seekType")]
    public required SeekType SeekType { get; init; }

    /// <summary>
    /// RFC 3339 / ISO 8601 timestamp to seek to. Required when seekType is "timestamp"; must be omitted otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seekTimestamp")]
    public DateTimeOffset? SeekTimestamp { get; init; }

    /// <summary>
    /// Optional Pub/Sub subscription filter expression (CEL). Maximum 256 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    [MaxLength(256)]
    public string? Filter { get; init; }

    /// <summary>
    /// Whether to enable ordered delivery of messages (requires messages to be published with ordering keys).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableOrdering")]
    public bool? EnableOrdering { get; init; }

    /// <summary>
    /// Acknowledgement deadline for messages, in seconds. Must be between 10 and 600.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ackDeadline")]
    [Minimum(10)]
    [Maximum(600)]
    public int? AckDeadline { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
