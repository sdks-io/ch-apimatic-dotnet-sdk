using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of the MySQL source. Defaults to "mysql" if not specified.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type9>))]
public sealed record Type9 : StringEnum<Type9>
{
    private Type9(string value) : base(value)
    {
    }

    public static readonly Type9 Mysql = new("mysql");

    public static readonly Type9 Rdsmysql = new("rdsmysql");

    public static readonly Type9 Auroramysql = new("auroramysql");

    public static readonly Type9 Mariadb = new("mariadb");

    public static readonly Type9 Rdsmariadb = new("rdsmariadb");

    public static Type9 FromValue(string value) => FromValueCore(value);
}
