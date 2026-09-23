
# Assigned Role

*This model accepts additional fields of type object.*

## Structure

`AssignedRole`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RoleId` | `Guid?` | Optional | Unique identifier of the role |
| `RoleName` | `string` | Optional | Human-readable name of the role |
| `RoleType` | [`RoleType?`](../../doc/models/role-type.md) | Optional | Type of role: system (predefined) or custom (organization-defined) |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

AssignedRole assignedRole = new AssignedRole
{
    RoleId = new Guid("000026fa-0000-0000-0000-000000000000"),
    RoleName = "roleName8",
    RoleType = RoleType.MSystem,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

