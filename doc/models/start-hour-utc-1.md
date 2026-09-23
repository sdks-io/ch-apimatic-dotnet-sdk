
# Start Hour Utc 1

UTC hour when the upgrade window starts. Must be one of 0, 6, 12, or 18. The upgrade window currently lasts 6 hours from this start time.

## Enumeration

`StartHourUtc1`

## Fields

| Name | Description |
|  --- | --- |
| `Hour0` | Upgrade window starts at 00:00 UTC. |
| `Hour6` | Upgrade window starts at 06:00 UTC. |
| `Hour12` | Upgrade window starts at 12:00 UTC. |
| `Hour18` | Upgrade window starts at 18:00 UTC. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

StartHourUtc1 startHourUtc1 = StartHourUtc1.Hour12;
```

