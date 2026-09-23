using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Optional static color applied to the displayed number. Raw SQL number tiles do not support conditional colorRules.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Color5>))]
public sealed record Color5 : StringEnum<Color5>
{
    private Color5(string value) : base(value)
    {
    }

    public static readonly Color5 ChartBlue = new("chart-blue");

    public static readonly Color5 ChartOrange = new("chart-orange");

    public static readonly Color5 ChartRed = new("chart-red");

    public static readonly Color5 ChartCyan = new("chart-cyan");

    public static readonly Color5 ChartGreen = new("chart-green");

    public static readonly Color5 ChartPink = new("chart-pink");

    public static readonly Color5 ChartPurple = new("chart-purple");

    public static readonly Color5 ChartLightBlue = new("chart-light-blue");

    public static readonly Color5 ChartBrown = new("chart-brown");

    public static readonly Color5 ChartGray = new("chart-gray");

    public static readonly Color5 ChartSuccess = new("chart-success");

    public static readonly Color5 ChartWarning = new("chart-warning");

    public static readonly Color5 ChartError = new("chart-error");

    public static Color5 FromValue(string value) => FromValueCore(value);
}
