using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Optional SQL console role type
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RoleV2>))]
public sealed record RoleV2 : StringEnum<RoleV2>
{
    private RoleV2(string value) : base(value)
    {
    }

    public static readonly RoleV2 SqlConsoleReadonly = new("sql-console-readonly");

    public static readonly RoleV2 SqlConsoleAdmin = new("sql-console-admin");

    public static RoleV2 FromValue(string value) => FromValueCore(value);
}
