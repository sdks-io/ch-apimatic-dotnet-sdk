using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// DEPRECATED. Use <c>assignedRoleIds</c> instead. Role to assign to the invited user in the organization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Role8>))]
public sealed record Role8 : StringEnum<Role8>
{
    private Role8(string value) : base(value)
    {
    }

    public static readonly Role8 Admin = new("admin");

    public static readonly Role8 Developer = new("developer");

    public static Role8 FromValue(string value) => FromValueCore(value);
}
