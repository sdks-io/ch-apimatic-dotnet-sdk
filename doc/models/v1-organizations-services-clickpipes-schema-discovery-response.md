
# V1 Organizations Services Clickpipes Schema Discovery Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickpipesSchemaDiscoveryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickPipeSchemaDiscoveryResponse`](../../doc/models/click-pipe-schema-discovery-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickpipesSchemaDiscoveryResponse v1OrganizationsServicesClickpipesSchemaDiscoveryResponse = new V1OrganizationsServicesClickpipesSchemaDiscoveryResponse
{
    Status = 200,
    RequestId = new Guid("0000116a-0000-0000-0000-000000000000"),
    Result = new ClickPipeSchemaDiscoveryResponse
    {
        Fields = new List<ClickPipeSchemaDiscoveryField>
        {
            new ClickPipeSchemaDiscoveryField
            {
                Name = "name8",
                Type = "type2",
                Optional = false,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        Meta = new Dictionary<string, string>
        {
            ["key0"] = "meta5",
            ["key1"] = "meta4",
            ["key2"] = "meta3",
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

