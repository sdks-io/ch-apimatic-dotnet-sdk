
# Scim Schema List Response

*This model accepts additional fields of type object.*

## Structure

`ScimSchemaListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | SCIM schema URIs. |
| `TotalResults` | `int` | Required | Total number of schemas. |
| `ItemsPerPage` | `int` | Required | Number of schemas per page. |
| `StartIndex` | `int` | Required | 1-based start index. |
| `Resources` | [`List<ScimSchema>`](../../doc/models/scim-schema.md) | Required | Array of schema definitions. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScimSchemaListResponse scimSchemaListResponse = new ScimSchemaListResponse
{
    Schemas = new List<string>
    {
        "schemas9",
    },
    TotalResults = 218,
    ItemsPerPage = 104,
    StartIndex = 100,
    Resources = new List<ScimSchema>
    {
        new ScimSchema
        {
            Schemas = new List<string>
            {
                "schemas9",
                "schemas8",
            },
            Id = "id6",
            Name = "name6",
            Description = "description6",
            Attributes = new List<ScimSchemaAttribute>
            {
                new ScimSchemaAttribute
                {
                    Name = "name4",
                    Type = "type4",
                    MultiValued = false,
                    Description = "description4",
                    Required = false,
                    Mutability = "mutability0",
                    Returned = "returned2",
                    SubAttributes = new List<ScimSchemaSubAttribute>
                    {
                        new ScimSchemaSubAttribute
                        {
                            Name = "name4",
                            Type = "type4",
                            MultiValued = false,
                            Description = "description4",
                            Required = false,
                            Mutability = "mutability0",
                            Returned = "returned2",
                            CaseExact = false,
                            Uniqueness = "uniqueness0",
                            ReferenceTypes = new List<string>
                            {
                                "referenceTypes0",
                                "referenceTypes1",
                            },
                            CanonicalValues = new List<string>
                            {
                                "canonicalValues4",
                            },
                            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                        },
                    },
                    CaseExact = false,
                    Uniqueness = "uniqueness0",
                    ReferenceTypes = new List<string>
                    {
                        "referenceTypes0",
                        "referenceTypes1",
                    },
                    CanonicalValues = new List<string>
                    {
                        "canonicalValues4",
                    },
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            Meta = new ScimSchemaMeta
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

