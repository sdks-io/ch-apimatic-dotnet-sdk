<!-- Generated file — do not edit; regenerated with the SDK. -->

# BackupApi — operations

Accessor: `client.BackupApi` · Source: `Api/BackupApi.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BackupBucketCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `BackupBucketCreate(Guid organizationId, Guid serviceId, BackupBucketPostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesBackupBucketResponse`
- **Error**: `SdkException<BackupBucketCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesBackupBucket400Error1(out V1OrganizationsServicesBackupBucket400Error1)` [400] · `TryGetV1OrganizationsServicesBackupBucket500Error1(out V1OrganizationsServicesBackupBucket500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BackupBucketPostRequest` | `Models/AnyOf/BackupBucketPostRequest.cs` |
| `V1OrganizationsServicesBackupBucketResponse` | `Models/V1OrganizationsServicesBackupBucketResponse.cs` |
| `BackupBucketCreateError` | `Errors/BackupBucketCreateError.cs` |
| `V1OrganizationsServicesBackupBucket400Error1` | `Models/V1OrganizationsServicesBackupBucket400Error1.cs` |
| `V1OrganizationsServicesBackupBucket500Error1` | `Models/V1OrganizationsServicesBackupBucket500Error1.cs` |

### BackupBucketDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `BackupBucketDelete(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesBackupBucketResponse3`
- **Error**: `SdkException<BackupBucketDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesBackupBucket400Error1(out V1OrganizationsServicesBackupBucket400Error1)` [400] · `TryGetV1OrganizationsServicesBackupBucket500Error1(out V1OrganizationsServicesBackupBucket500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesBackupBucketResponse3` | `Models/V1OrganizationsServicesBackupBucketResponse3.cs` |
| `BackupBucketDeleteError` | `Errors/BackupBucketDeleteError.cs` |
| `V1OrganizationsServicesBackupBucket400Error1` | `Models/V1OrganizationsServicesBackupBucket400Error1.cs` |
| `V1OrganizationsServicesBackupBucket500Error1` | `Models/V1OrganizationsServicesBackupBucket500Error1.cs` |

### BackupBucketGet

- **Auth**: `options.BasicAuth`
- **Signature**: `BackupBucketGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesBackupBucketResponse`
- **Error**: `SdkException<BackupBucketGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesBackupBucket400Error1(out V1OrganizationsServicesBackupBucket400Error1)` [400] · `TryGetV1OrganizationsServicesBackupBucket500Error1(out V1OrganizationsServicesBackupBucket500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesBackupBucketResponse` | `Models/V1OrganizationsServicesBackupBucketResponse.cs` |
| `BackupBucketGetError` | `Errors/BackupBucketGetError.cs` |
| `V1OrganizationsServicesBackupBucket400Error1` | `Models/V1OrganizationsServicesBackupBucket400Error1.cs` |
| `V1OrganizationsServicesBackupBucket500Error1` | `Models/V1OrganizationsServicesBackupBucket500Error1.cs` |

### BackupBucketUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `BackupBucketUpdate(Guid organizationId, Guid serviceId, BackupBucketPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesBackupBucketResponse`
- **Error**: `SdkException<BackupBucketUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesBackupBucket400Error1(out V1OrganizationsServicesBackupBucket400Error1)` [400] · `TryGetV1OrganizationsServicesBackupBucket500Error1(out V1OrganizationsServicesBackupBucket500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BackupBucketPatchRequest` | `Models/AnyOf/BackupBucketPatchRequest.cs` |
| `V1OrganizationsServicesBackupBucketResponse` | `Models/V1OrganizationsServicesBackupBucketResponse.cs` |
| `BackupBucketUpdateError` | `Errors/BackupBucketUpdateError.cs` |
| `V1OrganizationsServicesBackupBucket400Error1` | `Models/V1OrganizationsServicesBackupBucket400Error1.cs` |
| `V1OrganizationsServicesBackupBucket500Error1` | `Models/V1OrganizationsServicesBackupBucket500Error1.cs` |

### BackupConfigurationGet

- **Auth**: `options.BasicAuth`
- **Signature**: `BackupConfigurationGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesBackupConfigurationResponse`
- **Error**: `SdkException<BackupConfigurationGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesBackupConfiguration400Error1(out V1OrganizationsServicesBackupConfiguration400Error1)` [400] · `TryGetV1OrganizationsServicesBackupConfiguration500Error1(out V1OrganizationsServicesBackupConfiguration500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesBackupConfigurationResponse` | `Models/V1OrganizationsServicesBackupConfigurationResponse.cs` |
| `BackupConfigurationGetError` | `Errors/BackupConfigurationGetError.cs` |
| `V1OrganizationsServicesBackupConfiguration400Error1` | `Models/V1OrganizationsServicesBackupConfiguration400Error1.cs` |
| `V1OrganizationsServicesBackupConfiguration500Error1` | `Models/V1OrganizationsServicesBackupConfiguration500Error1.cs` |

### BackupConfigurationUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `BackupConfigurationUpdate(Guid organizationId, Guid serviceId, BackupConfigurationPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesBackupConfigurationResponse`
- **Error**: `SdkException<BackupConfigurationUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesBackupConfiguration400Error1(out V1OrganizationsServicesBackupConfiguration400Error1)` [400] · `TryGetV1OrganizationsServicesBackupConfiguration500Error1(out V1OrganizationsServicesBackupConfiguration500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `BackupConfigurationPatchRequest` | `Models/BackupConfigurationPatchRequest.cs` |
| `V1OrganizationsServicesBackupConfigurationResponse` | `Models/V1OrganizationsServicesBackupConfigurationResponse.cs` |
| `BackupConfigurationUpdateError` | `Errors/BackupConfigurationUpdateError.cs` |
| `V1OrganizationsServicesBackupConfiguration400Error1` | `Models/V1OrganizationsServicesBackupConfiguration400Error1.cs` |
| `V1OrganizationsServicesBackupConfiguration500Error1` | `Models/V1OrganizationsServicesBackupConfiguration500Error1.cs` |

### BackupGet

- **Auth**: `options.BasicAuth`
- **Signature**: `BackupGet(Guid organizationId, Guid serviceId, Guid backupId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesBackupsBackupIdResponse`
- **Error**: `SdkException<BackupGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesBackupsBackupId400Error1(out V1OrganizationsServicesBackupsBackupId400Error1)` [400] · `TryGetV1OrganizationsServicesBackupsBackupId500Error1(out V1OrganizationsServicesBackupsBackupId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesBackupsBackupIdResponse` | `Models/V1OrganizationsServicesBackupsBackupIdResponse.cs` |
| `BackupGetError` | `Errors/BackupGetError.cs` |
| `V1OrganizationsServicesBackupsBackupId400Error1` | `Models/V1OrganizationsServicesBackupsBackupId400Error1.cs` |
| `V1OrganizationsServicesBackupsBackupId500Error1` | `Models/V1OrganizationsServicesBackupsBackupId500Error1.cs` |

### BackupGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `BackupGetList(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesBackupsResponse`
- **Error**: `SdkException<BackupGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesBackups400Error1(out V1OrganizationsServicesBackups400Error1)` [400] · `TryGetV1OrganizationsServicesBackups500Error1(out V1OrganizationsServicesBackups500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesBackupsResponse` | `Models/V1OrganizationsServicesBackupsResponse.cs` |
| `BackupGetListError` | `Errors/BackupGetListError.cs` |
| `V1OrganizationsServicesBackups400Error1` | `Models/V1OrganizationsServicesBackups400Error1.cs` |
| `V1OrganizationsServicesBackups500Error1` | `Models/V1OrganizationsServicesBackups500Error1.cs` |

