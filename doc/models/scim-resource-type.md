
# Scim Resource Type

*This model accepts additional fields of type object.*

## Structure

`ScimResourceType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | SCIM schema URIs. |
| `Id` | `string` | Required | The resource type ID. |
| `Name` | `string` | Required | The resource type name. |
| `Endpoint` | `string` | Required | The endpoint path for this resource type. |
| `Description` | `string` | Required | A description of the resource type. |
| `Schema` | `string` | Required | The primary schema URI for this resource type. |
| `SchemaExtensions` | [`List<ScimSchemaExtension>`](../../doc/models/scim-schema-extension.md) | Required | Optional schema extensions for this resource type. |
| `Meta` | [`ScimResourceTypeMeta`](../../doc/models/scim-resource-type-meta.md) | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScimResourceType scimResourceType = new ScimResourceType
{
    Schemas = new List<string>
    {
        "schemas5",
        "schemas4",
    },
    Id = "id6",
    Name = "name6",
    Endpoint = "endpoint4",
    Description = "description6",
    Schema = "schema8",
    SchemaExtensions = new List<ScimSchemaExtension>
    {
        new ScimSchemaExtension
        {
            Schema = "schema0",
            Required = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Meta = new ScimResourceTypeMeta
    {
        ResourceType = "resourceType6",
        Location = "location6",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

