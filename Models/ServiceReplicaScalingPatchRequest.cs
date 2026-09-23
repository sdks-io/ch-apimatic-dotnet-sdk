using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ServiceReplicaScalingPatchRequest
{
    /// <summary>
    /// Minimum auto-scaling memory in Gb for a single replica. Available only for 'production' services. Must be a multiple of 4 and greater than or equal to 8. A range in vertical autoscaling; equal to maxReplicaMemoryGb in horizontal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicaMemoryGb")]
    [Minimum(8.0)]
    [Maximum(356.0)]
    [MultipleOf(4)]
    public double? MinReplicaMemoryGb { get; init; }

    /// <summary>
    /// Maximum auto-scaling memory in Gb for a single replica. Available only for 'production' services. Must be a multiple of 4 and lower than or equal to 120 for non paid services or 356 for paid services. A range in vertical autoscaling; equal to minReplicaMemoryGb in horizontal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicaMemoryGb")]
    [Minimum(8.0)]
    [Maximum(356.0)]
    [MultipleOf(4)]
    public double? MaxReplicaMemoryGb { get; init; }

    /// <summary>
    /// Target autoscaling mode. Omit to keep the service on its current mode. "vertical" runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory (minReplicaMemoryGb equal to maxReplicaMemoryGb). Switching to horizontal requires the feature to be enabled for the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoscalingMode")]
    public AutoscalingMode6? AutoscalingMode { get; init; }

    /// <summary>
    /// Fixed replica count for vertical autoscaling (autoscalingMode "vertical"). Mutually exclusive with minReplicas/maxReplicas. When switching to vertical (autoscalingMode "vertical") with numReplicas and no memory, the service's stored baseline per-replica memory is kept as the new vertical range. Please contact support to enable adjustment of numReplicas.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numReplicas")]
    [Minimum(1)]
    [Maximum(50)]
    public int? NumReplicas { get; init; }

    /// <summary>
    /// Minimum number of replicas. A minReplicas/maxReplicas band scales the replica count in horizontal autoscaling (autoscalingMode "horizontal"). Must be provided together with maxReplicas. Mutually exclusive with numReplicas. Requires horizontal autoscaling to be enabled for the service, unless autoscalingMode is omitted or "vertical" and minReplicas equals maxReplicas (an equal band is then an accepted vertical fixed count and needs no horizontal entitlement).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicas")]
    [Minimum(1)]
    [Maximum(50)]
    public int? MinReplicas { get; init; }

    /// <summary>
    /// Maximum number of replicas. A minReplicas/maxReplicas band scales the replica count in horizontal autoscaling (autoscalingMode "horizontal"). Must be provided together with minReplicas. Mutually exclusive with numReplicas. Requires horizontal autoscaling to be enabled for the service, unless autoscalingMode is omitted or "vertical" and minReplicas equals maxReplicas (an equal band is then an accepted vertical fixed count and needs no horizontal entitlement).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicas")]
    [Minimum(1)]
    [Maximum(50)]
    public int? MaxReplicas { get; init; }

    /// <summary>
    /// When set to true the service is allowed to scale down to zero when idle. True by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idleScaling")]
    public bool? IdleScaling { get; init; }

    /// <summary>
    /// Set minimum idling timeout (in minutes). Must be &gt;= 5 minutes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idleTimeoutMinutes")]
    public double? IdleTimeoutMinutes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
