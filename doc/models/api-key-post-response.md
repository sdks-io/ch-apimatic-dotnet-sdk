
# Api Key Post Response

*This model accepts additional fields of type object.*

## Structure

`ApiKeyPostResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | [`ApiKey`](../../doc/models/api-key.md) | Optional | - |
| `KeyId` | `string` | Optional | Generated key ID. Provided only if there was no 'hashData' in the request. |
| `KeySecret` | `string` | Optional | Generated key secret. Provided only if there was no 'hashData' in the request. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ApiKeyPostResponse apiKeyPostResponse = new ApiKeyPostResponse
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
};
```

