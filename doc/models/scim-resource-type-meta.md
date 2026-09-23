
# Scim Resource Type Meta

*This model accepts additional fields of type object.*

## Structure

`ScimResourceTypeMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceType` | `string` | Required | The resource type. |
| `Location` | `string` | Required | The URI of this resource. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimResourceTypeMeta scimResourceTypeMeta = new ScimResourceTypeMeta
{
    ResourceType = "resourceType6",
    Location = "location6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

