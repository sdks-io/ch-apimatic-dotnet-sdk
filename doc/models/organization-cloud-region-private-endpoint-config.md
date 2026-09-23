
# Organization Cloud Region Private Endpoint Config

*This model accepts additional fields of type object.*

## Structure

`OrganizationCloudRegionPrivateEndpointConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EndpointServiceId` | `string` | Optional | Unique identifier of the interface endpoint you created in your VPC with the AWS(Service Name) or GCP(Target Service) resource |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

OrganizationCloudRegionPrivateEndpointConfig organizationCloudRegionPrivateEndpointConfig = new OrganizationCloudRegionPrivateEndpointConfig
{
    EndpointServiceId = "endpointServiceId6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

