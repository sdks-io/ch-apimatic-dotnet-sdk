
# V1 Organizations Services Clickstack Alerts Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickstackAlertsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickStackAlertResponse`](../../doc/models/click-stack-alert-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsServicesClickstackAlertsResponse1 v1OrganizationsServicesClickstackAlertsResponse1 = new V1OrganizationsServicesClickstackAlertsResponse1
{
    Status = 200,
    RequestId = new Guid("00001f80-0000-0000-0000-000000000000"),
    Result = new ClickStackAlertResponse
    {
        DashboardId = "dashboardId6",
        TileId = "tileId2",
        SavedSearchId = "savedSearchId6",
        GroupBy = "groupBy4",
        Threshold = 139.44,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

