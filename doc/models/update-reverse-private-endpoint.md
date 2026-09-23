
# Update Reverse Private Endpoint

*This model accepts additional fields of type object.*

## Structure

`UpdateReversePrivateEndpoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CustomPrivateDnsMappings` | [`List<CustomPrivateDnsMapping>`](../../doc/models/custom-private-dns-mapping.md) | Optional | Optional private DNS names for Reverse Private Endpoint. Can be used as data source destination address. Must be unique across the ClickHouse service.<br>Generally available for Google Private Service Connect (PSC). For AWS PrivateLink (VPC endpoint service and VPC resource), available in Private Preview; contact ClickHouse support to enable it for your service. Not supported for MSK multi-VPC.<br>Supports exact names and leading wildcard names such as *.example.com |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

UpdateReversePrivateEndpoint updateReversePrivateEndpoint = new UpdateReversePrivateEndpoint
{
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
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

