
# Click Stack Numeric Color Condition

*This model accepts additional fields of type object.*

## Structure

`ClickStackNumericColorCondition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Operator` | [`Operator`](../../doc/models/operator.md) | Required | Numeric comparison operator. |
| `MValue` | `double` | Required | Numeric bound the displayed value is compared against. Only finite numbers are accepted (Infinity and NaN are rejected). |
| `Color` | [`Color1`](../../doc/models/color-1.md) | Required | Color applied when the rule matches. |
| `Label` | `string` | Optional | Optional label describing the rule. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackNumericColorCondition clickStackNumericColorCondition = new ClickStackNumericColorCondition
{
    MOperator = Operator.Gt,
    MValue = 100,
    Color = Color1.Chartred,
    Label = "High",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

