
# Scim User Meta

*This model accepts additional fields of type object.*

## Structure

`ScimUserMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceType` | `string` | Required | The name of the resource type of the resource. |
| `Created` | `DateTime` | Required | The DateTime the Resource was added to the Service Provider. |
| `LastModified` | `DateTime` | Required | The most recent DateTime the details of this Resource were updated. |
| `Location` | `string` | Optional | The URI of the resource being returned. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ScimUserMeta scimUserMeta = new ScimUserMeta
{
    ResourceType = "resourceType8",
    Created = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    LastModified = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Location = "location8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

