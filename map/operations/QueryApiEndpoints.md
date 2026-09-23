<!-- Generated file — do not edit; regenerated with the SDK. -->

# QueryApiEndpoints — operations

Accessor: `client.QueryApiEndpoints` · Source: `Api/QueryApiEndpoints.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### QueryApiEndpointCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `QueryApiEndpointCreate(Guid organizationId, Guid serviceId, PublicQueryApiEndpointRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesQueryApiEndpointsResponse`
- **Error**: `SdkException<QueryApiEndpointCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesQueryApiEndpoints400Error1(out V1OrganizationsServicesQueryApiEndpoints400Error1)` [400] · `TryGetV1OrganizationsServicesQueryApiEndpoints403Error1(out V1OrganizationsServicesQueryApiEndpoints403Error1)` [403] · `TryGetV1OrganizationsServicesQueryApiEndpoints404Error1(out V1OrganizationsServicesQueryApiEndpoints404Error1)` [404] · `TryGetV1OrganizationsServicesQueryApiEndpoints500Error1(out V1OrganizationsServicesQueryApiEndpoints500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PublicQueryApiEndpointRequest` | `Models/PublicQueryApiEndpointRequest.cs` |
| `V1OrganizationsServicesQueryApiEndpointsResponse` | `Models/V1OrganizationsServicesQueryApiEndpointsResponse.cs` |
| `QueryApiEndpointCreateError` | `Errors/QueryApiEndpointCreateError.cs` |
| `V1OrganizationsServicesQueryApiEndpoints400Error1` | `Models/V1OrganizationsServicesQueryApiEndpoints400Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpoints403Error1` | `Models/V1OrganizationsServicesQueryApiEndpoints403Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpoints404Error1` | `Models/V1OrganizationsServicesQueryApiEndpoints404Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpoints500Error1` | `Models/V1OrganizationsServicesQueryApiEndpoints500Error1.cs` |

### QueryApiEndpointDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `QueryApiEndpointDelete(Guid organizationId, Guid serviceId, Guid endpointId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse`
- **Error**: `SdkException<QueryApiEndpointDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId400Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1)` [400] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId403Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1)` [403] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId404Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1)` [404] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId409Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1)` [409] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId500Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse.cs` |
| `QueryApiEndpointDeleteError` | `Errors/QueryApiEndpointDeleteError.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1.cs` |

### QueryApiEndpointGet

- **Auth**: `options.BasicAuth`
- **Signature**: `QueryApiEndpointGet(Guid organizationId, Guid serviceId, Guid endpointId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1`
- **Error**: `SdkException<QueryApiEndpointGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId400Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1)` [400] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId403Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1)` [403] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId404Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1)` [404] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId500Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1.cs` |
| `QueryApiEndpointGetError` | `Errors/QueryApiEndpointGetError.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1.cs` |

### QueryApiEndpointList

- **Auth**: `options.BasicAuth`
- **Signature**: `QueryApiEndpointList(Guid organizationId, Guid serviceId, string? cursor, int? limit = 100, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - defaults: `limit` = `100`
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `V1OrganizationsServicesQueryApiEndpointsResponse1`
- **Error**: `SdkException<QueryApiEndpointListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesQueryApiEndpoints400Error1(out V1OrganizationsServicesQueryApiEndpoints400Error1)` [400] · `TryGetV1OrganizationsServicesQueryApiEndpoints403Error1(out V1OrganizationsServicesQueryApiEndpoints403Error1)` [403] · `TryGetV1OrganizationsServicesQueryApiEndpoints404Error1(out V1OrganizationsServicesQueryApiEndpoints404Error1)` [404] · `TryGetV1OrganizationsServicesQueryApiEndpoints500Error1(out V1OrganizationsServicesQueryApiEndpoints500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesQueryApiEndpointsResponse1` | `Models/V1OrganizationsServicesQueryApiEndpointsResponse1.cs` |
| `QueryApiEndpointListError` | `Errors/QueryApiEndpointListError.cs` |
| `V1OrganizationsServicesQueryApiEndpoints400Error1` | `Models/V1OrganizationsServicesQueryApiEndpoints400Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpoints403Error1` | `Models/V1OrganizationsServicesQueryApiEndpoints403Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpoints404Error1` | `Models/V1OrganizationsServicesQueryApiEndpoints404Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpoints500Error1` | `Models/V1OrganizationsServicesQueryApiEndpoints500Error1.cs` |

### QueryApiEndpointUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `QueryApiEndpointUpdate(Guid organizationId, Guid serviceId, Guid endpointId, PublicQueryApiEndpointRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1`
- **Error**: `SdkException<QueryApiEndpointUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId400Error31(out V1OrganizationsServicesQueryApiEndpointsEndpointId400Error31)` [400] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId403Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1)` [403] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId404Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1)` [404] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId409Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1)` [409] · `TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId500Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PublicQueryApiEndpointRequest` | `Models/PublicQueryApiEndpointRequest.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1.cs` |
| `QueryApiEndpointUpdateError` | `Errors/QueryApiEndpointUpdateError.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId400Error31` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId400Error31.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1.cs` |
| `V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1` | `Models/V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1.cs` |

