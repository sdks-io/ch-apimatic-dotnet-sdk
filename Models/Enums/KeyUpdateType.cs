using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// For 'openapi_key_update' activities: the type of update that was performed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<KeyUpdateType>))]
public sealed record KeyUpdateType : StringEnum<KeyUpdateType>
{
    private KeyUpdateType(string value) : base(value)
    {
    }

    public static readonly KeyUpdateType Created = new("created");

    public static readonly KeyUpdateType Deleted = new("deleted");

    public static readonly KeyUpdateType NameChanged = new("name-changed");

    public static readonly KeyUpdateType RoleChanged = new("role-changed");

    public static readonly KeyUpdateType StateChanged = new("state-changed");

    public static readonly KeyUpdateType DateChanged = new("date-changed");

    public static readonly KeyUpdateType IpAccessListChanged = new("ip-access-list-changed");

    public static readonly KeyUpdateType OrgRoleChanged = new("org-role-changed");

    public static readonly KeyUpdateType DefaultServiceRoleChanged = new("default-service-role-changed");

    public static readonly KeyUpdateType ServiceRoleChanged = new("service-role-changed");

    public static readonly KeyUpdateType RolesV2Changed = new("roles-v2-changed");

    public static KeyUpdateType FromValue(string value) => FromValueCore(value);
}
