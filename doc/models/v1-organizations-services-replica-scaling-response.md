
# V1 Organizations Services Replica Scaling Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesReplicaScalingResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ServiceScalingPatchResponse`](../../doc/models/service-scaling-patch-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesReplicaScalingResponse v1OrganizationsServicesReplicaScalingResponse = new V1OrganizationsServicesReplicaScalingResponse
{
    Status = 200,
    RequestId = new Guid("00001e9e-0000-0000-0000-000000000000"),
    Result = new ServiceScalingPatchResponse
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
        Id = new Guid("000002b8-0000-0000-0000-000000000000"),
        Name = "name6",
        Provider = Provider.Azure,
        Region = Region.Apsoutheast2,
        State = State.Provisioning,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

