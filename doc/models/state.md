
# State

Current state of the service.

## Enumeration

`State`

## Fields

| Name |
|  --- |
| `Starting` |
| `Stopping` |
| `Terminating` |
| `Softdeleting` |
| `Awaking` |
| `PartiallyRunning` |
| `Provisioning` |
| `Running` |
| `Stopped` |
| `Terminated` |
| `Softdeleted` |
| `Degraded` |
| `Failed` |
| `Idle` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

State state = State.Terminating;
```

