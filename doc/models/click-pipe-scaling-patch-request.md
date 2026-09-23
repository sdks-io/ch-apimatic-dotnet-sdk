
# Click Pipe Scaling Patch Request

*This model accepts additional fields of type object.*

## Structure

`ClickPipeScalingPatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Replicas` | `int?` | Optional | Number of replicas to scale to. Use to scale Kafka pipes.<br><br>**Constraints**: `>= 1`, `<= 40` |
| `Concurrency` | `int?` | Optional | Number of concurrency to scale to. Use to scale S3 pipes.<br><br>**Constraints**: `>= 0`, `<= 34` |
| `ReplicaCpuMillicores` | `int?` | Optional | CPU in millicores for each replica. Use to scale streaming pipes.<br><br>**Constraints**: `>= 125`, `<= 2000` |
| `ReplicaMemoryGb` | `double?` | Optional | Memory in GB for each replica. Use to scale streaming pipes.<br><br>**Constraints**: `>= 0.5`, `<= 8` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeScalingPatchRequest clickPipeScalingPatchRequest = new ClickPipeScalingPatchRequest
{
    Replicas = 2,
    Concurrency = 34,
    ReplicaCpuMillicores = 125,
    ReplicaMemoryGb = 0.92,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

