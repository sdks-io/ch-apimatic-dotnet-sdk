
# Click Stack Number Chart Series

*This model accepts additional fields of type object.*

## Structure

`ClickStackNumberChartSeries`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | Series type discriminator. Must be "number" for single-value number charts.<br><br>**Value**: `"number"` |
| `SourceId` | `string` | Required | ID of the data source to query |
| `AggFn` | [`AggFn`](../../doc/models/agg-fn.md) | Required | Aggregation function to apply to the field or metric value |
| `Level` | `double?` | Optional | Percentile level for quantile aggregations (e.g., 0.95 for p95) |
| `Field` | `string` | Optional | Column or expression to aggregate (required for most aggregation functions except count) |
| `Alias` | `string` | Optional | Display name for the series in the chart |
| `Where` | `string` | Required | Filter query for the data (syntax depends on whereLanguage) |
| `WhereLanguage` | [`WhereLanguage`](../../doc/models/where-language.md) | Required | Query language for the where clause |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `MetricDataType` | [`MetricDataType?`](../../doc/models/metric-data-type.md) | Optional | Metric data type, only for metrics data sources. |
| `MetricName` | `string` | Optional | Metric name for metrics data sources. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackNumberChartSeries clickStackNumberChartSeries = new ClickStackNumberChartSeries
{
    Type = "number",
    SourceId = "65f5e4a3b9e77c001a567890",
    AggFn = AggFn.Count,
    MWhere = "service:api",
    WhereLanguage = WhereLanguage.Lucene,
    Level = 0.95,
    Field = "duration",
    MAlias = "Total Requests",
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
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

