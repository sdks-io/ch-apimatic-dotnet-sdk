
# Click Stack Casl Permission

*This model accepts additional fields of type object.*

## Structure

`ClickStackCaslPermission`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required | The action this permission grants or denies. |
| `Subject` | `string` | Required | The resource the action applies to. |
| `Inverted` | `bool?` | Optional | When true, the rule denies rather than grants the action. |
| `Integration` | `string` | Optional | The integration the permission is scoped to. |
| `Conditions` | `object` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackCaslPermission clickStackCaslPermission = new ClickStackCaslPermission
{
    Action = "read",
    Subject = "dashboard",
    Inverted = false,
    Integration = "mongodb",
    Conditions = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

