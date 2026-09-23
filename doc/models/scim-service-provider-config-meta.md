
# Scim Service Provider Config Meta

*This model accepts additional fields of type object.*

## Structure

`ScimServiceProviderConfigMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceType` | `string` | Required | The resource type of this resource. |
| `Location` | `string` | Required | The URI of this resource. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimServiceProviderConfigMeta scimServiceProviderConfigMeta = new ScimServiceProviderConfigMeta
{
    ResourceType = "resourceType8",
    Location = "location8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

