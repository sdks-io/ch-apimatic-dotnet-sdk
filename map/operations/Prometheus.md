<!-- Generated file — do not edit; regenerated with the SDK. -->

# Prometheus — operations

Accessor: `client.Prometheus` · Source: `Api/Prometheus.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### InstancePrometheusGet

- **Auth**: `options.BasicAuth`
- **Signature**: `InstancePrometheusGet(Guid organizationId, Guid serviceId, string? filteredMetrics, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `filteredMetrics` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `filtered_metrics` ← `filteredMetrics`
- **Returns**: `string`
- **Error**: `SdkException<InstancePrometheusGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesPrometheus400Error1(out V1OrganizationsServicesPrometheus400Error1)` [400] · `TryGetV1OrganizationsServicesPrometheus500Error1(out V1OrganizationsServicesPrometheus500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InstancePrometheusGetError` | `Errors/InstancePrometheusGetError.cs` |
| `V1OrganizationsServicesPrometheus400Error1` | `Models/V1OrganizationsServicesPrometheus400Error1.cs` |
| `V1OrganizationsServicesPrometheus500Error1` | `Models/V1OrganizationsServicesPrometheus500Error1.cs` |

### OrganizationPrometheusDiscoveryGet

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationPrometheusDiscoveryGet(Guid organizationId, string? filteredMetrics, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `filteredMetrics` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `filtered_metrics` ← `filteredMetrics`
- **Returns**: `IReadOnlyList<PrometheusDiscoveryTargetGroup>`
- **Error**: `SdkException<OrganizationPrometheusDiscoveryGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPrometheusDiscovery400Error1(out V1OrganizationsPrometheusDiscovery400Error1)` [400] · `TryGetV1OrganizationsPrometheusDiscovery500Error1(out V1OrganizationsPrometheusDiscovery500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PrometheusDiscoveryTargetGroup` | `Models/PrometheusDiscoveryTargetGroup.cs` |
| `OrganizationPrometheusDiscoveryGetError` | `Errors/OrganizationPrometheusDiscoveryGetError.cs` |
| `V1OrganizationsPrometheusDiscovery400Error1` | `Models/V1OrganizationsPrometheusDiscovery400Error1.cs` |
| `V1OrganizationsPrometheusDiscovery500Error1` | `Models/V1OrganizationsPrometheusDiscovery500Error1.cs` |

### OrganizationPrometheusGet

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationPrometheusGet(Guid organizationId, string? filteredMetrics, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `filteredMetrics` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `filtered_metrics` ← `filteredMetrics`
- **Returns**: `string`
- **Error**: `SdkException<OrganizationPrometheusGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPrometheus400Error1(out V1OrganizationsPrometheus400Error1)` [400] · `TryGetV1OrganizationsPrometheus500Error1(out V1OrganizationsPrometheus500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OrganizationPrometheusGetError` | `Errors/OrganizationPrometheusGetError.cs` |
| `V1OrganizationsPrometheus400Error1` | `Models/V1OrganizationsPrometheus400Error1.cs` |
| `V1OrganizationsPrometheus500Error1` | `Models/V1OrganizationsPrometheus500Error1.cs` |

### PostgresInstancePrometheusGet

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresInstancePrometheusGet(Guid organizationId, Guid postgresId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `string`
- **Error**: `SdkException<PostgresInstancePrometheusGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresPrometheus400Error1(out V1OrganizationsPostgresPrometheus400Error1)` [400] · `TryGetV1OrganizationsPostgresPrometheus500Error1(out V1OrganizationsPostgresPrometheus500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresInstancePrometheusGetError` | `Errors/PostgresInstancePrometheusGetError.cs` |
| `V1OrganizationsPostgresPrometheus400Error1` | `Models/V1OrganizationsPostgresPrometheus400Error1.cs` |
| `V1OrganizationsPostgresPrometheus500Error1` | `Models/V1OrganizationsPostgresPrometheus500Error1.cs` |

### PostgresOrgPrometheusGet

- **Auth**: `options.BasicAuth`
- **Signature**: `PostgresOrgPrometheusGet(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `string`
- **Error**: `SdkException<PostgresOrgPrometheusGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsPostgresPrometheus400Error1(out V1OrganizationsPostgresPrometheus400Error1)` [400] · `TryGetV1OrganizationsPostgresPrometheus500Error1(out V1OrganizationsPostgresPrometheus500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostgresOrgPrometheusGetError` | `Errors/PostgresOrgPrometheusGetError.cs` |
| `V1OrganizationsPostgresPrometheus400Error1` | `Models/V1OrganizationsPostgresPrometheus400Error1.cs` |
| `V1OrganizationsPostgresPrometheus500Error1` | `Models/V1OrganizationsPostgresPrometheus500Error1.cs` |

