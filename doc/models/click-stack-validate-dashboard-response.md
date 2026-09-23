
# Click Stack Validate Dashboard Response

*This model accepts additional fields of type object.*

## Structure

`ClickStackValidateDashboardResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Valid` | `bool` | Required | True when the body passes all validation rules. |
| `Errors` | [`List<ClickStackValidateDashboardError>`](../../doc/models/click-stack-validate-dashboard-error.md) | Required | Validation errors. Empty when valid is true. |
| `Normalized` | `object` | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackValidateDashboardResponse clickStackValidateDashboardResponse = new ClickStackValidateDashboardResponse
{
    Valid = false,
    Errors = new List<ClickStackValidateDashboardError>
    {
        new ClickStackValidateDashboardError
        {
            Path = "tiles.0.config",
            Message = "Required",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Normalized = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

