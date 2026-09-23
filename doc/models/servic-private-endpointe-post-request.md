
# Servic Private Endpointe Post Request

*This model accepts additional fields of type object.*

## Structure

`ServicPrivateEndpointePostRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Private endpoint identifier |
| `Description` | `string` | Optional | Description of private endpoint |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServicPrivateEndpointePostRequest servicPrivateEndpointePostRequest = new ServicPrivateEndpointePostRequest
{
    Id = "id0",
    Description = "description0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

