using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ServiceScalingPatchRequest
{
    /// <summary>
    /// DEPRECATED - inaccurate for services with non-default numbers of replicas. Use <c>minReplicaMemoryGb</c> instead. Minimum memory of three workers during auto-scaling in Gb. Available only for 'production' services. Must be a multiple of 12 and greater than or equal to 24. Always absent for horizontal-autoscaling services (replica count is variable).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minTotalMemoryGb")]
    [Minimum(24.0)]
    [Maximum(1068.0)]
    [MultipleOf(12)]
    public double? MinTotalMemoryGb { get; init; }

    /// <summary>
    /// DEPRECATED - inaccurate for services with non-default numbers of replicas. Use <c>maxReplicaMemoryGb</c> instead. Maximum memory of three workers during auto-scaling in Gb. Available only for 'production' services. Must be a multiple of 12 and lower than or equal to 360 for non paid services or 1068 for paid services. Always absent for horizontal-autoscaling services (replica count is variable).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxTotalMemoryGb")]
    [Minimum(24.0)]
    [Maximum(1068.0)]
    [MultipleOf(12)]
    public double? MaxTotalMemoryGb { get; init; }

    /// <summary>
    /// Number of replicas for the service. The number of replicas must be between 2 and 50 for the first service in a warehouse. Services that are created in an existing warehouse can have a number of replicas as low as 1. Further restrictions may apply based on your organization's tier and its per-warehouse replica limit. It defaults to 1 for the BASIC tier and 3 for the SCALE and ENTERPRISE tiers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numReplicas")]
    [Minimum(1)]
    [Maximum(50)]
    public int? NumReplicas { get; init; }

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
