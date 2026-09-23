using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Configured autoscaling mode. "vertical" runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory. This is the baseline configuration; the mode currently applied (which may differ while a schedule entry is active) is currentScaling.effectiveAutoscalingMode.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AutoscalingMode3>))]
public sealed record AutoscalingMode3 : StringEnum<AutoscalingMode3>
{
    private AutoscalingMode3(string value) : base(value)
    {
    }

    public static readonly AutoscalingMode3 Vertical = new("vertical");

    public static readonly AutoscalingMode3 Horizontal = new("horizontal");

    public static AutoscalingMode3 FromValue(string value) => FromValueCore(value);
}
