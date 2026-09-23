
# Seek Type

Starting position strategy for consuming the subscription. The seekTimestamp companion is required only when seekType is "timestamp"; setting it for a mismatched seek type is rejected.

## Enumeration

`SeekType`

## Fields

| Name |
|  --- |
| `Latest` |
| `Earliest` |
| `Timestamp` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

SeekType seekType = SeekType.Earliest;
```

