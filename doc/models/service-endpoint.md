
# Service Endpoint

*This model accepts additional fields of type object.*

## Structure

`ServiceEndpoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Protocol` | [`Protocol?`](../../doc/models/protocol.md) | Optional | Endpoint protocol: 'https', 'nativesecure', 'mysql'. |
| `Host` | `string` | Optional | Service host name |
| `Port` | `double?` | Optional | Numeric port |
| `Username` | `string` | Optional | Optional username for the endpoint |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServiceEndpoint serviceEndpoint = new ServiceEndpoint
{
    Protocol = Protocol.Mysql,
    Host = "host8",
    Port = 112.8,
    Username = "username0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

