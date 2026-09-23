using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Sets the minimum SSL/TLS protocol version allowed for client connections.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SslMinProtocolVersion>))]
public sealed record SslMinProtocolVersion : StringEnum<SslMinProtocolVersion>
{
    private SslMinProtocolVersion(string value) : base(value)
    {
    }

    public static readonly SslMinProtocolVersion TlSv1 = new("TLSv1");

    public static readonly SslMinProtocolVersion TlSv11 = new("TLSv1.1");

    public static readonly SslMinProtocolVersion TlSv12 = new("TLSv1.2");

    public static readonly SslMinProtocolVersion TlSv13 = new("TLSv1.3");

    public static SslMinProtocolVersion FromValue(string value) => FromValueCore(value);
}
