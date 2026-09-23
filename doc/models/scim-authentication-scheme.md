
# Scim Authentication Scheme

*This model accepts additional fields of type object.*

## Structure

`ScimAuthenticationScheme`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | The authentication scheme type (e.g., "httpbasic", "oauthbearertoken"). |
| `Name` | `string` | Required | The common authentication scheme name. |
| `Description` | `string` | Required | A description of the authentication scheme. |
| `SpecUri` | `string` | Optional | An HTTP-addressable URL pointing to the scheme specification. |
| `Primary` | `bool?` | Optional | A Boolean value indicating the primary authentication scheme. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimAuthenticationScheme scimAuthenticationScheme = new ScimAuthenticationScheme
{
    Type = "type2",
    Name = "name8",
    Description = "description8",
    SpecUri = "specUri2",
    Primary = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

