using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeKinesisSource
{
    /// <summary>
    /// Format of the Kinesis stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("format")]
    public Format2? Format { get; init; }

    /// <summary>
    /// Name of the Kinesis stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("streamName")]
    public string? StreamName { get; init; }

    /// <summary>
    /// AWS region of the Kinesis stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("region")]
    public string? Region { get; init; }

    /// <summary>
    /// Use enhanced fan-out for the Kinesis stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useEnhancedFanOut")]
    public bool? UseEnhancedFanOut { get; init; }

    /// <summary>
    /// Type of iterator to use when reading from the Kinesis stream. If AT_TIMESTAMP is used, the timestamp field must be provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iteratorType")]
    public IteratorType? IteratorType { get; init; }

    /// <summary>
    /// UNIX timestamp to start reading from the Kinesis stream. Required if iteratorType is AT_TIMESTAMP.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public int? Timestamp { get; init; }

    /// <summary>
    /// Authentication method to use with the Kinesis stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authentication")]
    public Authentication5? Authentication { get; init; }

    /// <summary>
    /// IAM role to use for authentication. Required if IAM_ROLE is used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
