
# V1 Organizations Keys Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsKeysResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ApiKeyPostResponse`](../../doc/models/api-key-post-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsKeysResponse1 v1OrganizationsKeysResponse1 = new V1OrganizationsKeysResponse1
{
    Status = 200,
    RequestId = new Guid("000023a0-0000-0000-0000-000000000000"),
    Result = new ApiKeyPostResponse
    {
        Key = new ApiKey
        {
            Id = new Guid("00000988-0000-0000-0000-000000000000"),
            Name = "name0",
            State = State4.Enabled,
            Roles = new List<Role3>
            {
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
                new AssignedRole
                {
                    RoleId = new Guid("000023ca-0000-0000-0000-000000000000"),
                    RoleName = "roleName2",
                    RoleType = RoleType.MSystem,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new AssignedRole
                {
                    RoleId = new Guid("000023ca-0000-0000-0000-000000000000"),
                    RoleName = "roleName2",
                    RoleType = RoleType.MSystem,
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        KeyId = "keyId4",
        KeySecret = "keySecret0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

