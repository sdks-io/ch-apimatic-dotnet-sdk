
# Rbac Policy

*This model accepts additional fields of type object.*

## Structure

`RbacPolicy`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique policy identifier |
| `RoleId` | `string` | Optional | ID of the role this policy belongs to |
| `TenantId` | `string` | Optional | Tenant resource ID (e.g., organization/uuid) |
| `AllowDeny` | [`AllowDeny?`](../../doc/models/allow-deny.md) | Optional | Whether this policy allows or denies access |
| `Permissions` | `List<string>` | Optional | List of permissions granted or denied by this policy |
| `Resources` | `List<string>` | Optional | List of resource IDs this policy applies to (e.g., instance/uuid, instance/*) |
| `Tags` | [`RbacPolicyTags`](../../doc/models/rbac-policy-tags.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

RbacPolicy rbacPolicy = new RbacPolicy
{
    Id = "id0",
    RoleId = "roleId4",
    TenantId = "tenantId6",
    AllowDeny = AllowDeny.Allow,
    Permissions = new List<string>
    {
        "permissions7",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

