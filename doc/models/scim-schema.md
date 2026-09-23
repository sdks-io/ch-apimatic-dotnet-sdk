
# Scim Schema

*This model accepts additional fields of type object.*

## Structure

`ScimSchema`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Schemas` | `List<string>` | Required | SCIM schema URIs. |
| `Id` | `string` | Required | The unique URI of the schema. |
| `Name` | `string` | Required | The schema name. |
| `Description` | `string` | Required | A description of the schema. |
| `Attributes` | [`List<ScimSchemaAttribute>`](../../doc/models/scim-schema-attribute.md) | Required | Service provider attributes comprising the schema. |
| `Meta` | [`ScimSchemaMeta`](../../doc/models/scim-schema-meta.md) | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScimSchema scimSchema = new ScimSchema
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
};
```

