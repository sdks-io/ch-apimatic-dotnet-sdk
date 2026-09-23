
# Byoc Infrastructure Post Request

*This model accepts additional fields of type object.*

## Structure

`ByocInfrastructurePostRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RegionId` | [`RegionId1?`](../../doc/models/region-id-1.md) | Optional | Region in which the BYOC infrastructure will be located |
| `AccountId` | `string` | Optional | Cloud account ID the BYOC infrastructure is configured for |
| `AvailabilityZoneSuffixes` | [`List<AvailabilityZoneSuffix>`](../../doc/models/availability-zone-suffix.md) | Optional | List of availability zone suffixes |
| `VpcCidrRange` | `string` | Optional | CIDR range for VPC |
| `DisplayName` | `string` | Optional | Human readable name for infrastructure |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ByocInfrastructurePostRequest byocInfrastructurePostRequest = new ByocInfrastructurePostRequest
{
    RegionId = RegionId1.Useast1,
    AccountId = "accountId4",
    AvailabilityZoneSuffixes = new List<AvailabilityZoneSuffix>
    {
        AvailabilityZoneSuffix.E,
    },
    VpcCidrRange = "vpcCidrRange4",
    DisplayName = "displayName8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

