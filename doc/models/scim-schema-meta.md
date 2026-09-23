
# Scim Schema Meta

*This model accepts additional fields of type object.*

## Structure

`ScimSchemaMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceType` | `string` | Required | The resource type. |
| `Location` | `string` | Required | The URI of this schema. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ScimSchemaMeta scimSchemaMeta = new ScimSchemaMeta
{
    ResourceType = "resourceType4",
    Location = "location4",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

