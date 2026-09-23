<!-- Generated file — do not edit; regenerated with the SDK. -->

# UdfApi — operations

Accessor: `client.UdfApi` · Source: `Api/UdfApi.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### UdfAttach

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfAttach(Guid organizationId, string functionName, Guid serviceId, V1OrganizationsUdfsAttachmentsServiceIdRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsUdfsAttachmentsServiceIdResponse`
- **Error**: `SdkException<UdfAttachError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfsAttachmentsServiceId400Error1(out V1OrganizationsUdfsAttachmentsServiceId400Error1)` [400] · `TryGetV1OrganizationsUdfsAttachmentsServiceId404Error1(out V1OrganizationsUdfsAttachmentsServiceId404Error1)` [404] · `TryGetV1OrganizationsUdfsAttachmentsServiceId409Error1(out V1OrganizationsUdfsAttachmentsServiceId409Error1)` [409] · `TryGetV1OrganizationsUdfsAttachmentsServiceId422Error1(out V1OrganizationsUdfsAttachmentsServiceId422Error1)` [422] · `TryGetV1OrganizationsUdfsAttachmentsServiceId424Error1(out V1OrganizationsUdfsAttachmentsServiceId424Error1)` [424] · `TryGetV1OrganizationsUdfsAttachmentsServiceId500Error1(out V1OrganizationsUdfsAttachmentsServiceId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUdfsAttachmentsServiceIdRequest` | `Models/V1OrganizationsUdfsAttachmentsServiceIdRequest.cs` |
| `V1OrganizationsUdfsAttachmentsServiceIdResponse` | `Models/V1OrganizationsUdfsAttachmentsServiceIdResponse.cs` |
| `UdfAttachError` | `Errors/UdfAttachError.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId400Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId400Error1.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId404Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId404Error1.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId409Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId409Error1.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId422Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId422Error1.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId424Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId424Error1.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId500Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId500Error1.cs` |

