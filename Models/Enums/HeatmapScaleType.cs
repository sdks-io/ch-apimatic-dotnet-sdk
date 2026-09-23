using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Scale type used to bucket values on the y-axis.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HeatmapScaleType>))]
public sealed record HeatmapScaleType : StringEnum<HeatmapScaleType>
{
    private HeatmapScaleType(string value) : base(value)
    {
    }

    public static readonly HeatmapScaleType Log = new("log");

    public static readonly HeatmapScaleType Linear = new("linear");

    public static HeatmapScaleType FromValue(string value) => FromValueCore(value);
}
