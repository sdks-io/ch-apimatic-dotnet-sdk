using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record GcpBackupBucketPatchRequestV1
{
    /// <summary>
    /// Bucket provider
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bucketProvider")]
    public BucketProvider1? BucketProvider { get; init; }

    /// <summary>
    /// Bucket path
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bucketPath")]
    public string? BucketPath { get; init; }

    /// <summary>
    /// Access Key ID (HMAC key)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; init; }

    /// <summary>
    /// Secret Access Key (HMAC secret key)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secretAccessKey")]
    public string? SecretAccessKey { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
