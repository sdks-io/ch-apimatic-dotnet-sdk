
# Scim Service Provider Config Patch

*This model accepts additional fields of type object.*

## Structure

`ScimServiceProviderConfigPatch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Supported` | `bool` | Required | Whether PATCH is supported. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimServiceProviderConfigPatch scimServiceProviderConfigPatch = new ScimServiceProviderConfigPatch
{
    Supported = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

