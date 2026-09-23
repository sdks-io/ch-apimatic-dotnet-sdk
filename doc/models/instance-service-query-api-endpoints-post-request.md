
# Instance Service Query Api Endpoints Post Request

*This model accepts additional fields of type object.*

## Structure

`InstanceServiceQueryApiEndpointsPostRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Roles` | [`List<Role>`](../../doc/models/role.md) | Optional | The roles |
| `OpenApiKeys` | `List<string>` | Optional | The version of the service query endpoint |
| `AllowedOrigins` | `string` | Optional | The allowed origins as comma separated list of domains |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

InstanceServiceQueryApiEndpointsPostRequest instanceServiceQueryApiEndpointsPostRequest = new InstanceServiceQueryApiEndpointsPostRequest
{
    Roles = new List<Role>
    {
        Role.SqlConsoleReadOnly,
    },
    OpenApiKeys = new List<string>
    {
        "openApiKeys4",
        "openApiKeys5",
        "openApiKeys6",
    },
    AllowedOrigins = "allowedOrigins6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

