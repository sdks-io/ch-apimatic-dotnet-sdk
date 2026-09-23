
# V1 Organizations Services Clickstack Alerts Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickstackAlertsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`List<ClickStackAlertResponse>`](../../doc/models/click-stack-alert-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickstackAlertsResponse v1OrganizationsServicesClickstackAlertsResponse = new V1OrganizationsServicesClickstackAlertsResponse
{
    Status = 200,
    RequestId = new Guid("0000191c-0000-0000-0000-000000000000"),
    Result = new List<ClickStackAlertResponse>
    {
        new ClickStackAlertResponse
        {
            DashboardId = "dashboardId6",
            TileId = "tileId2",
            SavedSearchId = "savedSearchId6",
            GroupBy = "groupBy4",
            Threshold = 139.44,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackAlertResponse
        {
            DashboardId = "dashboardId6",
            TileId = "tileId2",
            SavedSearchId = "savedSearchId6",
            GroupBy = "groupBy4",
            Threshold = 139.44,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackAlertResponse
        {
            DashboardId = "dashboardId6",
            TileId = "tileId2",
            SavedSearchId = "savedSearchId6",
            GroupBy = "groupBy4",
            Threshold = 139.44,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

