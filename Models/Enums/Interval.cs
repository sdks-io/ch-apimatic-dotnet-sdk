using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Evaluation interval for the alert. <c>30s</c> requires the 30s alert interval feature to be enabled for your team.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Interval>))]
public sealed record Interval : StringEnum<Interval>
{
    private Interval(string value) : base(value)
    {
    }

    public static readonly Interval _30S = new("30s");

    public static readonly Interval _1M = new("1m");

    public static readonly Interval _5M = new("5m");

    public static readonly Interval _15M = new("15m");

    public static readonly Interval _30M = new("30m");

    public static readonly Interval _1H = new("1h");

    public static readonly Interval _6H = new("6h");

    public static readonly Interval _12H = new("12h");

    public static readonly Interval _1D = new("1d");

    public static Interval FromValue(string value) => FromValueCore(value);
}
