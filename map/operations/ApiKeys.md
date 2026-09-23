<!-- Generated file — do not edit; regenerated with the SDK. -->

# ApiKeys — operations

Accessor: `client.ApiKeys` · Source: `Api/ApiKeys.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### OpenapiKeyCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `OpenapiKeyCreate(Guid organizationId, ApiKeyPostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsKeysResponse1`
- **Error**: `SdkException<OpenapiKeyCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsKeys400Error1(out V1OrganizationsKeys400Error1)` [400] · `TryGetV1OrganizationsKeys500Error1(out V1OrganizationsKeys500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiKeyPostRequest` | `Models/ApiKeyPostRequest.cs` |
| `V1OrganizationsKeysResponse1` | `Models/V1OrganizationsKeysResponse1.cs` |
| `OpenapiKeyCreateError` | `Errors/OpenapiKeyCreateError.cs` |
| `V1OrganizationsKeys400Error1` | `Models/V1OrganizationsKeys400Error1.cs` |
| `V1OrganizationsKeys500Error1` | `Models/V1OrganizationsKeys500Error1.cs` |

### OpenapiKeyDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `OpenapiKeyDelete(Guid organizationId, Guid keyId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsKeysResponse4`
- **Error**: `SdkException<OpenapiKeyDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsKeys400Error1(out V1OrganizationsKeys400Error1)` [400] · `TryGetV1OrganizationsKeys500Error1(out V1OrganizationsKeys500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsKeysResponse4` | `Models/V1OrganizationsKeysResponse4.cs` |
| `OpenapiKeyDeleteError` | `Errors/OpenapiKeyDeleteError.cs` |
| `V1OrganizationsKeys400Error1` | `Models/V1OrganizationsKeys400Error1.cs` |
| `V1OrganizationsKeys500Error1` | `Models/V1OrganizationsKeys500Error1.cs` |

### OpenapiKeyGet

- **Auth**: `options.BasicAuth`
- **Signature**: `OpenapiKeyGet(Guid organizationId, Guid keyId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsKeysResponse2`
- **Error**: `SdkException<OpenapiKeyGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsKeys400Error1(out V1OrganizationsKeys400Error1)` [400] · `TryGetV1OrganizationsKeys500Error1(out V1OrganizationsKeys500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsKeysResponse2` | `Models/V1OrganizationsKeysResponse2.cs` |
| `OpenapiKeyGetError` | `Errors/OpenapiKeyGetError.cs` |
| `V1OrganizationsKeys400Error1` | `Models/V1OrganizationsKeys400Error1.cs` |
| `V1OrganizationsKeys500Error1` | `Models/V1OrganizationsKeys500Error1.cs` |

### OpenapiKeyGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `OpenapiKeyGetList(Guid organizationId, string? cursor, int? limit = 250, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cursor` — nullable, no default → **must pass explicitly**
  - defaults: `limit` = `250`
- **Query params (wire ← C#)**: `limit` ← `limit`, `cursor` ← `cursor`
- **Returns**: `V1OrganizationsKeysResponse`
- **Error**: `SdkException<OpenapiKeyGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsKeys400Error1(out V1OrganizationsKeys400Error1)` [400] · `TryGetV1OrganizationsKeys500Error1(out V1OrganizationsKeys500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsKeysResponse` | `Models/V1OrganizationsKeysResponse.cs` |
| `OpenapiKeyGetListError` | `Errors/OpenapiKeyGetListError.cs` |
| `V1OrganizationsKeys400Error1` | `Models/V1OrganizationsKeys400Error1.cs` |
| `V1OrganizationsKeys500Error1` | `Models/V1OrganizationsKeys500Error1.cs` |

### OpenapiKeyUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `OpenapiKeyUpdate(Guid organizationId, Guid keyId, ApiKeyPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsKeysResponse2`
- **Error**: `SdkException<OpenapiKeyUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsKeys400Error1(out V1OrganizationsKeys400Error1)` [400] · `TryGetV1OrganizationsKeys500Error1(out V1OrganizationsKeys500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ApiKeyPatchRequest` | `Models/ApiKeyPatchRequest.cs` |
| `V1OrganizationsKeysResponse2` | `Models/V1OrganizationsKeysResponse2.cs` |
| `OpenapiKeyUpdateError` | `Errors/OpenapiKeyUpdateError.cs` |
| `V1OrganizationsKeys400Error1` | `Models/V1OrganizationsKeys400Error1.cs` |
| `V1OrganizationsKeys500Error1` | `Models/V1OrganizationsKeys500Error1.cs` |

