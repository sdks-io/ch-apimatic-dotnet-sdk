
# V1 Organizations Services Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ServicePostResponse`](../../doc/models/service-post-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesResponse1 v1OrganizationsServicesResponse1 = new V1OrganizationsServicesResponse1
{
    Status = 200,
    RequestId = new Guid("00001470-0000-0000-0000-000000000000"),
    Result = new ServicePostResponse
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
        Password = "password0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

