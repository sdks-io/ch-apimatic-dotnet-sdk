
# Scim User Name

*This model accepts additional fields of type object.*

## Structure

`ScimUserName`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Formatted` | `string` | Optional | The full name, including all middle names, titles, and suffixes. |
| `FamilyName` | `string` | Optional | The family name of the User. |
| `GivenName` | `string` | Optional | The given name of the User. |
| `MiddleName` | `string` | Optional | The middle name(s) of the User. |
| `HonorificPrefix` | `string` | Optional | The honorific prefix(es) of the User, or title in some cultures. |
| `HonorificSuffix` | `string` | Optional | The honorific suffix(es) of the User. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimUserName scimUserName = new ScimUserName
{
    Formatted = "formatted6",
    FamilyName = "familyName2",
    GivenName = "givenName8",
    MiddleName = "middleName2",
    HonorificPrefix = "honorificPrefix8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

