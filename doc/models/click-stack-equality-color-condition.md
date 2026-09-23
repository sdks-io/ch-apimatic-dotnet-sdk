
# Click Stack Equality Color Condition

*This model accepts additional fields of type object.*

## Structure

`ClickStackEqualityColorCondition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Operator` | [`Operator1`](../../doc/models/operator-1.md) | Required | Equality comparison operator. |
| `MValue` | [`ClickStackEqualityColorConditionValue`](../../doc/models/containers/click-stack-equality-color-condition-value.md) | Required | This is a container for one-of cases. |
| `Color` | [`Color1`](../../doc/models/color-1.md) | Required | Color applied when the rule matches. |
| `Label` | `string` | Optional | Optional label describing the rule. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackEqualityColorCondition clickStackEqualityColorCondition = new ClickStackEqualityColorCondition
{
    MOperator = Operator1.Eq,
    MValue = ClickStackEqualityColorConditionValue.FromPrecision(68.8),
    Color = Color1.Chartblue,
    Label = "Healthy",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

