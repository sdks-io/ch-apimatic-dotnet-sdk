
# State 2

Current lifecycle state of the ClickPipe. For database pipes: "Provisioning" (initial setup), "Setup" (configuring replication), "Snapshot" (initial data load), "Running" (actively replicating), "Pausing" (transitioning to paused state), "Paused" (temporarily paused), "Modifying" (applying configuration updates), "Resync" (swapping resync tables with original tables), "Failed" (error occurred), "Unknown". For streaming/object storage pipes (Kafka, Kinesis, S3): "Unknown" (initial state), "Provisioning" (setting up resources), "Running" (actively ingesting data), "Stopping" (transitioning to stopped state), "Stopped" (manually stopped, can be restarted), "Completed" (batch ingestion finished for object storage), "Failed" (error occurred, pipe stopped), "InternalError" (internal system error).

## Enumeration

`State2`

## Fields

| Name |
|  --- |
| `Unknown` |
| `Provisioning` |
| `Running` |
| `Degraded` |
| `Stopping` |
| `Stopped` |
| `Failed` |
| `Completed` |
| `InternalError` |
| `Setup` |
| `Snapshot` |
| `Paused` |
| `Pausing` |
| `Modifying` |
| `Resync` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

State2 state2 = State2.Modifying;
```

