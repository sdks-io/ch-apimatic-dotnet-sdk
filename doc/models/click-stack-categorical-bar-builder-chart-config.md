
# Click Stack Categorical Bar Builder Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackCategoricalBarBuilderChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayType` | `string` | Required, Constant | Display type discriminator. Must be "bar" for categorical bar charts.<br><br>**Value**: `"bar"` |
| `SourceId` | `string` | Required | ID of the data source to query. |
| `Select` | [`List<ClickStackSelectItem>`](../../doc/models/click-stack-select-item.md) | Required | Exactly one aggregated value used to size each bar. |
| `GroupBy` | `string` | Optional | Field expression to group results by (one bar per group value). |
| `OrderBy` | `string` | Optional | Optional custom SQL ORDER BY expression (raw SQL). Overrides the default value-descending ordering and, when combined with "limit", controls which bars are kept. |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `Limit` | `int?` | Optional | Maximum number of bars (SQL LIMIT). Without a custom "orderBy" the query keeps the groups with the largest aggregated values; with an "orderBy" it keeps the first bars in that order. Omit or set 0 to fetch all groups. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackCategoricalBarBuilderChartConfig clickStackCategoricalBarBuilderChartConfig = new ClickStackCategoricalBarBuilderChartConfig
{
    DisplayType = "bar",
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
    OrderBy = "\"Count\" DESC",
    NumberFormat = new ClickStackNumberFormat
    {
        Output = Output.Currency,
        Mantissa = 170,
        ThousandSeparated = false,
        Average = false,
        DecimalBytes = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Limit = 10,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

