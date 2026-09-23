using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Channel type. Must be "webhook" for webhook alerts.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type17>))]
public sealed record Type17 : StringEnum<Type17>
{
    private Type17(string value) : base(value)
    {
    }

    public static readonly Type17 Webhook = new("webhook");

    public static readonly Type17 Email = new("email");

    public static Type17 FromValue(string value) => FromValueCore(value);
}
