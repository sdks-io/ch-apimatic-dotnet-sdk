
# V1 Organizations Services Clickpipes Cdc Scaling Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickpipesCdcScalingResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickPipesCdcScaling`](../../doc/models/click-pipes-cdc-scaling.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesClickpipesCdcScalingResponse v1OrganizationsServicesClickpipesCdcScalingResponse = new V1OrganizationsServicesClickpipesCdcScalingResponse
{
    Status = 200,
    RequestId = new Guid("000005ce-0000-0000-0000-000000000000"),
    Result = new ClickPipesCdcScaling
    {
        ReplicaCpuMillicores = 1000,
        ReplicaMemoryGb = 128,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

