
# V1 Organizations Services Clickpipes Reverse Private Endpoints Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<ReversePrivateEndpoint>`](../../doc/models/reverse-private-endpoint.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse v1OrganizationsServicesClickpipesReversePrivateEndpointsResponse = new V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse
{
    Status = 200,
    RequestId = new Guid("00001680-0000-0000-0000-000000000000"),
    Result = new List<ReversePrivateEndpoint>
    {
        new ReversePrivateEndpoint
        {
            Description = "description6",
            Type = Type1.MskMultiVpc,
            VpcEndpointServiceName = "vpcEndpointServiceName6",
            VpcResourceConfigurationId = "vpcResourceConfigurationId8",
            VpcResourceShareArn = "vpcResourceShareArn6",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ReversePrivateEndpoint
        {
            Description = "description6",
            Type = Type1.MskMultiVpc,
            VpcEndpointServiceName = "vpcEndpointServiceName6",
            VpcResourceConfigurationId = "vpcResourceConfigurationId8",
            VpcResourceShareArn = "vpcResourceShareArn6",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

