using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Role>))]
public sealed record Role : StringEnum<Role>
{
    private Role(string value) : base(value)
    {
    }

    public static readonly Role SqlConsoleReadOnly = new("sql_console_read_only");

    public static readonly Role SqlConsoleAdmin = new("sql_console_admin");

    public static Role FromValue(string value) => FromValueCore(value);
}
