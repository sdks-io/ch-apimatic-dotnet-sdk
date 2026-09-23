
# Click Stack Materialized View

*This model accepts additional fields of type object.*

## Structure

`ClickStackMaterializedView`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DatabaseName` | `string` | Required | Database name for the materialized view |
| `TableName` | `string` | Required | Table name for the materialized view |
| `DimensionColumns` | `string` | Required | Columns which are not pre-aggregated in the materialized view and can be used for filtering and grouping. |
| `MinGranularity` | `string` | Required | The granularity of the timestamp column: a positive integer followed by a unit (s, m, h, d). Common values: 1s, 15s, 30s, 1m, 5m, 15m, 30m, 1h, 2h, 6h, 12h, 1d, 2d, 7d, 30d. |
| `MinDate` | `DateTime?` | Optional | (Optional) The earliest date and time for which the materialized view contains data. If not provided, then HyperDX will assume that the materialized view contains data for all dates for which the source table contains data. |
| `TimestampColumn` | `string` | Required | Timestamp column name |
| `AggregatedColumns` | [`List<ClickStackAggregatedColumn>`](../../doc/models/click-stack-aggregated-column.md) | Required | Columns which are pre-aggregated by the materialized view |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

ClickStackMaterializedView clickStackMaterializedView = new ClickStackMaterializedView
{
    DatabaseName = "otel",
    TableName = "otel_logs_mv_5m",
    DimensionColumns = "ServiceName, SeverityText",
    MinGranularity = "5m",
    TimestampColumn = "Timestamp",
    AggregatedColumns = new List<ClickStackAggregatedColumn>
    {
        new ClickStackAggregatedColumn
        {
            AggFn = "sum",
            MvColumn = "sum__Duration",
            SourceColumn = "Duration",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    MinDate = DateTime.ParseExact("2025-01-01T00:00:00Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

