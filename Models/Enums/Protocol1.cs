using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Endpoint protocol
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Protocol1>))]
public sealed record Protocol1 : StringEnum<Protocol1>
{
    private Protocol1(string value) : base(value)
    {
    }

    public static readonly Protocol1 Mysql = new("mysql");

    public static Protocol1 FromValue(string value) => FromValueCore(value);
}
