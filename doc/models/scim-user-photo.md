
# Scim User Photo

*This model accepts additional fields of type object.*

## Structure

`ScimUserPhoto`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Optional | URL of a photo of the User. |
| `Type` | `string` | Optional | Type of photo (e.g., "photo", "thumbnail"). |
| `Primary` | `bool?` | Optional | A Boolean value indicating the preferred photo. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimUserPhoto scimUserPhoto = new ScimUserPhoto
{
    MValue = "value4",
    Type = "type8",
    Primary = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

