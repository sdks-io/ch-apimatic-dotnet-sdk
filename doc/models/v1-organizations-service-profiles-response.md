
# V1 Organizations Service Profiles Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServiceProfilesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<ServiceProfile>`](../../doc/models/service-profile.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServiceProfilesResponse v1OrganizationsServiceProfilesResponse = new V1OrganizationsServiceProfilesResponse
{
    Status = 200,
    RequestId = new Guid("00001792-0000-0000-0000-000000000000"),
    Result = new List<ServiceProfile>
    {
        new ServiceProfile
        {
            Profile = "profile4",
            CpuCores = 88.02,
            MemoryGi = 246.54,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

