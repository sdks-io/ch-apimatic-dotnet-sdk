
# Member

*This model accepts additional fields of type object.*

## Structure

`Member`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UserId` | `string` | Optional | Unique user ID. If a user is a member in multiple organizations this ID will stay the same. |
| `Name` | `string` | Optional | Name of the member as set a personal user profile. |
| `Email` | `string` | Optional | Email of the member as set in personal user profile. |
| `Role` | [`Role1?`](../../doc/models/role-1.md) | Optional | DEPRECATED. Use `assignedRoles` instead. Role of the member in the organization. For organizations that have migrated to custom roles, this field is frozen at the pre-migration value and does not reflect current role assignments. |
| `JoinedAt` | `DateTime?` | Optional | Timestamp the member joined the organization. ISO-8601. |
| `AssignedRoles` | [`List<AssignedRole>`](../../doc/models/assigned-role.md) | Optional | Custom roles and System roles assigned to this member |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

Member member = new Member
{
    UserId = "userId6",
    Name = "name6",
    Email = "email0",
    Role = Role1.Admin,
    JoinedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

