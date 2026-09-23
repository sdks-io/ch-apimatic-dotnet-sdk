
# Scim Enterprise Manager

*This model accepts additional fields of type object.*

## Structure

`ScimEnterpriseManager`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Optional | The id of the SCIM resource representing the user's manager. |
| `DisplayName` | `string` | Optional | The displayName of the user's manager. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimEnterpriseManager scimEnterpriseManager = new ScimEnterpriseManager
{
    MValue = "value8",
    DisplayName = "displayName6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

