
# Click Stack Background Chart

*This model accepts additional fields of type object.*

## Structure

`ClickStackBackgroundChart`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type19`](../../doc/models/type-19.md) | Required | Sparkline shape. |
| `Color` | [`Color?`](../../doc/models/color.md) | Optional | Optional palette-token override for the sparkline. When unset the sparkline inherits the tile's static color. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackBackgroundChart clickStackBackgroundChart = new ClickStackBackgroundChart
{
    Type = Type19.Line,
    Color = Color.Charterror,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

