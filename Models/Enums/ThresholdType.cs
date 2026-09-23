using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Threshold comparison direction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThresholdType>))]
public sealed record ThresholdType : StringEnum<ThresholdType>
{
    private ThresholdType(string value) : base(value)
    {
    }

    public static readonly ThresholdType Above = new("above");

    public static readonly ThresholdType Below = new("below");

    public static readonly ThresholdType AboveExclusive = new("above_exclusive");

    public static readonly ThresholdType BelowOrEqual = new("below_or_equal");

    public static readonly ThresholdType Equal = new("equal");

    public static readonly ThresholdType NotEqual = new("not_equal");

    public static readonly ThresholdType Between = new("between");

    public static readonly ThresholdType NotBetween = new("not_between");

    public static ThresholdType FromValue(string value) => FromValueCore(value);
}
