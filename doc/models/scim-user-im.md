
# Scim User Im

*This model accepts additional fields of type object.*

## Structure

`ScimUserIm`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Optional | Instant messaging address. |
| `Type` | `string` | Optional | Type of IM address (e.g., "aim", "gtalk", "icq", "xmpp", "msn", "skype", "qq"). |
| `Primary` | `bool?` | Optional | A Boolean value indicating the preferred IM address. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimUserIm scimUserIm = new ScimUserIm
{
    MValue = "value8",
    Type = "type6",
    Primary = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

