
# Scim Resource Type List Response

*This model accepts additional fields of type object.*

## Structure

`ScimResourceTypeListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | SCIM schema URIs. |
| `TotalResults` | `int` | Required | Total number of resource types. |
| `ItemsPerPage` | `int` | Required | Number of resources per page. |
| `StartIndex` | `int` | Required | 1-based start index. |
| `Resources` | [`List<ScimResourceType>`](../../doc/models/scim-resource-type.md) | Required | Array of resource type definitions. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScimResourceTypeListResponse scimResourceTypeListResponse = new ScimResourceTypeListResponse
{
    Schemas = new List<string>
    {
        "schemas7",
    },
    TotalResults = 58,
    ItemsPerPage = 56,
    StartIndex = 60,
    Resources = new List<ScimResourceType>
    {
        new ScimResourceType
        {
            Schemas = new List<string>
            {
                "schemas9",
                "schemas8",
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
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

