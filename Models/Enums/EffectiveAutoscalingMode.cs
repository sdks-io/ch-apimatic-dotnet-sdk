using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Autoscaling mode currently in effect on the running service. May diverge from the configured baseline mode while a schedule entry is active.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EffectiveAutoscalingMode>))]
public sealed record EffectiveAutoscalingMode : StringEnum<EffectiveAutoscalingMode>
{
    private EffectiveAutoscalingMode(string value) : base(value)
    {
    }

    public static readonly EffectiveAutoscalingMode Vertical = new("vertical");

    public static readonly EffectiveAutoscalingMode Horizontal = new("horizontal");

    public static EffectiveAutoscalingMode FromValue(string value) => FromValueCore(value);
}
