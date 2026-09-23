
# Click Stack Heatmap Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackHeatmapChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayType` | `string` | Required, Constant | Display type discriminator. Must be "heatmap" for heatmap tiles.<br><br>**Value**: `"heatmap"` |
| `SourceId` | `string` | Required | ID of the data source to query. |
| `Select` | [`List<ClickStackHeatmapSelectItem>`](../../doc/models/click-stack-heatmap-select-item.md) | Required | Exactly one heatmap select item. |
| `Where` | `string` | Optional | Row-level filter (syntax depends on whereLanguage). |
| `WhereLanguage` | [`WhereLanguage4?`](../../doc/models/where-language-4.md) | Optional | Query language for the where clause. |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackHeatmapChartConfig clickStackHeatmapChartConfig = new ClickStackHeatmapChartConfig
{
    DisplayType = "heatmap",
    SourceId = "65f5e4a3b9e77c001a111111",
    MSelect = new List<ClickStackHeatmapSelectItem>
    {
        new ClickStackHeatmapSelectItem
        {
            ValueExpression = "Duration",
            CountExpression = "count()",
            HeatmapScaleType = HeatmapScaleType.Log,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    MWhere = "ServiceName = 'api'",
    WhereLanguage = WhereLanguage4.Sql,
    NumberFormat = new ClickStackNumberFormat
    {
        Output = Output.Currency,
        Mantissa = 170,
        ThousandSeparated = false,
        Average = false,
        DecimalBytes = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

