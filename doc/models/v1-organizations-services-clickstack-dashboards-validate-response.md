
# V1 Organizations Services Clickstack Dashboards Validate Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickstackDashboardsValidateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickStackValidateDashboardResponse`](../../doc/models/click-stack-validate-dashboard-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickstackDashboardsValidateResponse v1OrganizationsServicesClickstackDashboardsValidateResponse = new V1OrganizationsServicesClickstackDashboardsValidateResponse
{
    Status = 200,
    RequestId = new Guid("000003b2-0000-0000-0000-000000000000"),
    Result = new ClickStackValidateDashboardResponse
    {
        Valid = false,
        Errors = new List<ClickStackValidateDashboardError>
        {
            new ClickStackValidateDashboardError
            {
                Path = "path4",
                Message = "message0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            new ClickStackValidateDashboardError
            {
                Path = "path4",
                Message = "message0",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        Normalized = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

