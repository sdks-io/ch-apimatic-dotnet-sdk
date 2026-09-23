
# Role Create Request

*This model accepts additional fields of type object.*

## Structure

`RoleCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name of the role |
| `Actors` | `List<string>` | Required | List of actor resource IDs to assign to this role (e.g., ["user/uuid", "apiKey/uuid"]) |
| `Policies` | [`List<RbacPolicyCreateRequest>`](../../doc/models/rbac-policy-create-request.md) | Required | List of policies to create for this role |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

RoleCreateRequest roleCreateRequest = new RoleCreateRequest
{
    Name = "name2",
    Actors = new List<string>
    {
        "actors5",
        "actors6",
        "actors7",
    },
    Policies = new List<RbacPolicyCreateRequest>
    {
        new RbacPolicyCreateRequest
        {
            AllowDeny = AllowDeny.Allow,
            Permissions = new List<string>
            {
                "permissions5",
            },
            Resources = new List<string>
            {
                "resources3",
                "resources2",
                "resources1",
            },
            Tags = new RbacPolicyTags
            {
                Grants = new List<string>
                {
                    "grants0",
                    "grants1",
                    "grants2",
                },
                RoleV2 = RoleV2.Sqlconsolereadonly,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

