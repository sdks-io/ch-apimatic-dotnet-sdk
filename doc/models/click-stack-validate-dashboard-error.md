
# Click Stack Validate Dashboard Error

*This model accepts additional fields of type object.*

## Structure

`ClickStackValidateDashboardError`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Path` | `string` | Required | Dot-separated field path, or empty string for top-level errors. |
| `Message` | `string` | Required | Human-readable error description. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackValidateDashboardError clickStackValidateDashboardError = new ClickStackValidateDashboardError
{
    Path = "tiles.0.config",
    Message = "Required",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

