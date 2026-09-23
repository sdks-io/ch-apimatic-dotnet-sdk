using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// DEPRECATED. Use <c>assignedRoleIds</c> instead. Role of the member in the organization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Role7>))]
public sealed record Role7 : StringEnum<Role7>
{
    private Role7(string value) : base(value)
    {
    }

    public static readonly Role7 Admin = new("admin");

    public static readonly Role7 Developer = new("developer");

    public static Role7 FromValue(string value) => FromValueCore(value);
}
