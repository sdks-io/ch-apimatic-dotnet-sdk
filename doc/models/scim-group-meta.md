
# Scim Group Meta

*This model accepts additional fields of type object.*

## Structure

`ScimGroupMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceType` | `string` | Required | Always "Group". |
| `Created` | `DateTime` | Required | DateTime the Group was created. |
| `LastModified` | `DateTime` | Required | DateTime the Group was last modified. |
| `Location` | `string` | Optional | The URI of this Group resource. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ScimGroupMeta scimGroupMeta = new ScimGroupMeta
{
    ResourceType = "resourceType6",
    Created = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    LastModified = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Location = "location6",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

