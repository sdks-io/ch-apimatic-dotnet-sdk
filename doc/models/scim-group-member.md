
# Scim Group Member

*This model accepts additional fields of type object.*

## Structure

`ScimGroupMember`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Required | The identifier of the member (user ID). |
| `Display` | `string` | Optional | A human-readable name for the member. |
| `Type` | `string` | Optional | Indicates the type of resource, typically "User". |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimGroupMember scimGroupMember = new ScimGroupMember
{
    MValue = "value0",
    Display = "display0",
    Type = "type2",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

