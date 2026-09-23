
# Rbac Policy Create Request

*This model accepts additional fields of type object.*

## Structure

`RbacPolicyCreateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllowDeny` | [`AllowDeny`](../../doc/models/allow-deny.md) | Required | Whether this policy allows or denies access |
| `Permissions` | `List<string>` | Required | List of permissions to grant or deny (e.g., ["control-plane:organization:view"]) |
| `Resources` | `List<string>` | Required | List of resource IDs this policy applies to (e.g., ["instance/uuid", "instance/*"]) |
| `Tags` | [`RbacPolicyTags`](../../doc/models/rbac-policy-tags.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

RbacPolicyCreateRequest rbacPolicyCreateRequest = new RbacPolicyCreateRequest
{
    AllowDeny = AllowDeny.Allow,
    Permissions = new List<string>
    {
        "permissions9",
        "permissions0",
        "permissions1",
    },
    Resources = new List<string>
    {
        "resources7",
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
};
```

