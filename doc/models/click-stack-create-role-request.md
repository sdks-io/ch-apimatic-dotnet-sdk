
# Click Stack Create Role Request

*This model accepts additional fields of type object.*

## Structure

`ClickStackCreateRoleRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Role name. Must be unique within the team and not collide with a predefined role. |
| `Description` | `string` | Optional | Human-readable role description. |
| `Permissions` | [`List<ClickStackCaslPermission>`](../../doc/models/click-stack-casl-permission.md) | Required | The CASL permissions to grant to the role. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackCreateRoleRequest clickStackCreateRoleRequest = new ClickStackCreateRoleRequest
{
    Name = "Deploy Bot",
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
    Description = "Manages dashboards via Terraform",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

