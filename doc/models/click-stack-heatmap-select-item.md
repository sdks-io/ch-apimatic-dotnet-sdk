
# Click Stack Heatmap Select Item

*This model accepts additional fields of type object.*

## Structure

`ClickStackHeatmapSelectItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ValueExpression` | `string` | Required | SQL expression for the value being bucketed on the y-axis. Must be non-empty. |
| `CountExpression` | `string` | Optional | SQL expression for the count contributing to each bucket. Defaults to "count()" in the editor when omitted. |
| `HeatmapScaleType` | [`HeatmapScaleType?`](../../doc/models/heatmap-scale-type.md) | Optional | Scale type used to bucket values on the y-axis. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackHeatmapSelectItem clickStackHeatmapSelectItem = new ClickStackHeatmapSelectItem
{
    ValueExpression = "Duration",
    CountExpression = "count()",
    HeatmapScaleType = HeatmapScaleType.Log,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

