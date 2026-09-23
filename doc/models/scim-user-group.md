
# Scim User Group

*This model accepts additional fields of type object.*

## Structure

`ScimUserGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Optional | The identifier of the group. |
| `Display` | `string` | Optional | A human-readable name for the group. |
| `Type` | `string` | Optional | A label indicating the attribute's function (e.g., "direct" or "indirect"). |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimUserGroup scimUserGroup = new ScimUserGroup
{
    MValue = "value8",
    Display = "display8",
    Type = "type4",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

