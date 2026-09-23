
# Scim User Address

*This model accepts additional fields of type object.*

## Structure

`ScimUserAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Formatted` | `string` | Optional | The full mailing address, formatted for display or use with a mailing label. |
| `StreetAddress` | `string` | Optional | The full street address component. |
| `Locality` | `string` | Optional | The city or locality component. |
| `Region` | `string` | Optional | The state or region component. |
| `PostalCode` | `string` | Optional | The zip code or postal code component. |
| `Country` | `string` | Optional | The country name component. |
| `Type` | `string` | Optional | Type of address (e.g., "work", "home", "other"). |
| `Primary` | `bool?` | Optional | A Boolean value indicating the preferred mailing address. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimUserAddress scimUserAddress = new ScimUserAddress
{
    Formatted = "formatted2",
    StreetAddress = "streetAddress0",
    Locality = "locality0",
    Region = "region6",
    PostalCode = "postalCode8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

