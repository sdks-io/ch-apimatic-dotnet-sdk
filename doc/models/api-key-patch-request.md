
# Api Key Patch Request

*This model accepts additional fields of type object.*

## Structure

`ApiKeyPatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the key |
| `Roles` | [`List<Role3>`](../../doc/models/role-3.md) | Optional | DEPRECATED. Use `assignedRoleIds` instead. List of roles assigned to the key. |
| `AssignedRoleIds` | `List<Guid>` | Optional | Array of role UUIDs to assign to the API key |
| `ExpireAt` | `DateTime?` | Optional | Timestamp the key expires. If `null` or is empty the key never expires. ISO-8601. |
| `State` | [`State4?`](../../doc/models/state-4.md) | Optional | State of the key: 'enabled', 'disabled'. |
| `IpAccessList` | [`List<IpAccessListEntry>`](../../doc/models/ip-access-list-entry.md) | Optional | List of IP addresses allowed to access the API using this key |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

ApiKeyPatchRequest apiKeyPatchRequest = new ApiKeyPatchRequest
{
    Name = "name2",
    Roles = new List<Role3>
    {
        Role3.Developer,
        Role3.Admin,
    },
    AssignedRoleIds = new List<Guid>
    {
        new Guid("00000a08-0000-0000-0000-000000000000"),
        new Guid("00000a07-0000-0000-0000-000000000000"),
    },
    ExpireAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    State = State4.Enabled,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

