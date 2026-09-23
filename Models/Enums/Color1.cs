using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Color applied when the rule matches.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Color1>))]
public sealed record Color1 : StringEnum<Color1>
{
    private Color1(string value) : base(value)
    {
    }

    public static readonly Color1 ChartBlue = new("chart-blue");

    public static readonly Color1 ChartOrange = new("chart-orange");

    public static readonly Color1 ChartRed = new("chart-red");

    public static readonly Color1 ChartCyan = new("chart-cyan");

    public static readonly Color1 ChartGreen = new("chart-green");

    public static readonly Color1 ChartPink = new("chart-pink");

    public static readonly Color1 ChartPurple = new("chart-purple");

    public static readonly Color1 ChartLightBlue = new("chart-light-blue");

    public static readonly Color1 ChartBrown = new("chart-brown");

    public static readonly Color1 ChartGray = new("chart-gray");

    public static readonly Color1 ChartSuccess = new("chart-success");

    public static readonly Color1 ChartWarning = new("chart-warning");

    public static readonly Color1 ChartError = new("chart-error");

    public static Color1 FromValue(string value) => FromValueCore(value);
}
