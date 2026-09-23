
# Scim Schema Sub Attribute

A sub-attribute of a complex SCIM schema attribute. Per RFC 7643, sub-attributes cannot themselves have sub-attributes.

*This model accepts additional fields of type object.*

## Structure

`ScimSchemaSubAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The attribute name. |
| `Type` | `string` | Required | The attribute type (e.g., "string", "boolean", "complex"). |
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

ScimSchemaSubAttribute scimSchemaSubAttribute = new ScimSchemaSubAttribute
{
    Name = "name8",
    Type = "type2",
    MultiValued = false,
    Description = "description8",
    Required = false,
    Mutability = "mutability4",
    Returned = "returned6",
    CaseExact = false,
    Uniqueness = "uniqueness4",
    ReferenceTypes = new List<string>
    {
        "referenceTypes6",
    },
    CanonicalValues = new List<string>
    {
        "canonicalValues2",
        "canonicalValues1",
        "canonicalValues0",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

