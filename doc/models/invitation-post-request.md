
# Invitation Post Request

*This model accepts additional fields of type object.*

## Structure

`InvitationPostRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Email` | `string` | Optional | Email of the invited user. Only a user with this email can join using the invitation. The email is stored in a lowercase form. |
| `Role` | [`Role8?`](../../doc/models/role-8.md) | Optional | DEPRECATED. Use `assignedRoleIds` instead. Role to assign to the invited user in the organization. |
| `AssignedRoleIds` | `List<string>` | Optional | List of role IDs to assign to the invited user when they accept the invitation |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

InvitationPostRequest invitationPostRequest = new InvitationPostRequest
{
    Email = "email0",
    Role = Role8.Admin,
    AssignedRoleIds = new List<string>
    {
        "assignedRoleIds2",
        "assignedRoleIds1",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

