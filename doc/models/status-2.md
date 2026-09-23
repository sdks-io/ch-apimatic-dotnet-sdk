
# Status 2

Status of the snapshot: 'done', 'error', 'in_progress', 'throttled'. 'throttled' means snapshot creation was rate-limited and will be retried.

## Enumeration

`Status2`

## Fields

| Name |
|  --- |
| `Done` |
| `Error` |
| `InProgress` |
| `Throttled` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

Status2 status2 = Status2.InProgress;
```

