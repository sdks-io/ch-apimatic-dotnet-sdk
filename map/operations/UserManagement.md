<!-- Generated file — do not edit; regenerated with the SDK. -->

# UserManagement — operations

Accessor: `client.UserManagement` · Source: `Api/UserManagement.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### InvitationCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `InvitationCreate(Guid organizationId, InvitationPostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsInvitationsResponse1`
- **Error**: `SdkException<InvitationCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsInvitations400Error1(out V1OrganizationsInvitations400Error1)` [400] · `TryGetV1OrganizationsInvitations500Error1(out V1OrganizationsInvitations500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InvitationPostRequest` | `Models/InvitationPostRequest.cs` |
| `V1OrganizationsInvitationsResponse1` | `Models/V1OrganizationsInvitationsResponse1.cs` |
| `InvitationCreateError` | `Errors/InvitationCreateError.cs` |
| `V1OrganizationsInvitations400Error1` | `Models/V1OrganizationsInvitations400Error1.cs` |
| `V1OrganizationsInvitations500Error1` | `Models/V1OrganizationsInvitations500Error1.cs` |

### InvitationDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `InvitationDelete(Guid organizationId, Guid invitationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsInvitationsResponse3`
- **Error**: `SdkException<InvitationDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsInvitations400Error1(out V1OrganizationsInvitations400Error1)` [400] · `TryGetV1OrganizationsInvitations500Error1(out V1OrganizationsInvitations500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsInvitationsResponse3` | `Models/V1OrganizationsInvitationsResponse3.cs` |
| `InvitationDeleteError` | `Errors/InvitationDeleteError.cs` |
| `V1OrganizationsInvitations400Error1` | `Models/V1OrganizationsInvitations400Error1.cs` |
| `V1OrganizationsInvitations500Error1` | `Models/V1OrganizationsInvitations500Error1.cs` |

### InvitationGet

- **Auth**: `options.BasicAuth`
- **Signature**: `InvitationGet(Guid organizationId, Guid invitationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsInvitationsResponse1`
- **Error**: `SdkException<InvitationGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsInvitations400Error1(out V1OrganizationsInvitations400Error1)` [400] · `TryGetV1OrganizationsInvitations500Error1(out V1OrganizationsInvitations500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsInvitationsResponse1` | `Models/V1OrganizationsInvitationsResponse1.cs` |
| `InvitationGetError` | `Errors/InvitationGetError.cs` |
| `V1OrganizationsInvitations400Error1` | `Models/V1OrganizationsInvitations400Error1.cs` |
| `V1OrganizationsInvitations500Error1` | `Models/V1OrganizationsInvitations500Error1.cs` |

### InvitationGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `InvitationGetList(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsInvitationsResponse`
- **Error**: `SdkException<InvitationGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsInvitations400Error1(out V1OrganizationsInvitations400Error1)` [400] · `TryGetV1OrganizationsInvitations500Error1(out V1OrganizationsInvitations500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsInvitationsResponse` | `Models/V1OrganizationsInvitationsResponse.cs` |
| `InvitationGetListError` | `Errors/InvitationGetListError.cs` |
| `V1OrganizationsInvitations400Error1` | `Models/V1OrganizationsInvitations400Error1.cs` |
| `V1OrganizationsInvitations500Error1` | `Models/V1OrganizationsInvitations500Error1.cs` |

### MemberDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `MemberDelete(Guid organizationId, Guid userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsMembersResponse3`
- **Error**: `SdkException<MemberDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsMembers400Error1(out V1OrganizationsMembers400Error1)` [400] · `TryGetV1OrganizationsMembers500Error1(out V1OrganizationsMembers500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsMembersResponse3` | `Models/V1OrganizationsMembersResponse3.cs` |
| `MemberDeleteError` | `Errors/MemberDeleteError.cs` |
| `V1OrganizationsMembers400Error1` | `Models/V1OrganizationsMembers400Error1.cs` |
| `V1OrganizationsMembers500Error1` | `Models/V1OrganizationsMembers500Error1.cs` |

### MemberGet

- **Auth**: `options.BasicAuth`
- **Signature**: `MemberGet(Guid organizationId, Guid userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsMembersResponse1`
- **Error**: `SdkException<MemberGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsMembers400Error1(out V1OrganizationsMembers400Error1)` [400] · `TryGetV1OrganizationsMembers500Error1(out V1OrganizationsMembers500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsMembersResponse1` | `Models/V1OrganizationsMembersResponse1.cs` |
| `MemberGetError` | `Errors/MemberGetError.cs` |
| `V1OrganizationsMembers400Error1` | `Models/V1OrganizationsMembers400Error1.cs` |
| `V1OrganizationsMembers500Error1` | `Models/V1OrganizationsMembers500Error1.cs` |

### MemberGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `MemberGetList(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsMembersResponse`
- **Error**: `SdkException<MemberGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsMembers400Error1(out V1OrganizationsMembers400Error1)` [400] · `TryGetV1OrganizationsMembers500Error1(out V1OrganizationsMembers500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsMembersResponse` | `Models/V1OrganizationsMembersResponse.cs` |
| `MemberGetListError` | `Errors/MemberGetListError.cs` |
| `V1OrganizationsMembers400Error1` | `Models/V1OrganizationsMembers400Error1.cs` |
| `V1OrganizationsMembers500Error1` | `Models/V1OrganizationsMembers500Error1.cs` |

### MemberUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `MemberUpdate(Guid organizationId, Guid userId, MemberPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsMembersResponse1`
- **Error**: `SdkException<MemberUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsMembers400Error1(out V1OrganizationsMembers400Error1)` [400] · `TryGetV1OrganizationsMembers500Error1(out V1OrganizationsMembers500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MemberPatchRequest` | `Models/MemberPatchRequest.cs` |
| `V1OrganizationsMembersResponse1` | `Models/V1OrganizationsMembersResponse1.cs` |
| `MemberUpdateError` | `Errors/MemberUpdateError.cs` |
| `V1OrganizationsMembers400Error1` | `Models/V1OrganizationsMembers400Error1.cs` |
| `V1OrganizationsMembers500Error1` | `Models/V1OrganizationsMembers500Error1.cs` |

