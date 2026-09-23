using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Endpoint protocol: 'https', 'nativesecure', 'mysql'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Protocol>))]
public sealed record Protocol : StringEnum<Protocol>
{
    private Protocol(string value) : base(value)
    {
    }

    public static readonly Protocol Https = new("https");

    public static readonly Protocol Nativesecure = new("nativesecure");

    public static readonly Protocol Mysql = new("mysql");

    public static Protocol FromValue(string value) => FromValueCore(value);
}
