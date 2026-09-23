using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Authentication type of the schema registry.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AuthenticationEnum>))]
public sealed record AuthenticationEnum : StringEnum<AuthenticationEnum>
{
    private AuthenticationEnum(string value) : base(value)
    {
    }

    public static readonly AuthenticationEnum Plain = new("PLAIN");

    public static AuthenticationEnum FromValue(string value) => FromValueCore(value);
}
