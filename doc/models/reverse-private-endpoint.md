
# Reverse Private Endpoint

*This model accepts additional fields of type object.*

## Structure

`ReversePrivateEndpoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | Reverse private endpoint description. Maximum length is 255 characters. |
| `Type` | [`Type1?`](../../doc/models/type-1.md) | Optional | Reverse private endpoint type. |
| `VpcEndpointServiceName` | `string` | Optional | VPC endpoint service name. |
| `VpcResourceConfigurationId` | `string` | Optional | VPC resource configuration ID. Required for VPC_RESOURCE type. |
| `VpcResourceShareArn` | `string` | Optional | VPC resource share ARN. Required for VPC_RESOURCE type. |
| `MskClusterArn` | `string` | Optional | MSK cluster ARN. Required for MSK_MULTI_VPC type. |
| `MskAuthentication` | [`MskAuthentication?`](../../doc/models/msk-authentication.md) | Optional | MSK cluster authentication type. Required for MSK_MULTI_VPC type. |
| `GcpServiceAttachment` | `string` | Optional | Private Preview. GCP PSC service attachment URI. Required for GCP_PSC_SERVICE_ATTACHMENT type. Format: projects/{project}/regions/{region}/serviceAttachments/{name}. |
| `CustomPrivateDnsMappings` | [`List<CustomPrivateDnsMapping>`](../../doc/models/custom-private-dns-mapping.md) | Optional | Optional private DNS names for Reverse Private Endpoint. Can be used as data source destination address. Must be unique across the ClickHouse service.<br>Generally available for Google Private Service Connect (PSC). For AWS PrivateLink (VPC endpoint service and VPC resource), available in Private Preview; contact ClickHouse support to enable it for your service. Not supported for MSK multi-VPC.<br>Supports exact names and leading wildcard names such as *.example.com |
| `Id` | `Guid?` | Optional | Reverse private endpoint ID. |
| `ServiceId` | `Guid?` | Optional | ClickHouse service ID reverse private endpoint is associated with. |
| `EndpointId` | `string` | Optional | Reverse private endpoint endpoint ID. |
| `DnsNames` | `List<string>` | Optional | Reverse private endpoint internal DNS names. |
| `PrivateDnsNames` | `List<string>` | Optional | Reverse private endpoint private DNS names. |
| `Status` | [`Status?`](../../doc/models/status.md) | Optional | Reverse private endpoint status. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ReversePrivateEndpoint reversePrivateEndpoint = new ReversePrivateEndpoint
{
    Description = "My reverse private endpoint",
    Type = Type1.VpcEndpointService,
    VpcEndpointServiceName = "com.amazonaws.vpce.us-east-1.vpce-svc-12345678901234567",
    VpcResourceConfigurationId = "rcfg-12345678901234567",
    VpcResourceShareArn = "arn:aws:ram:us-east-1:123456789012:resource-share/share-12345678901234567",
    MskClusterArn = "arn:aws:kafka:us-east-1:123456789012:cluster/my-cluster",
    MskAuthentication = MskAuthentication.SaslIam,
    GcpServiceAttachment = "projects/my-project/regions/us-central1/serviceAttachments/my-service",
    CustomPrivateDnsMappings = new List<CustomPrivateDnsMapping>
    {
        new CustomPrivateDnsMapping
        {
            PrivateDnsName = "my-service.example.com",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new CustomPrivateDnsMapping
        {
            PrivateDnsName = "*.example.com",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Id = new Guid("12345678-1234-1234-1234-123456789012"),
    ServiceId = new Guid("12345678-1234-1234-1234-123456789012"),
    EndpointId = "vpce-12345678901234567",
    DnsNames = new List<string>
    {
        "vpce-12345678901234567-abcdefg.execute-api.us-east-1.vpce.amazonaws.com",
    },
    PrivateDnsNames = new List<string>
    {
        "vpce-12345678901234567-abcdefg.execute-api.us-east-1.vpce.amazonaws.com",
    },
    Status = Status.Ready,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

