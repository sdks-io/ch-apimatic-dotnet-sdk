<!-- Generated file — do not edit; regenerated with the SDK. -->

# RoleManagement — operations

Accessor: `client.RoleManagement` · Source: `Api/RoleManagement.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### OrganizationRoleDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationRoleDelete(Guid organizationId, Guid roleId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsRolesResponse4`
- **Error**: `SdkException<OrganizationRoleDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsRoles400Error1(out V1OrganizationsRoles400Error1)` [400] · `TryGetV1OrganizationsRoles500Error1(out V1OrganizationsRoles500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsRolesResponse4` | `Models/V1OrganizationsRolesResponse4.cs` |
| `OrganizationRoleDeleteError` | `Errors/OrganizationRoleDeleteError.cs` |
| `V1OrganizationsRoles400Error1` | `Models/V1OrganizationsRoles400Error1.cs` |
| `V1OrganizationsRoles500Error1` | `Models/V1OrganizationsRoles500Error1.cs` |

### OrganizationRoleGet

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationRoleGet(Guid organizationId, Guid roleId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsRolesResponse1`
- **Error**: `SdkException<OrganizationRoleGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsRoles400Error1(out V1OrganizationsRoles400Error1)` [400] · `TryGetV1OrganizationsRoles500Error1(out V1OrganizationsRoles500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsRolesResponse1` | `Models/V1OrganizationsRolesResponse1.cs` |
| `OrganizationRoleGetError` | `Errors/OrganizationRoleGetError.cs` |
| `V1OrganizationsRoles400Error1` | `Models/V1OrganizationsRoles400Error1.cs` |
| `V1OrganizationsRoles500Error1` | `Models/V1OrganizationsRoles500Error1.cs` |

### OrganizationRolePatch

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationRolePatch(Guid organizationId, Guid roleId, RoleUpdateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsRolesResponse1`
- **Error**: `SdkException<OrganizationRolePatchError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsRoles400Error1(out V1OrganizationsRoles400Error1)` [400] · `TryGetV1OrganizationsRoles500Error1(out V1OrganizationsRoles500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RoleUpdateRequest` | `Models/RoleUpdateRequest.cs` |
| `V1OrganizationsRolesResponse1` | `Models/V1OrganizationsRolesResponse1.cs` |
| `OrganizationRolePatchError` | `Errors/OrganizationRolePatchError.cs` |
| `V1OrganizationsRoles400Error1` | `Models/V1OrganizationsRoles400Error1.cs` |
| `V1OrganizationsRoles500Error1` | `Models/V1OrganizationsRoles500Error1.cs` |

### OrganizationRolePost

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationRolePost(Guid organizationId, RoleCreateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsRolesResponse1`
- **Error**: `SdkException<OrganizationRolePostError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsRoles400Error1(out V1OrganizationsRoles400Error1)` [400] · `TryGetV1OrganizationsRoles500Error1(out V1OrganizationsRoles500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RoleCreateRequest` | `Models/RoleCreateRequest.cs` |
| `V1OrganizationsRolesResponse1` | `Models/V1OrganizationsRolesResponse1.cs` |
| `OrganizationRolePostError` | `Errors/OrganizationRolePostError.cs` |
| `V1OrganizationsRoles400Error1` | `Models/V1OrganizationsRoles400Error1.cs` |
| `V1OrganizationsRoles500Error1` | `Models/V1OrganizationsRoles500Error1.cs` |

### OrganizationRolesGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `OrganizationRolesGetList(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsRolesResponse`
- **Error**: `SdkException<OrganizationRolesGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsRoles400Error1(out V1OrganizationsRoles400Error1)` [400] · `TryGetV1OrganizationsRoles500Error1(out V1OrganizationsRoles500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsRolesResponse` | `Models/V1OrganizationsRolesResponse.cs` |
| `OrganizationRolesGetListError` | `Errors/OrganizationRolesGetListError.cs` |
| `V1OrganizationsRoles400Error1` | `Models/V1OrganizationsRoles400Error1.cs` |
| `V1OrganizationsRoles500Error1` | `Models/V1OrganizationsRoles500Error1.cs` |

