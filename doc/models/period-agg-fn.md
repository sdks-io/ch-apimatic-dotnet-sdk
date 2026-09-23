
# Period Agg Fn

Optional period aggregation function for Gauge metrics (e.g., compute the delta over the period).

## Enumeration

`PeriodAggFn`

## Fields

| Name |
|  --- |
| `Delta` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

PeriodAggFn periodAggFn = PeriodAggFn.Delta;
```

