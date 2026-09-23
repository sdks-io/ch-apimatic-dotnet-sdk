# Click Stack

```csharp
ClickStackApi clickStackApi = client.ClickStackApi;
```

## Class Name

`ClickStackApi`

## Methods

* [Click Stack List Dashboards](../../doc/controllers/click-stack.md#click-stack-list-dashboards)
* [Click Stack Create Dashboard](../../doc/controllers/click-stack.md#click-stack-create-dashboard)
* [Click Stack Get Dashboard](../../doc/controllers/click-stack.md#click-stack-get-dashboard)
* [Click Stack Update Dashboard](../../doc/controllers/click-stack.md#click-stack-update-dashboard)
* [Click Stack Delete Dashboard](../../doc/controllers/click-stack.md#click-stack-delete-dashboard)
* [Click Stack Validate Dashboard](../../doc/controllers/click-stack.md#click-stack-validate-dashboard)
* [Click Stack List Alerts](../../doc/controllers/click-stack.md#click-stack-list-alerts)
* [Click Stack Create Alert](../../doc/controllers/click-stack.md#click-stack-create-alert)
* [Click Stack List Sources](../../doc/controllers/click-stack.md#click-stack-list-sources)
* [Click Stack Create Source](../../doc/controllers/click-stack.md#click-stack-create-source)
* [Click Stack Get Source](../../doc/controllers/click-stack.md#click-stack-get-source)
* [Click Stack Update Source](../../doc/controllers/click-stack.md#click-stack-update-source)
* [Click Stack Delete Source](../../doc/controllers/click-stack.md#click-stack-delete-source)
* [Click Stack Get Alert](../../doc/controllers/click-stack.md#click-stack-get-alert)
* [Click Stack Update Alert](../../doc/controllers/click-stack.md#click-stack-update-alert)
* [Click Stack Delete Alert](../../doc/controllers/click-stack.md#click-stack-delete-alert)
* [Click Stack List Webhooks](../../doc/controllers/click-stack.md#click-stack-list-webhooks)
* [Click Stack Create Webhook](../../doc/controllers/click-stack.md#click-stack-create-webhook)
* [Click Stack Update Webhook](../../doc/controllers/click-stack.md#click-stack-update-webhook)
* [Click Stack Delete Webhook](../../doc/controllers/click-stack.md#click-stack-delete-webhook)
* [Click Stack List Roles](../../doc/controllers/click-stack.md#click-stack-list-roles)
* [Click Stack Create Role](../../doc/controllers/click-stack.md#click-stack-create-role)
* [Click Stack Get Role](../../doc/controllers/click-stack.md#click-stack-get-role)
* [Click Stack Update Role](../../doc/controllers/click-stack.md#click-stack-update-role)
* [Click Stack Delete Role](../../doc/controllers/click-stack.md#click-stack-delete-role)
* [Click Stack List Saved Searches](../../doc/controllers/click-stack.md#click-stack-list-saved-searches)
* [Click Stack Create Saved Search](../../doc/controllers/click-stack.md#click-stack-create-saved-search)
* [Click Stack Get Saved Search](../../doc/controllers/click-stack.md#click-stack-get-saved-search)
* [Click Stack Update Saved Search](../../doc/controllers/click-stack.md#click-stack-update-saved-search)
* [Click Stack Delete Saved Search](../../doc/controllers/click-stack.md#click-stack-delete-saved-search)


# Click Stack List Dashboards

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a list of all dashboards for the authenticated team

```csharp
ClickStackListDashboardsAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackDashboardsResponse](../../doc/models/v1-organizations-services-clickstack-dashboards-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickstackDashboardsResponse> result = await clickStackApi.ClickStackListDashboardsAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackDashboards400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboards400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackDashboards500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboards500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackDashboards400ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackDashboards500ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-500-error-exception.md) |


# Click Stack Create Dashboard

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new dashboard

```csharp
ClickStackCreateDashboardAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ClickStackCreateDashboardRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `body` | [`ClickStackCreateDashboardRequest`](../../doc/models/click-stack-create-dashboard-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackDashboardsResponse1](../../doc/models/v1-organizations-services-clickstack-dashboards-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ClickStackCreateDashboardRequest body = new ClickStackCreateDashboardRequest
{
    Name = "New Dashboard",
    Tiles = new List<ClickStackTileInput>
    {
        new ClickStackTileInput
        {
            Name = "Error Rate",
            X = 0,
            Y = 0,
            W = 6,
            H = 3,
            ContainerId = "service-health",
            TabId = "errors",
            Id = "65f5e4a3b9e77c001a901234",
            AsRatio = false,
        },
    },
    Tags = new List<string>
    {
        "development",
    },
    SavedQuery = "service.name = 'api'",
    SavedQueryLanguage = SavedQueryLanguage.Sql,
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackDashboardsResponse1> result = await clickStackApi.ClickStackCreateDashboardAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackDashboards400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboards400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackDashboards500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboards500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackDashboards400ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackDashboards500ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-500-error-exception.md) |


# Click Stack Get Dashboard

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a specific dashboard by ID

```csharp
ClickStackGetDashboardAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackDashboardId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackDashboardId` | `string` | Template, Required | ClickStack Dashboard ID |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse](../../doc/models/v1-organizations-services-clickstack-dashboards-click-stack-dashboard-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackDashboardId = "clickStackDashboardId6";
try
{
    ApiResponse<V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse> result = await clickStackApi.ClickStackGetDashboardAsync(
        organizationId,
        serviceId,
        clickStackDashboardId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-click-stack-dashboard-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-click-stack-dashboard-id-500-error-exception.md) |


# Click Stack Update Dashboard

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Updates an existing dashboard.  **Concurrency:** This endpoint does not support optimistic concurrency control. Concurrent PUT requests for the same dashboard may silently overwrite each other, which can leave orphan tile-to-container references on layout-shape edits. Clients should serialize edits to a given dashboard.

```csharp
ClickStackUpdateDashboardAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackDashboardId,
    Models.ClickStackUpdateDashboardRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackDashboardId` | `string` | Template, Required | ClickStack Dashboard ID |
| `body` | [`ClickStackUpdateDashboardRequest`](../../doc/models/click-stack-update-dashboard-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse](../../doc/models/v1-organizations-services-clickstack-dashboards-click-stack-dashboard-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackDashboardId = "clickStackDashboardId6";
ClickStackUpdateDashboardRequest body = new ClickStackUpdateDashboardRequest
{
    Name = "Updated Dashboard Name",
    Tiles = new List<ClickStackTileInput>
    {
        new ClickStackTileInput
        {
            Name = "Error Rate",
            X = 0,
            Y = 0,
            W = 6,
            H = 3,
            ContainerId = "service-health",
            TabId = "errors",
            Id = "65f5e4a3b9e77c001a901234",
            AsRatio = false,
        },
    },
    Tags = new List<string>
    {
        "production",
        "updated",
    },
    SavedQuery = "service.name = 'api'",
    SavedQueryLanguage = SavedQueryLanguage.Sql,
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse> result = await clickStackApi.ClickStackUpdateDashboardAsync(
        organizationId,
        serviceId,
        clickStackDashboardId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-click-stack-dashboard-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-click-stack-dashboard-id-500-error-exception.md) |


# Click Stack Delete Dashboard

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes a dashboard

```csharp
ClickStackDeleteDashboardAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackDashboardId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackDashboardId` | `string` | Template, Required | ClickStack Dashboard ID |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2](../../doc/models/v1-organizations-services-clickstack-dashboards-click-stack-dashboard-id-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackDashboardId = "clickStackDashboardId6";
try
{
    ApiResponse<V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2> result = await clickStackApi.ClickStackDeleteDashboardAsync(
        organizationId,
        serviceId,
        clickStackDashboardId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-click-stack-dashboard-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-click-stack-dashboard-id-500-error-exception.md) |


# Click Stack Validate Dashboard

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Validates a dashboard body against the same schema and tile rules used by POST /api/v2/dashboards. The dashboard is **never persisted**. Use this endpoint at plan time (e.g. from a Terraform provider) to check that a dashboard configuration is valid before applying it.

```csharp
ClickStackValidateDashboardAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ClickStackCreateDashboardRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `body` | [`ClickStackCreateDashboardRequest`](../../doc/models/click-stack-create-dashboard-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackDashboardsValidateResponse](../../doc/models/v1-organizations-services-clickstack-dashboards-validate-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ClickStackCreateDashboardRequest body = new ClickStackCreateDashboardRequest
{
    Name = "New Dashboard",
    Tiles = new List<ClickStackTileInput>
    {
        new ClickStackTileInput
        {
            Name = "Error Rate",
            X = 0,
            Y = 0,
            W = 6,
            H = 3,
            ContainerId = "service-health",
            TabId = "errors",
            Id = "65f5e4a3b9e77c001a901234",
            AsRatio = false,
        },
    },
    Tags = new List<string>
    {
        "development",
    },
    SavedQuery = "service.name = 'api'",
    SavedQueryLanguage = SavedQueryLanguage.Sql,
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackDashboardsValidateResponse> result = await clickStackApi.ClickStackValidateDashboardAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackDashboardsValidate400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboardsValidate400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackDashboardsValidate500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackDashboardsValidate500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackDashboardsValidate400ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-validate-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackDashboardsValidate500ErrorException`](../../doc/models/v1-organizations-services-clickstack-dashboards-validate-500-error-exception.md) |


# Click Stack List Alerts

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves alerts for the authenticated team (paginated). Results are capped at `limit` (default and maximum 1000). When `totalCount` exceeds the number of returned items, page with `limit`/`offset` to retrieve them all.

```csharp
ClickStackListAlertsAsync(
    Guid organizationId,
    Guid serviceId,
    int? limit = 1000,
    int? offset = 0)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `limit` | `int?` | Query, Optional | Maximum number of results to return.<br><br>**Default**: `1000`<br><br>**Constraints**: `>= 1`, `<= 1000` |
| `offset` | `int?` | Query, Optional | Number of results to skip before returning.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0` |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackAlertsResponse](../../doc/models/v1-organizations-services-clickstack-alerts-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
int? limit = 1000;
int? offset = 0;
try
{
    ApiResponse<V1OrganizationsServicesClickstackAlertsResponse> result = await clickStackApi.ClickStackListAlertsAsync(
        organizationId,
        serviceId,
        limit,
        offset
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackAlerts400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackAlerts400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackAlerts500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackAlerts500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackAlerts400ErrorException`](../../doc/models/v1-organizations-services-clickstack-alerts-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackAlerts500ErrorException`](../../doc/models/v1-organizations-services-clickstack-alerts-500-error-exception.md) |


# Click Stack Create Alert

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new alert

```csharp
ClickStackCreateAlertAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ClickStackCreateAlertRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `body` | [`ClickStackCreateAlertRequest`](../../doc/models/click-stack-create-alert-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackAlertsResponse1](../../doc/models/v1-organizations-services-clickstack-alerts-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ClickStackCreateAlertRequest body = new ClickStackCreateAlertRequest
{
    DashboardId = "65f5e4a3b9e77c001a567890",
    TileId = "65f5e4a3b9e77c001a901234",
    SavedSearchId = "65f5e4a3b9e77c001a345678",
    GroupBy = "ServiceName",
    Threshold = 100,
    ThresholdMax = 500,
    Interval = Interval.Enum1H,
    ScheduleOffsetMinutes = 2,
    ScheduleStartAt = DateTime.ParseExact("02/08/2026 10:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Source = Source.Tile,
    ThresholdType = ThresholdType.Above,
    Name = "Test Alert",
    Message = "Test Alert Message",
    Note = "Threshold raised from 50 to 100 on 2026-01-15. See [runbook](https://wiki.example.com/runbook).",
    NumConsecutiveWindows = 3,
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackAlertsResponse1> result = await clickStackApi.ClickStackCreateAlertAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackAlerts400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackAlerts400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackAlerts500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackAlerts500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackAlerts400ErrorException`](../../doc/models/v1-organizations-services-clickstack-alerts-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackAlerts500ErrorException`](../../doc/models/v1-organizations-services-clickstack-alerts-500-error-exception.md) |


# Click Stack List Sources

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a list of all sources for the authenticated team

```csharp
ClickStackListSourcesAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackSourcesResponse](../../doc/models/v1-organizations-services-clickstack-sources-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickstackSourcesResponse> result = await clickStackApi.ClickStackListSourcesAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackSources400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSources400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackSources500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSources500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackSources400ErrorException`](../../doc/models/v1-organizations-services-clickstack-sources-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackSources500ErrorException`](../../doc/models/v1-organizations-services-clickstack-sources-500-error-exception.md) |


# Click Stack Create Source

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new source.  The request body is a source object without the `id` field. If an `id` is sent anyway it is silently ignored (stripped before validation — the request is never rejected because of it). Granularity fields (`materializedViews[].minGranularity` and `metadataMaterializedViews.granularity`) accept the same short format the API returns (e.g. `5m`, `15s`, `1h`, `1d`).

```csharp
ClickStackCreateSourceAsync(
    Guid organizationId,
    Guid serviceId,
    ClickStackSource body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `body` | [`ClickStackSource`](../../doc/models/containers/click-stack-source.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackSourcesResponse1](../../doc/models/v1-organizations-services-clickstack-sources-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ClickStackSource body = ClickStackSource.FromClickStackLogSource(
    new ClickStackLogSource
    {
        Name = "Logs",
        Kind = "log",
        Connection = "507f1f77bcf86cd799439012",
        From = new ClickStackSourceFrom
        {
            DatabaseName = "otel",
            TableName = "otel_logs",
        },
        DefaultTableSelectExpression = "Timestamp, ServiceName, SeverityText, Body",
        TimestampValueExpression = "Timestamp",
        Id = "507f1f77bcf86cd799439011",
        Section = "Billing",
        Disabled = false,
        ServiceNameExpression = "ServiceName",
        ServiceVersionExpression = "ResourceAttributes['service.version']",
        SeverityTextExpression = "SeverityText",
        BodyExpression = "Body",
        EventAttributesExpression = "LogAttributes",
        ResourceAttributesExpression = "ResourceAttributes",
        DisplayedTimestampValueExpression = "TimestampTime",
        MetricSourceId = "507f1f77bcf86cd799439013",
        TraceSourceId = "507f1f77bcf86cd799439014",
        TraceIdExpression = "TraceId",
        SpanIdExpression = "SpanId",
        ImplicitColumnExpression = "Body",
        KnownColumnsListExpression = "Timestamp, Body, ServiceName",
        UseTextIndexForImplicitColumn = UseTextIndexForImplicitColumn.Auto,
    }
);

try
{
    ApiResponse<V1OrganizationsServicesClickstackSourcesResponse1> result = await clickStackApi.ClickStackCreateSourceAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackSources400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSources400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackSources500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSources500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackSources400ErrorException`](../../doc/models/v1-organizations-services-clickstack-sources-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackSources500ErrorException`](../../doc/models/v1-organizations-services-clickstack-sources-500-error-exception.md) |


# Click Stack Get Source

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a specific source by ID

```csharp
ClickStackGetSourceAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackSourceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackSourceId` | `string` | Template, Required | Source ID |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse](../../doc/models/v1-organizations-services-clickstack-sources-click-stack-source-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackSourceId = "clickStackSourceId8";
try
{
    ApiResponse<V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse> result = await clickStackApi.ClickStackGetSourceAsync(
        organizationId,
        serviceId,
        clickStackSourceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackSourcesClickStackSourceId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSourcesClickStackSourceId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackSourcesClickStackSourceId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSourcesClickStackSourceId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackSourcesClickStackSourceId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-sources-click-stack-source-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackSourcesClickStackSourceId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-sources-click-stack-source-id-500-error-exception.md) |


# Click Stack Update Source

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Updates an existing source. The full source object must be provided; this is a replace, not a patch.  The request body is a source object without the `id` field. If an `id` is sent anyway it is silently ignored (stripped before validation — never a 400); the path parameter alone identifies the source. Granularity fields (`materializedViews[].minGranularity` and `metadataMaterializedViews.granularity`) accept the same short format the API returns (e.g. `5m`, `15s`, `1h`, `1d`).

```csharp
ClickStackUpdateSourceAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackSourceId,
    ClickStackSource body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackSourceId` | `string` | Template, Required | Source ID |
| `body` | [`ClickStackSource`](../../doc/models/containers/click-stack-source.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse](../../doc/models/v1-organizations-services-clickstack-sources-click-stack-source-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackSourceId = "clickStackSourceId8";
ClickStackSource body = ClickStackSource.FromClickStackLogSource(
    new ClickStackLogSource
    {
        Name = "Logs",
        Kind = "log",
        Connection = "507f1f77bcf86cd799439012",
        From = new ClickStackSourceFrom
        {
            DatabaseName = "otel",
            TableName = "otel_logs",
        },
        DefaultTableSelectExpression = "Timestamp, ServiceName, SeverityText, Body",
        TimestampValueExpression = "Timestamp",
        Id = "507f1f77bcf86cd799439011",
        Section = "Billing",
        Disabled = false,
        ServiceNameExpression = "ServiceName",
        ServiceVersionExpression = "ResourceAttributes['service.version']",
        SeverityTextExpression = "SeverityText",
        BodyExpression = "Body",
        EventAttributesExpression = "LogAttributes",
        ResourceAttributesExpression = "ResourceAttributes",
        DisplayedTimestampValueExpression = "TimestampTime",
        MetricSourceId = "507f1f77bcf86cd799439013",
        TraceSourceId = "507f1f77bcf86cd799439014",
        TraceIdExpression = "TraceId",
        SpanIdExpression = "SpanId",
        ImplicitColumnExpression = "Body",
        KnownColumnsListExpression = "Timestamp, Body, ServiceName",
        UseTextIndexForImplicitColumn = UseTextIndexForImplicitColumn.Auto,
    }
);

try
{
    ApiResponse<V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse> result = await clickStackApi.ClickStackUpdateSourceAsync(
        organizationId,
        serviceId,
        clickStackSourceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackSourcesClickStackSourceId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSourcesClickStackSourceId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackSourcesClickStackSourceId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSourcesClickStackSourceId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackSourcesClickStackSourceId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-sources-click-stack-source-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackSourcesClickStackSourceId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-sources-click-stack-source-id-500-error-exception.md) |


# Click Stack Delete Source

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes a source

```csharp
ClickStackDeleteSourceAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackSourceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackSourceId` | `string` | Template, Required | Source ID |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2](../../doc/models/v1-organizations-services-clickstack-sources-click-stack-source-id-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackSourceId = "clickStackSourceId8";
try
{
    ApiResponse<V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2> result = await clickStackApi.ClickStackDeleteSourceAsync(
        organizationId,
        serviceId,
        clickStackSourceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackSourcesClickStackSourceId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSourcesClickStackSourceId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackSourcesClickStackSourceId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSourcesClickStackSourceId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackSourcesClickStackSourceId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-sources-click-stack-source-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackSourcesClickStackSourceId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-sources-click-stack-source-id-500-error-exception.md) |


# Click Stack Get Alert

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a specific alert by ID

```csharp
ClickStackGetAlertAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackAlertId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackAlertId` | `string` | Template, Required | ClickStack Alert ID |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse](../../doc/models/v1-organizations-services-clickstack-alerts-click-stack-alert-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackAlertId = "clickStackAlertId2";
try
{
    ApiResponse<V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse> result = await clickStackApi.ClickStackGetAlertAsync(
        organizationId,
        serviceId,
        clickStackAlertId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackAlertsClickStackAlertId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackAlertsClickStackAlertId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackAlertsClickStackAlertId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackAlertsClickStackAlertId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackAlertsClickStackAlertId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-alerts-click-stack-alert-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackAlertsClickStackAlertId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-alerts-click-stack-alert-id-500-error-exception.md) |


# Click Stack Update Alert

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Updates an existing alert

```csharp
ClickStackUpdateAlertAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackAlertId,
    Models.ClickStackUpdateAlertRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackAlertId` | `string` | Template, Required | ClickStack Alert ID |
| `body` | [`ClickStackUpdateAlertRequest`](../../doc/models/click-stack-update-alert-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse](../../doc/models/v1-organizations-services-clickstack-alerts-click-stack-alert-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackAlertId = "clickStackAlertId2";
ClickStackUpdateAlertRequest body = new ClickStackUpdateAlertRequest
{
    DashboardId = "65f5e4a3b9e77c001a567890",
    TileId = "65f5e4a3b9e77c001a901234",
    SavedSearchId = "65f5e4a3b9e77c001a345678",
    GroupBy = "ServiceName",
    Threshold = 100,
    ThresholdMax = 500,
    Interval = Interval.Enum1H,
    ScheduleOffsetMinutes = 2,
    ScheduleStartAt = DateTime.ParseExact("02/08/2026 10:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Source = Source.Tile,
    ThresholdType = ThresholdType.Above,
    Name = "Test Alert",
    Message = "Test Alert Message",
    Note = "Threshold raised from 50 to 100 on 2026-01-15. See [runbook](https://wiki.example.com/runbook).",
    NumConsecutiveWindows = 3,
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse> result = await clickStackApi.ClickStackUpdateAlertAsync(
        organizationId,
        serviceId,
        clickStackAlertId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackAlertsClickStackAlertId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackAlertsClickStackAlertId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackAlertsClickStackAlertId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackAlertsClickStackAlertId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackAlertsClickStackAlertId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-alerts-click-stack-alert-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackAlertsClickStackAlertId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-alerts-click-stack-alert-id-500-error-exception.md) |


# Click Stack Delete Alert

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes an alert

```csharp
ClickStackDeleteAlertAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackAlertId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackAlertId` | `string` | Template, Required | ClickStack Alert ID |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2](../../doc/models/v1-organizations-services-clickstack-alerts-click-stack-alert-id-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackAlertId = "clickStackAlertId2";
try
{
    ApiResponse<V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2> result = await clickStackApi.ClickStackDeleteAlertAsync(
        organizationId,
        serviceId,
        clickStackAlertId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackAlertsClickStackAlertId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackAlertsClickStackAlertId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackAlertsClickStackAlertId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackAlertsClickStackAlertId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackAlertsClickStackAlertId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-alerts-click-stack-alert-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackAlertsClickStackAlertId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-alerts-click-stack-alert-id-500-error-exception.md) |


# Click Stack List Webhooks

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves webhooks for the authenticated team (paginated). Results are capped at `limit` (default and maximum 1000). When `totalCount` exceeds the number of returned items, page with `limit`/`offset` to retrieve them all.

```csharp
ClickStackListWebhooksAsync(
    Guid organizationId,
    Guid serviceId,
    int? limit = 1000,
    int? offset = 0)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `limit` | `int?` | Query, Optional | Maximum number of results to return.<br><br>**Default**: `1000`<br><br>**Constraints**: `>= 1`, `<= 1000` |
| `offset` | `int?` | Query, Optional | Number of results to skip before returning.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0` |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackWebhooksResponse](../../doc/models/v1-organizations-services-clickstack-webhooks-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
int? limit = 1000;
int? offset = 0;
try
{
    ApiResponse<V1OrganizationsServicesClickstackWebhooksResponse> result = await clickStackApi.ClickStackListWebhooksAsync(
        organizationId,
        serviceId,
        limit,
        offset
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackWebhooks400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackWebhooks400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackWebhooks500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackWebhooks500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackWebhooks400ErrorException`](../../doc/models/v1-organizations-services-clickstack-webhooks-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackWebhooks500ErrorException`](../../doc/models/v1-organizations-services-clickstack-webhooks-500-error-exception.md) |


# Click Stack Create Webhook

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new webhook for the authenticated team.

```csharp
ClickStackCreateWebhookAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ClickStackWebhookInput body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `body` | [`ClickStackWebhookInput`](../../doc/models/click-stack-webhook-input.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackWebhooksResponse1](../../doc/models/v1-organizations-services-clickstack-webhooks-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ClickStackWebhookInput body = new ClickStackWebhookInput
{
    Name = "Production Alerts",
    Service = Service1.Slack,
    Url = "https://hooks.slack.com/services/EXAMPLE/WEBHOOK/URL",
    Description = "Sends critical alerts to the #incidents channel",
    Body = "{\"alert\": \"{{title}}\", \"severity\": \"{{level}}\"}",
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackWebhooksResponse1> result = await clickStackApi.ClickStackCreateWebhookAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackWebhooks400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackWebhooks400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackWebhooks500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackWebhooks500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackWebhooks400ErrorException`](../../doc/models/v1-organizations-services-clickstack-webhooks-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackWebhooks500ErrorException`](../../doc/models/v1-organizations-services-clickstack-webhooks-500-error-exception.md) |


# Click Stack Update Webhook

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Replaces an existing webhook. Readable optional fields (`description`, `body`) are a full replace: omitting them clears them. The write-only fields `headers` and `queryParams` are never returned on read, so omitting them preserves the stored values; send an explicit empty object (`{}`) to clear them. Exception: if the destination (`url` or `service`) changes, omitted `headers`/ `queryParams` are cleared rather than preserved so stored secrets are never forwarded to a new destination.

```csharp
ClickStackUpdateWebhookAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackWebhookId,
    Models.ClickStackWebhookInput body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackWebhookId` | `string` | Template, Required | Webhook ID |
| `body` | [`ClickStackWebhookInput`](../../doc/models/click-stack-webhook-input.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse](../../doc/models/v1-organizations-services-clickstack-webhooks-click-stack-webhook-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackWebhookId = "clickStackWebhookId2";
ClickStackWebhookInput body = new ClickStackWebhookInput
{
    Name = "Production Alerts",
    Service = Service1.Slack,
    Url = "https://hooks.slack.com/services/EXAMPLE/WEBHOOK/URL",
    Description = "Sends critical alerts to the #incidents channel",
    Body = "{\"alert\": \"{{title}}\", \"severity\": \"{{level}}\"}",
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse> result = await clickStackApi.ClickStackUpdateWebhookAsync(
        organizationId,
        serviceId,
        clickStackWebhookId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-webhooks-click-stack-webhook-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-webhooks-click-stack-webhook-id-500-error-exception.md) |


# Click Stack Delete Webhook

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes a webhook. Blocked with a 409 while any alert still references it — reassign or remove those alerts first — so deletion never leaves an alert pointing at a missing webhook (which would silently drop notifications). Mirrors the internal webhook delete guard.

```csharp
ClickStackDeleteWebhookAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackWebhookId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackWebhookId` | `string` | Template, Required | Webhook ID |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1](../../doc/models/v1-organizations-services-clickstack-webhooks-click-stack-webhook-id-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackWebhookId = "clickStackWebhookId2";
try
{
    ApiResponse<V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1> result = await clickStackApi.ClickStackDeleteWebhookAsync(
        organizationId,
        serviceId,
        clickStackWebhookId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-webhooks-click-stack-webhook-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-webhooks-click-stack-webhook-id-500-error-exception.md) |


# Click Stack List Roles

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves all roles for the authenticated team, including predefined roles.

```csharp
ClickStackListRolesAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackRolesResponse](../../doc/models/v1-organizations-services-clickstack-roles-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickstackRolesResponse> result = await clickStackApi.ClickStackListRolesAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackRoles400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackRoles400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackRoles500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackRoles500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackRoles400ErrorException`](../../doc/models/v1-organizations-services-clickstack-roles-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackRoles500ErrorException`](../../doc/models/v1-organizations-services-clickstack-roles-500-error-exception.md) |


# Click Stack Create Role

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new custom role for the team.

```csharp
ClickStackCreateRoleAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ClickStackCreateRoleRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `body` | [`ClickStackCreateRoleRequest`](../../doc/models/click-stack-create-role-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackRolesResponse1](../../doc/models/v1-organizations-services-clickstack-roles-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ClickStackCreateRoleRequest body = new ClickStackCreateRoleRequest
{
    Name = "Deploy Bot",
    Permissions = new List<ClickStackCaslPermission>
    {
        new ClickStackCaslPermission
        {
            Action = "read",
            Subject = "dashboard",
            Inverted = false,
            Integration = "mongodb",
        },
    },
    Description = "Manages dashboards via Terraform",
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackRolesResponse1> result = await clickStackApi.ClickStackCreateRoleAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackRoles400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackRoles400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackRoles500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackRoles500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackRoles400ErrorException`](../../doc/models/v1-organizations-services-clickstack-roles-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackRoles500ErrorException`](../../doc/models/v1-organizations-services-clickstack-roles-500-error-exception.md) |


# Click Stack Get Role

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a specific role by ID.

```csharp
ClickStackGetRoleAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackRoleId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackRoleId` | `string` | Template, Required | id parameter |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse](../../doc/models/v1-organizations-services-clickstack-roles-click-stack-role-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackRoleId = "clickStackRoleId6";
try
{
    ApiResponse<V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse> result = await clickStackApi.ClickStackGetRoleAsync(
        organizationId,
        serviceId,
        clickStackRoleId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackRolesClickStackRoleId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackRolesClickStackRoleId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackRolesClickStackRoleId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackRolesClickStackRoleId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackRolesClickStackRoleId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-roles-click-stack-role-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackRolesClickStackRoleId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-roles-click-stack-role-id-500-error-exception.md) |


# Click Stack Update Role

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Updates a custom role's permissions, name, and description. Predefined roles cannot be modified.

```csharp
ClickStackUpdateRoleAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackRoleId,
    Models.ClickStackUpdateRoleRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackRoleId` | `string` | Template, Required | id parameter |
| `body` | [`ClickStackUpdateRoleRequest`](../../doc/models/click-stack-update-role-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse](../../doc/models/v1-organizations-services-clickstack-roles-click-stack-role-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackRoleId = "clickStackRoleId6";
ClickStackUpdateRoleRequest body = new ClickStackUpdateRoleRequest
{
    Permissions = new List<ClickStackCaslPermission>
    {
        new ClickStackCaslPermission
        {
            Action = "read",
            Subject = "dashboard",
            Inverted = false,
            Integration = "mongodb",
        },
    },
    Name = "Deploy Bot",
    Description = "Manages dashboards via Terraform",
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse> result = await clickStackApi.ClickStackUpdateRoleAsync(
        organizationId,
        serviceId,
        clickStackRoleId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackRolesClickStackRoleId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackRolesClickStackRoleId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackRolesClickStackRoleId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackRolesClickStackRoleId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackRolesClickStackRoleId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-roles-click-stack-role-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackRolesClickStackRoleId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-roles-click-stack-role-id-500-error-exception.md) |


# Click Stack Delete Role

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes a custom role. Predefined roles, the team default user role, and roles assigned to users cannot be deleted.

```csharp
ClickStackDeleteRoleAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackRoleId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackRoleId` | `string` | Template, Required | id parameter |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2](../../doc/models/v1-organizations-services-clickstack-roles-click-stack-role-id-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackRoleId = "clickStackRoleId6";
try
{
    ApiResponse<V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2> result = await clickStackApi.ClickStackDeleteRoleAsync(
        organizationId,
        serviceId,
        clickStackRoleId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackRolesClickStackRoleId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackRolesClickStackRoleId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackRolesClickStackRoleId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackRolesClickStackRoleId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackRolesClickStackRoleId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-roles-click-stack-role-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackRolesClickStackRoleId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-roles-click-stack-role-id-500-error-exception.md) |


# Click Stack List Saved Searches

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves saved searches for the authenticated team (paginated). Results are capped at `limit` (default and maximum 1000). When `totalCount` exceeds the number of returned items, page with `limit`/`offset` to retrieve them all.

```csharp
ClickStackListSavedSearchesAsync(
    Guid organizationId,
    Guid serviceId,
    int? limit = 1000,
    int? offset = 0)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `limit` | `int?` | Query, Optional | Maximum number of results to return.<br><br>**Default**: `1000`<br><br>**Constraints**: `>= 1`, `<= 1000` |
| `offset` | `int?` | Query, Optional | Number of results to skip before returning.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0` |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackSavedSearchesResponse](../../doc/models/v1-organizations-services-clickstack-saved-searches-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
int? limit = 1000;
int? offset = 0;
try
{
    ApiResponse<V1OrganizationsServicesClickstackSavedSearchesResponse> result = await clickStackApi.ClickStackListSavedSearchesAsync(
        organizationId,
        serviceId,
        limit,
        offset
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackSavedSearches400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSavedSearches400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackSavedSearches500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSavedSearches500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackSavedSearches400ErrorException`](../../doc/models/v1-organizations-services-clickstack-saved-searches-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackSavedSearches500ErrorException`](../../doc/models/v1-organizations-services-clickstack-saved-searches-500-error-exception.md) |


# Click Stack Create Saved Search

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new saved search.

```csharp
ClickStackCreateSavedSearchAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ClickStackSavedSearchInput body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `body` | [`ClickStackSavedSearchInput`](../../doc/models/click-stack-saved-search-input.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackSavedSearchesResponse1](../../doc/models/v1-organizations-services-clickstack-saved-searches-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ClickStackSavedSearchInput body = new ClickStackSavedSearchInput
{
    Name = "Production Errors",
    SourceId = "507f1f77bcf86cd799439012",
    MSelect = "Timestamp, ServiceName, Body",
    MWhere = "SeverityText:ERROR",
    WhereLanguage = WhereLanguage12.Lucene,
    OrderBy = "Timestamp DESC",
    Tags = new List<string>
    {
        "production",
        "errors",
    },
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackSavedSearchesResponse1> result = await clickStackApi.ClickStackCreateSavedSearchAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackSavedSearches400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSavedSearches400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackSavedSearches500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSavedSearches500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackSavedSearches400ErrorException`](../../doc/models/v1-organizations-services-clickstack-saved-searches-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackSavedSearches500ErrorException`](../../doc/models/v1-organizations-services-clickstack-saved-searches-500-error-exception.md) |


# Click Stack Get Saved Search

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a specific saved search by ID.

```csharp
ClickStackGetSavedSearchAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackSavedSearchId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackSavedSearchId` | `string` | Template, Required | Saved search ID |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse](../../doc/models/v1-organizations-services-clickstack-saved-searches-click-stack-saved-search-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackSavedSearchId = "clickStackSavedSearchId8";
try
{
    ApiResponse<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse> result = await clickStackApi.ClickStackGetSavedSearchAsync(
        organizationId,
        serviceId,
        clickStackSavedSearchId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-saved-searches-click-stack-saved-search-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-saved-searches-click-stack-saved-search-id-500-error-exception.md) |


# Click Stack Update Saved Search

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Updates an existing saved search. This is a full replace: send the full object. Every optional field (`select`, `where`, `whereLanguage`, `orderBy`, `tags`, `filters`) is always written and falls back to its default when omitted, so omitting a field resets it rather than preserving the stored value.

```csharp
ClickStackUpdateSavedSearchAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackSavedSearchId,
    Models.ClickStackSavedSearchInput body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackSavedSearchId` | `string` | Template, Required | Saved search ID |
| `body` | [`ClickStackSavedSearchInput`](../../doc/models/click-stack-saved-search-input.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse](../../doc/models/v1-organizations-services-clickstack-saved-searches-click-stack-saved-search-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackSavedSearchId = "clickStackSavedSearchId8";
ClickStackSavedSearchInput body = new ClickStackSavedSearchInput
{
    Name = "Production Errors",
    SourceId = "507f1f77bcf86cd799439012",
    MSelect = "Timestamp, ServiceName, Body",
    MWhere = "SeverityText:ERROR",
    WhereLanguage = WhereLanguage12.Lucene,
    OrderBy = "Timestamp DESC",
    Tags = new List<string>
    {
        "production",
        "errors",
    },
};

try
{
    ApiResponse<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse> result = await clickStackApi.ClickStackUpdateSavedSearchAsync(
        organizationId,
        serviceId,
        clickStackSavedSearchId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-saved-searches-click-stack-saved-search-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-saved-searches-click-stack-saved-search-id-500-error-exception.md) |


# Click Stack Delete Saved Search

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes a saved search and any alerts attached to it.

```csharp
ClickStackDeleteSavedSearchAsync(
    Guid organizationId,
    Guid serviceId,
    string clickStackSavedSearchId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the ClickStack service. |
| `clickStackSavedSearchId` | `string` | Template, Required | Saved search ID |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2](../../doc/models/v1-organizations-services-clickstack-saved-searches-click-stack-saved-search-id-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string clickStackSavedSearchId = "clickStackSavedSearchId8";
try
{
    ApiResponse<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2> result = await clickStackApi.ClickStackDeleteSavedSearchAsync(
        organizationId,
        serviceId,
        clickStackSavedSearchId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400ErrorException`](../../doc/models/v1-organizations-services-clickstack-saved-searches-click-stack-saved-search-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500ErrorException`](../../doc/models/v1-organizations-services-clickstack-saved-searches-click-stack-saved-search-id-500-error-exception.md) |

