
# Scim User Phone Number

*This model accepts additional fields of type object.*

## Structure

`ScimUserPhoneNumber`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Optional | Phone number value. |
| `Type` | `string` | Optional | Type of phone number (e.g., "work", "home", "mobile"). |
| `Primary` | `bool?` | Optional | A Boolean value indicating the preferred phone number. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimUserPhoneNumber scimUserPhoneNumber = new ScimUserPhoneNumber
{
    MValue = "value2",
    Type = "type0",
    Primary = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

