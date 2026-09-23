<!-- Generated file — do not edit; regenerated with the SDK. -->

# OrganizationApi — operations

Accessor: `client.OrganizationApi` · Source: `Api/OrganizationApi.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivityGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ActivityGet(Guid organizationId, string activityId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsActivitiesResponse1`
- **Error**: `SdkException<ActivityGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsActivities400Error1(out V1OrganizationsActivities400Error1)` [400] · `TryGetV1OrganizationsActivities500Error1(out V1OrganizationsActivities500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsActivitiesResponse1` | `Models/V1OrganizationsActivitiesResponse1.cs` |
| `ActivityGetError` | `Errors/ActivityGetError.cs` |
| `V1OrganizationsActivities400Error1` | `Models/V1OrganizationsActivities400Error1.cs` |
| `V1OrganizationsActivities500Error1` | `Models/V1OrganizationsActivities500Error1.cs` |

### ActivityGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `ActivityGetList(Guid organizationId, DateTimeOffset? fromDate, DateTimeOffset? toDate, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `fromDate` — nullable, no default → **must pass explicitly**
  - `toDate` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `from_date` ← `fromDate`, `to_date` ← `toDate`
- **Returns**: `V1OrganizationsActivitiesResponse`
- **Error**: `SdkException<ActivityGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsActivities400Error1(out V1OrganizationsActivities400Error1)` [400] · `TryGetV1OrganizationsActivities500Error1(out V1OrganizationsActivities500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsActivitiesResponse` | `Models/V1OrganizationsActivitiesResponse.cs` |
| `ActivityGetListError` | `Errors/ActivityGetListError.cs` |
| `V1OrganizationsActivities400Error1` | `Models/V1OrganizationsActivities400Error1.cs` |
| `V1OrganizationsActivities500Error1` | `Models/V1OrganizationsActivities500Error1.cs` |

### OrganizationByocInfrastructureCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationByocInfrastructureCreate(Guid organizationId, ByocInfrastructurePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsByocInfrastructureResponse`
- **Error**: `SdkException<OrganizationByocInfrastructureCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsByocInfrastructure400Error1(out V1OrganizationsByocInfrastructure400Error1)` [400] · `TryGetV1OrganizationsByocInfrastructure500Error1(out V1OrganizationsByocInfrastructure500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ByocInfrastructurePostRequest` | `Models/ByocInfrastructurePostRequest.cs` |
| `V1OrganizationsByocInfrastructureResponse` | `Models/V1OrganizationsByocInfrastructureResponse.cs` |
| `OrganizationByocInfrastructureCreateError` | `Errors/OrganizationByocInfrastructureCreateError.cs` |
| `V1OrganizationsByocInfrastructure400Error1` | `Models/V1OrganizationsByocInfrastructure400Error1.cs` |
| `V1OrganizationsByocInfrastructure500Error1` | `Models/V1OrganizationsByocInfrastructure500Error1.cs` |

### OrganizationByocInfrastructureDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationByocInfrastructureDelete(Guid organizationId, Guid byocInfrastructureId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsByocInfrastructureResponse1`
- **Error**: `SdkException<OrganizationByocInfrastructureDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsByocInfrastructure400Error1(out V1OrganizationsByocInfrastructure400Error1)` [400] · `TryGetV1OrganizationsByocInfrastructure500Error1(out V1OrganizationsByocInfrastructure500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsByocInfrastructureResponse1` | `Models/V1OrganizationsByocInfrastructureResponse1.cs` |
| `OrganizationByocInfrastructureDeleteError` | `Errors/OrganizationByocInfrastructureDeleteError.cs` |
| `V1OrganizationsByocInfrastructure400Error1` | `Models/V1OrganizationsByocInfrastructure400Error1.cs` |
| `V1OrganizationsByocInfrastructure500Error1` | `Models/V1OrganizationsByocInfrastructure500Error1.cs` |

### OrganizationByocInfrastructureUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationByocInfrastructureUpdate(Guid organizationId, Guid byocInfrastructureId, ByocInfrastructurePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsByocInfrastructureResponse`
- **Error**: `SdkException<OrganizationByocInfrastructureUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsByocInfrastructure400Error1(out V1OrganizationsByocInfrastructure400Error1)` [400] · `TryGetV1OrganizationsByocInfrastructure500Error1(out V1OrganizationsByocInfrastructure500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ByocInfrastructurePatchRequest` | `Models/ByocInfrastructurePatchRequest.cs` |
| `V1OrganizationsByocInfrastructureResponse` | `Models/V1OrganizationsByocInfrastructureResponse.cs` |
| `OrganizationByocInfrastructureUpdateError` | `Errors/OrganizationByocInfrastructureUpdateError.cs` |
| `V1OrganizationsByocInfrastructure400Error1` | `Models/V1OrganizationsByocInfrastructure400Error1.cs` |
| `V1OrganizationsByocInfrastructure500Error1` | `Models/V1OrganizationsByocInfrastructure500Error1.cs` |

