
# Api Key

*This model accepts additional fields of type object.*

## Structure

`ApiKey`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique API key ID. |
| `Name` | `string` | Optional | Name of the key |
| `State` | [`State4?`](../../doc/models/state-4.md) | Optional | State of the key: 'enabled', 'disabled'. |
| `Roles` | [`List<Role3>`](../../doc/models/role-3.md) | Optional | DEPRECATED. Use `assignedRoles` instead. List of roles assigned to the key. For organizations that have migrated to custom roles, this field is frozen at the pre-migration value and does not reflect current role assignments. |
| `AssignedRoles` | [`List<AssignedRole>`](../../doc/models/assigned-role.md) | Optional | Custom roles and System roles assigned to this API key |
| `KeySuffix` | `string` | Optional | Last 4 letters of the key. |
| `CreatedAt` | `DateTime?` | Optional | Timestamp the key was created. ISO-8601. |
| `ExpireAt` | `DateTime?` | Optional | Timestamp the key expires. If not present, `null` or is empty the key never expires. ISO-8601. |
| `UsedAt` | `DateTime?` | Optional | Timestamp the key was used last time, with one-minute precision. If not present the key was never used. ISO-8601. |
| `IpAccessList` | [`List<IpAccessListEntry>`](../../doc/models/ip-access-list-entry.md) | Optional | List of IP addresses allowed to access the API using this key |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ApiKey apiKey = new ApiKey
{
    Id = new Guid("000017de-0000-0000-0000-000000000000"),
    Name = "name0",
    State = State4.Enabled,
    Roles = new List<Role3>
    {
        Role3.Admin,
        Role3.Developer,
        Role3.QueryEndpoints,
    },
    AssignedRoles = new List<AssignedRole>
    {
        new AssignedRole
        {
            RoleId = new Guid("000023ca-0000-0000-0000-000000000000"),
            RoleName = "roleName2",
            RoleType = RoleType.MSystem,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

