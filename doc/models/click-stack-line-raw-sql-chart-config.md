
# Click Stack Line Raw Sql Chart Config

*This model accepts additional fields of type object.*

## Structure

`ClickStackLineRawSqlChartConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ConfigType` | `string` | Required, Constant | Must be "sql" to use the Raw SQL chart config variant.<br><br>**Value**: `"sql"` |
| `ConnectionId` | `string` | Required | ID of the ClickHouse connection to execute the query against. |
| `SqlTemplate` | `string` | Required | SQL query template to execute. Supports HyperDX template variables. |
| `SourceId` | `string` | Optional | Optional ID of the data source associated with this Raw SQL chart. Used for applying dashboard filters. |
| `NumberFormat` | [`ClickStackNumberFormat`](../../doc/models/click-stack-number-format.md) | Optional | - |
| `DisplayType` | `string` | Required, Constant | Display as a line time-series chart.<br><br>**Value**: `"line"` |
| `CompareToPreviousPeriod` | `bool?` | Optional | Overlay the equivalent previous time period for comparison. |
| `FillNulls` | `bool?` | Optional | Fill missing time buckets with zero instead of leaving gaps. |
| `AlignDateRangeToGranularity` | `bool?` | Optional | Expand date range boundaries to the query granularity interval. |
| `FitYAxisToData` | `bool?` | Optional | Set the y-axis lower bound to the minimum of the displayed data instead of zero, making small fluctuations between series easier to see. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackLineRawSqlChartConfig clickStackLineRawSqlChartConfig = new ClickStackLineRawSqlChartConfig
{
    ConfigType = "sql",
    ConnectionId = "65f5e4a3b9e77c001a567890",
    SqlTemplate = "SELECT count() FROM otel_logs WHERE timestamp > now() - INTERVAL 1 HOUR",
    DisplayType = "line",
    SourceId = "65f5e4a3b9e77c001a567890",
    NumberFormat = new ClickStackNumberFormat
    {
        Output = Output.Currency,
        Mantissa = 170,
        ThousandSeparated = false,
        Average = false,
        DecimalBytes = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    CompareToPreviousPeriod = false,
    FillNulls = false,
    AlignDateRangeToGranularity = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

