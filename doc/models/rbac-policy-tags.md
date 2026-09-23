
# Rbac Policy Tags

*This model accepts additional fields of type object.*

## Structure

`RbacPolicyTags`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Grants` | `List<string>` | Optional | Optional list of database grants (e.g., database names) |
| `RoleV2` | [`RoleV2?`](../../doc/models/role-v2.md) | Optional | Optional SQL console role type |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

RbacPolicyTags rbacPolicyTags = new RbacPolicyTags
{
    Grants = new List<string>
    {
        "grants6",
    },
    RoleV2 = RoleV2.Sqlconsolereadonly,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

