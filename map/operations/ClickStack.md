<!-- Generated file — do not edit; regenerated with the SDK. -->

# ClickStack — operations

Accessor: `client.ClickStack` · Source: `Api/ClickStack.cs` · 30 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ClickStackCreateAlert

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackCreateAlert(Guid organizationId, Guid serviceId, ClickStackCreateAlertRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackAlertsResponse1`
- **Error**: `SdkException<ClickStackCreateAlertError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackAlerts400Error1(out V1OrganizationsServicesClickstackAlerts400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackAlerts500Error1(out V1OrganizationsServicesClickstackAlerts500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackCreateAlertRequest` | `Models/ClickStackCreateAlertRequest.cs` |
| `V1OrganizationsServicesClickstackAlertsResponse1` | `Models/V1OrganizationsServicesClickstackAlertsResponse1.cs` |
| `ClickStackCreateAlertError` | `Errors/ClickStackCreateAlertError.cs` |
| `V1OrganizationsServicesClickstackAlerts400Error1` | `Models/V1OrganizationsServicesClickstackAlerts400Error1.cs` |
| `V1OrganizationsServicesClickstackAlerts500Error1` | `Models/V1OrganizationsServicesClickstackAlerts500Error1.cs` |

### ClickStackCreateDashboard

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackCreateDashboard(Guid organizationId, Guid serviceId, ClickStackCreateDashboardRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackDashboardsResponse1`
- **Error**: `SdkException<ClickStackCreateDashboardError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackDashboards400Error1(out V1OrganizationsServicesClickstackDashboards400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackDashboards500Error1(out V1OrganizationsServicesClickstackDashboards500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackCreateDashboardRequest` | `Models/ClickStackCreateDashboardRequest.cs` |
| `V1OrganizationsServicesClickstackDashboardsResponse1` | `Models/V1OrganizationsServicesClickstackDashboardsResponse1.cs` |
| `ClickStackCreateDashboardError` | `Errors/ClickStackCreateDashboardError.cs` |
| `V1OrganizationsServicesClickstackDashboards400Error1` | `Models/V1OrganizationsServicesClickstackDashboards400Error1.cs` |
| `V1OrganizationsServicesClickstackDashboards500Error1` | `Models/V1OrganizationsServicesClickstackDashboards500Error1.cs` |

### ClickStackCreateRole

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackCreateRole(Guid organizationId, Guid serviceId, ClickStackCreateRoleRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackRolesResponse1`
- **Error**: `SdkException<ClickStackCreateRoleError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackRoles400Error1(out V1OrganizationsServicesClickstackRoles400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackRoles500Error1(out V1OrganizationsServicesClickstackRoles500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackCreateRoleRequest` | `Models/ClickStackCreateRoleRequest.cs` |
| `V1OrganizationsServicesClickstackRolesResponse1` | `Models/V1OrganizationsServicesClickstackRolesResponse1.cs` |
| `ClickStackCreateRoleError` | `Errors/ClickStackCreateRoleError.cs` |
| `V1OrganizationsServicesClickstackRoles400Error1` | `Models/V1OrganizationsServicesClickstackRoles400Error1.cs` |
| `V1OrganizationsServicesClickstackRoles500Error1` | `Models/V1OrganizationsServicesClickstackRoles500Error1.cs` |

### ClickStackCreateSavedSearch

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackCreateSavedSearch(Guid organizationId, Guid serviceId, ClickStackSavedSearchInput? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackSavedSearchesResponse1`
- **Error**: `SdkException<ClickStackCreateSavedSearchError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackSavedSearches400Error1(out V1OrganizationsServicesClickstackSavedSearches400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackSavedSearches500Error1(out V1OrganizationsServicesClickstackSavedSearches500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackSavedSearchInput` | `Models/ClickStackSavedSearchInput.cs` |
| `V1OrganizationsServicesClickstackSavedSearchesResponse1` | `Models/V1OrganizationsServicesClickstackSavedSearchesResponse1.cs` |
| `ClickStackCreateSavedSearchError` | `Errors/ClickStackCreateSavedSearchError.cs` |
| `V1OrganizationsServicesClickstackSavedSearches400Error1` | `Models/V1OrganizationsServicesClickstackSavedSearches400Error1.cs` |
| `V1OrganizationsServicesClickstackSavedSearches500Error1` | `Models/V1OrganizationsServicesClickstackSavedSearches500Error1.cs` |

### ClickStackCreateSource

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackCreateSource(Guid organizationId, Guid serviceId, ClickStackSource? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackSourcesResponse1`
- **Error**: `SdkException<ClickStackCreateSourceError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackSources400Error1(out V1OrganizationsServicesClickstackSources400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackSources500Error1(out V1OrganizationsServicesClickstackSources500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackSource` | `Models/AnyOf/ClickStackSource.cs` |
| `V1OrganizationsServicesClickstackSourcesResponse1` | `Models/V1OrganizationsServicesClickstackSourcesResponse1.cs` |
| `ClickStackCreateSourceError` | `Errors/ClickStackCreateSourceError.cs` |
| `V1OrganizationsServicesClickstackSources400Error1` | `Models/V1OrganizationsServicesClickstackSources400Error1.cs` |
| `V1OrganizationsServicesClickstackSources500Error1` | `Models/V1OrganizationsServicesClickstackSources500Error1.cs` |

### ClickStackCreateWebhook

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackCreateWebhook(Guid organizationId, Guid serviceId, ClickStackWebhookInput? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackWebhooksResponse1`
- **Error**: `SdkException<ClickStackCreateWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackWebhooks400Error1(out V1OrganizationsServicesClickstackWebhooks400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackWebhooks500Error1(out V1OrganizationsServicesClickstackWebhooks500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackWebhookInput` | `Models/ClickStackWebhookInput.cs` |
| `V1OrganizationsServicesClickstackWebhooksResponse1` | `Models/V1OrganizationsServicesClickstackWebhooksResponse1.cs` |
| `ClickStackCreateWebhookError` | `Errors/ClickStackCreateWebhookError.cs` |
| `V1OrganizationsServicesClickstackWebhooks400Error1` | `Models/V1OrganizationsServicesClickstackWebhooks400Error1.cs` |
| `V1OrganizationsServicesClickstackWebhooks500Error1` | `Models/V1OrganizationsServicesClickstackWebhooks500Error1.cs` |

### ClickStackDeleteAlert

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackDeleteAlert(Guid organizationId, Guid serviceId, string clickStackAlertId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2`
- **Error**: `SdkException<ClickStackDeleteAlertError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1(out V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1(out V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2` | `Models/V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2.cs` |
| `ClickStackDeleteAlertError` | `Errors/ClickStackDeleteAlertError.cs` |
| `V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1` | `Models/V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1.cs` |
| `V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1` | `Models/V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1.cs` |

### ClickStackDeleteDashboard

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackDeleteDashboard(Guid organizationId, Guid serviceId, string clickStackDashboardId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2`
- **Error**: `SdkException<ClickStackDeleteDashboardError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1(out V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1(out V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2` | `Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2.cs` |
| `ClickStackDeleteDashboardError` | `Errors/ClickStackDeleteDashboardError.cs` |
| `V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1` | `Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1.cs` |
| `V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1` | `Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1.cs` |

### ClickStackDeleteRole

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackDeleteRole(Guid organizationId, Guid serviceId, string clickStackRoleId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2`
- **Error**: `SdkException<ClickStackDeleteRoleError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId400Error1(out V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId500Error1(out V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2` | `Models/V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2.cs` |
| `ClickStackDeleteRoleError` | `Errors/ClickStackDeleteRoleError.cs` |
| `V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1` | `Models/V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1.cs` |
| `V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1` | `Models/V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1.cs` |

### ClickStackDeleteSavedSearch

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackDeleteSavedSearch(Guid organizationId, Guid serviceId, string clickStackSavedSearchId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2`
- **Error**: `SdkException<ClickStackDeleteSavedSearchError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1(out V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1(out V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2` | `Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2.cs` |
| `ClickStackDeleteSavedSearchError` | `Errors/ClickStackDeleteSavedSearchError.cs` |
| `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1` | `Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1.cs` |
| `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1` | `Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1.cs` |

### ClickStackDeleteSource

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackDeleteSource(Guid organizationId, Guid serviceId, string clickStackSourceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2`
- **Error**: `SdkException<ClickStackDeleteSourceError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1(out V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1(out V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2` | `Models/V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2.cs` |
| `ClickStackDeleteSourceError` | `Errors/ClickStackDeleteSourceError.cs` |
| `V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1` | `Models/V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1.cs` |
| `V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1` | `Models/V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1.cs` |

### ClickStackDeleteWebhook

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackDeleteWebhook(Guid organizationId, Guid serviceId, string clickStackWebhookId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1`
- **Error**: `SdkException<ClickStackDeleteWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1(out V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1(out V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1` | `Models/V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1.cs` |
| `ClickStackDeleteWebhookError` | `Errors/ClickStackDeleteWebhookError.cs` |
| `V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1` | `Models/V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1.cs` |
| `V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1` | `Models/V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1.cs` |

### ClickStackGetAlert

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackGetAlert(Guid organizationId, Guid serviceId, string clickStackAlertId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse`
- **Error**: `SdkException<ClickStackGetAlertError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1(out V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1(out V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse` | `Models/V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse.cs` |
| `ClickStackGetAlertError` | `Errors/ClickStackGetAlertError.cs` |
| `V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1` | `Models/V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1.cs` |
| `V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1` | `Models/V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1.cs` |

### ClickStackGetDashboard

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackGetDashboard(Guid organizationId, Guid serviceId, string clickStackDashboardId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse`
- **Error**: `SdkException<ClickStackGetDashboardError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1(out V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1(out V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse` | `Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse.cs` |
| `ClickStackGetDashboardError` | `Errors/ClickStackGetDashboardError.cs` |
| `V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1` | `Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1.cs` |
| `V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1` | `Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1.cs` |

### ClickStackGetRole

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackGetRole(Guid organizationId, Guid serviceId, string clickStackRoleId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse`
- **Error**: `SdkException<ClickStackGetRoleError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId400Error1(out V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId500Error1(out V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse` | `Models/V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse.cs` |
| `ClickStackGetRoleError` | `Errors/ClickStackGetRoleError.cs` |
| `V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1` | `Models/V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1.cs` |
| `V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1` | `Models/V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1.cs` |

### ClickStackGetSavedSearch

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackGetSavedSearch(Guid organizationId, Guid serviceId, string clickStackSavedSearchId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse`
- **Error**: `SdkException<ClickStackGetSavedSearchError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1(out V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1(out V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse` | `Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse.cs` |
| `ClickStackGetSavedSearchError` | `Errors/ClickStackGetSavedSearchError.cs` |
| `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1` | `Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1.cs` |
| `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1` | `Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1.cs` |

### ClickStackGetSource

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackGetSource(Guid organizationId, Guid serviceId, string clickStackSourceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse`
- **Error**: `SdkException<ClickStackGetSourceError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1(out V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1(out V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse` | `Models/V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse.cs` |
| `ClickStackGetSourceError` | `Errors/ClickStackGetSourceError.cs` |
| `V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1` | `Models/V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1.cs` |
| `V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1` | `Models/V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1.cs` |

### ClickStackListAlerts

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackListAlerts(Guid organizationId, Guid serviceId, int? limit = 1000, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `limit` = `1000`, `offset` = `0`
- **Query params (wire ← C#)**: `limit` ← `limit`, `offset` ← `offset`
- **Returns**: `V1OrganizationsServicesClickstackAlertsResponse`
- **Error**: `SdkException<ClickStackListAlertsError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackAlerts400Error1(out V1OrganizationsServicesClickstackAlerts400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackAlerts500Error1(out V1OrganizationsServicesClickstackAlerts500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackAlertsResponse` | `Models/V1OrganizationsServicesClickstackAlertsResponse.cs` |
| `ClickStackListAlertsError` | `Errors/ClickStackListAlertsError.cs` |
| `V1OrganizationsServicesClickstackAlerts400Error1` | `Models/V1OrganizationsServicesClickstackAlerts400Error1.cs` |
| `V1OrganizationsServicesClickstackAlerts500Error1` | `Models/V1OrganizationsServicesClickstackAlerts500Error1.cs` |

### ClickStackListDashboards

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackListDashboards(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackDashboardsResponse`
- **Error**: `SdkException<ClickStackListDashboardsError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackDashboards400Error1(out V1OrganizationsServicesClickstackDashboards400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackDashboards500Error1(out V1OrganizationsServicesClickstackDashboards500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackDashboardsResponse` | `Models/V1OrganizationsServicesClickstackDashboardsResponse.cs` |
| `ClickStackListDashboardsError` | `Errors/ClickStackListDashboardsError.cs` |
| `V1OrganizationsServicesClickstackDashboards400Error1` | `Models/V1OrganizationsServicesClickstackDashboards400Error1.cs` |
| `V1OrganizationsServicesClickstackDashboards500Error1` | `Models/V1OrganizationsServicesClickstackDashboards500Error1.cs` |

### ClickStackListRoles

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackListRoles(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackRolesResponse`
- **Error**: `SdkException<ClickStackListRolesError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackRoles400Error1(out V1OrganizationsServicesClickstackRoles400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackRoles500Error1(out V1OrganizationsServicesClickstackRoles500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackRolesResponse` | `Models/V1OrganizationsServicesClickstackRolesResponse.cs` |
| `ClickStackListRolesError` | `Errors/ClickStackListRolesError.cs` |
| `V1OrganizationsServicesClickstackRoles400Error1` | `Models/V1OrganizationsServicesClickstackRoles400Error1.cs` |
| `V1OrganizationsServicesClickstackRoles500Error1` | `Models/V1OrganizationsServicesClickstackRoles500Error1.cs` |

### ClickStackListSavedSearches

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackListSavedSearches(Guid organizationId, Guid serviceId, int? limit = 1000, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `limit` = `1000`, `offset` = `0`
- **Query params (wire ← C#)**: `limit` ← `limit`, `offset` ← `offset`
- **Returns**: `V1OrganizationsServicesClickstackSavedSearchesResponse`
- **Error**: `SdkException<ClickStackListSavedSearchesError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackSavedSearches400Error1(out V1OrganizationsServicesClickstackSavedSearches400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackSavedSearches500Error1(out V1OrganizationsServicesClickstackSavedSearches500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackSavedSearchesResponse` | `Models/V1OrganizationsServicesClickstackSavedSearchesResponse.cs` |
| `ClickStackListSavedSearchesError` | `Errors/ClickStackListSavedSearchesError.cs` |
| `V1OrganizationsServicesClickstackSavedSearches400Error1` | `Models/V1OrganizationsServicesClickstackSavedSearches400Error1.cs` |
| `V1OrganizationsServicesClickstackSavedSearches500Error1` | `Models/V1OrganizationsServicesClickstackSavedSearches500Error1.cs` |

### ClickStackListSources

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackListSources(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickstackSourcesResponse`
- **Error**: `SdkException<ClickStackListSourcesError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackSources400Error1(out V1OrganizationsServicesClickstackSources400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackSources500Error1(out V1OrganizationsServicesClickstackSources500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackSourcesResponse` | `Models/V1OrganizationsServicesClickstackSourcesResponse.cs` |
| `ClickStackListSourcesError` | `Errors/ClickStackListSourcesError.cs` |
| `V1OrganizationsServicesClickstackSources400Error1` | `Models/V1OrganizationsServicesClickstackSources400Error1.cs` |
| `V1OrganizationsServicesClickstackSources500Error1` | `Models/V1OrganizationsServicesClickstackSources500Error1.cs` |

### ClickStackListWebhooks

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackListWebhooks(Guid organizationId, Guid serviceId, int? limit = 1000, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `limit` = `1000`, `offset` = `0`
- **Query params (wire ← C#)**: `limit` ← `limit`, `offset` ← `offset`
- **Returns**: `V1OrganizationsServicesClickstackWebhooksResponse`
- **Error**: `SdkException<ClickStackListWebhooksError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackWebhooks400Error1(out V1OrganizationsServicesClickstackWebhooks400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackWebhooks500Error1(out V1OrganizationsServicesClickstackWebhooks500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickstackWebhooksResponse` | `Models/V1OrganizationsServicesClickstackWebhooksResponse.cs` |
| `ClickStackListWebhooksError` | `Errors/ClickStackListWebhooksError.cs` |
| `V1OrganizationsServicesClickstackWebhooks400Error1` | `Models/V1OrganizationsServicesClickstackWebhooks400Error1.cs` |
| `V1OrganizationsServicesClickstackWebhooks500Error1` | `Models/V1OrganizationsServicesClickstackWebhooks500Error1.cs` |

### ClickStackUpdateAlert

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackUpdateAlert(Guid organizationId, Guid serviceId, string clickStackAlertId, ClickStackUpdateAlertRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse`
- **Error**: `SdkException<ClickStackUpdateAlertError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1(out V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1(out V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackUpdateAlertRequest` | `Models/ClickStackUpdateAlertRequest.cs` |
| `V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse` | `Models/V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse.cs` |
| `ClickStackUpdateAlertError` | `Errors/ClickStackUpdateAlertError.cs` |
| `V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1` | `Models/V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1.cs` |
| `V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1` | `Models/V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1.cs` |

### ClickStackUpdateDashboard

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackUpdateDashboard(Guid organizationId, Guid serviceId, string clickStackDashboardId, ClickStackUpdateDashboardRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse`
- **Error**: `SdkException<ClickStackUpdateDashboardError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1(out V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1(out V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackUpdateDashboardRequest` | `Models/ClickStackUpdateDashboardRequest.cs` |
| `V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse` | `Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse.cs` |
| `ClickStackUpdateDashboardError` | `Errors/ClickStackUpdateDashboardError.cs` |
| `V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1` | `Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1.cs` |
| `V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1` | `Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1.cs` |

### ClickStackUpdateRole

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackUpdateRole(Guid organizationId, Guid serviceId, string clickStackRoleId, ClickStackUpdateRoleRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse`
- **Error**: `SdkException<ClickStackUpdateRoleError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId400Error1(out V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId500Error1(out V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackUpdateRoleRequest` | `Models/ClickStackUpdateRoleRequest.cs` |
| `V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse` | `Models/V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse.cs` |
| `ClickStackUpdateRoleError` | `Errors/ClickStackUpdateRoleError.cs` |
| `V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1` | `Models/V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1.cs` |
| `V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1` | `Models/V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1.cs` |

### ClickStackUpdateSavedSearch

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackUpdateSavedSearch(Guid organizationId, Guid serviceId, string clickStackSavedSearchId, ClickStackSavedSearchInput? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse`
- **Error**: `SdkException<ClickStackUpdateSavedSearchError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1(out V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1(out V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackSavedSearchInput` | `Models/ClickStackSavedSearchInput.cs` |
| `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse` | `Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse.cs` |
| `ClickStackUpdateSavedSearchError` | `Errors/ClickStackUpdateSavedSearchError.cs` |
| `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1` | `Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1.cs` |
| `V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1` | `Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1.cs` |

### ClickStackUpdateSource

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackUpdateSource(Guid organizationId, Guid serviceId, string clickStackSourceId, ClickStackSource? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse`
- **Error**: `SdkException<ClickStackUpdateSourceError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1(out V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1(out V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackSource` | `Models/AnyOf/ClickStackSource.cs` |
| `V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse` | `Models/V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse.cs` |
| `ClickStackUpdateSourceError` | `Errors/ClickStackUpdateSourceError.cs` |
| `V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1` | `Models/V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1.cs` |
| `V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1` | `Models/V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1.cs` |

### ClickStackUpdateWebhook

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackUpdateWebhook(Guid organizationId, Guid serviceId, string clickStackWebhookId, ClickStackWebhookInput? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse`
- **Error**: `SdkException<ClickStackUpdateWebhookError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1(out V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1(out V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackWebhookInput` | `Models/ClickStackWebhookInput.cs` |
| `V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse` | `Models/V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse.cs` |
| `ClickStackUpdateWebhookError` | `Errors/ClickStackUpdateWebhookError.cs` |
| `V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1` | `Models/V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1.cs` |
| `V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1` | `Models/V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1.cs` |

### ClickStackValidateDashboard

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickStackValidateDashboard(Guid organizationId, Guid serviceId, ClickStackCreateDashboardRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickstackDashboardsValidateResponse`
- **Error**: `SdkException<ClickStackValidateDashboardApiError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickstackDashboardsValidate400Error1(out V1OrganizationsServicesClickstackDashboardsValidate400Error1)` [400] · `TryGetV1OrganizationsServicesClickstackDashboardsValidate500Error1(out V1OrganizationsServicesClickstackDashboardsValidate500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickStackCreateDashboardRequest` | `Models/ClickStackCreateDashboardRequest.cs` |
| `V1OrganizationsServicesClickstackDashboardsValidateResponse` | `Models/V1OrganizationsServicesClickstackDashboardsValidateResponse.cs` |
| `ClickStackValidateDashboardApiError` | `Errors/ClickStackValidateDashboardApiError.cs` |
| `V1OrganizationsServicesClickstackDashboardsValidate400Error1` | `Models/V1OrganizationsServicesClickstackDashboardsValidate400Error1.cs` |
| `V1OrganizationsServicesClickstackDashboardsValidate500Error1` | `Models/V1OrganizationsServicesClickstackDashboardsValidate500Error1.cs` |

