using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Target autoscaling mode. Omit to keep the service on its current mode. "vertical" runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory (minReplicaMemoryGb equal to maxReplicaMemoryGb). Switching to horizontal requires the feature to be enabled for the organization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AutoscalingMode6>))]
public sealed record AutoscalingMode6 : StringEnum<AutoscalingMode6>
{
    private AutoscalingMode6(string value) : base(value)
    {
    }

    public static readonly AutoscalingMode6 Vertical = new("vertical");

    public static readonly AutoscalingMode6 Horizontal = new("horizontal");

    public static AutoscalingMode6 FromValue(string value) => FromValueCore(value);
}
