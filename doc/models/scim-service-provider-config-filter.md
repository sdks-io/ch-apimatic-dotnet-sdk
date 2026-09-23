
# Scim Service Provider Config Filter

*This model accepts additional fields of type object.*

## Structure

`ScimServiceProviderConfigFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Supported` | `bool` | Required | Whether filter is supported. |
| `MaxResults` | `int` | Required | Maximum number of results per filter query. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimServiceProviderConfigFilter scimServiceProviderConfigFilter = new ScimServiceProviderConfigFilter
{
    Supported = false,
    MaxResults = 102,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

