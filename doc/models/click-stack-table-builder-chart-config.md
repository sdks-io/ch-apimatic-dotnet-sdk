
# Click Stack Table Builder Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackTableBuilderChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayType` | `string` | Required, Constant | Display type discriminator. Must be "table" for table charts.<br><br>**Value**: `"table"` |
| `SourceId` | `string` | Required | ID of the data source to query. |
| `Select` | [`List<ClickStackSelectItem>`](../../doc/models/click-stack-select-item.md) | Required | One or more aggregated values to display as table columns. When asRatio is true, exactly two select items are required. |
| `GroupBy` | `string` | Optional | Field expression to group results by (one row per group value). |
| `Having` | `string` | Optional | Post-aggregation SQL HAVING condition. |
| `OrderBy` | `string` | Optional | SQL ORDER BY expression for sorting table rows. |
| `AsRatio` | `bool?` | Optional | Display select[0] / select[1] as a ratio. Requires exactly two select items. |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `GroupByColumnsOnLeft` | `bool?` | Optional | When true, render Group By columns to the left of series columns in the table. Defaults to false (Group By columns on the right). |
| `OnClick` | [`ClickStackOnClick`](../../doc/models/containers/click-stack-on-click.md) | Optional | - |
| `Formulas` | [`List<ClickStackFormula>`](../../doc/models/click-stack-formula.md) | Optional | Derived columns computed from the select items via letter-ref arithmetic ("A" = select[0], "B" = select[1], ...). Metric, log, and trace sources only. Cannot be combined with asRatio. |
| `ShowOperandSeries` | `bool?` | Optional | Only meaningful with formulas. When false, only the formula columns are returned; the raw operand columns are hidden. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackTableBuilderChartConfig clickStackTableBuilderChartConfig = new ClickStackTableBuilderChartConfig
{
    DisplayType = "table",
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
    Having = "count > 100",
    OrderBy = "count DESC",
    AsRatio = false,
    NumberFormat = new ClickStackNumberFormat
    {
        Output = Output.Currency,
        Mantissa = 170,
        ThousandSeparated = false,
        Average = false,
        DecimalBytes = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    GroupByColumnsOnLeft = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

