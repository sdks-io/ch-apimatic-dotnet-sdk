
# Service Profile

*This model accepts additional fields of type object.*

## Structure

`ServiceProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Profile` | `string` | Optional | Profile name to pass as `profile` when creating a service (e.g. 'v1-standard-byoc-4'). |
| `CpuCores` | `double?` | Optional | Number of vCPUs per replica. |
| `MemoryGi` | `double?` | Optional | Memory per replica in GiB. When creating a BYOC service with this profile, minReplicaMemoryGb and maxReplicaMemoryGb must both equal this value. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServiceProfile serviceProfile = new ServiceProfile
{
    Profile = "profile4",
    CpuCores = 159.22,
    MemoryGi = 61.74,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

