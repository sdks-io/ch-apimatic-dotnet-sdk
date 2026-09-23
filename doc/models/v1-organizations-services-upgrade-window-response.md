
# V1 Organizations Services Upgrade Window Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesUpgradeWindowResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`UpgradeWindow`](../../doc/models/upgrade-window.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesUpgradeWindowResponse v1OrganizationsServicesUpgradeWindowResponse = new V1OrganizationsServicesUpgradeWindowResponse
{
    Status = 200,
    RequestId = new Guid("000012d6-0000-0000-0000-000000000000"),
    Result = new UpgradeWindow
    {
        Weekday = 6,
        StartHourUtc = StartHourUtc.Hour0,
        Duration = 8,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

