using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of role: system (predefined) or custom (organization-defined)
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RoleType>))]
public sealed record RoleType : StringEnum<RoleType>
{
    private RoleType(string value) : base(value)
    {
    }

    public static readonly RoleType System = new("system");

    public static readonly RoleType Custom = new("custom");

    public static RoleType FromValue(string value) => FromValueCore(value);
}
