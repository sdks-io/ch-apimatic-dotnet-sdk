
# Scim User Role

*This model accepts additional fields of type object.*

## Structure

`ScimUserRole`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Optional | The value of a role; a string or label representing a collection of entitlements. No canonical types. |
| `Display` | `string` | Optional | A human-readable name, primarily used for display purposes. |
| `Type` | `string` | Optional | A label indicating the attribute's function. |
| `Primary` | `bool?` | Optional | A Boolean value indicating the primary or preferred role. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimUserRole scimUserRole = new ScimUserRole
{
    MValue = "value2",
    Display = "display2",
    Type = "type0",
    Primary = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

