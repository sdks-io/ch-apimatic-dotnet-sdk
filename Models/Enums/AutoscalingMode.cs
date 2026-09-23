using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Autoscaling mode for this entry. "vertical" runs a fixed replica count while memory scales; "horizontal" scales the replica count at a fixed per-replica memory. Defaults to "vertical" for entries persisted before the mode was exposed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AutoscalingMode>))]
public sealed record AutoscalingMode : StringEnum<AutoscalingMode>
{
    private AutoscalingMode(string value) : base(value)
    {
    }

    public static readonly AutoscalingMode Vertical = new("vertical");

    public static readonly AutoscalingMode Horizontal = new("horizontal");

    public static AutoscalingMode FromValue(string value) => FromValueCore(value);
}
