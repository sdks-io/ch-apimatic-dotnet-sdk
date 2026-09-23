using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// DEPRECATED. Use <c>assignedRoles</c> instead. Role of the invited user in the organization. For organizations that have migrated to custom roles, this field is frozen at the pre-migration value and does not reflect the role assignment that will be applied.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Role2>))]
public sealed record Role2 : StringEnum<Role2>
{
    private Role2(string value) : base(value)
    {
    }

    public static readonly Role2 Admin = new("admin");

    public static readonly Role2 Developer = new("developer");

    public static Role2 FromValue(string value) => FromValueCore(value);
}
