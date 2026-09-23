
# Instance Private Endpoint

*This model accepts additional fields of type object.*

## Structure

`InstancePrivateEndpoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Private endpoint identifier |
| `Description` | `string` | Optional | Description of private endpoint |
| `CloudProvider` | [`CloudProvider1?`](../../doc/models/cloud-provider-1.md) | Optional | Cloud provider in which the private endpoint is lcoated |
| `Region` | [`Region1?`](../../doc/models/region-1.md) | Optional | Region in which the private endpoint is located |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

InstancePrivateEndpoint instancePrivateEndpoint = new InstancePrivateEndpoint
{
    Id = "id8",
    Description = "description8",
    CloudProvider = CloudProvider1.Aws,
    Region = Region1.Eastus2,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

