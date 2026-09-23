
# Interval

Evaluation interval for the alert. `30s` requires the 30s alert interval feature to be enabled for your team.

## Enumeration

`Interval`

## Fields

| Name |
|  --- |
| `Enum30S` |
| `Enum1M` |
| `Enum5M` |
| `Enum15M` |
| `Enum30M` |
| `Enum1H` |
| `Enum6H` |
| `Enum12H` |
| `Enum1D` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

Interval interval = Interval.Enum1D;
```

