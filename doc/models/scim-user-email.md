
# Scim User Email

*This model accepts additional fields of type object.*

## Structure

`ScimUserEmail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Required | Email address value. |
| `Type` | `string` | Optional | Type of email (e.g., "work", "home"). |
| `Primary` | `bool?` | Optional | A Boolean value indicating the primary email address. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimUserEmail scimUserEmail = new ScimUserEmail
{
    MValue = "value0",
    Type = "type2",
    Primary = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