### OrganizationGet

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationGet(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsResponse1`
- **Error**: `SdkException<OrganizationGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1Organizations400Error1(out V1Organizations400Error1)` [400] · `TryGetV1Organizations500Error1(out V1Organizations500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsResponse1` | `Models/V1OrganizationsResponse1.cs` |
| `OrganizationGetError` | `Errors/OrganizationGetError.cs` |
| `V1Organizations400Error1` | `Models/V1Organizations400Error1.cs` |
| `V1Organizations500Error1` | `Models/V1Organizations500Error1.cs` |

### OrganizationGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationGetList(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsResponse`
- **Error**: `SdkException<OrganizationGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1Organizations400Error1(out V1Organizations400Error1)` [400] · `TryGetV1Organizations500Error1(out V1Organizations500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsResponse` | `Models/V1OrganizationsResponse.cs` |
| `OrganizationGetListError` | `Errors/OrganizationGetListError.cs` |
| `V1Organizations400Error1` | `Models/V1Organizations400Error1.cs` |
| `V1Organizations500Error1` | `Models/V1Organizations500Error1.cs` |

### OrganizationPrivateEndpointConfigGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationPrivateEndpointConfigGetList(Guid organizationId, string cloudProvider, string regionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `cloud_provider` ← `cloudProvider`, `region_id` ← `regionId`
- **Returns**: `V1OrganizationsPrivateEndpointConfigResponse`
- **Error**: `SdkException<OrganizationPrivateEndpointConfigGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPrivateEndpointConfig400Error1(out V1OrganizationsPrivateEndpointConfig400Error1)` [400] · `TryGetV1OrganizationsPrivateEndpointConfig500Error1(out V1OrganizationsPrivateEndpointConfig500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsPrivateEndpointConfigResponse` | `Models/V1OrganizationsPrivateEndpointConfigResponse.cs` |
| `OrganizationPrivateEndpointConfigGetListError` | `Errors/OrganizationPrivateEndpointConfigGetListError.cs` |
| `V1OrganizationsPrivateEndpointConfig400Error1` | `Models/V1OrganizationsPrivateEndpointConfig400Error1.cs` |
| `V1OrganizationsPrivateEndpointConfig500Error1` | `Models/V1OrganizationsPrivateEndpointConfig500Error1.cs` |

### OrganizationQuotaGet

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationQuotaGet(Guid organizationId, string quotaCode, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsQuotasResponse1`
- **Error**: `SdkException<OrganizationQuotaGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsQuotas400Error1(out V1OrganizationsQuotas400Error1)` [400] · `TryGetV1OrganizationsQuotas500Error1(out V1OrganizationsQuotas500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsQuotasResponse1` | `Models/V1OrganizationsQuotasResponse1.cs` |
| `OrganizationQuotaGetError` | `Errors/OrganizationQuotaGetError.cs` |
| `V1OrganizationsQuotas400Error1` | `Models/V1OrganizationsQuotas400Error1.cs` |
| `V1OrganizationsQuotas500Error1` | `Models/V1OrganizationsQuotas500Error1.cs` |

### OrganizationQuotasGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationQuotasGetList(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsQuotasResponse`
- **Error**: `SdkException<OrganizationQuotasGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsQuotas400Error1(out V1OrganizationsQuotas400Error1)` [400] · `TryGetV1OrganizationsQuotas500Error1(out V1OrganizationsQuotas500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsQuotasResponse` | `Models/V1OrganizationsQuotasResponse.cs` |
| `OrganizationQuotasGetListError` | `Errors/OrganizationQuotasGetListError.cs` |
| `V1OrganizationsQuotas400Error1` | `Models/V1OrganizationsQuotas400Error1.cs` |
| `V1OrganizationsQuotas500Error1` | `Models/V1OrganizationsQuotas500Error1.cs` |

### OrganizationUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationUpdate(Guid organizationId, OrganizationPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsResponse1`
- **Error**: `SdkException<OrganizationUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1Organizations400Error1(out V1Organizations400Error1)` [400] · `TryGetV1Organizations500Error1(out V1Organizations500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OrganizationPatchRequest` | `Models/OrganizationPatchRequest.cs` |
| `V1OrganizationsResponse1` | `Models/V1OrganizationsResponse1.cs` |
| `OrganizationUpdateError` | `Errors/OrganizationUpdateError.cs` |
| `V1Organizations400Error1` | `Models/V1Organizations400Error1.cs` |
| `V1Organizations500Error1` | `Models/V1Organizations500Error1.cs` |

