
# Click Stack Update Role Request

*This model accepts additional fields of type object.*

## Structure

`ClickStackUpdateRoleRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | New role name. Omit to leave the name unchanged. |
| `Description` | `string` | Optional | New role description. |
| `Permissions` | [`List<ClickStackCaslPermission>`](../../doc/models/click-stack-casl-permission.md) | Required | The replacement set of CASL permissions for the role. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackUpdateRoleRequest clickStackUpdateRoleRequest = new ClickStackUpdateRoleRequest
{
    Permissions = new List<ClickStackCaslPermission>
    {
        new ClickStackCaslPermission
        {
            Action = "read",
            Subject = "dashboard",
            Inverted = false,
            Integration = "mongodb",
            Conditions = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Name = "Deploy Bot",
    Description = "Manages dashboards via Terraform",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

