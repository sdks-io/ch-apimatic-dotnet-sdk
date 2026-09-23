using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Autoscaling mode for this entry. "vertical" (the default when omitted) runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory (minReplicaMemoryGb equal to maxReplicaMemoryGb). Horizontal requires the feature to be enabled for the organization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AutoscalingMode2>))]
public sealed record AutoscalingMode2 : StringEnum<AutoscalingMode2>
{
    private AutoscalingMode2(string value) : base(value)
    {
    }

    public static readonly AutoscalingMode2 Vertical = new("vertical");

    public static readonly AutoscalingMode2 Horizontal = new("horizontal");

    public static AutoscalingMode2 FromValue(string value) => FromValueCore(value);
}
