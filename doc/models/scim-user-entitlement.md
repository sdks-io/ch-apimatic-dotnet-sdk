
# Scim User Entitlement

*This model accepts additional fields of type object.*

## Structure

`ScimUserEntitlement`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Optional | The value of an entitlement. |
| `Display` | `string` | Optional | A human-readable name for the entitlement. |
| `Type` | `string` | Optional | A label indicating the attribute's function. |
| `Primary` | `bool?` | Optional | A Boolean value indicating the primary entitlement. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimUserEntitlement scimUserEntitlement = new ScimUserEntitlement
{
    MValue = "value4",
    Display = "display4",
    Type = "type8",
    Primary = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

