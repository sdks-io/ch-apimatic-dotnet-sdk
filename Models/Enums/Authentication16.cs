using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Authenticate with a Google Cloud service account JSON key. Defaults to SERVICE_ACCOUNT when omitted.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Authentication16>))]
public sealed record Authentication16 : StringEnum<Authentication16>
{
    private Authentication16(string value) : base(value)
    {
    }

    public static readonly Authentication16 ServiceAccount = new("SERVICE_ACCOUNT");

    public static Authentication16 FromValue(string value) => FromValueCore(value);
}
