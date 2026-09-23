using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScalingScheduleEntry
{
    /// <summary>
    /// Unique identifier for this schedule entry.
    /// </summary>
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

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
    /// Autoscaling mode for this entry. "vertical" runs a fixed replica count while memory scales; "horizontal" scales the replica count at a fixed per-replica memory. Defaults to "vertical" for entries persisted before the mode was exposed.
    /// </summary>
    [JsonPropertyName("autoscalingMode")]
    public required AutoscalingMode AutoscalingMode { get; init; }

    /// <summary>
    /// Minimum memory per replica (Gb) during this window. A range in vertical; in horizontal it equals maxReplicaMemoryGb (memory is fixed while the replica count scales).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicaMemoryGb")]
    public double? MinReplicaMemoryGb { get; init; }

    /// <summary>
    /// Maximum memory per replica (Gb) during this window. A range in vertical; in horizontal it equals minReplicaMemoryGb (memory is fixed while the replica count scales).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicaMemoryGb")]
    public double? MaxReplicaMemoryGb { get; init; }

    /// <summary>
    /// Minimum number of replicas during this window. For a horizontal entry the replica count scales between minReplicas and maxReplicas; for a vertical entry minReplicas and maxReplicas are equal and report the fixed replica count (both omitted when the entry stored no count).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicas")]
    public int? MinReplicas { get; init; }

    /// <summary>
    /// Maximum number of replicas during this window. For a horizontal entry the replica count scales between minReplicas and maxReplicas; for a vertical entry minReplicas and maxReplicas are equal and report the fixed replica count (both omitted when the entry stored no count).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicas")]
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

    /// <summary>
    /// Whether this entry is currently active. Scheduled times are indicative — actions are applied on a best-effort basis and may be delayed by a few minutes.
    /// </summary>
    [JsonPropertyName("isActiveNow")]
    public required bool IsActiveNow { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
