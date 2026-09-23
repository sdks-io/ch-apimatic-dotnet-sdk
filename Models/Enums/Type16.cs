using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Channel type. Must be "email" for email alerts.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type16>))]
public sealed record Type16 : StringEnum<Type16>
{
    private Type16(string value) : base(value)
    {
    }

    public static readonly Type16 Webhook = new("webhook");

    public static readonly Type16 Email = new("email");

    public static Type16 FromValue(string value) => FromValueCore(value);
}
