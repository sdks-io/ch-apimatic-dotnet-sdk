
# V1 Organizations Keys Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsKeysResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<ApiKey>`](../../doc/models/api-key.md) | Optional | - |
| `Limit` | `int?` | Optional | Maximum number of results returned in this page. |
| `TotalCount` | `int?` | Optional | Total number of results across all pages. |
| `NextCursor` | `string` | Optional | Cursor for the next page, to be sent as the `cursor` query parameter. Null on the last page. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsKeysResponse v1OrganizationsKeysResponse = new V1OrganizationsKeysResponse
{
    Status = 200,
    RequestId = new Guid("00000f26-0000-0000-0000-000000000000"),
    Result = new List<ApiKey>
    {
        new ApiKey
        {
            Id = new Guid("000002b8-0000-0000-0000-000000000000"),
            Name = "name6",
            State = State4.Enabled,
            Roles = new List<Role3>
            {
                Role3.Admin,
                Role3.QueryEndpoints,
                Role3.Developer,
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
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ApiKey
        {
            Id = new Guid("000002b8-0000-0000-0000-000000000000"),
            Name = "name6",
            State = State4.Enabled,
            Roles = new List<Role3>
            {
                Role3.Admin,
                Role3.QueryEndpoints,
                Role3.Developer,
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
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ApiKey
        {
            Id = new Guid("000002b8-0000-0000-0000-000000000000"),
            Name = "name6",
            State = State4.Enabled,
            Roles = new List<Role3>
            {
                Role3.Admin,
                Role3.QueryEndpoints,
                Role3.Developer,
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
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Limit = 216,
    TotalCount = 210,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

