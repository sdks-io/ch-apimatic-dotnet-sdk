using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Build state of this UDF version.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status4>))]
public sealed record Status4 : StringEnum<Status4>
{
    private Status4(string value) : base(value)
    {
    }

    public static readonly Status4 Building = new("building");

    public static readonly Status4 Error = new("error");

    public static readonly Status4 Ready = new("ready");

    public static Status4 FromValue(string value) => FromValueCore(value);
}
