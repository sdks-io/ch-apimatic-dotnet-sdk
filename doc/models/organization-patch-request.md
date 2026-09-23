
# Organization Patch Request

*This model accepts additional fields of type object.*

## Structure

`OrganizationPatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the organization. |
| `PrivateEndpoints` | [`OrganizationPrivateEndpointsPatch`](../../doc/models/organization-private-endpoints-patch.md) | Optional | - |
| `EnableCoreDumps` | `bool?` | Optional | Whether crash reports (core dumps) collection is enabled for services in the organization. When disabled at the organization level, individual services cannot enable crash reports. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

OrganizationPatchRequest organizationPatchRequest = new OrganizationPatchRequest
{
    Name = "name2",
    PrivateEndpoints = new OrganizationPrivateEndpointsPatch
    {
        MAdd = new List<OrganizationPatchPrivateEndpoint>
        {
            new OrganizationPatchPrivateEndpoint
            {
                Id = "id6",
                Description = "description4",
                CloudProvider = CloudProvider1.Azure,
                Region = Region1.Apsoutheast2,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new OrganizationPatchPrivateEndpoint
            {
                Id = "id6",
                Description = "description4",
                CloudProvider = CloudProvider1.Azure,
                Region = Region1.Apsoutheast2,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new OrganizationPatchPrivateEndpoint
            {
                Id = "id6",
                Description = "description4",
                CloudProvider = CloudProvider1.Azure,
                Region = Region1.Apsoutheast2,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        MRemove = new List<OrganizationPatchPrivateEndpoint>
        {
            new OrganizationPatchPrivateEndpoint
            {
                Id = "id0",
                Description = "description0",
                CloudProvider = CloudProvider1.Azure,
                Region = Region1.Apsouth1,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    EnableCoreDumps = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

