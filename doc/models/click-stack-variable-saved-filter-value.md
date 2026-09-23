
# Click Stack Variable Saved Filter Value

*This model accepts additional fields of type object.*

## Structure

`ClickStackVariableSavedFilterValue`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | Filter type.<br><br>**Value**: `"variable"` |
| `Name` | `string` | Required | The variableName of the dashboard variable this selection belongs to. Only allowed for variable-enabled filters. |
| `Values` | `List<string>` | Required | Selected values |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackVariableSavedFilterValue clickStackVariableSavedFilterValue = new ClickStackVariableSavedFilterValue
{
    Type = "variable",
    Name = "service",
    Values = new List<string>
    {
        "hdx-oss-dev-api",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

