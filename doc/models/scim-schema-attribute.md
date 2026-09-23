
# Scim Schema Attribute

*This model accepts additional fields of type object.*

## Structure

`ScimSchemaAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The attribute name. |
| `Type` | `string` | Required | The attribute type (e.g., "string", "boolean", "complex"). |
| `SubAttributes` | [`List<ScimSchemaSubAttribute>`](../../doc/models/scim-schema-sub-attribute.md) | Optional | Sub-attributes for complex attributes. |
| `MultiValued` | `bool` | Required | Whether the attribute can have multiple values. |
| `Description` | `string` | Required | A human-readable description of the attribute. |
| `Required` | `bool` | Required | Whether the attribute is required. |
| `CaseExact` | `bool?` | Optional | Whether the string attribute is case sensitive. |
| `Mutability` | `string` | Required | The circumstances under which the value of the attribute can be (re)defined. |
| `Returned` | `string` | Required | The circumstances under which an attribute and associated values are returned. |
| `Uniqueness` | `string` | Optional | How the service provider enforces uniqueness of attribute values. |
| `ReferenceTypes` | `List<string>` | Optional | A multi-valued array of JSON strings. |
| `CanonicalValues` | `List<string>` | Optional | A collection of suggested canonical values that MAY be used. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ScimSchemaAttribute scimSchemaAttribute = new ScimSchemaAttribute
{
    Name = "name2",
    Type = "type8",
    MultiValued = false,
    Description = "description2",
    Required = false,
    Mutability = "mutability8",
    Returned = "returned0",
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
    Uniqueness = "uniqueness8",
    ReferenceTypes = new List<string>
    {
        "referenceTypes2",
    },
    CanonicalValues = new List<string>
    {
        "canonicalValues8",
        "canonicalValues7",
        "canonicalValues6",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

