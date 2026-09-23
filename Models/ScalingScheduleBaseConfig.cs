using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ScalingScheduleBaseConfig
{
    /// <summary>
    /// Autoscaling mode applied when no schedule entry is active. "vertical" runs a fixed replica count while memory scales; "horizontal" scales the replica count at a fixed per-replica memory.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoscalingMode")]
    public AutoscalingMode1? AutoscalingMode { get; init; }

    /// <summary>
    /// Minimum memory per replica (Gb) when no schedule entry is active. Absent for services that do not autoscale memory.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicaMemoryGb")]
    public double? MinReplicaMemoryGb { get; init; }

    /// <summary>
    /// Maximum memory per replica (Gb) when no schedule entry is active. Absent for services that do not autoscale memory.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicaMemoryGb")]
    public double? MaxReplicaMemoryGb { get; init; }

    /// <summary>
    /// Minimum number of replicas when no schedule entry is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minReplicas")]
    public int? MinReplicas { get; init; }

    /// <summary>
    /// Maximum number of replicas when no schedule entry is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxReplicas")]
    public int? MaxReplicas { get; init; }

    /// <summary>
    /// Whether idle scaling is enabled when no schedule entry is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idleScaling")]
    public bool? IdleScaling { get; init; }

    /// <summary>
    /// Idle timeout in minutes when no schedule entry is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idleTimeoutMinutes")]
    public int? IdleTimeoutMinutes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
