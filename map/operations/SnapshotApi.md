<!-- Generated file — do not edit; regenerated with the SDK. -->

# SnapshotApi — operations

Accessor: `client.SnapshotApi` · Source: `Api/SnapshotApi.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SnapshotConfigurationGet

- **Auth**: `options.BasicAuth`
- **Signature**: `SnapshotConfigurationGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesSnapshotConfigurationResponse`
- **Error**: `SdkException<SnapshotConfigurationGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesSnapshotConfiguration400Error1(out V1OrganizationsServicesSnapshotConfiguration400Error1)` [400] · `TryGetV1OrganizationsServicesSnapshotConfiguration500Error1(out V1OrganizationsServicesSnapshotConfiguration500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesSnapshotConfigurationResponse` | `Models/V1OrganizationsServicesSnapshotConfigurationResponse.cs` |
| `SnapshotConfigurationGetError` | `Errors/SnapshotConfigurationGetError.cs` |
| `V1OrganizationsServicesSnapshotConfiguration400Error1` | `Models/V1OrganizationsServicesSnapshotConfiguration400Error1.cs` |
| `V1OrganizationsServicesSnapshotConfiguration500Error1` | `Models/V1OrganizationsServicesSnapshotConfiguration500Error1.cs` |

### SnapshotConfigurationUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `SnapshotConfigurationUpdate(Guid organizationId, Guid serviceId, SnapshotConfigurationPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesSnapshotConfigurationResponse`
- **Error**: `SdkException<SnapshotConfigurationUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesSnapshotConfiguration400Error1(out V1OrganizationsServicesSnapshotConfiguration400Error1)` [400] · `TryGetV1OrganizationsServicesSnapshotConfiguration500Error1(out V1OrganizationsServicesSnapshotConfiguration500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SnapshotConfigurationPatchRequest` | `Models/SnapshotConfigurationPatchRequest.cs` |
| `V1OrganizationsServicesSnapshotConfigurationResponse` | `Models/V1OrganizationsServicesSnapshotConfigurationResponse.cs` |
| `SnapshotConfigurationUpdateError` | `Errors/SnapshotConfigurationUpdateError.cs` |
| `V1OrganizationsServicesSnapshotConfiguration400Error1` | `Models/V1OrganizationsServicesSnapshotConfiguration400Error1.cs` |
| `V1OrganizationsServicesSnapshotConfiguration500Error1` | `Models/V1OrganizationsServicesSnapshotConfiguration500Error1.cs` |

### SnapshotGet

- **Auth**: `options.BasicAuth`
- **Signature**: `SnapshotGet(Guid organizationId, Guid serviceId, Guid snapshotId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesSnapshotsSnapshotIdResponse`
- **Error**: `SdkException<SnapshotGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesSnapshotsSnapshotId400Error1(out V1OrganizationsServicesSnapshotsSnapshotId400Error1)` [400] · `TryGetV1OrganizationsServicesSnapshotsSnapshotId500Error1(out V1OrganizationsServicesSnapshotsSnapshotId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesSnapshotsSnapshotIdResponse` | `Models/V1OrganizationsServicesSnapshotsSnapshotIdResponse.cs` |
| `SnapshotGetError` | `Errors/SnapshotGetError.cs` |
| `V1OrganizationsServicesSnapshotsSnapshotId400Error1` | `Models/V1OrganizationsServicesSnapshotsSnapshotId400Error1.cs` |
| `V1OrganizationsServicesSnapshotsSnapshotId500Error1` | `Models/V1OrganizationsServicesSnapshotsSnapshotId500Error1.cs` |

### SnapshotGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `SnapshotGetList(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesSnapshotsResponse`
- **Error**: `SdkException<SnapshotGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesSnapshots400Error1(out V1OrganizationsServicesSnapshots400Error1)` [400] · `TryGetV1OrganizationsServicesSnapshots500Error1(out V1OrganizationsServicesSnapshots500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesSnapshotsResponse` | `Models/V1OrganizationsServicesSnapshotsResponse.cs` |
| `SnapshotGetListError` | `Errors/SnapshotGetListError.cs` |
| `V1OrganizationsServicesSnapshots400Error1` | `Models/V1OrganizationsServicesSnapshots400Error1.cs` |
| `V1OrganizationsServicesSnapshots500Error1` | `Models/V1OrganizationsServicesSnapshots500Error1.cs` |

