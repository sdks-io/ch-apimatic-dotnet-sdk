
# Byoc Config

*This model accepts additional fields of type object.*

## Structure

`ByocConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique identifier of the BYOC configuration |
| `State` | [`State1?`](../../doc/models/state-1.md) | Optional | State of the infrastructure |
| `AccountName` | `string` | Optional | Name of the account |
| `RegionId` | [`RegionId?`](../../doc/models/region-id.md) | Optional | Region for which the BYOC has been configured and where it is possible to create services |
| `CloudProvider` | [`CloudProvider2?`](../../doc/models/cloud-provider-2.md) | Optional | Cloud provider of the region |
| `DisplayName` | `string` | Optional | Human readable name for infrastructure |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ByocConfig byocConfig = new ByocConfig
{
    Id = "id0",
    State = State1.Infraprovisioning,
    AccountName = "accountName4",
    RegionId = RegionId.Apsoutheast2,
    CloudProvider = CloudProvider2.Azure,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

