
# Api Key Post Request

*This model accepts additional fields of type object.*

## Structure

`ApiKeyPostRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the key. |
| `ExpireAt` | `DateTime?` | Optional | Timestamp the key expires. If not present, `null` or is empty the key never expires. ISO-8601. |
| `State` | [`State6?`](../../doc/models/state-6.md) | Optional | Initial state of the key: 'enabled', 'disabled'. If not provided the new key will be 'enabled'. |
| `HashData` | [`ApiKeyHashData`](../../doc/models/api-key-hash-data.md) | Optional | - |
| `Roles` | [`List<Role3>`](../../doc/models/role-3.md) | Optional | DEPRECATED. Use `assignedRoleIds` instead. List of roles assigned to the key. Contains at least 1 element. |
| `AssignedRoleIds` | `List<Guid>` | Optional | Array of role UUIDs to assign to the API key |
| `IpAccessList` | [`List<IpAccessListEntry>`](../../doc/models/ip-access-list-entry.md) | Optional | List of IP addresses allowed to access the API using this key |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

ApiKeyPostRequest apiKeyPostRequest = new ApiKeyPostRequest
{
    Name = "name4",
    ExpireAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    State = State6.Enabled,
    HashData = new ApiKeyHashData
    {
        KeyIdHash = "keyIdHash4",
        KeyIdSuffix = "keyIdSuffix6",
        KeySecretHash = "keySecretHash8",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Roles = new List<Role3>
    {
        Role3.QueryEndpoints,
        Role3.Admin,
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

