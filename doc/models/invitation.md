
# Invitation

*This model accepts additional fields of type object.*

## Structure

`Invitation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Role` | [`Role2?`](../../doc/models/role-2.md) | Optional | DEPRECATED. Use `assignedRoles` instead. Role of the invited user in the organization. For organizations that have migrated to custom roles, this field is frozen at the pre-migration value and does not reflect the role assignment that will be applied. |
| `Id` | `Guid?` | Optional | Unique invitation ID. |
| `Email` | `string` | Optional | Email of the invited user. Only a user with this email can join using the invitation. The email is stored in a lowercase form. |
| `CreatedAt` | `DateTime?` | Optional | Invitation creation timestamp. ISO-8601. |
| `ExpireAt` | `DateTime?` | Optional | Timestamp the invitation expires. ISO-8601. |
| `AssignedRoles` | [`List<AssignedRole>`](../../doc/models/assigned-role.md) | Optional | Custom roles and System roles that will be assigned to the user when they accept the invitation |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

Invitation invitation = new Invitation
{
    Role = Role2.Admin,
    Id = new Guid("00002526-0000-0000-0000-000000000000"),
    Email = "email6",
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ExpireAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

