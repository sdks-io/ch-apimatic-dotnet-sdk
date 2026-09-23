<!-- Generated file — do not edit; regenerated with the SDK. -->

# Billing — operations

Accessor: `client.Billing` · Source: `Api/Billing.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActiveBalancesGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ActiveBalancesGet(Guid organizationId, int? limit = 100, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `limit` = `100`, `offset` = `0`
- **Query params (wire ← C#)**: `limit` ← `limit`, `offset` ← `offset`
- **Returns**: `V1OrganizationsActiveBalancesResponse`
- **Error**: `SdkException<ActiveBalancesGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsActiveBalances400Error1(out V1OrganizationsActiveBalances400Error1)` [400] · `TryGetV1OrganizationsActiveBalances500Error1(out V1OrganizationsActiveBalances500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsActiveBalancesResponse` | `Models/V1OrganizationsActiveBalancesResponse.cs` |
| `ActiveBalancesGetError` | `Errors/ActiveBalancesGetError.cs` |
| `V1OrganizationsActiveBalances400Error1` | `Models/V1OrganizationsActiveBalances400Error1.cs` |
| `V1OrganizationsActiveBalances500Error1` | `Models/V1OrganizationsActiveBalances500Error1.cs` |

### CreditBalancesGet

- **Auth**: `options.BasicAuth`
- **Signature**: `CreditBalancesGet(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsCreditBalancesResponse`
- **Error**: `SdkException<CreditBalancesGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsCreditBalances400Error1(out V1OrganizationsCreditBalances400Error1)` [400] · `TryGetV1OrganizationsCreditBalances500Error1(out V1OrganizationsCreditBalances500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsCreditBalancesResponse` | `Models/V1OrganizationsCreditBalancesResponse.cs` |
| `CreditBalancesGetError` | `Errors/CreditBalancesGetError.cs` |
| `V1OrganizationsCreditBalances400Error1` | `Models/V1OrganizationsCreditBalances400Error1.cs` |
| `V1OrganizationsCreditBalances500Error1` | `Models/V1OrganizationsCreditBalances500Error1.cs` |

### UsageCostGet

- **Auth**: `options.BasicAuth`
- **Signature**: `UsageCostGet(Guid organizationId, DateTimeOffset fromDate, DateTimeOffset toDate, IReadOnlyList<string>? filter, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `from_date` ← `fromDate`, `to_date` ← `toDate`, `filter` ← `filter`
- **Returns**: `V1OrganizationsUsageCostResponse`
- **Error**: `SdkException<UsageCostGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsUsageCost400Error1(out V1OrganizationsUsageCost400Error1)` [400] · `TryGetV1OrganizationsUsageCost500Error1(out V1OrganizationsUsageCost500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsUsageCostResponse` | `Models/V1OrganizationsUsageCostResponse.cs` |
| `UsageCostGetError` | `Errors/UsageCostGetError.cs` |
| `V1OrganizationsUsageCost400Error1` | `Models/V1OrganizationsUsageCost400Error1.cs` |
| `V1OrganizationsUsageCost500Error1` | `Models/V1OrganizationsUsageCost500Error1.cs` |