### UdfAttachmentGet

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfAttachmentGet(Guid organizationId, string functionName, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsUdfsAttachmentsServiceIdResponse`
- **Error**: `SdkException<UdfAttachmentGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfsAttachmentsServiceId400Error21(out V1OrganizationsUdfsAttachmentsServiceId400Error21)` [400] · `TryGetV1OrganizationsUdfsAttachmentsServiceId404Error1(out V1OrganizationsUdfsAttachmentsServiceId404Error1)` [404] · `TryGetV1OrganizationsUdfsAttachmentsServiceId500Error1(out V1OrganizationsUdfsAttachmentsServiceId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUdfsAttachmentsServiceIdResponse` | `Models/V1OrganizationsUdfsAttachmentsServiceIdResponse.cs` |
| `UdfAttachmentGetError` | `Errors/UdfAttachmentGetError.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId400Error21` | `Models/V1OrganizationsUdfsAttachmentsServiceId400Error21.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId404Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId404Error1.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId500Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId500Error1.cs` |

### UdfAttachmentList

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfAttachmentList(Guid organizationId, string functionName, string? cursor, int? limit = 100, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - defaults: `limit` = `100`
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `V1OrganizationsUdfsAttachmentsResponse`
- **Error**: `SdkException<UdfAttachmentListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfsAttachments400Error1(out V1OrganizationsUdfsAttachments400Error1)` [400] · `TryGetV1OrganizationsUdfsAttachments404Error1(out V1OrganizationsUdfsAttachments404Error1)` [404] · `TryGetV1OrganizationsUdfsAttachments500Error1(out V1OrganizationsUdfsAttachments500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUdfsAttachmentsResponse` | `Models/V1OrganizationsUdfsAttachmentsResponse.cs` |
| `UdfAttachmentListError` | `Errors/UdfAttachmentListError.cs` |
| `V1OrganizationsUdfsAttachments400Error1` | `Models/V1OrganizationsUdfsAttachments400Error1.cs` |
| `V1OrganizationsUdfsAttachments404Error1` | `Models/V1OrganizationsUdfsAttachments404Error1.cs` |
| `V1OrganizationsUdfsAttachments500Error1` | `Models/V1OrganizationsUdfsAttachments500Error1.cs` |

### UdfCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfCreate(Guid organizationId, UdfCreateRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsUdfsResponse`
- **Error**: `SdkException<UdfCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfs400Error1(out V1OrganizationsUdfs400Error1)` [400] · `TryGetV1OrganizationsUdfs403Error1(out V1OrganizationsUdfs403Error1)` [403] · `TryGetV1OrganizationsUdfs409Error1(out V1OrganizationsUdfs409Error1)` [409] · `TryGetV1OrganizationsUdfs410Error1(out V1OrganizationsUdfs410Error1)` [410] · `TryGetV1OrganizationsUdfs500Error1(out V1OrganizationsUdfs500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UdfCreateRequest2` | `Models/AnyOf/UdfCreateRequest2.cs` |
| `V1OrganizationsUdfsResponse` | `Models/V1OrganizationsUdfsResponse.cs` |
| `UdfCreateError` | `Errors/UdfCreateError.cs` |
| `V1OrganizationsUdfs400Error1` | `Models/V1OrganizationsUdfs400Error1.cs` |
| `V1OrganizationsUdfs403Error1` | `Models/V1OrganizationsUdfs403Error1.cs` |
| `V1OrganizationsUdfs409Error1` | `Models/V1OrganizationsUdfs409Error1.cs` |
| `V1OrganizationsUdfs410Error1` | `Models/V1OrganizationsUdfs410Error1.cs` |
| `V1OrganizationsUdfs500Error1` | `Models/V1OrganizationsUdfs500Error1.cs` |

### UdfDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfDelete(Guid organizationId, string functionName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsUdfsResponse2`
- **Error**: `SdkException<UdfDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfs400Error1(out V1OrganizationsUdfs400Error1)` [400] · `TryGetV1OrganizationsUdfs404Error1(out V1OrganizationsUdfs404Error1)` [404] · `TryGetV1OrganizationsUdfs409Error1(out V1OrganizationsUdfs409Error1)` [409] · `TryGetV1OrganizationsUdfs500Error1(out V1OrganizationsUdfs500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUdfsResponse2` | `Models/V1OrganizationsUdfsResponse2.cs` |
| `UdfDeleteError` | `Errors/UdfDeleteError.cs` |
| `V1OrganizationsUdfs400Error1` | `Models/V1OrganizationsUdfs400Error1.cs` |
| `V1OrganizationsUdfs404Error1` | `Models/V1OrganizationsUdfs404Error1.cs` |
| `V1OrganizationsUdfs409Error1` | `Models/V1OrganizationsUdfs409Error1.cs` |
| `V1OrganizationsUdfs500Error1` | `Models/V1OrganizationsUdfs500Error1.cs` |

### UdfDetach

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfDetach(Guid organizationId, string functionName, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsUdfsAttachmentsServiceIdResponse2`
- **Error**: `SdkException<UdfDetachError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfsAttachmentsServiceId400Error21(out V1OrganizationsUdfsAttachmentsServiceId400Error21)` [400] · `TryGetV1OrganizationsUdfsAttachmentsServiceId404Error1(out V1OrganizationsUdfsAttachmentsServiceId404Error1)` [404] · `TryGetV1OrganizationsUdfsAttachmentsServiceId409Error1(out V1OrganizationsUdfsAttachmentsServiceId409Error1)` [409] · `TryGetV1OrganizationsUdfsAttachmentsServiceId500Error1(out V1OrganizationsUdfsAttachmentsServiceId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUdfsAttachmentsServiceIdResponse2` | `Models/V1OrganizationsUdfsAttachmentsServiceIdResponse2.cs` |
| `UdfDetachError` | `Errors/UdfDetachError.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId400Error21` | `Models/V1OrganizationsUdfsAttachmentsServiceId400Error21.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId404Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId404Error1.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId409Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId409Error1.cs` |
| `V1OrganizationsUdfsAttachmentsServiceId500Error1` | `Models/V1OrganizationsUdfsAttachmentsServiceId500Error1.cs` |

### UdfGet

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfGet(Guid organizationId, string functionName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsUdfsResponse`
- **Error**: `SdkException<UdfGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfs400Error1(out V1OrganizationsUdfs400Error1)` [400] · `TryGetV1OrganizationsUdfs404Error1(out V1OrganizationsUdfs404Error1)` [404] · `TryGetV1OrganizationsUdfs500Error1(out V1OrganizationsUdfs500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUdfsResponse` | `Models/V1OrganizationsUdfsResponse.cs` |
| `UdfGetError` | `Errors/UdfGetError.cs` |
| `V1OrganizationsUdfs400Error1` | `Models/V1OrganizationsUdfs400Error1.cs` |
| `V1OrganizationsUdfs404Error1` | `Models/V1OrganizationsUdfs404Error1.cs` |
| `V1OrganizationsUdfs500Error1` | `Models/V1OrganizationsUdfs500Error1.cs` |

### UdfList

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfList(Guid organizationId, string? cursor, int? limit = 100, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - defaults: `limit` = `100`
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `V1OrganizationsUdfsResponse1`
- **Error**: `SdkException<UdfListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfs400Error1(out V1OrganizationsUdfs400Error1)` [400] · `TryGetV1OrganizationsUdfs500Error1(out V1OrganizationsUdfs500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUdfsResponse1` | `Models/V1OrganizationsUdfsResponse1.cs` |
| `UdfListError` | `Errors/UdfListError.cs` |
| `V1OrganizationsUdfs400Error1` | `Models/V1OrganizationsUdfs400Error1.cs` |
| `V1OrganizationsUdfs500Error1` | `Models/V1OrganizationsUdfs500Error1.cs` |

### UdfUploadSessionCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfUploadSessionCreate(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsUdfUploadsUrlResponse`
- **Error**: `SdkException<UdfUploadSessionCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfUploadsUrl400Error1(out V1OrganizationsUdfUploadsUrl400Error1)` [400] · `TryGetV1OrganizationsUdfUploadsUrl500Error1(out V1OrganizationsUdfUploadsUrl500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUdfUploadsUrlResponse` | `Models/V1OrganizationsUdfUploadsUrlResponse.cs` |
| `UdfUploadSessionCreateError` | `Errors/UdfUploadSessionCreateError.cs` |
| `V1OrganizationsUdfUploadsUrl400Error1` | `Models/V1OrganizationsUdfUploadsUrl400Error1.cs` |
| `V1OrganizationsUdfUploadsUrl500Error1` | `Models/V1OrganizationsUdfUploadsUrl500Error1.cs` |

### UdfVersionCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfVersionCreate(Guid organizationId, string functionName, UdfVersionCreateRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsUdfsVersionsResponse`
- **Error**: `SdkException<UdfVersionCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfsVersions400Error1(out V1OrganizationsUdfsVersions400Error1)` [400] · `TryGetV1OrganizationsUdfsVersions403Error1(out V1OrganizationsUdfsVersions403Error1)` [403] · `TryGetV1OrganizationsUdfsVersions404Error1(out V1OrganizationsUdfsVersions404Error1)` [404] · `TryGetV1OrganizationsUdfsVersions409Error1(out V1OrganizationsUdfsVersions409Error1)` [409] · `TryGetV1OrganizationsUdfsVersions410Error1(out V1OrganizationsUdfsVersions410Error1)` [410] · `TryGetV1OrganizationsUdfsVersions500Error1(out V1OrganizationsUdfsVersions500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UdfVersionCreateRequest2` | `Models/AnyOf/UdfVersionCreateRequest2.cs` |
| `V1OrganizationsUdfsVersionsResponse` | `Models/V1OrganizationsUdfsVersionsResponse.cs` |
| `UdfVersionCreateError` | `Errors/UdfVersionCreateError.cs` |
| `V1OrganizationsUdfsVersions400Error1` | `Models/V1OrganizationsUdfsVersions400Error1.cs` |
| `V1OrganizationsUdfsVersions403Error1` | `Models/V1OrganizationsUdfsVersions403Error1.cs` |
| `V1OrganizationsUdfsVersions404Error1` | `Models/V1OrganizationsUdfsVersions404Error1.cs` |
| `V1OrganizationsUdfsVersions409Error1` | `Models/V1OrganizationsUdfsVersions409Error1.cs` |
| `V1OrganizationsUdfsVersions410Error1` | `Models/V1OrganizationsUdfsVersions410Error1.cs` |
| `V1OrganizationsUdfsVersions500Error1` | `Models/V1OrganizationsUdfsVersions500Error1.cs` |

### UdfVersionDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfVersionDelete(Guid organizationId, string functionName, int version, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsUdfsVersionsVersionResponse`
- **Error**: `SdkException<UdfVersionDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfsVersionsVersion400Error1(out V1OrganizationsUdfsVersionsVersion400Error1)` [400] · `TryGetV1OrganizationsUdfsVersionsVersion404Error1(out V1OrganizationsUdfsVersionsVersion404Error1)` [404] · `TryGetV1OrganizationsUdfsVersionsVersion409Error1(out V1OrganizationsUdfsVersionsVersion409Error1)` [409] · `TryGetV1OrganizationsUdfsVersionsVersion500Error1(out V1OrganizationsUdfsVersionsVersion500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUdfsVersionsVersionResponse` | `Models/V1OrganizationsUdfsVersionsVersionResponse.cs` |
| `UdfVersionDeleteError` | `Errors/UdfVersionDeleteError.cs` |
| `V1OrganizationsUdfsVersionsVersion400Error1` | `Models/V1OrganizationsUdfsVersionsVersion400Error1.cs` |
| `V1OrganizationsUdfsVersionsVersion404Error1` | `Models/V1OrganizationsUdfsVersionsVersion404Error1.cs` |
| `V1OrganizationsUdfsVersionsVersion409Error1` | `Models/V1OrganizationsUdfsVersionsVersion409Error1.cs` |
| `V1OrganizationsUdfsVersionsVersion500Error1` | `Models/V1OrganizationsUdfsVersionsVersion500Error1.cs` |

### UdfVersionList

- **Auth**: `options.BasicAuth`
- **Signature**: `UdfVersionList(Guid organizationId, string functionName, string? cursor, int? limit = 100, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - defaults: `limit` = `100`
- **Query params (wire ← C#)**: `cursor` ← `cursor`, `limit` ← `limit`
- **Returns**: `V1OrganizationsUdfsVersionsResponse1`
- **Error**: `SdkException<UdfVersionListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUdfsVersions400Error1(out V1OrganizationsUdfsVersions400Error1)` [400] · `TryGetV1OrganizationsUdfsVersions404Error1(out V1OrganizationsUdfsVersions404Error1)` [404] · `TryGetV1OrganizationsUdfsVersions500Error1(out V1OrganizationsUdfsVersions500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUdfsVersionsResponse1` | `Models/V1OrganizationsUdfsVersionsResponse1.cs` |
| `UdfVersionListError` | `Errors/UdfVersionListError.cs` |
| `V1OrganizationsUdfsVersions400Error1` | `Models/V1OrganizationsUdfsVersions400Error1.cs` |
| `V1OrganizationsUdfsVersions404Error1` | `Models/V1OrganizationsUdfsVersions404Error1.cs` |
| `V1OrganizationsUdfsVersions500Error1` | `Models/V1OrganizationsUdfsVersions500Error1.cs` |

