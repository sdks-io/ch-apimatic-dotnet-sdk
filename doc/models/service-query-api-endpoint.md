
# Service Query Api Endpoint

*This model accepts additional fields of type object.*

## Structure

`ServiceQueryApiEndpoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The id of the service query endpoint |
| `OpenApiKeys` | `List<string>` | Optional | List of OpenAPI keys that can access the service query endpoint |
| `Roles` | [`List<Role>`](../../doc/models/role.md) | Optional | List of roles that can access the service query endpoint |
| `AllowedOrigins` | `string` | Optional | The allowed origins as comma separated list of domains |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ServiceQueryApiEndpoint serviceQueryApiEndpoint = new ServiceQueryApiEndpoint
{
    Id = "id0",
    OpenApiKeys = new List<string>
    {
        "openApiKeys6",
        "openApiKeys7",
    },
    Roles = new List<Role>
    {
        Role.SqlConsoleReadOnly,
        Role.SqlConsoleAdmin,
        Role.SqlConsoleReadOnly,
    },
    AllowedOrigins = "allowedOrigins6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

