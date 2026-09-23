
# Click Pipe

*This model accepts additional fields of type object.*

## Structure

`ClickPipe`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique ClickPipe ID. |
| `ServiceId` | `Guid?` | Optional | ID of the service this ClickPipe belongs to. |
| `Name` | `string` | Optional | Name of the ClickPipe.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255` |
| `State` | [`State2?`](../../doc/models/state-2.md) | Optional | Current lifecycle state of the ClickPipe. For database pipes: "Provisioning" (initial setup), "Setup" (configuring replication), "Snapshot" (initial data load), "Running" (actively replicating), "Pausing" (transitioning to paused state), "Paused" (temporarily paused), "Modifying" (applying configuration updates), "Resync" (swapping resync tables with original tables), "Failed" (error occurred), "Unknown". For streaming/object storage pipes (Kafka, Kinesis, S3): "Unknown" (initial state), "Provisioning" (setting up resources), "Running" (actively ingesting data), "Stopping" (transitioning to stopped state), "Stopped" (manually stopped, can be restarted), "Completed" (batch ingestion finished for object storage), "Failed" (error occurred, pipe stopped), "InternalError" (internal system error). |
| `Scaling` | [`ClickPipeScaling`](../../doc/models/click-pipe-scaling.md) | Optional | - |
| `Source` | [`ClickPipeSource`](../../doc/models/click-pipe-source.md) | Optional | - |
| `Destination` | [`ClickPipeDestination`](../../doc/models/click-pipe-destination.md) | Optional | - |
| `FieldMappings` | [`List<ClickPipeFieldMapping>`](../../doc/models/click-pipe-field-mapping.md) | Optional | Field mappings of the ClickPipe. Note that all destination columns must be included in the mappings. |
| `Settings` | [`ClickPipeSettings`](../../doc/models/click-pipe-settings.md) | Optional | - |
| `CreatedAt` | `DateTime?` | Optional | Creation timestamp of the ClickPipe in ISO 8601 format. |
| `UpdatedAt` | `DateTime?` | Optional | Last update timestamp of the ClickPipe in ISO 8601 format. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipe clickPipe = new ClickPipe
{
    Id = new Guid("00001656-0000-0000-0000-000000000000"),
    ServiceId = new Guid("00002596-0000-0000-0000-000000000000"),
    Name = "my_postgres_pipe",
    State = State2.Running,
    Scaling = new ClickPipeScaling
    {
        Replicas = 40,
        Concurrency = 26,
        ReplicaCpuMillicores = 196,
        ReplicaMemoryGb = 8,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

