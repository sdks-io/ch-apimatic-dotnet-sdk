using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Optional palette-token override for the sparkline. When unset the sparkline inherits the tile's static color.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Color>))]
public sealed record Color : StringEnum<Color>
{
    private Color(string value) : base(value)
    {
    }

    public static readonly Color ChartBlue = new("chart-blue");

    public static readonly Color ChartOrange = new("chart-orange");

    public static readonly Color ChartRed = new("chart-red");

    public static readonly Color ChartCyan = new("chart-cyan");

    public static readonly Color ChartGreen = new("chart-green");

    public static readonly Color ChartPink = new("chart-pink");

    public static readonly Color ChartPurple = new("chart-purple");

    public static readonly Color ChartLightBlue = new("chart-light-blue");

    public static readonly Color ChartBrown = new("chart-brown");

    public static readonly Color ChartGray = new("chart-gray");

    public static readonly Color ChartSuccess = new("chart-success");

    public static readonly Color ChartWarning = new("chart-warning");

    public static readonly Color ChartError = new("chart-error");

    public static Color FromValue(string value) => FromValueCore(value);
}
