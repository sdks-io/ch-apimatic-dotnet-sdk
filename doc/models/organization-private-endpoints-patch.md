
# Organization Private Endpoints Patch

*This model accepts additional fields of type object.*

## Structure

`OrganizationPrivateEndpointsPatch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Add` | [`List<OrganizationPatchPrivateEndpoint>`](../../doc/models/organization-patch-private-endpoint.md) | Optional | DEPRECATED. Elements to add. Executed after "remove" part is processed. Please use the `Update Service Basic Details` endpoint with the `privateEndpointIds` field instead to modify the private endpoints. |
| `Remove` | [`List<OrganizationPatchPrivateEndpoint>`](../../doc/models/organization-patch-private-endpoint.md) | Optional | Elements to remove. Executed before "add" part is processed. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

OrganizationPrivateEndpointsPatch organizationPrivateEndpointsPatch = new OrganizationPrivateEndpointsPatch
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
};
```

