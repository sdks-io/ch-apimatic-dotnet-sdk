
# Member Patch Request

*This model accepts additional fields of type object.*

## Structure

`MemberPatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Role` | [`Role7?`](../../doc/models/role-7.md) | Optional | DEPRECATED. Use `assignedRoleIds` instead. Role of the member in the organization. |
| `AssignedRoleIds` | `List<string>` | Optional | List of role IDs to assign to the member |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

MemberPatchRequest memberPatchRequest = new MemberPatchRequest
{
    Role = Role7.Admin,
    AssignedRoleIds = new List<string>
    {
        "assignedRoleIds0",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

