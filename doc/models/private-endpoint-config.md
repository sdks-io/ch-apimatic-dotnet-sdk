
# Private Endpoint Config

*This model accepts additional fields of type object.*

## Structure

`PrivateEndpointConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EndpointServiceId` | `string` | Optional | Unique identifier of the interface endpoint you created in your VPC with the AWS(Service Name), GCP(Target Service) or AZURE (Private Link Service) resource |
| `PrivateDnsHostname` | `string` | Optional | Private DNS Hostname of the VPC you created |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

PrivateEndpointConfig privateEndpointConfig = new PrivateEndpointConfig
{
    EndpointServiceId = "endpointServiceId4",
    PrivateDnsHostname = "privateDnsHostname2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

