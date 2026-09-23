using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeScaling
{
    /// <summary>
    /// Desired number of replicas. Only for scalable pipes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicas")]
    [Minimum(1)]
    [Maximum(40)]
    public int? Replicas { get; init; }

    /// <summary>
    /// Desired number of concurrency. Only for S3 pipes. If set to 0, concurrency is auto-scaled based on the cluster memory.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("concurrency")]
    public int? Concurrency { get; init; }

    /// <summary>
    /// CPU in millicores for each replica. Only for streaming pipes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicaCpuMillicores")]
    [Minimum(125)]
    [Maximum(2000)]
    public int? ReplicaCpuMillicores { get; init; }

    /// <summary>
    /// Memory in GB for each replica. Only for streaming pipes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("replicaMemoryGb")]
    [Minimum(0.5)]
    [Maximum(8.0)]
    public double? ReplicaMemoryGb { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
