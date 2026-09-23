
# Click Stack Select Item

*This model accepts additional fields of type object.*

## Structure

`ClickStackSelectItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AggFn` | [`AggFn3`](../../doc/models/agg-fn-3.md) | Required | Aggregation function to apply. "count" does not require a valueExpression; "quantile" requires a level field indicating the desired percentile (e.g., 0.95). |
| `ValueExpression` | `string` | Optional | Expression for the column or value to aggregate. Must be omitted when aggFn is "count"; required for all other aggFn values. |
| `Alias` | `string` | Optional | Display alias for this select item in chart legends. |
| `Level` | [`Level?`](../../doc/models/level.md) | Optional | Percentile level; only valid when aggFn is "quantile". |
| `Where` | `string` | Optional | SQL or Lucene filter condition applied before aggregation. |
| `WhereLanguage` | [`WhereLanguage4?`](../../doc/models/where-language-4.md) | Optional | Query language for the where clause. |
| `MetricName` | `string` | Optional | Name of the metric to aggregate; only applicable when the source is a metrics source. |
| `MetricType` | [`MetricType?`](../../doc/models/metric-type.md) | Optional | Metric type; only applicable when the source is a metrics source. |
| `PeriodAggFn` | [`PeriodAggFn?`](../../doc/models/period-agg-fn.md) | Optional | Optional period aggregation function for Gauge metrics (e.g., compute the delta over the period). |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackSelectItem clickStackSelectItem = new ClickStackSelectItem
{
    AggFn = AggFn3.Count,
    ValueExpression = "Duration",
    MAlias = "Request Duration",
    Level = Level.P95,
    MWhere = "service:api",
    WhereLanguage = WhereLanguage4.Sql,
    MetricName = "http.server.duration",
    PeriodAggFn = PeriodAggFn.Delta,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

