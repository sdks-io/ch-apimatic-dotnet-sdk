using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// DEPRECATED. Use <c>assignedRoles</c> instead. Role of the member in the organization. For organizations that have migrated to custom roles, this field is frozen at the pre-migration value and does not reflect current role assignments.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Role1>))]
public sealed record Role1 : StringEnum<Role1>
{
    private Role1(string value) : base(value)
    {
    }

    public static readonly Role1 Admin = new("admin");

    public static readonly Role1 Developer = new("developer");

    public static Role1 FromValue(string value) => FromValueCore(value);
}
