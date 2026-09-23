
# Click Pipes Cdc Scaling

*This model accepts additional fields of type object.*

## Structure

`ClickPipesCdcScaling`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReplicaCpuMillicores` | `int?` | Optional | CPU in millicores for DB ClickPipes.<br><br>**Constraints**: `>= 1000`, `<= 32000`, *Multiple Of*: `1000` |
| `ReplicaMemoryGb` | `double?` | Optional | Memory in GiB for DB ClickPipes. Must be 4× the CPU core count.<br><br>**Constraints**: `>= 4`, `<= 128`, *Multiple Of*: `4` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipesCdcScaling clickPipesCdcScaling = new ClickPipesCdcScaling
{
    ReplicaCpuMillicores = 2000,
    ReplicaMemoryGb = 8,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

