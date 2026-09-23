
# V1 Organizations Roles Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsRolesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`RbacRole`](../../doc/models/rbac-role.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsRolesResponse1 v1OrganizationsRolesResponse1 = new V1OrganizationsRolesResponse1
{
    Status = 200,
    RequestId = new Guid("00000f6a-0000-0000-0000-000000000000"),
    Result = new RbacRole
    {
        Id = "id6",
        TenantId = "tenantId2",
        OwnerId = "ownerId8",
        Name = "name6",
        Type = OpenApiSpecForClickHouseCloud.Standard.Models.Type.MSystem,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

