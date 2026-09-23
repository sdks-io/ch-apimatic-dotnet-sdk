
# Scim Boolean Feature

*This model accepts additional fields of type object.*

## Structure

`ScimBooleanFeature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Supported` | `bool` | Required | Whether the feature is supported. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimBooleanFeature scimBooleanFeature = new ScimBooleanFeature
{
    Supported = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

