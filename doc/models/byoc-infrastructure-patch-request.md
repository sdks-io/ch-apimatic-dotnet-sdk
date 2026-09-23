
# Byoc Infrastructure Patch Request

*This model accepts additional fields of type object.*

## Structure

`ByocInfrastructurePatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DisplayName` | `string` | Optional | Human readable name for infrastructure object |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ByocInfrastructurePatchRequest byocInfrastructurePatchRequest = new ByocInfrastructurePatchRequest
{
    DisplayName = "displayName0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

