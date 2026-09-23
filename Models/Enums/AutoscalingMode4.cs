using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Autoscaling mode. "vertical" (the default when omitted) runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory (minReplicaMemoryGb equal to maxReplicaMemoryGb). Horizontal requires the feature to be enabled for the organization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AutoscalingMode4>))]
public sealed record AutoscalingMode4 : StringEnum<AutoscalingMode4>
{
    private AutoscalingMode4(string value) : base(value)
    {
    }

    public static readonly AutoscalingMode4 Vertical = new("vertical");

    public static readonly AutoscalingMode4 Horizontal = new("horizontal");

    public static AutoscalingMode4 FromValue(string value) => FromValueCore(value);
}
