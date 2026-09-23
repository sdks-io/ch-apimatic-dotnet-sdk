using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record CurrentScaling
{
    /// <summary>
    /// Autoscaling mode currently in effect on the running service. May diverge from the configured baseline mode while a schedule entry is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effectiveAutoscalingMode")]
    public EffectiveAutoscalingMode? EffectiveAutoscalingMode { get; init; }

    /// <summary>
    /// Minimum memory per replica (Gb) currently applied to the running service. May diverge from the top-level <c>minReplicaMemoryGb</c> baseline while a schedule entry is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effectiveMinReplicaMemoryGb")]
    public double? EffectiveMinReplicaMemoryGb { get; init; }

    /// <summary>
    /// Maximum memory per replica (Gb) currently applied to the running service. May diverge from the top-level <c>maxReplicaMemoryGb</c> baseline while a schedule entry is active. Reflects the stored value: normally equal to <c>effectiveMinReplicaMemoryGb</c> in horizontal mode, but a legacy service stored with an unequal memory range reports the stored bounds as-is.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effectiveMaxReplicaMemoryGb")]
    public double? EffectiveMaxReplicaMemoryGb { get; init; }

    /// <summary>
    /// Minimum number of replicas currently applied to the running service. May diverge from the baseline while a schedule entry is active. Reflects the stored value: normally equal to <c>effectiveMaxReplicas</c> in vertical mode (a fixed replica count), but a legacy service stored with an unequal replica range reports the stored bounds as-is.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effectiveMinReplicas")]
    public int? EffectiveMinReplicas { get; init; }

    /// <summary>
    /// Maximum number of replicas currently applied to the running service. May diverge from the baseline while a schedule entry is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effectiveMaxReplicas")]
    public int? EffectiveMaxReplicas { get; init; }

    /// <summary>
    /// Whether idle scaling is currently in effect on the service. May diverge from the top-level <c>idleScaling</c> baseline while a schedule entry is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effectiveIdleScaling")]
    public bool? EffectiveIdleScaling { get; init; }

    /// <summary>
    /// Idle timeout in minutes currently in effect on the service. May diverge from the top-level <c>idleTimeoutMinutes</c> baseline while a schedule entry is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("effectiveIdleTimeoutMinutes")]
    public int? EffectiveIdleTimeoutMinutes { get; init; }

    /// <summary>
    /// ID of the schedule entry whose values are currently applied to the service. Absent when no entry is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activeEntryId")]
    public Guid? ActiveEntryId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
