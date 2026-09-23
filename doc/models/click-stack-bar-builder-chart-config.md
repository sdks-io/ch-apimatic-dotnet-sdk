
# Click Stack Bar Builder Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackBarBuilderChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayType` | `string` | Required, Constant | Display type discriminator. Must be "stacked_bar" for stacked-bar charts.<br><br>**Value**: `"stacked_bar"` |
| `SourceId` | `string` | Required | ID of the data source to query. |
| `Select` | [`List<ClickStackSelectItem>`](../../doc/models/click-stack-select-item.md) | Required | One or more aggregated values to plot. When asRatio is true, exactly two select items are required. |
| `GroupBy` | `string` | Optional | Field expression to group results by (creates separate bars segments per group value). |
| `AsRatio` | `bool?` | Optional | Plot select[0] / select[1] as a ratio. Requires exactly two select items. |
| `AlignDateRangeToGranularity` | `bool?` | Optional | Align the date range boundaries to the query granularity interval. |
| `FillNulls` | `bool?` | Optional | Fill missing time buckets with zero instead of leaving gaps. |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `SeriesLimit` | `int?` | Optional | Maximum number of series rendered (top-N by value). Omit to use the default render cap, set 0 for unlimited, or a positive N to keep the top N series. |
| `Formulas` | [`List<ClickStackFormula>`](../../doc/models/click-stack-formula.md) | Optional | Derived series computed from the select items via letter-ref arithmetic ("A" = select[0], "B" = select[1], ...). Metric, log, and trace sources only. Cannot be combined with asRatio. |
| `ShowOperandSeries` | `bool?` | Optional | Only meaningful with formulas. When false, only the formula series are returned; the raw operand series are hidden. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackBarBuilderChartConfig clickStackBarBuilderChartConfig = new ClickStackBarBuilderChartConfig
{
    DisplayType = "stacked_bar",
    SourceId = "65f5e4a3b9e77c001a111111",
    MSelect = new List<ClickStackSelectItem>
    {
        new ClickStackSelectItem
        {
            AggFn = AggFn3.Count,
            ValueExpression = "Duration",
            MAlias = "Request Duration",
            Level = Level.P50,
            MWhere = "service:api",
            WhereLanguage = WhereLanguage4.Sql,
            MetricName = "http.server.duration",
            PeriodAggFn = PeriodAggFn.Delta,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    GroupBy = "service",
    AsRatio = false,
    AlignDateRangeToGranularity = false,
    FillNulls = false,
    NumberFormat = new ClickStackNumberFormat
    {
        Output = Output.Currency,
        Mantissa = 170,
        ThousandSeparated = false,
        Average = false,
        DecimalBytes = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    SeriesLimit = 5,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

