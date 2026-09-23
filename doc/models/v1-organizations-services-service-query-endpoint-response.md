
# V1 Organizations Services Service Query Endpoint Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesServiceQueryEndpointResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ServiceQueryApiEndpoint`](../../doc/models/service-query-api-endpoint.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesServiceQueryEndpointResponse v1OrganizationsServicesServiceQueryEndpointResponse = new V1OrganizationsServicesServiceQueryEndpointResponse
{
    Status = 200,
    RequestId = new Guid("00000b9e-0000-0000-0000-000000000000"),
    Result = new ServiceQueryApiEndpoint
    {
        Id = "id6",
        OpenApiKeys = new List<string>
        {
            "openApiKeys2",
        },
        Roles = new List<Role>
        {
            Role.SqlConsoleReadOnly,
            Role.SqlConsoleAdmin,
            Role.SqlConsoleReadOnly,
        },
        AllowedOrigins = "allowedOrigins2",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

