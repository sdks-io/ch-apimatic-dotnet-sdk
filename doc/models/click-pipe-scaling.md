
# Click Pipe Scaling

*This model accepts additional fields of type object.*

## Structure

`ClickPipeScaling`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Replicas` | `int?` | Optional | Desired number of replicas. Only for scalable pipes.<br><br>**Constraints**: `>= 1`, `<= 40` |
| `Concurrency` | `int?` | Optional | Desired number of concurrency. Only for S3 pipes. If set to 0, concurrency is auto-scaled based on the cluster memory. |
| `ReplicaCpuMillicores` | `int?` | Optional | CPU in millicores for each replica. Only for streaming pipes.<br><br>**Constraints**: `>= 125`, `<= 2000` |
| `ReplicaMemoryGb` | `double?` | Optional | Memory in GB for each replica. Only for streaming pipes.<br><br>**Constraints**: `>= 0.5`, `<= 8` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeScaling clickPipeScaling = new ClickPipeScaling
{
    Replicas = 34,
    Concurrency = 218,
    ReplicaCpuMillicores = 132,
    ReplicaMemoryGb = 6.44,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

