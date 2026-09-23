
# Click Stack Time Chart Series

*This model accepts additional fields of type object.*

## Structure

`ClickStackTimeChartSeries`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | Series type discriminator. Must be "time" for time-series charts.<br><br>**Value**: `"time"` |
| `SourceId` | `string` | Required | ID of the data source to query |
| `AggFn` | [`AggFn`](../../doc/models/agg-fn.md) | Required | Aggregation function to apply to the field or metric value |
| `Level` | `double?` | Optional | Percentile level for quantile aggregations (e.g., 0.95 for p95) |
| `Field` | `string` | Optional | Column or expression to aggregate (required for most aggregation functions except count) |
| `Alias` | `string` | Optional | Display name for the series in the chart |
| `Where` | `string` | Required | Filter query for the data (syntax depends on whereLanguage) |
| `WhereLanguage` | [`WhereLanguage`](../../doc/models/where-language.md) | Required | Query language for the where clause |
| `GroupBy` | `List<string>` | Required | Fields to group results by (creates separate series for each group) |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `MetricDataType` | [`MetricDataType?`](../../doc/models/metric-data-type.md) | Optional | Metric data type, only for metrics data sources. |
| `MetricName` | `string` | Optional | Metric name for metrics data sources |
| `DisplayType` | [`DisplayType?`](../../doc/models/display-type.md) | Optional | Visual representation type for the time series |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackTimeChartSeries clickStackTimeChartSeries = new ClickStackTimeChartSeries
{
    Type = "time",
    SourceId = "65f5e4a3b9e77c001a567890",
    AggFn = AggFn.Count,
    MWhere = "service:api",
    WhereLanguage = WhereLanguage.Lucene,
    GroupBy = new List<string>
    {
        "host",
    },
    Level = 0.95,
    Field = "duration",
    MAlias = "Request Duration",
    NumberFormat = new ClickStackNumberFormat
    {
        Output = Output.Currency,
        Mantissa = 170,
        ThousandSeparated = false,
        Average = false,
        DecimalBytes = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    MetricDataType = MetricDataType.Sum,
    MetricName = "http.server.duration",
    DisplayType = DisplayType.Line,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

