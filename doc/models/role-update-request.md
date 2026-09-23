
# Role Update Request

*This model accepts additional fields of type object.*

## Structure

`RoleUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | New name for the role |
| `Actors` | `List<string>` | Optional | New list of actor resource IDs (replaces existing actors) |
| `Policies` | [`List<RbacPolicyCreateRequest>`](../../doc/models/rbac-policy-create-request.md) | Optional | New list of policies (replaces existing policies) |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

RoleUpdateRequest roleUpdateRequest = new RoleUpdateRequest
{
    Name = "name8",
    Actors = new List<string>
    {
        "actors1",
        "actors2",
        "actors3",
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

