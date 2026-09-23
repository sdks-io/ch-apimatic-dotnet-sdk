using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Visual representation type for the time series
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisplayType>))]
public sealed record DisplayType : StringEnum<DisplayType>
{
    private DisplayType(string value) : base(value)
    {
    }

    public static readonly DisplayType StackedBar = new("stacked_bar");

    public static readonly DisplayType Line = new("line");

    public static DisplayType FromValue(string value) => FromValueCore(value);
}
