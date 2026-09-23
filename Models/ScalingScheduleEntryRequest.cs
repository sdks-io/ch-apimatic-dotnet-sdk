using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScalingScheduleEntryRequest
{
    /// <summary>
    /// Human-readable label for this schedule entry.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Days of the week this entry applies to. 0 = Sunday, 1 = Monday, …, 6 = Saturday.
    /// </summary>
    [JsonPropertyName("weekdays")]
    [MinLength(1)]
    public required IReadOnlyList<int> Weekdays { get; init; }

    /// <summary>
    /// UTC hour (0–23) when this entry becomes active (inclusive).
    /// </summary>
    [JsonPropertyName("startHourUtc")]
    [Minimum(0)]
    [Maximum(23)]
    public required int StartHourUtc { get; init; }

    /// <summary>
    /// UTC hour (1–24) when this entry deactivates (exclusive). Must differ from startHourUtc. Set to 24 to end at midnight. Values less than startHourUtc create an overnight window spanning midnight.
    /// </summary>
    [JsonPropertyName("endHourUtc")]
    [Minimum(1)]
    [Maximum(24)]
    public required int EndHourUtc { get; init; }

    /// <summary>
    /// Autoscaling mode for this entry. "vertical" (the default when omitted) runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory (minReplicaMemoryGb equal to maxReplicaMemoryGb). Horizontal requires the feature to be enabled for the organization.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoscalingMode")]
    public AutoscalingMode2? AutoscalingMode { get; init; }

    /// <summary>
    /// Minimum memory per replica (Gb). Optional for vertical entries — provide both bounds for a memory range, or omit both to inherit memory from the base scaling config. Required for horizontal (both bounds, equal to maxReplicaMemoryGb — memory is fixed while the replica count scales). The upper bound is tier-dependent (lower for non-paid organizations) and enforced when the entry is applied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicaMemoryGb")]
    [Minimum(8.0)]
    [Maximum(356.0)]
    [MultipleOf(4)]
    public double? MinReplicaMemoryGb { get; init; }

    /// <summary>
    /// Maximum memory per replica (Gb). Optional for vertical entries — provide both bounds for a memory range, or omit both to inherit memory from the base scaling config. Required for horizontal (both bounds, equal to minReplicaMemoryGb — memory is fixed while the replica count scales). The upper bound is tier-dependent (lower for non-paid organizations) and enforced when the entry is applied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicaMemoryGb")]
    [Minimum(8.0)]
    [Maximum(356.0)]
    [MultipleOf(4)]
    public double? MaxReplicaMemoryGb { get; init; }

    /// <summary>
    /// Fixed replica count for a vertical entry (autoscalingMode "vertical" or omitted). Mutually exclusive with minReplicas/maxReplicas. The per-service replica maximum is variable (tier-dependent, configurable per service) and enforced when the entry is applied, not at request time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numReplicas")]
    [Minimum(1)]
    public int? NumReplicas { get; init; }

    /// <summary>
    /// Minimum number of replicas. A minReplicas/maxReplicas band scales the replica count in a horizontal entry (autoscalingMode "horizontal"); when autoscalingMode is omitted or "vertical", an equal band (minReplicas === maxReplicas) is instead an accepted vertical fixed count and needs no horizontal entitlement. Must be provided together with maxReplicas. The per-service replica maximum is variable (tier-dependent, configurable per service) and enforced when the entry is applied, not at request time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicas")]
    [Minimum(1)]
    public int? MinReplicas { get; init; }

    /// <summary>
    /// Maximum number of replicas. A minReplicas/maxReplicas band scales the replica count in a horizontal entry (autoscalingMode "horizontal"); when autoscalingMode is omitted or "vertical", an equal band (minReplicas === maxReplicas) is instead an accepted vertical fixed count and needs no horizontal entitlement. Must be provided together with minReplicas. The per-service replica maximum is variable (tier-dependent, configurable per service) and enforced when the entry is applied, not at request time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicas")]
    [Minimum(1)]
    public int? MaxReplicas { get; init; }

    /// <summary>
    /// Whether idle scaling is enabled during this window.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idleScaling")]
    public bool? IdleScaling { get; init; }

    /// <summary>
    /// Idle timeout in minutes during this window.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idleTimeoutMinutes")]
    public int? IdleTimeoutMinutes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
