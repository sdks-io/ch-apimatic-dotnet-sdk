
# Scim Schema Extension

*This model accepts additional fields of type object.*

## Structure

`ScimSchemaExtension`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schema` | `string` | Required | The URI of a schema extension. |
| `Required` | `bool` | Required | Whether the schema extension is required. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimSchemaExtension scimSchemaExtension = new ScimSchemaExtension
{
    Schema = "schema4",
    Required = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

