
# Scim Service Provider Config Bulk

*This model accepts additional fields of type object.*

## Structure

`ScimServiceProviderConfigBulk`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Supported` | `bool` | Required | Whether bulk operations are supported. |
| `MaxOperations` | `int` | Required | Maximum number of bulk operations per request. |
| `MaxPayloadSize` | `int` | Required | Maximum payload size for bulk requests in bytes. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimServiceProviderConfigBulk scimServiceProviderConfigBulk = new ScimServiceProviderConfigBulk
{
    Supported = false,
    MaxOperations = 90,
    MaxPayloadSize = 46,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

