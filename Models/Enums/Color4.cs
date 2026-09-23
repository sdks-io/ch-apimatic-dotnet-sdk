using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Optional static color applied to the displayed number.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Color4>))]
public sealed record Color4 : StringEnum<Color4>
{
    private Color4(string value) : base(value)
    {
    }

    public static readonly Color4 ChartBlue = new("chart-blue");

    public static readonly Color4 ChartOrange = new("chart-orange");

    public static readonly Color4 ChartRed = new("chart-red");

    public static readonly Color4 ChartCyan = new("chart-cyan");

    public static readonly Color4 ChartGreen = new("chart-green");

    public static readonly Color4 ChartPink = new("chart-pink");

    public static readonly Color4 ChartPurple = new("chart-purple");

    public static readonly Color4 ChartLightBlue = new("chart-light-blue");

    public static readonly Color4 ChartBrown = new("chart-brown");

    public static readonly Color4 ChartGray = new("chart-gray");

    public static readonly Color4 ChartSuccess = new("chart-success");

    public static readonly Color4 ChartWarning = new("chart-warning");

    public static readonly Color4 ChartError = new("chart-error");

    public static Color4 FromValue(string value) => FromValueCore(value);
}
