<!-- Generated file — do not edit; regenerated with the SDK. -->

# Postgres — operations

Accessor: `client.Postgres` · Source: `Api/Postgres.cs` · 17 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostgresInstanceConfigGet

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresInstanceConfigGet(Guid organizationId, Guid postgresId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsPostgresConfigResponse`
- **Error**: `SdkException<PostgresInstanceConfigGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresConfig400Error1(out V1OrganizationsPostgresConfig400Error1)` [400] · `TryGetV1OrganizationsPostgresConfig500Error1(out V1OrganizationsPostgresConfig500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsPostgresConfigResponse` | `Models/V1OrganizationsPostgresConfigResponse.cs` |
| `PostgresInstanceConfigGetError` | `Errors/PostgresInstanceConfigGetError.cs` |
| `V1OrganizationsPostgresConfig400Error1` | `Models/V1OrganizationsPostgresConfig400Error1.cs` |
| `V1OrganizationsPostgresConfig500Error1` | `Models/V1OrganizationsPostgresConfig500Error1.cs` |

### PostgresInstanceConfigPatch

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresInstanceConfigPatch(Guid organizationId, Guid postgresId, PostgresInstanceConfig? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsPostgresConfigResponse1`
- **Error**: `SdkException<PostgresInstanceConfigPatchError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresConfig400Error1(out V1OrganizationsPostgresConfig400Error1)` [400] · `TryGetV1OrganizationsPostgresConfig500Error1(out V1OrganizationsPostgresConfig500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresInstanceConfig` | `Models/PostgresInstanceConfig.cs` |
| `V1OrganizationsPostgresConfigResponse1` | `Models/V1OrganizationsPostgresConfigResponse1.cs` |
| `PostgresInstanceConfigPatchError` | `Errors/PostgresInstanceConfigPatchError.cs` |
| `V1OrganizationsPostgresConfig400Error1` | `Models/V1OrganizationsPostgresConfig400Error1.cs` |
| `V1OrganizationsPostgresConfig500Error1` | `Models/V1OrganizationsPostgresConfig500Error1.cs` |

### PostgresInstanceConfigPost

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresInstanceConfigPost(Guid organizationId, Guid postgresId, PostgresInstanceConfig? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsPostgresConfigResponse1`
- **Error**: `SdkException<PostgresInstanceConfigPostError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresConfig400Error1(out V1OrganizationsPostgresConfig400Error1)` [400] · `TryGetV1OrganizationsPostgresConfig500Error1(out V1OrganizationsPostgresConfig500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresInstanceConfig` | `Models/PostgresInstanceConfig.cs` |
| `V1OrganizationsPostgresConfigResponse1` | `Models/V1OrganizationsPostgresConfigResponse1.cs` |
| `PostgresInstanceConfigPostError` | `Errors/PostgresInstanceConfigPostError.cs` |
| `V1OrganizationsPostgresConfig400Error1` | `Models/V1OrganizationsPostgresConfig400Error1.cs` |
| `V1OrganizationsPostgresConfig500Error1` | `Models/V1OrganizationsPostgresConfig500Error1.cs` |

### PostgresInstanceCreateReadReplica

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresInstanceCreateReadReplica(Guid organizationId, Guid postgresId, PostgresServiceReadReplicaRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsPostgresReadReplicaResponse`
- **Error**: `SdkException<PostgresInstanceCreateReadReplicaError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresReadReplica400Error1(out V1OrganizationsPostgresReadReplica400Error1)` [400] · `TryGetV1OrganizationsPostgresReadReplica500Error1(out V1OrganizationsPostgresReadReplica500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresServiceReadReplicaRequest` | `Models/PostgresServiceReadReplicaRequest.cs` |
| `V1OrganizationsPostgresReadReplicaResponse` | `Models/V1OrganizationsPostgresReadReplicaResponse.cs` |
| `PostgresInstanceCreateReadReplicaError` | `Errors/PostgresInstanceCreateReadReplicaError.cs` |
| `V1OrganizationsPostgresReadReplica400Error1` | `Models/V1OrganizationsPostgresReadReplica400Error1.cs` |
| `V1OrganizationsPostgresReadReplica500Error1` | `Models/V1OrganizationsPostgresReadReplica500Error1.cs` |

### PostgresInstanceMetricsGet

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresInstanceMetricsGet(Guid organizationId, Guid postgresId, DateTimeOffset fromDate, DateTimeOffset toDate, int? bucketSizeSeconds, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `bucketSizeSeconds` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `from_date` ← `fromDate`, `to_date` ← `toDate`, `bucket_size_seconds` ← `bucketSizeSeconds`
- **Returns**: `V1OrganizationsPostgresMetricsResponse`
- **Error**: `SdkException<PostgresInstanceMetricsGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresMetrics400Error1(out V1OrganizationsPostgresMetrics400Error1)` [400] · `TryGetV1OrganizationsPostgresMetrics500Error1(out V1OrganizationsPostgresMetrics500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsPostgresMetricsResponse` | `Models/V1OrganizationsPostgresMetricsResponse.cs` |
| `PostgresInstanceMetricsGetError` | `Errors/PostgresInstanceMetricsGetError.cs` |
| `V1OrganizationsPostgresMetrics400Error1` | `Models/V1OrganizationsPostgresMetrics400Error1.cs` |
| `V1OrganizationsPostgresMetrics500Error1` | `Models/V1OrganizationsPostgresMetrics500Error1.cs` |

### PostgresInstanceRestore

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresInstanceRestore(Guid organizationId, Guid postgresId, PostgresServiceRestoreRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsPostgresRestoredServiceResponse`
- **Error**: `SdkException<PostgresInstanceRestoreError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresRestoredService400Error1(out V1OrganizationsPostgresRestoredService400Error1)` [400] · `TryGetV1OrganizationsPostgresRestoredService500Error1(out V1OrganizationsPostgresRestoredService500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresServiceRestoreRequest` | `Models/PostgresServiceRestoreRequest.cs` |
| `V1OrganizationsPostgresRestoredServiceResponse` | `Models/V1OrganizationsPostgresRestoredServiceResponse.cs` |
| `PostgresInstanceRestoreError` | `Errors/PostgresInstanceRestoreError.cs` |
| `V1OrganizationsPostgresRestoredService400Error1` | `Models/V1OrganizationsPostgresRestoredService400Error1.cs` |
| `V1OrganizationsPostgresRestoredService500Error1` | `Models/V1OrganizationsPostgresRestoredService500Error1.cs` |

### PostgresLogsGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresLogsGetList(Guid organizationId, Guid postgresId, DateTimeOffset fromDate, DateTimeOffset toDate, string? bodyContains, string? severity, SortOrder1? sortOrder, int? limit = 50, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `bodyContains` — nullable, no default → **must pass explicitly**
  - `severity` — nullable, no default → **must pass explicitly**
  - `sortOrder` — nullable, no default → **must pass explicitly**
  - defaults: `limit` = `50`, `offset` = `0`
- **Query params (wire ← C#)**: `from_date` ← `fromDate`, `to_date` ← `toDate`, `body_contains` ← `bodyContains`, `severity` ← `severity`, `sort_order` ← `sortOrder`, `limit` ← `limit`, `offset` ← `offset`
- **Returns**: `V1OrganizationsPostgresLogsResponse`
- **Error**: `SdkException<PostgresLogsGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresLogs400Error1(out V1OrganizationsPostgresLogs400Error1)` [400] · `TryGetV1OrganizationsPostgresLogs500Error1(out V1OrganizationsPostgresLogs500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SortOrder1` | `Models/Enums/SortOrder1.cs` |
| `V1OrganizationsPostgresLogsResponse` | `Models/V1OrganizationsPostgresLogsResponse.cs` |
| `PostgresLogsGetListError` | `Errors/PostgresLogsGetListError.cs` |
| `V1OrganizationsPostgresLogs400Error1` | `Models/V1OrganizationsPostgresLogs400Error1.cs` |
| `V1OrganizationsPostgresLogs500Error1` | `Models/V1OrganizationsPostgresLogs500Error1.cs` |

### PostgresServiceCertsGet

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresServiceCertsGet(Guid organizationId, Guid postgresId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<PostgresServiceCertsGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresCaCertificates400Error1(out V1OrganizationsPostgresCaCertificates400Error1)` [400] · `TryGetV1OrganizationsPostgresCaCertificates500Error1(out V1OrganizationsPostgresCaCertificates500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresServiceCertsGetError` | `Errors/PostgresServiceCertsGetError.cs` |
| `V1OrganizationsPostgresCaCertificates400Error1` | `Models/V1OrganizationsPostgresCaCertificates400Error1.cs` |
| `V1OrganizationsPostgresCaCertificates500Error1` | `Models/V1OrganizationsPostgresCaCertificates500Error1.cs` |

### PostgresServiceCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresServiceCreate(Guid organizationId, PostgresServicePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsPostgresResponse`
- **Error**: `SdkException<PostgresServiceCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgres400Error1(out V1OrganizationsPostgres400Error1)` [400] · `TryGetV1OrganizationsPostgres500Error1(out V1OrganizationsPostgres500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresServicePostRequest` | `Models/PostgresServicePostRequest.cs` |
| `V1OrganizationsPostgresResponse` | `Models/V1OrganizationsPostgresResponse.cs` |
| `PostgresServiceCreateError` | `Errors/PostgresServiceCreateError.cs` |
| `V1OrganizationsPostgres400Error1` | `Models/V1OrganizationsPostgres400Error1.cs` |
| `V1OrganizationsPostgres500Error1` | `Models/V1OrganizationsPostgres500Error1.cs` |

### PostgresServiceDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresServiceDelete(Guid organizationId, Guid postgresId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsPostgresResponse3`
- **Error**: `SdkException<PostgresServiceDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgres400Error1(out V1OrganizationsPostgres400Error1)` [400] · `TryGetV1OrganizationsPostgres500Error1(out V1OrganizationsPostgres500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsPostgresResponse3` | `Models/V1OrganizationsPostgresResponse3.cs` |
| `PostgresServiceDeleteError` | `Errors/PostgresServiceDeleteError.cs` |
| `V1OrganizationsPostgres400Error1` | `Models/V1OrganizationsPostgres400Error1.cs` |
| `V1OrganizationsPostgres500Error1` | `Models/V1OrganizationsPostgres500Error1.cs` |

### PostgresServiceGet

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresServiceGet(Guid organizationId, Guid postgresId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsPostgresResponse`
- **Error**: `SdkException<PostgresServiceGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgres400Error1(out V1OrganizationsPostgres400Error1)` [400] · `TryGetV1OrganizationsPostgres500Error1(out V1OrganizationsPostgres500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsPostgresResponse` | `Models/V1OrganizationsPostgresResponse.cs` |
| `PostgresServiceGetError` | `Errors/PostgresServiceGetError.cs` |
| `V1OrganizationsPostgres400Error1` | `Models/V1OrganizationsPostgres400Error1.cs` |
| `V1OrganizationsPostgres500Error1` | `Models/V1OrganizationsPostgres500Error1.cs` |

### PostgresServiceGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresServiceGetList(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsPostgresResponse1`
- **Error**: `SdkException<PostgresServiceGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgres400Error1(out V1OrganizationsPostgres400Error1)` [400] · `TryGetV1OrganizationsPostgres500Error1(out V1OrganizationsPostgres500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsPostgresResponse1` | `Models/V1OrganizationsPostgresResponse1.cs` |
| `PostgresServiceGetListError` | `Errors/PostgresServiceGetListError.cs` |
| `V1OrganizationsPostgres400Error1` | `Models/V1OrganizationsPostgres400Error1.cs` |
| `V1OrganizationsPostgres500Error1` | `Models/V1OrganizationsPostgres500Error1.cs` |

### PostgresServicePatch

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresServicePatch(Guid organizationId, Guid postgresId, PostgresServicePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsPostgresResponse`
- **Error**: `SdkException<PostgresServicePatchError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgres400Error1(out V1OrganizationsPostgres400Error1)` [400] · `TryGetV1OrganizationsPostgres500Error1(out V1OrganizationsPostgres500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresServicePatchRequest` | `Models/PostgresServicePatchRequest.cs` |
| `V1OrganizationsPostgresResponse` | `Models/V1OrganizationsPostgresResponse.cs` |
| `PostgresServicePatchError` | `Errors/PostgresServicePatchError.cs` |
| `V1OrganizationsPostgres400Error1` | `Models/V1OrganizationsPostgres400Error1.cs` |
| `V1OrganizationsPostgres500Error1` | `Models/V1OrganizationsPostgres500Error1.cs` |

### PostgresServicePatchState

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresServicePatchState(Guid organizationId, Guid postgresId, PostgresServiceSetState? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsPostgresStateResponse`
- **Error**: `SdkException<PostgresServicePatchStateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresState400Error1(out V1OrganizationsPostgresState400Error1)` [400] · `TryGetV1OrganizationsPostgresState500Error1(out V1OrganizationsPostgresState500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresServiceSetState` | `Models/PostgresServiceSetState.cs` |
| `V1OrganizationsPostgresStateResponse` | `Models/V1OrganizationsPostgresStateResponse.cs` |
| `PostgresServicePatchStateError` | `Errors/PostgresServicePatchStateError.cs` |
| `V1OrganizationsPostgresState400Error1` | `Models/V1OrganizationsPostgresState400Error1.cs` |
| `V1OrganizationsPostgresState500Error1` | `Models/V1OrganizationsPostgresState500Error1.cs` |

### PostgresServiceSetPassword

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresServiceSetPassword(Guid organizationId, Guid postgresId, PostgresServiceSetPassword? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsPostgresPasswordResponse`
- **Error**: `SdkException<PostgresServiceSetPasswordError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresPassword400Error1(out V1OrganizationsPostgresPassword400Error1)` [400] · `TryGetV1OrganizationsPostgresPassword500Error1(out V1OrganizationsPostgresPassword500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresServiceSetPassword` | `Models/PostgresServiceSetPassword.cs` |
| `V1OrganizationsPostgresPasswordResponse` | `Models/V1OrganizationsPostgresPasswordResponse.cs` |
| `PostgresServiceSetPasswordError` | `Errors/PostgresServiceSetPasswordError.cs` |
| `V1OrganizationsPostgresPassword400Error1` | `Models/V1OrganizationsPostgresPassword400Error1.cs` |
| `V1OrganizationsPostgresPassword500Error1` | `Models/V1OrganizationsPostgresPassword500Error1.cs` |

### SlowQueryPatternGet

- **Auth**: `options.BasicAuth`
- **Signature**: `SlowQueryPatternGet(Guid organizationId, Guid postgresId, string queryId, string dbName, string dbUser, string dbOperation, string? app, DateTimeOffset? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `app` — nullable, no default → **must pass explicitly**
  - `timestamp` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `db_name` ← `dbName`, `db_user` ← `dbUser`, `db_operation` ← `dbOperation`, `app` ← `app`, `timestamp` ← `timestamp`
- **Returns**: `V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse`
- **Error**: `SdkException<SlowQueryPatternGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresSlowQueryPatternsQueryId400Error1(out V1OrganizationsPostgresSlowQueryPatternsQueryId400Error1)` [400] · `TryGetV1OrganizationsPostgresSlowQueryPatternsQueryId500Error1(out V1OrganizationsPostgresSlowQueryPatternsQueryId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse` | `Models/V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse.cs` |
| `SlowQueryPatternGetError` | `Errors/SlowQueryPatternGetError.cs` |
| `V1OrganizationsPostgresSlowQueryPatternsQueryId400Error1` | `Models/V1OrganizationsPostgresSlowQueryPatternsQueryId400Error1.cs` |
| `V1OrganizationsPostgresSlowQueryPatternsQueryId500Error1` | `Models/V1OrganizationsPostgresSlowQueryPatternsQueryId500Error1.cs` |

### SlowQueryPatternsGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `SlowQueryPatternsGetList(Guid organizationId, Guid postgresId, DateTimeOffset fromDate, DateTimeOffset toDate, string? dbName, string? dbUser, string? dbOperation, string? app, SortBy? sortBy, SortOrder1? sortOrder, int? limit = 20, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`dbName` … `sortOrder`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `limit` = `20`, `offset` = `0`
- **Query params (wire ← C#)**: `from_date` ← `fromDate`, `to_date` ← `toDate`, `db_name` ← `dbName`, `db_user` ← `dbUser`, `db_operation` ← `dbOperation`, `app` ← `app`, `sort_by` ← `sortBy`, `sort_order` ← `sortOrder`, `limit` ← `limit`, `offset` ← `offset`
- **Returns**: `V1OrganizationsPostgresSlowQueryPatternsResponse`
- **Error**: `SdkException<SlowQueryPatternsGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresSlowQueryPatterns400Error1(out V1OrganizationsPostgresSlowQueryPatterns400Error1)` [400] · `TryGetV1OrganizationsPostgresSlowQueryPatterns500Error1(out V1OrganizationsPostgresSlowQueryPatterns500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SortBy` | `Models/Enums/SortBy.cs` |
| `SortOrder1` | `Models/Enums/SortOrder1.cs` |
| `V1OrganizationsPostgresSlowQueryPatternsResponse` | `Models/V1OrganizationsPostgresSlowQueryPatternsResponse.cs` |
| `SlowQueryPatternsGetListError` | `Errors/SlowQueryPatternsGetListError.cs` |
| `V1OrganizationsPostgresSlowQueryPatterns400Error1` | `Models/V1OrganizationsPostgresSlowQueryPatterns400Error1.cs` |
| `V1OrganizationsPostgresSlowQueryPatterns500Error1` | `Models/V1OrganizationsPostgresSlowQueryPatterns500Error1.cs` |

