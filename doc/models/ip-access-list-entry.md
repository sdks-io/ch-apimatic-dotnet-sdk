
# Ip Access List Entry

*This model accepts additional fields of type object.*

## Structure

`IpAccessListEntry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Source` | `string` | Optional | IP or CIDR |
| `Description` | `string` | Optional | Optional description of IPv4 address or IPv4 CIDR to allow access from |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

IpAccessListEntry ipAccessListEntry = new IpAccessListEntry
{
    Source = "source6",
    Description = "description0",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

