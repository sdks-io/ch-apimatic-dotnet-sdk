
# Click Stack between Color Condition

*This model accepts additional fields of type object.*

## Structure

`ClickStackBetweenColorCondition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Operator` | `string` | Required, Constant | Range comparison operator.<br><br>**Value**: `"between"` |
| `MValue` | `List<double>` | Required | Inclusive [min, max] range. Both bounds must be finite numbers. |
| `Color` | [`Color1`](../../doc/models/color-1.md) | Required | Color applied when the rule matches. |
| `Label` | `string` | Optional | Optional label describing the rule. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackBetweenColorCondition clickStackBetweenColorCondition = new ClickStackBetweenColorCondition
{
    MOperator = "between",
    MValue = new List<double>
    {
        100,
        500,
    },
    Color = Color1.Charterror,
    Label = "Warning",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

