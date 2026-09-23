
# V1 Organizations Private Endpoint Config Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsPrivateEndpointConfigResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`OrganizationCloudRegionPrivateEndpointConfig`](../../doc/models/organization-cloud-region-private-endpoint-config.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsPrivateEndpointConfigResponse v1OrganizationsPrivateEndpointConfigResponse = new V1OrganizationsPrivateEndpointConfigResponse
{
    Status = 200,
    RequestId = new Guid("000026a6-0000-0000-0000-000000000000"),
    Result = new OrganizationCloudRegionPrivateEndpointConfig
    {
        EndpointServiceId = "endpointServiceId4",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

