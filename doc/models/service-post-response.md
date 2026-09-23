
# Service Post Response

*This model accepts additional fields of type object.*

## Structure

`ServicePostResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Service` | [`Service`](../../doc/models/service.md) | Optional | - |
| `Password` | `string` | Optional | Password for the newly created service. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServicePostResponse servicePostResponse = new ServicePostResponse
{
    Service = new Service
    {
        AutoscalingMode = AutoscalingMode3.Vertical,
        CurrentScaling = new CurrentScaling
        {
            EffectiveAutoscalingMode = EffectiveAutoscalingMode.Vertical,
            EffectiveMinReplicaMemoryGb = 39.2,
            EffectiveMaxReplicaMemoryGb = 21.08,
            EffectiveMinReplicas = 124,
            EffectiveMaxReplicas = 40,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        Id = new Guid("000023dc-0000-0000-0000-000000000000"),
        Name = "name0",
        Provider = Provider.Aws,
        Region = Region.Apnortheast1,
        State = State.Terminating,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Password = "password6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

