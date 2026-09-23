
# Level

Percentile level; only valid when aggFn is "quantile".

## Enumeration

`Level`

## Fields

| Name | Description |
|  --- | --- |
| `P50` | 50th percentile. |
| `P90` | 90th percentile. |
| `P95` | 95th percentile. |
| `P99` | 99th percentile. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

Level level = Level.P95;
```

