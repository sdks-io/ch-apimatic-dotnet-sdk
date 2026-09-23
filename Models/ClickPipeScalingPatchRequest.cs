using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeScalingPatchRequest
{
    /// <summary>
    /// Number of replicas to scale to. Use to scale Kafka pipes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicas")]
    [Minimum(1)]
    [Maximum(40)]
    public int? Replicas { get; init; }

    /// <summary>
    /// Number of concurrency to scale to. Use to scale S3 pipes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("concurrency")]
    [Minimum(0)]
    [Maximum(34)]
    public int? Concurrency { get; init; }

    /// <summary>
    /// CPU in millicores for each replica. Use to scale streaming pipes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicaCpuMillicores")]
    [Minimum(125)]
    [Maximum(2000)]
    public int? ReplicaCpuMillicores { get; init; }

    /// <summary>
    /// Memory in GB for each replica. Use to scale streaming pipes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicaMemoryGb")]
    [Minimum(0.5)]
    [Maximum(8.0)]
    public double? ReplicaMemoryGb { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
