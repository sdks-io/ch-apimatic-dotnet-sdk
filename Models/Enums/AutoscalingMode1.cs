using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Autoscaling mode applied when no schedule entry is active. "vertical" runs a fixed replica count while memory scales; "horizontal" scales the replica count at a fixed per-replica memory.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AutoscalingMode1>))]
public sealed record AutoscalingMode1 : StringEnum<AutoscalingMode1>
{
    private AutoscalingMode1(string value) : base(value)
    {
    }

    public static readonly AutoscalingMode1 Vertical = new("vertical");

    public static readonly AutoscalingMode1 Horizontal = new("horizontal");

    public static AutoscalingMode1 FromValue(string value) => FromValueCore(value);
}
