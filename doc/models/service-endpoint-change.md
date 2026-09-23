
# Service Endpoint Change

*This model accepts additional fields of type object.*

## Structure

`ServiceEndpointChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Protocol` | [`Protocol1?`](../../doc/models/protocol-1.md) | Optional | Endpoint protocol |
| `Enabled` | `bool?` | Optional | Enable or disable the endpoint |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServiceEndpointChange serviceEndpointChange = new ServiceEndpointChange
{
    Protocol = Protocol1.Mysql,
    Enabled = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

