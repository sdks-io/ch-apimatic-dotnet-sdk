
# V1 Organizations Roles Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsRolesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<RbacRole>`](../../doc/models/rbac-role.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsRolesResponse v1OrganizationsRolesResponse = new V1OrganizationsRolesResponse
{
    Status = 200,
    RequestId = new Guid("00000362-0000-0000-0000-000000000000"),
    Result = new List<RbacRole>
    {
        new RbacRole
        {
            Id = "id6",
            TenantId = "tenantId2",
            OwnerId = "ownerId8",
            Name = "name6",
            Type = OpenApiSpecForClickHouseCloud.Standard.Models.Type.MSystem,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new RbacRole
        {
            Id = "id6",
            TenantId = "tenantId2",
            OwnerId = "ownerId8",
            Name = "name6",
            Type = OpenApiSpecForClickHouseCloud.Standard.Models.Type.MSystem,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

