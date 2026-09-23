# Reference

> Source: [OpenApiSpecForClickHouseCloudClient](OpenApiSpecForClickHouseCloudClient.cs)

## ApiKeys

> Source: [ApiKeys](Api/ApiKeys.cs)

<details>
<summary><code>Task&lt;V1OrganizationsKeysResponse1&gt; OpenapiKeyCreate(Guid organizationId, ApiKeyPostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates new API key.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeys.OpenapiKeyCreate(organizationId, body);
    // TODO: Handle 'response' of type V1OrganizationsKeysResponse1
}
catch (SdkException<OpenapiKeyCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsKeys400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsKeys400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that will own the key. |
| <code>body</code> | <code>[ApiKeyPostRequest?](Models/ApiKeyPostRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsKeysResponse1](Models/V1OrganizationsKeysResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OpenapiKeyCreateError](Errors/OpenapiKeyCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsKeysResponse4&gt; OpenapiKeyDelete(Guid organizationId, Guid keyId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes API key. Only a key not used to authenticate the active request can be deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeys.OpenapiKeyDelete(organizationId, keyId);
    // TODO: Handle 'response' of type V1OrganizationsKeysResponse4
}
catch (SdkException<OpenapiKeyDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsKeys400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsKeys400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the key. |
| <code>keyId</code> | <code>Guid</code> | ID of the key to delete. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsKeysResponse4](Models/V1OrganizationsKeysResponse4.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OpenapiKeyDeleteError](Errors/OpenapiKeyDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsKeysResponse2&gt; OpenapiKeyGet(Guid organizationId, Guid keyId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single key details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeys.OpenapiKeyGet(organizationId, keyId);
    // TODO: Handle 'response' of type V1OrganizationsKeysResponse2
}
catch (SdkException<OpenapiKeyGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsKeys400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsKeys400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>keyId</code> | <code>Guid</code> | ID of the requested key. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsKeysResponse2](Models/V1OrganizationsKeysResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OpenapiKeyGetError](Errors/OpenapiKeyGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsKeysResponse&gt; OpenapiKeyGetList(Guid organizationId, string? cursor, int? limit = 250, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of keys in the organization, ordered by creation date, oldest first. Results are capped at `limit` (default and maximum 250) per page. Every response carries `limit`, `totalCount` and `nextCursor`; pass `nextCursor` as the `cursor` query parameter to fetch the next page, repeating until it is null.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeys.OpenapiKeyGetList(organizationId, cursor);
    // TODO: Handle 'response' of type V1OrganizationsKeysResponse
}
catch (SdkException<OpenapiKeyGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsKeys400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsKeys400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>cursor</code> | <code>string?</code> | Opaque cursor from a previous response's `nextCursor`, marking where to resume the list. |
| <code>limit</code> | <code>int?</code> | Maximum number of results to return.<br>**Default**: 250 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsKeysResponse](Models/V1OrganizationsKeysResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OpenapiKeyGetListError](Errors/OpenapiKeyGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsKeysResponse2&gt; OpenapiKeyUpdate(Guid organizationId, Guid keyId, ApiKeyPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates API key properties.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ApiKeys.OpenapiKeyUpdate(organizationId, keyId, body);
    // TODO: Handle 'response' of type V1OrganizationsKeysResponse2
}
catch (SdkException<OpenapiKeyUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsKeys400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsKeys400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the key. |
| <code>keyId</code> | <code>Guid</code> | ID of the key to update. |
| <code>body</code> | <code>[ApiKeyPatchRequest?](Models/ApiKeyPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsKeysResponse2](Models/V1OrganizationsKeysResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OpenapiKeyUpdateError](Errors/OpenapiKeyUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## BackupApi

> Source: [BackupApi](Api/BackupApi.cs)

<details>
<summary><code>Task&lt;V1OrganizationsServicesBackupBucketResponse&gt; BackupBucketCreate(Guid organizationId, Guid serviceId, BackupBucketPostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Create service backup bucket. Requires ADMIN auth key role.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BackupApi.BackupBucketCreate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesBackupBucketResponse
}
catch (SdkException<BackupBucketCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesBackupBucket400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesBackupBucket400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>body</code> | <code>[BackupBucketPostRequest?](Models/AnyOf/BackupBucketPostRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesBackupBucketResponse](Models/V1OrganizationsServicesBackupBucketResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BackupBucketCreateError](Errors/BackupBucketCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesBackupBucketResponse3&gt; BackupBucketDelete(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Delete service backup bucket. Requires ADMIN auth key role.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BackupApi.BackupBucketDelete(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesBackupBucketResponse3
}
catch (SdkException<BackupBucketDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesBackupBucket400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesBackupBucket400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesBackupBucketResponse3](Models/V1OrganizationsServicesBackupBucketResponse3.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BackupBucketDeleteError](Errors/BackupBucketDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesBackupBucketResponse&gt; BackupBucketGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns the service backup bucket.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BackupApi.BackupBucketGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesBackupBucketResponse
}
catch (SdkException<BackupBucketGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesBackupBucket400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesBackupBucket400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesBackupBucketResponse](Models/V1OrganizationsServicesBackupBucketResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BackupBucketGetError](Errors/BackupBucketGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesBackupBucketResponse&gt; BackupBucketUpdate(Guid organizationId, Guid serviceId, BackupBucketPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Update service backup bucket. Requires ADMIN auth key role. The secrets of the specified bucket provider are always required

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BackupApi.BackupBucketUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesBackupBucketResponse
}
catch (SdkException<BackupBucketUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesBackupBucket400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesBackupBucket400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>body</code> | <code>[BackupBucketPatchRequest?](Models/AnyOf/BackupBucketPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesBackupBucketResponse](Models/V1OrganizationsServicesBackupBucketResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BackupBucketUpdateError](Errors/BackupBucketUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesBackupConfigurationResponse&gt; BackupConfigurationGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the service backup configuration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BackupApi.BackupConfigurationGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesBackupConfigurationResponse
}
catch (SdkException<BackupConfigurationGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesBackupConfiguration400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesBackupConfiguration400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesBackupConfigurationResponse](Models/V1OrganizationsServicesBackupConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BackupConfigurationGetError](Errors/BackupConfigurationGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesBackupConfigurationResponse&gt; BackupConfigurationUpdate(Guid organizationId, Guid serviceId, BackupConfigurationPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates service backup configuration. Requires ADMIN auth key role. Setting the properties with null value, will reset the properties to theirs default values.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BackupApi.BackupConfigurationUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesBackupConfigurationResponse
}
catch (SdkException<BackupConfigurationUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesBackupConfiguration400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesBackupConfiguration400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |
| <code>body</code> | <code>[BackupConfigurationPatchRequest?](Models/BackupConfigurationPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesBackupConfigurationResponse](Models/V1OrganizationsServicesBackupConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BackupConfigurationUpdateError](Errors/BackupConfigurationUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesBackupsBackupIdResponse&gt; BackupGet(Guid organizationId, Guid serviceId, Guid backupId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single backup info.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BackupApi.BackupGet(organizationId, serviceId, backupId);
    // TODO: Handle 'response' of type V1OrganizationsServicesBackupsBackupIdResponse
}
catch (SdkException<BackupGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesBackupsBackupId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesBackupsBackupId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the backup. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service the backup was created from. |
| <code>backupId</code> | <code>Guid</code> | ID of the requested backup. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesBackupsBackupIdResponse](Models/V1OrganizationsServicesBackupsBackupIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BackupGetError](Errors/BackupGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesBackupsResponse&gt; BackupGetList(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all backups for the service. The most recent backups comes first in the list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.BackupApi.BackupGetList(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesBackupsResponse
}
catch (SdkException<BackupGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesBackups400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesBackups400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the backup. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service the backup was created from. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesBackupsResponse](Models/V1OrganizationsServicesBackupsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[BackupGetListError](Errors/BackupGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Billing

> Source: [Billing](Api/Billing.cs)

<details>
<summary><code>Task&lt;V1OrganizationsActiveBalancesResponse&gt; ActiveBalancesGet(Guid organizationId, int? limit = 100, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

DEPRECATED. Use the `/v1/organizations/{organizationId}/creditBalances` endpoint instead. <br /><br /> Returns the active prepaid credit balances for the organization, each with its own balance ID and remaining credits, along with the total remaining credits across all active balances. A balance is active when it has started, has not expired, and has credits remaining. Balances are ordered by expiration date, soonest first, and the returned page is capped at `limit` (default and maximum 100). When `totalCount` exceeds the number of returned balances, page with `limit`/`offset` to retrieve them all. `totalRemainingPrepaidCredits` always covers every active balance, not just the returned page.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.ActiveBalancesGet(organizationId);
    // TODO: Handle 'response' of type V1OrganizationsActiveBalancesResponse
}
catch (SdkException<ActiveBalancesGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsActiveBalances400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsActiveBalances400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>limit</code> | <code>int?</code> | Maximum number of results to return.<br>**Default**: 100 |
| <code>offset</code> | <code>int?</code> | Number of results to skip before returning.<br>**Default**: 0 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsActiveBalancesResponse](Models/V1OrganizationsActiveBalancesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActiveBalancesGetError](Errors/ActiveBalancesGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsCreditBalancesResponse&gt; CreditBalancesGet(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the active credit balances for the organization, each with its own balance ID, type and remaining credits, along with the total remaining credits across all of them. A balance is active when it has started, has not expired, and has credits remaining. Balances are ordered by expiration date, soonest first. The list is always present and is empty when the organization has no active balances.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.CreditBalancesGet(organizationId);
    // TODO: Handle 'response' of type V1OrganizationsCreditBalancesResponse
}
catch (SdkException<CreditBalancesGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsCreditBalances400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsCreditBalances400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsCreditBalancesResponse](Models/V1OrganizationsCreditBalancesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[CreditBalancesGetError](Errors/CreditBalancesGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUsageCostResponse&gt; UsageCostGet(Guid organizationId, DateTimeOffset fromDate, DateTimeOffset toDate, IReadOnlyList&lt;string&gt;? filter, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a grand total and a list of daily, per-entity organization usage cost records for the organization in the queried time period (maximum 31 days). All days in both the request and the response are evaluated based on the UTC timezone.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Billing.UsageCostGet(organizationId, fromDate, toDate, filter);
    // TODO: Handle 'response' of type V1OrganizationsUsageCostResponse
}
catch (SdkException<UsageCostGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUsageCost400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUsageCost400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>fromDate</code> | <code>DateTimeOffset</code> | Start date for the report, e.g. 2024-12-19. |
| <code>toDate</code> | <code>DateTimeOffset</code> | End date (inclusive) for the report, e.g. 2024-12-20. This date cannot be more than 30 days after from_date (for a maximum queried period of 31 days). |
| <code>filter</code> | <code>IReadOnlyList&lt;string&gt;?</code> | Filter criteria to apply when retrieving the usage cost report. Currently, only filtering by resource tags is supported. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUsageCostResponse](Models/V1OrganizationsUsageCostResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UsageCostGetError](Errors/UsageCostGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClickPipes

> Source: [ClickPipes](Api/ClickPipes.cs)

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesCdcScalingResponse&gt; ClickPipeCdcScalingGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get scaling settings for database ClickPipes (PostgreSQL, MySQL, MongoDB, BigQuery).

The infrastructure is shared between all database ClickPipes in the service, both for initial load and CDC. For billing purposes, 2 CPU cores and 8 GB of RAM [correspond](https://clickhouse.com/docs/cloud/manage/billing/overview#clickpipes-for-postgres-cdc) to one compute unit.

**Note:** For Kafka, Kinesis, and object storage pipes (S3, GCS, Azure Blob), see [Get ClickPipe](#tag/ClickPipes/operation/clickPipeGet).

**This endpoint becomes available once at least one database ClickPipe was provisioned.**

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeCdcScalingGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesCdcScalingResponse
}
catch (SdkException<ClickPipeCdcScalingGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesCdcScaling400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesCdcScaling400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the ClickPipe. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesCdcScalingResponse](Models/V1OrganizationsServicesClickpipesCdcScalingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeCdcScalingGetError](Errors/ClickPipeCdcScalingGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesCdcScalingResponse&gt; ClickPipeCdcScalingUpdate(Guid organizationId, Guid serviceId, ClickPipesCdcScalingPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update scaling settings for database ClickPipes (PostgreSQL, MySQL, MongoDB, BigQuery).

The infrastructure is shared between all database ClickPipes in the service, both for initial load and CDC. Scaling settings may take a few minutes to fully propagate.

For billing purposes, 2 CPU cores and 8 GB of RAM [correspond](https://clickhouse.com/docs/cloud/manage/billing/overview#clickpipes-for-postgres-cdc) to one compute unit. If your organization tier changes, database ClickPipes will be [rescaled](https://clickhouse.com/docs/cloud/manage/billing/overview#compute) appropriately.

**Note:** For Kafka, Kinesis, and object storage pipes (S3, GCS, Azure Blob), see [Get ClickPipe](#tag/ClickPipes/operation/clickPipeGet).

**This endpoint becomes available once at least one database ClickPipe was provisioned.**

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeCdcScalingUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesCdcScalingResponse
}
catch (SdkException<ClickPipeCdcScalingUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesCdcScaling400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesCdcScaling400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the ClickPipe. |
| <code>body</code> | <code>[ClickPipesCdcScalingPatchRequest?](Models/ClickPipesCdcScalingPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesCdcScalingResponse](Models/V1OrganizationsServicesClickpipesCdcScalingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeCdcScalingUpdateError](Errors/ClickPipeCdcScalingUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesResponse1&gt; ClickPipeCreate(Guid organizationId, Guid serviceId, ClickPipePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new ClickPipe.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeCreate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesResponse1
}
catch (SdkException<ClickPipeCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipes400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipes400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service to create the ClickPipe for. |
| <code>body</code> | <code>[ClickPipePostRequest?](Models/ClickPipePostRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesResponse1](Models/V1OrganizationsServicesClickpipesResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeCreateError](Errors/ClickPipeCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesClickPipeIdResponse2&gt; ClickPipeDelete(Guid organizationId, Guid serviceId, Guid clickPipeId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete the specified ClickPipe.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeDelete(organizationId, serviceId, clickPipeId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesClickPipeIdResponse2
}
catch (SdkException<ClickPipeDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesClickPipeId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesClickPipeId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the ClickPipe. |
| <code>clickPipeId</code> | <code>Guid</code> | ID of the ClickPipe to delete. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesClickPipeIdResponse2](Models/V1OrganizationsServicesClickpipesClickPipeIdResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeDeleteError](Errors/ClickPipeDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesClickPipeIdResponse&gt; ClickPipeGet(Guid organizationId, Guid serviceId, Guid clickPipeId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the specified ClickPipe.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeGet(organizationId, serviceId, clickPipeId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesClickPipeIdResponse
}
catch (SdkException<ClickPipeGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesClickPipeId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesClickPipeId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the ClickPipe. |
| <code>clickPipeId</code> | <code>Guid</code> | ID of the requested ClickPipe. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesClickPipeIdResponse](Models/V1OrganizationsServicesClickpipesClickPipeIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeGetError](Errors/ClickPipeGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesResponse&gt; ClickPipeGetList(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of ClickPipes.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeGetList(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesResponse
}
catch (SdkException<ClickPipeGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipes400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipes400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the ClickPipe. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesResponse](Models/V1OrganizationsServicesClickpipesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeGetListError](Errors/ClickPipeGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1&gt; ClickPipeReversePrivateEndpointCreate(Guid organizationId, Guid serviceId, CreateReversePrivateEndpoint? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new reverse private endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeReversePrivateEndpointCreate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1
}
catch (SdkException<ClickPipeReversePrivateEndpointCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the Reverse Private Endpoint. |
| <code>body</code> | <code>[CreateReversePrivateEndpoint?](Models/CreateReversePrivateEndpoint.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1](Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeReversePrivateEndpointCreateError](Errors/ClickPipeReversePrivateEndpointCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1&gt; ClickPipeReversePrivateEndpointDelete(Guid organizationId, Guid serviceId, Guid reversePrivateEndpointId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete the reverse private endpoint with the specified ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeReversePrivateEndpointDelete(organizationId,
        serviceId,
        reversePrivateEndpointId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1
}
catch (SdkException<ClickPipeReversePrivateEndpointDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the Reverse Private Endpoint. |
| <code>reversePrivateEndpointId</code> | <code>Guid</code> | ID of the reverse private endpoint to delete. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1](Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeReversePrivateEndpointDeleteError](Errors/ClickPipeReversePrivateEndpointDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse&gt; ClickPipeReversePrivateEndpointGet(Guid organizationId, Guid serviceId, Guid reversePrivateEndpointId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the reverse private endpoint with the specified ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeReversePrivateEndpointGet(organizationId,
        serviceId,
        reversePrivateEndpointId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse
}
catch (SdkException<ClickPipeReversePrivateEndpointGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the Reverse Private Endpoint. |
| <code>reversePrivateEndpointId</code> | <code>Guid</code> | ID of the reverse private endpoint to get. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse](Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeReversePrivateEndpointGetError](Errors/ClickPipeReversePrivateEndpointGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse&gt; ClickPipeReversePrivateEndpointGetList(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of reverse private endpoints for the specified service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeReversePrivateEndpointGetList(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse
}
catch (SdkException<ClickPipeReversePrivateEndpointGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the Reverse Private Endpoint. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse](Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeReversePrivateEndpointGetListError](Errors/ClickPipeReversePrivateEndpointGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse&gt; ClickPipeReversePrivateEndpointUpdate(Guid organizationId, Guid serviceId, Guid reversePrivateEndpointId, UpdateReversePrivateEndpoint? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update mutable fields for an existing reverse private endpoint. customPrivateDnsMappings is a full replacement list. Use an empty array to clear mappings.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeReversePrivateEndpointUpdate(organizationId,
        serviceId,
        reversePrivateEndpointId,
        body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse
}
catch (SdkException<ClickPipeReversePrivateEndpointUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the Reverse Private Endpoint. |
| <code>reversePrivateEndpointId</code> | <code>Guid</code> | ID of the reverse private endpoint to update. |
| <code>body</code> | <code>[UpdateReversePrivateEndpoint?](Models/UpdateReversePrivateEndpoint.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse](Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeReversePrivateEndpointUpdateError](Errors/ClickPipeReversePrivateEndpointUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesClickPipeIdScalingResponse&gt; ClickPipeScalingUpdate(Guid organizationId, Guid serviceId, Guid clickPipeId, ClickPipeScalingPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Change scaling settings for the specified ClickPipe. This endpoint supports Kafka, Kinesis, and object storage pipes (S3, GCS, Azure Blob).

**Note:** For database ClickPipes (PostgreSQL, MySQL, MongoDB, BigQuery), use the [Update CDC ClickPipes scaling](#tag/ClickPipes/operation/clickPipeCdcScalingUpdate) endpoint instead.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeScalingUpdate(organizationId, serviceId, clickPipeId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesClickPipeIdScalingResponse
}
catch (SdkException<ClickPipeScalingUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesClickPipeIdScaling400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesClickPipeIdScaling400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the ClickPipe. |
| <code>clickPipeId</code> | <code>Guid</code> | ID of the ClickPipe to update scaling settings. |
| <code>body</code> | <code>[ClickPipeScalingPatchRequest?](Models/ClickPipeScalingPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesClickPipeIdScalingResponse](Models/V1OrganizationsServicesClickpipesClickPipeIdScalingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeScalingUpdateError](Errors/ClickPipeScalingUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesSchemaDiscoveryResponse&gt; ClickPipeSchemaDiscovery(Guid organizationId, Guid serviceId, ClickPipeSchemaDiscoveryRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Infers the schema (field names and ClickHouse data types) of a ClickPipe source without creating a pipe. Supported for Kafka, Kinesis, Pub/Sub, and object storage sources. Object storage inference runs on the destination service, which must be running.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeSchemaDiscovery(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesSchemaDiscoveryResponse
}
catch (SdkException<ClickPipeSchemaDiscoveryError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesSchemaDiscovery400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesSchemaDiscovery400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service to run schema discovery against. |
| <code>body</code> | <code>[ClickPipeSchemaDiscoveryRequest?](Models/ClickPipeSchemaDiscoveryRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesSchemaDiscoveryResponse](Models/V1OrganizationsServicesClickpipesSchemaDiscoveryResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeSchemaDiscoveryError](Errors/ClickPipeSchemaDiscoveryError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse&gt; ClickPipeSettingsGet(Guid organizationId, Guid serviceId, Guid clickPipeId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the advanced settings for the specified ClickPipe.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeSettingsGet(organizationId, serviceId, clickPipeId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse
}
catch (SdkException<ClickPipeSettingsGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesClickPipeIdSettings400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the ClickPipe. |
| <code>clickPipeId</code> | <code>Guid</code> | ID of the ClickPipe to get settings for. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse](Models/V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeSettingsGetError](Errors/ClickPipeSettingsGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse&gt; ClickPipeSettingsUpdate(Guid organizationId, Guid serviceId, Guid clickPipeId, ClickPipeSettingsPutRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the advanced settings for the specified ClickPipe. Send key-value pairs where values can be strings, numbers, or booleans.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeSettingsUpdate(organizationId, serviceId, clickPipeId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse
}
catch (SdkException<ClickPipeSettingsUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesClickPipeIdSettings400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the ClickPipe. |
| <code>clickPipeId</code> | <code>Guid</code> | ID of the ClickPipe to update settings for. |
| <code>body</code> | <code>[ClickPipeSettingsPutRequest?](Models/ClickPipeSettingsPutRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse](Models/V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeSettingsUpdateError](Errors/ClickPipeSettingsUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesClickPipeIdStateResponse&gt; ClickPipeStateUpdate(Guid organizationId, Guid serviceId, Guid clickPipeId, ClickPipeStatePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Start, stop or resync ClickPipe. Stopping a ClickPipe will stop the ingestion process from any state. Starting is allowed for ClickPipes in the "Stopped" state or with a "Failed" state. Resyncing is only for Postgres and MySQL pipes and can be done from any state.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeStateUpdate(organizationId, serviceId, clickPipeId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesClickPipeIdStateResponse
}
catch (SdkException<ClickPipeStateUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesClickPipeIdState400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesClickPipeIdState400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service that owns the ClickPipe. |
| <code>clickPipeId</code> | <code>Guid</code> | ID of the ClickPipe to update state. |
| <code>body</code> | <code>[ClickPipeStatePatchRequest?](Models/ClickPipeStatePatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesClickPipeIdStateResponse](Models/V1OrganizationsServicesClickpipesClickPipeIdStateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeStateUpdateError](Errors/ClickPipeStateUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesClickPipeIdResponse&gt; ClickPipeUpdate(Guid organizationId, Guid serviceId, Guid clickPipeId, ClickPipePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the specified ClickPipe. Source fields not present in the per-source update schemas are immutable after creation. For Kafka sources, values submitted for immutable fields (type, format, brokers, topics, consumerGroup, offset, schemaRegistry, exactlyOnce) are not applied, except schema registry credentials, which are rejected.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipeUpdate(organizationId, serviceId, clickPipeId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesClickPipeIdResponse
}
catch (SdkException<ClickPipeUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesClickPipeId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesClickPipeId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service to create the ClickPipe for. |
| <code>clickPipeId</code> | <code>Guid</code> | ID of the requested ClickPipe. |
| <code>body</code> | <code>[ClickPipePatchRequest?](Models/ClickPipePatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesClickPipeIdResponse](Models/V1OrganizationsServicesClickpipesClickPipeIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipeUpdateError](Errors/ClickPipeUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickpipesContextResponse&gt; ClickPipesServiceContextGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns service-level ClickPipes capabilities and Private Preview workload identity context, including the GCP service account to grant access to customer source resources.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickPipes.ClickPipesServiceContextGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickpipesContextResponse
}
catch (SdkException<ClickPipesServiceContextGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickpipesContext400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickpipesContext400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service to get ClickPipes context for. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickpipesContextResponse](Models/V1OrganizationsServicesClickpipesContextResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickPipesServiceContextGetError](Errors/ClickPipesServiceContextGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClickStack

> Source: [ClickStack](Api/ClickStack.cs)

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackAlertsResponse1&gt; ClickStackCreateAlert(Guid organizationId, Guid serviceId, ClickStackCreateAlertRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new alert

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackCreateAlert(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackAlertsResponse1
}
catch (SdkException<ClickStackCreateAlertError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackAlerts400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackAlerts400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>body</code> | <code>[ClickStackCreateAlertRequest?](Models/ClickStackCreateAlertRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackAlertsResponse1](Models/V1OrganizationsServicesClickstackAlertsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackCreateAlertError](Errors/ClickStackCreateAlertError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackDashboardsResponse1&gt; ClickStackCreateDashboard(Guid organizationId, Guid serviceId, ClickStackCreateDashboardRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new dashboard

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackCreateDashboard(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackDashboardsResponse1
}
catch (SdkException<ClickStackCreateDashboardError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackDashboards400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackDashboards400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>body</code> | <code>[ClickStackCreateDashboardRequest?](Models/ClickStackCreateDashboardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackDashboardsResponse1](Models/V1OrganizationsServicesClickstackDashboardsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackCreateDashboardError](Errors/ClickStackCreateDashboardError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackRolesResponse1&gt; ClickStackCreateRole(Guid organizationId, Guid serviceId, ClickStackCreateRoleRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new custom role for the team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackCreateRole(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackRolesResponse1
}
catch (SdkException<ClickStackCreateRoleError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackRoles400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackRoles400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>body</code> | <code>[ClickStackCreateRoleRequest?](Models/ClickStackCreateRoleRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackRolesResponse1](Models/V1OrganizationsServicesClickstackRolesResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackCreateRoleError](Errors/ClickStackCreateRoleError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackSavedSearchesResponse1&gt; ClickStackCreateSavedSearch(Guid organizationId, Guid serviceId, ClickStackSavedSearchInput? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new saved search.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackCreateSavedSearch(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackSavedSearchesResponse1
}
catch (SdkException<ClickStackCreateSavedSearchError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackSavedSearches400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackSavedSearches400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>body</code> | <code>[ClickStackSavedSearchInput?](Models/ClickStackSavedSearchInput.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackSavedSearchesResponse1](Models/V1OrganizationsServicesClickstackSavedSearchesResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackCreateSavedSearchError](Errors/ClickStackCreateSavedSearchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackSourcesResponse1&gt; ClickStackCreateSource(Guid organizationId, Guid serviceId, ClickStackSource? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new source.  The request body is a source object without the `id` field. If an `id` is sent anyway it is silently ignored (stripped before validation — the request is never rejected because of it). Granularity fields (`materializedViews[].minGranularity` and `metadataMaterializedViews.granularity`) accept the same short format the API returns (e.g. `5m`, `15s`, `1h`, `1d`).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackCreateSource(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackSourcesResponse1
}
catch (SdkException<ClickStackCreateSourceError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackSources400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackSources400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>body</code> | <code>[ClickStackSource?](Models/AnyOf/ClickStackSource.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackSourcesResponse1](Models/V1OrganizationsServicesClickstackSourcesResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackCreateSourceError](Errors/ClickStackCreateSourceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackWebhooksResponse1&gt; ClickStackCreateWebhook(Guid organizationId, Guid serviceId, ClickStackWebhookInput? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Creates a new webhook for the authenticated team.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackCreateWebhook(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackWebhooksResponse1
}
catch (SdkException<ClickStackCreateWebhookError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackWebhooks400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackWebhooks400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>body</code> | <code>[ClickStackWebhookInput?](Models/ClickStackWebhookInput.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackWebhooksResponse1](Models/V1OrganizationsServicesClickstackWebhooksResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackCreateWebhookError](Errors/ClickStackCreateWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2&gt; ClickStackDeleteAlert(Guid organizationId, Guid serviceId, string clickStackAlertId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes an alert

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackDeleteAlert(organizationId, serviceId, clickStackAlertId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2
}
catch (SdkException<ClickStackDeleteAlertError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackAlertId</code> | <code>string</code> | ClickStack Alert ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2](Models/V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackDeleteAlertError](Errors/ClickStackDeleteAlertError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2&gt; ClickStackDeleteDashboard(Guid organizationId, Guid serviceId, string clickStackDashboardId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes a dashboard

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackDeleteDashboard(organizationId, serviceId, clickStackDashboardId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2
}
catch (SdkException<ClickStackDeleteDashboardError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackDashboardId</code> | <code>string</code> | ClickStack Dashboard ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2](Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackDeleteDashboardError](Errors/ClickStackDeleteDashboardError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2&gt; ClickStackDeleteRole(Guid organizationId, Guid serviceId, string clickStackRoleId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes a custom role. Predefined roles, the team default user role, and roles assigned to users cannot be deleted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackDeleteRole(organizationId, serviceId, clickStackRoleId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2
}
catch (SdkException<ClickStackDeleteRoleError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackRoleId</code> | <code>string</code> | id parameter |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2](Models/V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackDeleteRoleError](Errors/ClickStackDeleteRoleError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2&gt; ClickStackDeleteSavedSearch(Guid organizationId, Guid serviceId, string clickStackSavedSearchId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes a saved search and any alerts attached to it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackDeleteSavedSearch(organizationId,
        serviceId,
        clickStackSavedSearchId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2
}
catch (SdkException<ClickStackDeleteSavedSearchError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackSavedSearchId</code> | <code>string</code> | Saved search ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2](Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackDeleteSavedSearchError](Errors/ClickStackDeleteSavedSearchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2&gt; ClickStackDeleteSource(Guid organizationId, Guid serviceId, string clickStackSourceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes a source

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackDeleteSource(organizationId, serviceId, clickStackSourceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2
}
catch (SdkException<ClickStackDeleteSourceError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackSourceId</code> | <code>string</code> | Source ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2](Models/V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackDeleteSourceError](Errors/ClickStackDeleteSourceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1&gt; ClickStackDeleteWebhook(Guid organizationId, Guid serviceId, string clickStackWebhookId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Deletes a webhook. Blocked with a 409 while any alert still references it — reassign or remove those alerts first — so deletion never leaves an alert pointing at a missing webhook (which would silently drop notifications). Mirrors the internal webhook delete guard.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackDeleteWebhook(organizationId, serviceId, clickStackWebhookId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1
}
catch (SdkException<ClickStackDeleteWebhookError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackWebhookId</code> | <code>string</code> | Webhook ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1](Models/V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackDeleteWebhookError](Errors/ClickStackDeleteWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse&gt; ClickStackGetAlert(Guid organizationId, Guid serviceId, string clickStackAlertId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a specific alert by ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackGetAlert(organizationId, serviceId, clickStackAlertId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse
}
catch (SdkException<ClickStackGetAlertError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackAlertId</code> | <code>string</code> | ClickStack Alert ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse](Models/V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackGetAlertError](Errors/ClickStackGetAlertError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse&gt; ClickStackGetDashboard(Guid organizationId, Guid serviceId, string clickStackDashboardId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a specific dashboard by ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackGetDashboard(organizationId, serviceId, clickStackDashboardId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse
}
catch (SdkException<ClickStackGetDashboardError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackDashboardId</code> | <code>string</code> | ClickStack Dashboard ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse](Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackGetDashboardError](Errors/ClickStackGetDashboardError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse&gt; ClickStackGetRole(Guid organizationId, Guid serviceId, string clickStackRoleId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a specific role by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackGetRole(organizationId, serviceId, clickStackRoleId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse
}
catch (SdkException<ClickStackGetRoleError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackRoleId</code> | <code>string</code> | id parameter |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse](Models/V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackGetRoleError](Errors/ClickStackGetRoleError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse&gt; ClickStackGetSavedSearch(Guid organizationId, Guid serviceId, string clickStackSavedSearchId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a specific saved search by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackGetSavedSearch(organizationId, serviceId, clickStackSavedSearchId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse
}
catch (SdkException<ClickStackGetSavedSearchError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackSavedSearchId</code> | <code>string</code> | Saved search ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse](Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackGetSavedSearchError](Errors/ClickStackGetSavedSearchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse&gt; ClickStackGetSource(Guid organizationId, Guid serviceId, string clickStackSourceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a specific source by ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackGetSource(organizationId, serviceId, clickStackSourceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse
}
catch (SdkException<ClickStackGetSourceError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackSourceId</code> | <code>string</code> | Source ID |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse](Models/V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackGetSourceError](Errors/ClickStackGetSourceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackAlertsResponse&gt; ClickStackListAlerts(Guid organizationId, Guid serviceId, int? limit = 1000, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves alerts for the authenticated team (paginated). Results are capped at `limit` (default and maximum 1000). When `totalCount` exceeds the number of returned items, page with `limit`/`offset` to retrieve them all.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackListAlerts(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackAlertsResponse
}
catch (SdkException<ClickStackListAlertsError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackAlerts400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackAlerts400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>limit</code> | <code>int?</code> | Maximum number of results to return.<br>**Default**: 1000 |
| <code>offset</code> | <code>int?</code> | Number of results to skip before returning.<br>**Default**: 0 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackAlertsResponse](Models/V1OrganizationsServicesClickstackAlertsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackListAlertsError](Errors/ClickStackListAlertsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackDashboardsResponse&gt; ClickStackListDashboards(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a list of all dashboards for the authenticated team

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackListDashboards(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackDashboardsResponse
}
catch (SdkException<ClickStackListDashboardsError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackDashboards400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackDashboards400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackDashboardsResponse](Models/V1OrganizationsServicesClickstackDashboardsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackListDashboardsError](Errors/ClickStackListDashboardsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackRolesResponse&gt; ClickStackListRoles(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves all roles for the authenticated team, including predefined roles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackListRoles(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackRolesResponse
}
catch (SdkException<ClickStackListRolesError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackRoles400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackRoles400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackRolesResponse](Models/V1OrganizationsServicesClickstackRolesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackListRolesError](Errors/ClickStackListRolesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackSavedSearchesResponse&gt; ClickStackListSavedSearches(Guid organizationId, Guid serviceId, int? limit = 1000, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves saved searches for the authenticated team (paginated). Results are capped at `limit` (default and maximum 1000). When `totalCount` exceeds the number of returned items, page with `limit`/`offset` to retrieve them all.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackListSavedSearches(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackSavedSearchesResponse
}
catch (SdkException<ClickStackListSavedSearchesError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackSavedSearches400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackSavedSearches400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>limit</code> | <code>int?</code> | Maximum number of results to return.<br>**Default**: 1000 |
| <code>offset</code> | <code>int?</code> | Number of results to skip before returning.<br>**Default**: 0 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackSavedSearchesResponse](Models/V1OrganizationsServicesClickstackSavedSearchesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackListSavedSearchesError](Errors/ClickStackListSavedSearchesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackSourcesResponse&gt; ClickStackListSources(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves a list of all sources for the authenticated team

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackListSources(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackSourcesResponse
}
catch (SdkException<ClickStackListSourcesError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackSources400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackSources400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackSourcesResponse](Models/V1OrganizationsServicesClickstackSourcesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackListSourcesError](Errors/ClickStackListSourcesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackWebhooksResponse&gt; ClickStackListWebhooks(Guid organizationId, Guid serviceId, int? limit = 1000, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Retrieves webhooks for the authenticated team (paginated). Results are capped at `limit` (default and maximum 1000). When `totalCount` exceeds the number of returned items, page with `limit`/`offset` to retrieve them all.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackListWebhooks(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackWebhooksResponse
}
catch (SdkException<ClickStackListWebhooksError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackWebhooks400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackWebhooks400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>limit</code> | <code>int?</code> | Maximum number of results to return.<br>**Default**: 1000 |
| <code>offset</code> | <code>int?</code> | Number of results to skip before returning.<br>**Default**: 0 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackWebhooksResponse](Models/V1OrganizationsServicesClickstackWebhooksResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackListWebhooksError](Errors/ClickStackListWebhooksError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse&gt; ClickStackUpdateAlert(Guid organizationId, Guid serviceId, string clickStackAlertId, ClickStackUpdateAlertRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Updates an existing alert

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackUpdateAlert(organizationId, serviceId, clickStackAlertId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse
}
catch (SdkException<ClickStackUpdateAlertError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackAlertId</code> | <code>string</code> | ClickStack Alert ID |
| <code>body</code> | <code>[ClickStackUpdateAlertRequest?](Models/ClickStackUpdateAlertRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse](Models/V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackUpdateAlertError](Errors/ClickStackUpdateAlertError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse&gt; ClickStackUpdateDashboard(Guid organizationId, Guid serviceId, string clickStackDashboardId, ClickStackUpdateDashboardRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Updates an existing dashboard.  **Concurrency:** This endpoint does not support optimistic concurrency control. Concurrent PUT requests for the same dashboard may silently overwrite each other, which can leave orphan tile-to-container references on layout-shape edits. Clients should serialize edits to a given dashboard.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackUpdateDashboard(organizationId,
        serviceId,
        clickStackDashboardId,
        body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse
}
catch (SdkException<ClickStackUpdateDashboardError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackDashboardId</code> | <code>string</code> | ClickStack Dashboard ID |
| <code>body</code> | <code>[ClickStackUpdateDashboardRequest?](Models/ClickStackUpdateDashboardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse](Models/V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackUpdateDashboardError](Errors/ClickStackUpdateDashboardError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse&gt; ClickStackUpdateRole(Guid organizationId, Guid serviceId, string clickStackRoleId, ClickStackUpdateRoleRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Updates a custom role's permissions, name, and description. Predefined roles cannot be modified.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackUpdateRole(organizationId, serviceId, clickStackRoleId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse
}
catch (SdkException<ClickStackUpdateRoleError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackRoleId</code> | <code>string</code> | id parameter |
| <code>body</code> | <code>[ClickStackUpdateRoleRequest?](Models/ClickStackUpdateRoleRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse](Models/V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackUpdateRoleError](Errors/ClickStackUpdateRoleError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse&gt; ClickStackUpdateSavedSearch(Guid organizationId, Guid serviceId, string clickStackSavedSearchId, ClickStackSavedSearchInput? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Updates an existing saved search. This is a full replace: send the full object. Every optional field (`select`, `where`, `whereLanguage`, `orderBy`, `tags`, `filters`) is always written and falls back to its default when omitted, so omitting a field resets it rather than preserving the stored value.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackUpdateSavedSearch(organizationId,
        serviceId,
        clickStackSavedSearchId,
        body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse
}
catch (SdkException<ClickStackUpdateSavedSearchError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackSavedSearchId</code> | <code>string</code> | Saved search ID |
| <code>body</code> | <code>[ClickStackSavedSearchInput?](Models/ClickStackSavedSearchInput.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse](Models/V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackUpdateSavedSearchError](Errors/ClickStackUpdateSavedSearchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse&gt; ClickStackUpdateSource(Guid organizationId, Guid serviceId, string clickStackSourceId, ClickStackSource? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Updates an existing source. The full source object must be provided; this is a replace, not a patch.  The request body is a source object without the `id` field. If an `id` is sent anyway it is silently ignored (stripped before validation — never a 400); the path parameter alone identifies the source. Granularity fields (`materializedViews[].minGranularity` and `metadataMaterializedViews.granularity`) accept the same short format the API returns (e.g. `5m`, `15s`, `1h`, `1d`).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackUpdateSource(organizationId, serviceId, clickStackSourceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse
}
catch (SdkException<ClickStackUpdateSourceError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackSourceId</code> | <code>string</code> | Source ID |
| <code>body</code> | <code>[ClickStackSource?](Models/AnyOf/ClickStackSource.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse](Models/V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackUpdateSourceError](Errors/ClickStackUpdateSourceError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse&gt; ClickStackUpdateWebhook(Guid organizationId, Guid serviceId, string clickStackWebhookId, ClickStackWebhookInput? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Replaces an existing webhook. Readable optional fields (`description`, `body`) are a full replace: omitting them clears them. The write-only fields `headers` and `queryParams` are never returned on read, so omitting them preserves the stored values; send an explicit empty object (`{}`) to clear them. Exception: if the destination (`url` or `service`) changes, omitted `headers`/ `queryParams` are cleared rather than preserved so stored secrets are never forwarded to a new destination.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackUpdateWebhook(organizationId,
        serviceId,
        clickStackWebhookId,
        body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse
}
catch (SdkException<ClickStackUpdateWebhookError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>clickStackWebhookId</code> | <code>string</code> | Webhook ID |
| <code>body</code> | <code>[ClickStackWebhookInput?](Models/ClickStackWebhookInput.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse](Models/V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackUpdateWebhookError](Errors/ClickStackUpdateWebhookError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickstackDashboardsValidateResponse&gt; ClickStackValidateDashboard(Guid organizationId, Guid serviceId, ClickStackCreateDashboardRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> ClickStack: Validates a dashboard body against the same schema and tile rules used by POST /api/v2/dashboards. The dashboard is **never persisted**. Use this endpoint at plan time (e.g. from a Terraform provider) to check that a dashboard configuration is valid before applying it.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClickStack.ClickStackValidateDashboard(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickstackDashboardsValidateResponse
}
catch (SdkException<ClickStackValidateDashboardApiError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickstackDashboardsValidate400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickstackDashboardsValidate400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the ClickStack service. |
| <code>body</code> | <code>[ClickStackCreateDashboardRequest?](Models/ClickStackCreateDashboardRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickstackDashboardsValidateResponse](Models/V1OrganizationsServicesClickstackDashboardsValidateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ClickStackValidateDashboardApiError](Errors/ClickStackValidateDashboardApiError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## OrganizationApi

> Source: [OrganizationApi](Api/OrganizationApi.cs)

<details>
<summary><code>Task&lt;V1OrganizationsActivitiesResponse1&gt; ActivityGet(Guid organizationId, string activityId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single organization activity by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.ActivityGet(organizationId, activityId);
    // TODO: Handle 'response' of type V1OrganizationsActivitiesResponse1
}
catch (SdkException<ActivityGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsActivities400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsActivities400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>activityId</code> | <code>string</code> | ID of the requested activity. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsActivitiesResponse1](Models/V1OrganizationsActivitiesResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActivityGetError](Errors/ActivityGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsActivitiesResponse&gt; ActivityGetList(Guid organizationId, DateTimeOffset? fromDate, DateTimeOffset? toDate, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all organization activities.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.ActivityGetList(organizationId, fromDate, toDate);
    // TODO: Handle 'response' of type V1OrganizationsActivitiesResponse
}
catch (SdkException<ActivityGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsActivities400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsActivities400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>fromDate</code> | <code>DateTimeOffset?</code> | A starting date for a search |
| <code>toDate</code> | <code>DateTimeOffset?</code> | An ending date for a search |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsActivitiesResponse](Models/V1OrganizationsActivitiesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ActivityGetListError](Errors/ActivityGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsByocInfrastructureResponse&gt; OrganizationByocInfrastructureCreate(Guid organizationId, ByocInfrastructurePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new BYOC Infrastructure in the organization. Returns the configuration of the newly created infrastructure

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.OrganizationByocInfrastructureCreate(organizationId, body);
    // TODO: Handle 'response' of type V1OrganizationsByocInfrastructureResponse
}
catch (SdkException<OrganizationByocInfrastructureCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsByocInfrastructure400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsByocInfrastructure400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>body</code> | <code>[ByocInfrastructurePostRequest?](Models/ByocInfrastructurePostRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsByocInfrastructureResponse](Models/V1OrganizationsByocInfrastructureResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationByocInfrastructureCreateError](Errors/OrganizationByocInfrastructureCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsByocInfrastructureResponse1&gt; OrganizationByocInfrastructureDelete(Guid organizationId, Guid byocInfrastructureId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a BYOC Infrastructure from the organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.OrganizationByocInfrastructureDelete(organizationId,
        byocInfrastructureId);
    // TODO: Handle 'response' of type V1OrganizationsByocInfrastructureResponse1
}
catch (SdkException<OrganizationByocInfrastructureDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsByocInfrastructure400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsByocInfrastructure400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>byocInfrastructureId</code> | <code>Guid</code> | ID of the requested BYOC Infrastructure |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsByocInfrastructureResponse1](Models/V1OrganizationsByocInfrastructureResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationByocInfrastructureDeleteError](Errors/OrganizationByocInfrastructureDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsByocInfrastructureResponse&gt; OrganizationByocInfrastructureUpdate(Guid organizationId, Guid byocInfrastructureId, ByocInfrastructurePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update configuration of the BYOC infrastructure. Returns the modified infrastructure

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.OrganizationByocInfrastructureUpdate(organizationId,
        byocInfrastructureId,
        body);
    // TODO: Handle 'response' of type V1OrganizationsByocInfrastructureResponse
}
catch (SdkException<OrganizationByocInfrastructureUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsByocInfrastructure400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsByocInfrastructure400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>byocInfrastructureId</code> | <code>Guid</code> | ID of the requested BYOC Infrastructure |
| <code>body</code> | <code>[ByocInfrastructurePatchRequest?](Models/ByocInfrastructurePatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsByocInfrastructureResponse](Models/V1OrganizationsByocInfrastructureResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationByocInfrastructureUpdateError](Errors/OrganizationByocInfrastructureUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsResponse1&gt; OrganizationGet(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details of a single organization. In order to get the details, the auth key must belong to the organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.OrganizationGet(organizationId);
    // TODO: Handle 'response' of type V1OrganizationsResponse1
}
catch (SdkException<OrganizationGetError> ex)
{
    if (ex.Error.TryGetV1Organizations400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1Organizations400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsResponse1](Models/V1OrganizationsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationGetError](Errors/OrganizationGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsResponse&gt; OrganizationGetList(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list with a single organization associated with the API key in the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.OrganizationGetList();
    // TODO: Handle 'response' of type V1OrganizationsResponse
}
catch (SdkException<OrganizationGetListError> ex)
{
    if (ex.Error.TryGetV1Organizations400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1Organizations400Error1
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsResponse](Models/V1OrganizationsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationGetListError](Errors/OrganizationGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPrivateEndpointConfigResponse&gt; OrganizationPrivateEndpointConfigGetList(Guid organizationId, string cloudProvider, string regionId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated. Please follow [documentation](https://clickhouse.com/docs/manage/security/aws-privatelink#add-endpoint-id-to-services-allow-list) for the updated process.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.OrganizationPrivateEndpointConfigGetList(organizationId,
        cloudProvider,
        regionId);
    // TODO: Handle 'response' of type V1OrganizationsPrivateEndpointConfigResponse
}
catch (SdkException<OrganizationPrivateEndpointConfigGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPrivateEndpointConfig400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPrivateEndpointConfig400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>cloudProvider</code> | <code>string</code> | Cloud provider identifier. One of aws, gcp, or azure. |
| <code>regionId</code> | <code>string</code> | Region identifier within specific cloud providers. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPrivateEndpointConfigResponse](Models/V1OrganizationsPrivateEndpointConfigResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationPrivateEndpointConfigGetListError](Errors/OrganizationPrivateEndpointConfigGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsQuotasResponse1&gt; OrganizationQuotaGet(Guid organizationId, string quotaCode, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns a single organization quota identified by its quota code. Responds with a not found error when the quota code is unknown or the quota does not apply to the organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.OrganizationQuotaGet(organizationId, quotaCode);
    // TODO: Handle 'response' of type V1OrganizationsQuotasResponse1
}
catch (SdkException<OrganizationQuotaGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsQuotas400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsQuotas400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>quotaCode</code> | <code>string</code> | Code of the requested quota. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsQuotasResponse1](Models/V1OrganizationsQuotasResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationQuotaGetError](Errors/OrganizationQuotaGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsQuotasResponse&gt; OrganizationQuotasGetList(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the resource quotas enforced for the organization together with their current usage where available. Quotas that do not apply to the organization are omitted. Quota values reflect the limits currently enforced, so they can be polled to detect changes, for example after a billing status change. The response contains one entry per quota code; quotas enforced per resource may additionally appear under resource-scoped endpoints in the future.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.OrganizationQuotasGetList(organizationId);
    // TODO: Handle 'response' of type V1OrganizationsQuotasResponse
}
catch (SdkException<OrganizationQuotasGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsQuotas400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsQuotas400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsQuotasResponse](Models/V1OrganizationsQuotasResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationQuotasGetListError](Errors/OrganizationQuotasGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsResponse1&gt; OrganizationUpdate(Guid organizationId, OrganizationPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates organization fields. Requires ADMIN auth key role.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.OrganizationApi.OrganizationUpdate(organizationId, body);
    // TODO: Handle 'response' of type V1OrganizationsResponse1
}
catch (SdkException<OrganizationUpdateError> ex)
{
    if (ex.Error.TryGetV1Organizations400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1Organizations400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization to update. |
| <code>body</code> | <code>[OrganizationPatchRequest?](Models/OrganizationPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsResponse1](Models/V1OrganizationsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationUpdateError](Errors/OrganizationUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Postgres

> Source: [Postgres](Api/Postgres.cs)

<details>
<summary><code>Task&lt;V1OrganizationsPostgresConfigResponse&gt; PostgresInstanceConfigGet(Guid organizationId, Guid postgresId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns the configuration data for a Postgres service and its PgBouncer service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresInstanceConfigGet(organizationId, postgresId);
    // TODO: Handle 'response' of type V1OrganizationsPostgresConfigResponse
}
catch (SdkException<PostgresInstanceConfigGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresConfig400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresConfig400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresConfigResponse](Models/V1OrganizationsPostgresConfigResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresInstanceConfigGetError](Errors/PostgresInstanceConfigGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresConfigResponse1&gt; PostgresInstanceConfigPatch(Guid organizationId, Guid postgresId, PostgresInstanceConfig? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Update the existing Postgres service and pgBouncer configuration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresInstanceConfigPatch(organizationId, postgresId, body);
    // TODO: Handle 'response' of type V1OrganizationsPostgresConfigResponse1
}
catch (SdkException<PostgresInstanceConfigPatchError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresConfig400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresConfig400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |
| <code>body</code> | <code>[PostgresInstanceConfig?](Models/PostgresInstanceConfig.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresConfigResponse1](Models/V1OrganizationsPostgresConfigResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresInstanceConfigPatchError](Errors/PostgresInstanceConfigPatchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresConfigResponse1&gt; PostgresInstanceConfigPost(Guid organizationId, Guid postgresId, PostgresInstanceConfig? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Replace the existing Postgres service and pgBouncer configuration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresInstanceConfigPost(organizationId, postgresId, body);
    // TODO: Handle 'response' of type V1OrganizationsPostgresConfigResponse1
}
catch (SdkException<PostgresInstanceConfigPostError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresConfig400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresConfig400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |
| <code>body</code> | <code>[PostgresInstanceConfig?](Models/PostgresInstanceConfig.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresConfigResponse1](Models/V1OrganizationsPostgresConfigResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresInstanceConfigPostError](Errors/PostgresInstanceConfigPostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresReadReplicaResponse&gt; PostgresInstanceCreateReadReplica(Guid organizationId, Guid postgresId, PostgresServiceReadReplicaRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Initiate the process to create a new read replica for a Postgres service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresInstanceCreateReadReplica(organizationId, postgresId, body);
    // TODO: Handle 'response' of type V1OrganizationsPostgresReadReplicaResponse
}
catch (SdkException<PostgresInstanceCreateReadReplicaError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresReadReplica400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresReadReplica400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |
| <code>body</code> | <code>[PostgresServiceReadReplicaRequest?](Models/PostgresServiceReadReplicaRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresReadReplicaResponse](Models/V1OrganizationsPostgresReadReplicaResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresInstanceCreateReadReplicaError](Errors/PostgresInstanceCreateReadReplicaError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresMetricsResponse&gt; PostgresInstanceMetricsGet(Guid organizationId, Guid postgresId, DateTimeOffset fromDate, DateTimeOffset toDate, int? bucketSizeSeconds, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns bucketed time-series metrics for a PostgreSQL service over the requested window (CPU, memory, disk, network, connections, cache hit ratio, throughput, transactions, and more). Use this to chart or analyze how a service behaved over time.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresInstanceMetricsGet(organizationId,
        postgresId,
        fromDate,
        toDate,
        bucketSizeSeconds);
    // TODO: Handle 'response' of type V1OrganizationsPostgresMetricsResponse
}
catch (SdkException<PostgresInstanceMetricsGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresMetrics400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresMetrics400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the Postgres service. |
| <code>fromDate</code> | <code>DateTimeOffset</code> | Inclusive start of the time window (RFC 3339 date-time). |
| <code>toDate</code> | <code>DateTimeOffset</code> | Exclusive end of the time window (RFC 3339 date-time). |
| <code>bucketSizeSeconds</code> | <code>int?</code> | Time-series bucket size in seconds. When omitted, a bucket size is derived from the requested window. Requests are capped at 250 data points. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresMetricsResponse](Models/V1OrganizationsPostgresMetricsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresInstanceMetricsGetError](Errors/PostgresInstanceMetricsGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresRestoredServiceResponse&gt; PostgresInstanceRestore(Guid organizationId, Guid postgresId, PostgresServiceRestoreRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Restore a Postgres database from continuous backup, optionally at a specific point in time.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresInstanceRestore(organizationId, postgresId, body);
    // TODO: Handle 'response' of type V1OrganizationsPostgresRestoredServiceResponse
}
catch (SdkException<PostgresInstanceRestoreError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresRestoredService400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresRestoredService400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |
| <code>body</code> | <code>[PostgresServiceRestoreRequest?](Models/PostgresServiceRestoreRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresRestoredServiceResponse](Models/V1OrganizationsPostgresRestoredServiceResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresInstanceRestoreError](Errors/PostgresInstanceRestoreError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresLogsResponse&gt; PostgresLogsGetList(Guid organizationId, Guid postgresId, DateTimeOffset fromDate, DateTimeOffset toDate, string? bodyContains, string? severity, SortOrder1? sortOrder, int? limit = 50, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns PostgreSQL server log entries for a Postgres service within the given time window, most recent first by default (override with `sort_order`). Results are paginated with `limit`/`offset`; advance `offset` until a page returns fewer than `limit` entries to read the full window. The time range must not exceed 30 days, and `to_date` must be after `from_date`.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresLogsGetList(organizationId,
        postgresId,
        fromDate,
        toDate,
        bodyContains,
        severity,
        sortOrder);
    // TODO: Handle 'response' of type V1OrganizationsPostgresLogsResponse
}
catch (SdkException<PostgresLogsGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresLogs400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresLogs400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |
| <code>fromDate</code> | <code>DateTimeOffset</code> | Inclusive start of the time window (RFC 3339 date-time). |
| <code>toDate</code> | <code>DateTimeOffset</code> | Inclusive end of the time window (RFC 3339 date-time). |
| <code>bodyContains</code> | <code>string?</code> | Case-sensitive substring the log body must contain. |
| <code>severity</code> | <code>string?</code> | Filter to log entries with this PostgreSQL severity (for example, ERROR, WARNING, LOG). |
| <code>sortOrder</code> | <code>[SortOrder1?](Models/Enums/SortOrder1.cs)</code> | Sort order. One of `asc` or `desc`. |
| <code>limit</code> | <code>int?</code> | Maximum number of results to return.<br>**Default**: 50 |
| <code>offset</code> | <code>int?</code> | Number of results to skip before returning.<br>**Default**: 0 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresLogsResponse](Models/V1OrganizationsPostgresLogsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresLogsGetListError](Errors/PostgresLogsGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PostgresServiceCertsGet(Guid organizationId, Guid postgresId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Download CA certificates for a PostgreSQL service

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Postgres.PostgresServiceCertsGet(organizationId, postgresId);
}
catch (SdkException<PostgresServiceCertsGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresCaCertificates400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresCaCertificates400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresServiceCertsGetError](Errors/PostgresServiceCertsGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresResponse&gt; PostgresServiceCreate(Guid organizationId, PostgresServicePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Creates a new Postgres service in the organization and returns it. The service is started asynchronously.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresServiceCreate(organizationId, body);
    // TODO: Handle 'response' of type V1OrganizationsPostgresResponse
}
catch (SdkException<PostgresServiceCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgres400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgres400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that will own the service. |
| <code>body</code> | <code>[PostgresServicePostRequest?](Models/PostgresServicePostRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresResponse](Models/V1OrganizationsPostgresResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresServiceCreateError](Errors/PostgresServiceCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresResponse3&gt; PostgresServiceDelete(Guid organizationId, Guid postgresId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Deletes a Postgres service that belongs to the organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresServiceDelete(organizationId, postgresId);
    // TODO: Handle 'response' of type V1OrganizationsPostgresResponse3
}
catch (SdkException<PostgresServiceDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgres400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgres400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresResponse3](Models/V1OrganizationsPostgresResponse3.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresServiceDeleteError](Errors/PostgresServiceDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresResponse&gt; PostgresServiceGet(Guid organizationId, Guid postgresId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns a Postgres service that belongs to the organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresServiceGet(organizationId, postgresId);
    // TODO: Handle 'response' of type V1OrganizationsPostgresResponse
}
catch (SdkException<PostgresServiceGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgres400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgres400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresResponse](Models/V1OrganizationsPostgresResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresServiceGetError](Errors/PostgresServiceGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresResponse1&gt; PostgresServiceGetList(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns a list of all Postgres services in the organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresServiceGetList(organizationId);
    // TODO: Handle 'response' of type V1OrganizationsPostgresResponse1
}
catch (SdkException<PostgresServiceGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgres400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgres400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the services. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresResponse1](Models/V1OrganizationsPostgresResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresServiceGetListError](Errors/PostgresServiceGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresResponse&gt; PostgresServicePatch(Guid organizationId, Guid postgresId, PostgresServicePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Update a Postgres service that belongs to the organization. **WARNING:** Changing the name also updates the host name and certificates for the service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresServicePatch(organizationId, postgresId, body);
    // TODO: Handle 'response' of type V1OrganizationsPostgresResponse
}
catch (SdkException<PostgresServicePatchError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgres400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgres400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |
| <code>body</code> | <code>[PostgresServicePatchRequest?](Models/PostgresServicePatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresResponse](Models/V1OrganizationsPostgresResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresServicePatchError](Errors/PostgresServicePatchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresStateResponse&gt; PostgresServicePatchState(Guid organizationId, Guid postgresId, PostgresServiceSetState? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Initiate a process for a Postgres service:
* restart: Initiates a service restart
* promote: Promotes a read replica to primary
* switchover: Switch a primary over to a standby

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresServicePatchState(organizationId, postgresId, body);
    // TODO: Handle 'response' of type V1OrganizationsPostgresStateResponse
}
catch (SdkException<PostgresServicePatchStateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresState400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresState400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |
| <code>body</code> | <code>[PostgresServiceSetState?](Models/PostgresServiceSetState.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresStateResponse](Models/V1OrganizationsPostgresStateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresServicePatchStateError](Errors/PostgresServicePatchStateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresPasswordResponse&gt; PostgresServiceSetPassword(Guid organizationId, Guid postgresId, PostgresServiceSetPassword? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Sets a new password for a Postgres service's superuser account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.PostgresServiceSetPassword(organizationId, postgresId, body);
    // TODO: Handle 'response' of type V1OrganizationsPostgresPasswordResponse
}
catch (SdkException<PostgresServiceSetPasswordError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresPassword400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresPassword400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |
| <code>body</code> | <code>[PostgresServiceSetPassword?](Models/PostgresServiceSetPassword.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresPasswordResponse](Models/V1OrganizationsPostgresPasswordResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresServiceSetPasswordError](Errors/PostgresServiceSetPasswordError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse&gt; SlowQueryPatternGet(Guid organizationId, Guid postgresId, string queryId, string dbName, string dbUser, string dbOperation, string? app, DateTimeOffset? timestamp, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns aggregate metrics for a single slow query pattern together with its most recent individual executions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.SlowQueryPatternGet(organizationId,
        postgresId,
        queryId,
        dbName,
        dbUser,
        dbOperation,
        app,
        timestamp);
    // TODO: Handle 'response' of type V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse
}
catch (SdkException<SlowQueryPatternGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresSlowQueryPatternsQueryId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresSlowQueryPatternsQueryId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |
| <code>queryId</code> | <code>string</code> | Stable identifier for the query pattern. |
| <code>dbName</code> | <code>string</code> | Database name filter. |
| <code>dbUser</code> | <code>string</code> | Database user filter. |
| <code>dbOperation</code> | <code>string</code> | Database operation filter (for example, SELECT, INSERT, UPDATE, DELETE, UTILITY). |
| <code>app</code> | <code>string?</code> | Application name filter. |
| <code>timestamp</code> | <code>DateTimeOffset?</code> | Timestamp of a specific execution (RFC 3339). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse](Models/V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SlowQueryPatternGetError](Errors/SlowQueryPatternGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsPostgresSlowQueryPatternsResponse&gt; SlowQueryPatternsGetList(Guid organizationId, Guid postgresId, DateTimeOffset fromDate, DateTimeOffset toDate, string? dbName, string? dbUser, string? dbOperation, string? app, SortBy? sortBy, SortOrder1? sortOrder, int? limit = 20, int? offset = 0, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns aggregate metrics for the slowest query patterns observed on a Postgres service during the given time window. Use this to discover which queries dominate total execution time, CPU, I/O, or WAL generation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Postgres.SlowQueryPatternsGetList(organizationId,
        postgresId,
        fromDate,
        toDate,
        dbName,
        dbUser,
        dbOperation,
        app,
        sortBy,
        sortOrder);
    // TODO: Handle 'response' of type V1OrganizationsPostgresSlowQueryPatternsResponse
}
catch (SdkException<SlowQueryPatternsGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresSlowQueryPatterns400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresSlowQueryPatterns400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |
| <code>fromDate</code> | <code>DateTimeOffset</code> | Inclusive start of the time window (RFC 3339 date-time). |
| <code>toDate</code> | <code>DateTimeOffset</code> | Exclusive end of the time window (RFC 3339 date-time). |
| <code>dbName</code> | <code>string?</code> | Database name filter. |
| <code>dbUser</code> | <code>string?</code> | Database user filter. |
| <code>dbOperation</code> | <code>string?</code> | Database operation filter (for example, SELECT, INSERT, UPDATE, DELETE, UTILITY). |
| <code>app</code> | <code>string?</code> | Application name filter. |
| <code>sortBy</code> | <code>[SortBy?](Models/Enums/SortBy.cs)</code> | Field to sort results by. |
| <code>sortOrder</code> | <code>[SortOrder1?](Models/Enums/SortOrder1.cs)</code> | Sort order. One of `asc` or `desc`. |
| <code>limit</code> | <code>int?</code> | Maximum number of results to return.<br>**Default**: 20 |
| <code>offset</code> | <code>int?</code> | Number of results to skip before returning.<br>**Default**: 0 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsPostgresSlowQueryPatternsResponse](Models/V1OrganizationsPostgresSlowQueryPatternsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SlowQueryPatternsGetListError](Errors/SlowQueryPatternsGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Prometheus

> Source: [Prometheus](Api/Prometheus.cs)

<details>
<summary><code>Task&lt;string&gt; InstancePrometheusGet(Guid organizationId, Guid serviceId, string? filteredMetrics, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns prometheus metrics for a service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Prometheus.InstancePrometheusGet(organizationId, serviceId, filteredMetrics);
    // TODO: Handle 'response' of type string
}
catch (SdkException<InstancePrometheusGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesPrometheus400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesPrometheus400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>filteredMetrics</code> | <code>string?</code> | Return a filtered list of Prometheus metrics. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>string</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstancePrometheusGetError](Errors/InstancePrometheusGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;PrometheusDiscoveryTargetGroup&gt;&gt; OrganizationPrometheusDiscoveryGet(Guid organizationId, string? filteredMetrics, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns one Prometheus scrape target per service in the organization, in the [HTTP service discovery](https://prometheus.io/docs/prometheus/latest/http_sd/) (`http_sd`) format. Only services the API key is authorized to view are included; services that are being deleted or have been deleted are omitted.

Point an [`http_sd_configs`](https://prometheus.io/docs/prometheus/latest/configuration/configuration/#http_sd_config) job at this endpoint to discover and scrape all services in the organization automatically. Prometheus refreshes the target list on every discovery poll, so newly created and deleted services are picked up without configuration changes.

Discovered targets scrape with `filtered_metrics=true` by default; pass `?filtered_metrics=false` to this endpoint to discover unfiltered targets. See the [Prometheus integration guide](https://clickhouse.com/docs/integrations/prometheus) for more on the exported metrics.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Prometheus.OrganizationPrometheusDiscoveryGet(organizationId, filteredMetrics);
    // TODO: Handle 'response' of type IReadOnlyList<PrometheusDiscoveryTargetGroup>
}
catch (SdkException<OrganizationPrometheusDiscoveryGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPrometheusDiscovery400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPrometheusDiscovery400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>filteredMetrics</code> | <code>string?</code> | Whether discovered targets scrape a filtered list of metrics. Sets the filtered_metrics parameter on each discovered target. Defaults to true. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[PrometheusDiscoveryTargetGroup](Models/PrometheusDiscoveryTargetGroup.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationPrometheusDiscoveryGetError](Errors/OrganizationPrometheusDiscoveryGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;string&gt; OrganizationPrometheusGet(Guid organizationId, string? filteredMetrics, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deprecated. Use the Prometheus service discovery endpoint (/v1/organizations/{organizationId}/prometheus/discovery) instead. This endpoint is not available for new organizations; contact ClickHouse support to request access. Returns Prometheus metrics for the services in an organization that the caller is authorized to view. Services the caller lacks view access to are omitted.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Prometheus.OrganizationPrometheusGet(organizationId, filteredMetrics);
    // TODO: Handle 'response' of type string
}
catch (SdkException<OrganizationPrometheusGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPrometheus400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPrometheus400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>filteredMetrics</code> | <code>string?</code> | Return a filtered list of Prometheus metrics. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>string</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationPrometheusGetError](Errors/OrganizationPrometheusGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;string&gt; PostgresInstancePrometheusGet(Guid organizationId, Guid postgresId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns Prometheus metrics for a PostgreSQL service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Prometheus.PostgresInstancePrometheusGet(organizationId, postgresId);
    // TODO: Handle 'response' of type string
}
catch (SdkException<PostgresInstancePrometheusGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresPrometheus400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresPrometheus400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the Postgres service. |
| <code>postgresId</code> | <code>Guid</code> | ID of the requested Postgres service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>string</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresInstancePrometheusGetError](Errors/PostgresInstancePrometheusGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;string&gt; PostgresOrgPrometheusGet(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns Prometheus metrics for all PostgreSQL services in an organization. Maximum 100 services supported.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Prometheus.PostgresOrgPrometheusGet(organizationId);
    // TODO: Handle 'response' of type string
}
catch (SdkException<PostgresOrgPrometheusGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsPostgresPrometheus400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsPostgresPrometheus400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>string</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostgresOrgPrometheusGetError](Errors/PostgresOrgPrometheusGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## QueryApiEndpoints

> Source: [QueryApiEndpoints](Api/QueryApiEndpoints.cs)

<details>
<summary><code>Task&lt;V1OrganizationsServicesQueryApiEndpointsResponse&gt; QueryApiEndpointCreate(Guid organizationId, Guid serviceId, PublicQueryApiEndpointRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Creates a Query API endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.QueryApiEndpoints.QueryApiEndpointCreate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesQueryApiEndpointsResponse
}
catch (SdkException<QueryApiEndpointCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesQueryApiEndpoints400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesQueryApiEndpoints400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>body</code> | <code>[PublicQueryApiEndpointRequest?](Models/PublicQueryApiEndpointRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesQueryApiEndpointsResponse](Models/V1OrganizationsServicesQueryApiEndpointsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryApiEndpointCreateError](Errors/QueryApiEndpointCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse&gt; QueryApiEndpointDelete(Guid organizationId, Guid serviceId, Guid endpointId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Deletes a Query API endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.QueryApiEndpoints.QueryApiEndpointDelete(organizationId, serviceId, endpointId);
    // TODO: Handle 'response' of type V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse
}
catch (SdkException<QueryApiEndpointDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>endpointId</code> | <code>Guid</code> | ID of the requested Query API endpoint. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse](Models/V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryApiEndpointDeleteError](Errors/QueryApiEndpointDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1&gt; QueryApiEndpointGet(Guid organizationId, Guid serviceId, Guid endpointId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns a Query API endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.QueryApiEndpoints.QueryApiEndpointGet(organizationId, serviceId, endpointId);
    // TODO: Handle 'response' of type V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1
}
catch (SdkException<QueryApiEndpointGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>endpointId</code> | <code>Guid</code> | ID of the requested Query API endpoint. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1](Models/V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryApiEndpointGetError](Errors/QueryApiEndpointGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesQueryApiEndpointsResponse1&gt; QueryApiEndpointList(Guid organizationId, Guid serviceId, string? cursor, int? limit = 100, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns all active Query API endpoints for the service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.QueryApiEndpoints.QueryApiEndpointList(organizationId, serviceId, cursor);
    // TODO: Handle 'response' of type V1OrganizationsServicesQueryApiEndpointsResponse1
}
catch (SdkException<QueryApiEndpointListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesQueryApiEndpoints400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesQueryApiEndpoints400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>cursor</code> | <code>string?</code> | Cursor returned in `pagination.nextCursor` from the previous page. |
| <code>limit</code> | <code>int?</code> | Maximum number of records to return per page. Defaults to 100. Maximum is 100.<br>**Default**: 100 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesQueryApiEndpointsResponse1](Models/V1OrganizationsServicesQueryApiEndpointsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryApiEndpointListError](Errors/QueryApiEndpointListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1&gt; QueryApiEndpointUpdate(Guid organizationId, Guid serviceId, Guid endpointId, PublicQueryApiEndpointRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Updates a Query API endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.QueryApiEndpoints.QueryApiEndpointUpdate(organizationId, serviceId, endpointId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1
}
catch (SdkException<QueryApiEndpointUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId400Error31(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesQueryApiEndpointsEndpointId400Error31
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>endpointId</code> | <code>Guid</code> | ID of the requested Query API endpoint. |
| <code>body</code> | <code>[PublicQueryApiEndpointRequest?](Models/PublicQueryApiEndpointRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1](Models/V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[QueryApiEndpointUpdateError](Errors/QueryApiEndpointUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## RoleManagement

> Source: [RoleManagement](Api/RoleManagement.cs)

<details>
<summary><code>Task&lt;V1OrganizationsRolesResponse4&gt; OrganizationRoleDelete(Guid organizationId, Guid roleId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes an existing custom role. System roles cannot be deleted. This operation will remove the role and all its associated policies.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RoleManagement.OrganizationRoleDelete(organizationId, roleId);
    // TODO: Handle 'response' of type V1OrganizationsRolesResponse4
}
catch (SdkException<OrganizationRoleDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsRoles400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsRoles400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>roleId</code> | <code>Guid</code> | ID of the requested role. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsRolesResponse4](Models/V1OrganizationsRolesResponse4.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationRoleDeleteError](Errors/OrganizationRoleDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsRolesResponse1&gt; OrganizationRoleGet(Guid organizationId, Guid roleId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details for a specific role.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RoleManagement.OrganizationRoleGet(organizationId, roleId);
    // TODO: Handle 'response' of type V1OrganizationsRolesResponse1
}
catch (SdkException<OrganizationRoleGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsRoles400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsRoles400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>roleId</code> | <code>Guid</code> | ID of the requested role. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsRolesResponse1](Models/V1OrganizationsRolesResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationRoleGetError](Errors/OrganizationRoleGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsRolesResponse1&gt; OrganizationRolePatch(Guid organizationId, Guid roleId, RoleUpdateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an existing custom role. System roles cannot be updated. All fields are optional - only provided fields will be updated.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RoleManagement.OrganizationRolePatch(organizationId, roleId, body);
    // TODO: Handle 'response' of type V1OrganizationsRolesResponse1
}
catch (SdkException<OrganizationRolePatchError> ex)
{
    if (ex.Error.TryGetV1OrganizationsRoles400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsRoles400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>roleId</code> | <code>Guid</code> | ID of the requested role. |
| <code>body</code> | <code>[RoleUpdateRequest?](Models/RoleUpdateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsRolesResponse1](Models/V1OrganizationsRolesResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationRolePatchError](Errors/OrganizationRolePatchError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsRolesResponse1&gt; OrganizationRolePost(Guid organizationId, RoleCreateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new custom role for an organization with specified policies and actors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RoleManagement.OrganizationRolePost(organizationId, body);
    // TODO: Handle 'response' of type V1OrganizationsRolesResponse1
}
catch (SdkException<OrganizationRolePostError> ex)
{
    if (ex.Error.TryGetV1OrganizationsRoles400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsRoles400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>body</code> | <code>[RoleCreateRequest?](Models/RoleCreateRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsRolesResponse1](Models/V1OrganizationsRolesResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationRolePostError](Errors/OrganizationRolePostError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsRolesResponse&gt; OrganizationRolesGetList(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all available roles (system + custom) for an organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.RoleManagement.OrganizationRolesGetList(organizationId);
    // TODO: Handle 'response' of type V1OrganizationsRolesResponse
}
catch (SdkException<OrganizationRolesGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsRoles400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsRoles400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsRolesResponse](Models/V1OrganizationsRolesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[OrganizationRolesGetListError](Errors/OrganizationRolesGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ServiceApi

> Source: [ServiceApi](Api/ServiceApi.cs)

<details>
<summary><code>Task&lt;V1OrganizationsServicesResponse1&gt; InstanceCreate(Guid organizationId, ServicePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a new service in the organization, and returns the current service state and a password to access the service. The service is started asynchronously.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceCreate(organizationId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesResponse1
}
catch (SdkException<InstanceCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServices400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServices400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that will own the service. |
| <code>body</code> | <code>[ServicePostRequest?](Models/ServicePostRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesResponse1](Models/V1OrganizationsServicesResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceCreateError](Errors/InstanceCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesResponse4&gt; InstanceDelete(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the service. The service must be in stopped state and is deleted asynchronously after this method call.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceDelete(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesResponse4
}
catch (SdkException<InstanceDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServices400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServices400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service to delete. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesResponse4](Models/V1OrganizationsServicesResponse4.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceDeleteError](Errors/InstanceDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesResponse2&gt; InstanceGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a service that belongs to the organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesResponse2
}
catch (SdkException<InstanceGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServices400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServices400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesResponse2](Models/V1OrganizationsServicesResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceGetError](Errors/InstanceGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesResponse&gt; InstanceGetList(Guid organizationId, IReadOnlyList&lt;string&gt;? filter, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all services in the organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceGetList(organizationId, filter);
    // TODO: Handle 'response' of type V1OrganizationsServicesResponse
}
catch (SdkException<InstanceGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServices400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServices400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>filter</code> | <code>IReadOnlyList&lt;string&gt;?</code> | Filter criteria to apply when retrieving the resource. Currently, only filtering by resource tags is supported. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesResponse](Models/V1OrganizationsServicesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceGetListError](Errors/InstanceGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesPasswordResponse&gt; InstancePasswordUpdate(Guid organizationId, Guid serviceId, ServicePasswordPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Sets a new password for the service

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstancePasswordUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesPasswordResponse
}
catch (SdkException<InstancePasswordUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesPassword400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesPassword400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service to update password. |
| <code>body</code> | <code>[ServicePasswordPatchRequest?](Models/ServicePasswordPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesPasswordResponse](Models/V1OrganizationsServicesPasswordResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstancePasswordUpdateError](Errors/InstancePasswordUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesPrivateEndpointConfigResponse&gt; InstancePrivateEndpointConfigGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Information required to set up a private endpoint

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstancePrivateEndpointConfigGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesPrivateEndpointConfigResponse
}
catch (SdkException<InstancePrivateEndpointConfigGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesPrivateEndpointConfig400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesPrivateEndpointConfig400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesPrivateEndpointConfigResponse](Models/V1OrganizationsServicesPrivateEndpointConfigResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstancePrivateEndpointConfigGetError](Errors/InstancePrivateEndpointConfigGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesPrivateEndpointResponse&gt; InstancePrivateEndpointCreate(Guid organizationId, Guid serviceId, ServicPrivateEndpointePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new private endpoint. The private endpoint will be associated with this service and organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstancePrivateEndpointCreate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesPrivateEndpointResponse
}
catch (SdkException<InstancePrivateEndpointCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesPrivateEndpoint400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesPrivateEndpoint400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>body</code> | <code>[ServicPrivateEndpointePostRequest?](Models/ServicPrivateEndpointePostRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesPrivateEndpointResponse](Models/V1OrganizationsServicesPrivateEndpointResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstancePrivateEndpointCreateError](Errors/InstancePrivateEndpointCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesServiceQueryEndpointResponse1&gt; InstanceQueryEndpointDelete(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes the service query endpoint.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceQueryEndpointDelete(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesServiceQueryEndpointResponse1
}
catch (SdkException<InstanceQueryEndpointDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesServiceQueryEndpoint400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesServiceQueryEndpoint400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesServiceQueryEndpointResponse1](Models/V1OrganizationsServicesServiceQueryEndpointResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceQueryEndpointDeleteError](Errors/InstanceQueryEndpointDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesServiceQueryEndpointResponse&gt; InstanceQueryEndpointGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Get the configuration for the service query endpoint that allows executing queries via API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceQueryEndpointGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesServiceQueryEndpointResponse
}
catch (SdkException<InstanceQueryEndpointGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesServiceQueryEndpoint400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesServiceQueryEndpoint400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesServiceQueryEndpointResponse](Models/V1OrganizationsServicesServiceQueryEndpointResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceQueryEndpointGetError](Errors/InstanceQueryEndpointGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesServiceQueryEndpointResponse&gt; InstanceQueryEndpointUpsert(Guid organizationId, Guid serviceId, InstanceServiceQueryApiEndpointsPostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create the service query endpoint that allows executing queries via API.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceQueryEndpointUpsert(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesServiceQueryEndpointResponse
}
catch (SdkException<InstanceQueryEndpointUpsertError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesServiceQueryEndpoint400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesServiceQueryEndpoint400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>body</code> | <code>[InstanceServiceQueryApiEndpointsPostRequest?](Models/InstanceServiceQueryApiEndpointsPostRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesServiceQueryEndpointResponse](Models/V1OrganizationsServicesServiceQueryEndpointResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceQueryEndpointUpsertError](Errors/InstanceQueryEndpointUpsertError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesReplicaScalingResponse&gt; InstanceReplicaScalingUpdate(Guid organizationId, Guid serviceId, ServiceReplicaScalingPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates minimum and maximum memory limits per replica and idle mode scaling behavior for the service. Supports both vertical autoscaling (fixed replica count, variable memory) and horizontal autoscaling (variable replica count, fixed memory). The memory settings are available only for "production" services and must be a multiple of 4 starting from 8GB. For vertical autoscaling, please contact support to enable adjustment of numReplicas. For horizontal autoscaling (autoscalingMode "horizontal" with minReplicas/maxReplicas), contact support to enable the feature for your organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceReplicaScalingUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesReplicaScalingResponse
}
catch (SdkException<InstanceReplicaScalingUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesReplicaScaling400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesReplicaScaling400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service to update scaling parameters. |
| <code>body</code> | <code>[ServiceReplicaScalingPatchRequest?](Models/ServiceReplicaScalingPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesReplicaScalingResponse](Models/V1OrganizationsServicesReplicaScalingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceReplicaScalingUpdateError](Errors/InstanceReplicaScalingUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesScalingResponse&gt; InstanceScalingUpdate(Guid organizationId, Guid serviceId, ServiceScalingPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates minimum and maximum total memory limits and idle mode scaling behavior for the service. The memory settings are available only for "production" services and must be a multiple of 12 starting from 24GB. Please contact support to enable adjustment of numReplicas.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceScalingUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesScalingResponse
}
catch (SdkException<InstanceScalingUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesScaling400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesScaling400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service to update scaling parameters. |
| <code>body</code> | <code>[ServiceScalingPatchRequest?](Models/ServiceScalingPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesScalingResponse](Models/V1OrganizationsServicesScalingResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceScalingUpdateError](Errors/InstanceScalingUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesStateResponse&gt; InstanceStateUpdate(Guid organizationId, Guid serviceId, ServiceStatePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Starts, stops, or wakes a service. The `start` and `stop` commands require the `control-plane:service:manage` permission on the service. The `awake` command requires only `control-plane:service:view` and applies to an idle service; it does not start a stopped service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceStateUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesStateResponse
}
catch (SdkException<InstanceStateUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesState400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesState400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service to update state. |
| <code>body</code> | <code>[ServiceStatePatchRequest?](Models/ServiceStatePatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesStateResponse](Models/V1OrganizationsServicesStateResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceStateUpdateError](Errors/InstanceStateUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesResponse2&gt; InstanceUpdate(Guid organizationId, Guid serviceId, ServicePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates basic service details like service name or IP access list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.InstanceUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesResponse2
}
catch (SdkException<InstanceUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServices400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServices400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service to update. |
| <code>body</code> | <code>[ServicePatchRequest?](Models/ServicePatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesResponse2](Models/V1OrganizationsServicesResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InstanceUpdateError](Errors/InstanceUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesScalingScheduleResponse2&gt; ScalingScheduleDelete(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Deletes the autoscaling schedule for a service. If a schedule entry is currently active, the base scaling config is restored to the instance before the schedule is removed. Returns 404 if no schedule exists. Requires the scheduled autoscaling feature to be enabled for the organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.ScalingScheduleDelete(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesScalingScheduleResponse2
}
catch (SdkException<ScalingScheduleDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesScalingSchedule400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesScalingSchedule400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesScalingScheduleResponse2](Models/V1OrganizationsServicesScalingScheduleResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ScalingScheduleDeleteError](Errors/ScalingScheduleDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesScalingScheduleResponse&gt; ScalingScheduleGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the autoscaling schedule for a service. Returns 404 if no schedule has been configured or if the schedule was cleared. Requires the scheduled autoscaling feature to be enabled for the organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.ScalingScheduleGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesScalingScheduleResponse
}
catch (SdkException<ScalingScheduleGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesScalingSchedule400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesScalingSchedule400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesScalingScheduleResponse](Models/V1OrganizationsServicesScalingScheduleResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ScalingScheduleGetError](Errors/ScalingScheduleGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesScalingScheduleResponse&gt; ScalingScheduleUpsert(Guid organizationId, Guid serviceId, ScalingSchedulePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Creates or fully replaces the autoscaling schedule for a service. Pass an empty `entries` array to clear the schedule — a subsequent GET will return 404, and the response will contain an empty `baseConfig` (all fields absent). The base scaling config (applied when no entry is active) is managed separately via the `replicaScaling` endpoint. Requires the scheduled autoscaling feature to be enabled for the organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.ScalingScheduleUpsert(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesScalingScheduleResponse
}
catch (SdkException<ScalingScheduleUpsertError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesScalingSchedule400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesScalingSchedule400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |
| <code>body</code> | <code>[ScalingSchedulePostRequest?](Models/ScalingSchedulePostRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesScalingScheduleResponse](Models/V1OrganizationsServicesScalingScheduleResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ScalingScheduleUpsertError](Errors/ScalingScheduleUpsertError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickhouseSettingsSettingNameResponse1&gt; ServiceClickhouseSettingDelete(Guid organizationId, Guid serviceId, string settingName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Removes a previously-configured ClickHouse setting, reverting its effective value to the platform default. Settings under `spec.extraConfig.server.*` (e.g. `keep_alive_timeout`, `shared_merge_tree_disable_merges_and_mutations_assignment`) trigger a ClickHouse server rollout restart; other settings propagate to all replicas after a short delay. Deleting a setting that was never configured is a no-op (200 OK).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.ServiceClickhouseSettingDelete(organizationId, serviceId, settingName);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickhouseSettingsSettingNameResponse1
}
catch (SdkException<ServiceClickhouseSettingDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickhouseSettingsSettingName400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickhouseSettingsSettingName400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |
| <code>settingName</code> | <code>string</code> | Name of the setting to reset. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickhouseSettingsSettingNameResponse1](Models/V1OrganizationsServicesClickhouseSettingsSettingNameResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ServiceClickhouseSettingDeleteError](Errors/ServiceClickhouseSettingDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickhouseSettingsSettingNameResponse&gt; ServiceClickhouseSettingGet(Guid organizationId, Guid serviceId, string settingName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the current value of a ClickHouse setting for the service. Use the [schema endpoint](#tag/Service/operation/serviceClickhouseSettingsSchemaGet) to discover which settings are configurable.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.ServiceClickhouseSettingGet(organizationId, serviceId, settingName);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickhouseSettingsSettingNameResponse
}
catch (SdkException<ServiceClickhouseSettingGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickhouseSettingsSettingName400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickhouseSettingsSettingName400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |
| <code>settingName</code> | <code>string</code> | Name of the setting to retrieve. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickhouseSettingsSettingNameResponse](Models/V1OrganizationsServicesClickhouseSettingsSettingNameResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ServiceClickhouseSettingGetError](Errors/ServiceClickhouseSettingGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickhouseSettingsResponse&gt; ServiceClickhouseSettingsListGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the configured ClickHouse settings for the service. Only settings that have been explicitly set are included.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.ServiceClickhouseSettingsListGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickhouseSettingsResponse
}
catch (SdkException<ServiceClickhouseSettingsListGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickhouseSettings400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickhouseSettings400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickhouseSettingsResponse](Models/V1OrganizationsServicesClickhouseSettingsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ServiceClickhouseSettingsListGetError](Errors/ServiceClickhouseSettingsListGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickhouseSettingsSchemaResponse&gt; ServiceClickhouseSettingsSchemaGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the schema of all configurable ClickHouse settings, including types, valid values, descriptions, and warnings.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.ServiceClickhouseSettingsSchemaGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickhouseSettingsSchemaResponse
}
catch (SdkException<ServiceClickhouseSettingsSchemaGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickhouseSettingsSchema400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickhouseSettingsSchema400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickhouseSettingsSchemaResponse](Models/V1OrganizationsServicesClickhouseSettingsSchemaResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ServiceClickhouseSettingsSchemaGetError](Errors/ServiceClickhouseSettingsSchemaGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesClickhouseSettingsResponse1&gt; ServiceClickhouseSettingsUpdate(Guid organizationId, Guid serviceId, ServiceClickhouseSettingsPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Updates one or more ClickHouse settings for the service. To reset a setting to its platform default, use the [DELETE single setting](#tag/Service/operation/serviceClickhouseSettingDelete) endpoint. Use the [schema endpoint](#tag/Service/operation/serviceClickhouseSettingsSchemaGet) to discover which settings are configurable.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.ServiceClickhouseSettingsUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesClickhouseSettingsResponse1
}
catch (SdkException<ServiceClickhouseSettingsUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesClickhouseSettings400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesClickhouseSettings400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |
| <code>body</code> | <code>[ServiceClickhouseSettingsPatchRequest?](Models/ServiceClickhouseSettingsPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesClickhouseSettingsResponse1](Models/V1OrganizationsServicesClickhouseSettingsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ServiceClickhouseSettingsUpdateError](Errors/ServiceClickhouseSettingsUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServiceProfilesResponse&gt; ServiceProfilesList(Guid organizationId, string? regionId, Guid? byocId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the custom instance profiles the organization can use in a region. Pass byoc_id to list the profiles configured for a BYOC infrastructure; the region is then taken from the infrastructure and region_id may be omitted. The list is empty when the organization tier does not include custom hardware profiles.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.ServiceProfilesList(organizationId, regionId, byocId);
    // TODO: Handle 'response' of type V1OrganizationsServiceProfilesResponse
}
catch (SdkException<ServiceProfilesListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServiceProfiles400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServiceProfiles400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization to list available profiles for. |
| <code>regionId</code> | <code>string?</code> | Region to list profiles for, e.g. us-east-1. Required unless byoc_id is set; when both are set it must match the BYOC infrastructure's region. |
| <code>byocId</code> | <code>Guid?</code> | ID of the BYOC infrastructure to list profiles for. BYOC profiles are only returned when this is set. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServiceProfilesResponse](Models/V1OrganizationsServiceProfilesResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[ServiceProfilesListError](Errors/ServiceProfilesListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesUpgradeWindowResponse2&gt; UpgradeWindowDelete(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes the upgrade window for a service, restoring the default scheduling behaviour. The upgrade window can only be deleted on primary services. Deletion succeeds even if the organization has lost the scheduled upgrades entitlement, so a window can be cleared after entitlement loss.

Errors:
- 400: the service is a secondary service.
- 401: missing, invalid, or disabled API key.
- 403: caller lacks `control-plane:service:manage` on the service.
- 404: service does not exist, is not visible to the caller, or no upgrade window is configured.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.UpgradeWindowDelete(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesUpgradeWindowResponse2
}
catch (SdkException<UpgradeWindowDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesUpgradeWindow400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesUpgradeWindow400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesUpgradeWindowResponse2](Models/V1OrganizationsServicesUpgradeWindowResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpgradeWindowDeleteError](Errors/UpgradeWindowDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesUpgradeWindowResponse&gt; UpgradeWindowGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the configured upgrade window for a service.

Errors:
- 401: missing, invalid, or disabled API key.
- 403: caller lacks `control-plane:service:view` on the service.
- 404: service does not exist, is not visible to the caller, or no upgrade window has been configured.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.UpgradeWindowGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesUpgradeWindowResponse
}
catch (SdkException<UpgradeWindowGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesUpgradeWindow400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesUpgradeWindow400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesUpgradeWindowResponse](Models/V1OrganizationsServicesUpgradeWindowResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpgradeWindowGetError](Errors/UpgradeWindowGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesUpgradeWindowResponse&gt; UpgradeWindowUpdate(Guid organizationId, Guid serviceId, UpgradeWindowPutRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates or fully replaces the upgrade window for a service. The upgrade window currently lasts 6 hours from `startHourUtc`. The upgrade window can only be set on primary services; secondary services inherit the primary service window.

Errors:
- 400: invalid field values (`weekday` not in 0–6, `startHourUtc` not in {0, 6, 12, 18}), or the service is a secondary service.
- 401: missing, invalid, or disabled API key.
- 403: caller lacks `control-plane:service:manage` on the service, or the organization does not have the scheduled upgrades feature enabled.
- 404: service does not exist or is not visible to the caller.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ServiceApi.UpgradeWindowUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesUpgradeWindowResponse
}
catch (SdkException<UpgradeWindowUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesUpgradeWindow400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesUpgradeWindow400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |
| <code>body</code> | <code>[UpgradeWindowPutRequest?](Models/UpgradeWindowPutRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesUpgradeWindowResponse](Models/V1OrganizationsServicesUpgradeWindowResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UpgradeWindowUpdateError](Errors/UpgradeWindowUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SnapshotApi

> Source: [SnapshotApi](Api/SnapshotApi.cs)

<details>
<summary><code>Task&lt;V1OrganizationsServicesSnapshotConfigurationResponse&gt; SnapshotConfigurationGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns the service snapshot configuration.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SnapshotApi.SnapshotConfigurationGet(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesSnapshotConfigurationResponse
}
catch (SdkException<SnapshotConfigurationGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesSnapshotConfiguration400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesSnapshotConfiguration400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesSnapshotConfigurationResponse](Models/V1OrganizationsServicesSnapshotConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SnapshotConfigurationGetError](Errors/SnapshotConfigurationGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesSnapshotConfigurationResponse&gt; SnapshotConfigurationUpdate(Guid organizationId, Guid serviceId, SnapshotConfigurationPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Updates the service snapshot configuration. Requires ADMIN auth key role. Enables or disables scheduled snapshots and sets the cadence; when enabled, gap and timeFrame (in minutes) must together be one of the supported (gap, timeFrame) pairs: (30, 1440), (60, 2880). Provide at least one of enabled, gap, timeFrame; omit a field to leave it unchanged (null is not accepted).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SnapshotApi.SnapshotConfigurationUpdate(organizationId, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsServicesSnapshotConfigurationResponse
}
catch (SdkException<SnapshotConfigurationUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesSnapshotConfiguration400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesSnapshotConfiguration400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the service. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service. |
| <code>body</code> | <code>[SnapshotConfigurationPatchRequest?](Models/SnapshotConfigurationPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesSnapshotConfigurationResponse](Models/V1OrganizationsServicesSnapshotConfigurationResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SnapshotConfigurationUpdateError](Errors/SnapshotConfigurationUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesSnapshotsSnapshotIdResponse&gt; SnapshotGet(Guid organizationId, Guid serviceId, Guid snapshotId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns a single snapshot info.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SnapshotApi.SnapshotGet(organizationId, serviceId, snapshotId);
    // TODO: Handle 'response' of type V1OrganizationsServicesSnapshotsSnapshotIdResponse
}
catch (SdkException<SnapshotGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesSnapshotsSnapshotId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesSnapshotsSnapshotId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the snapshot. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service the snapshot was created from. |
| <code>snapshotId</code> | <code>Guid</code> | ID of the requested snapshot. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesSnapshotsSnapshotIdResponse](Models/V1OrganizationsServicesSnapshotsSnapshotIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SnapshotGetError](Errors/SnapshotGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsServicesSnapshotsResponse&gt; SnapshotGetList(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns a list of all snapshots for the service. The most recent snapshots come first in the list.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SnapshotApi.SnapshotGetList(organizationId, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsServicesSnapshotsResponse
}
catch (SdkException<SnapshotGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsServicesSnapshots400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsServicesSnapshots400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that owns the snapshot. |
| <code>serviceId</code> | <code>Guid</code> | ID of the service the snapshot was created from. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsServicesSnapshotsResponse](Models/V1OrganizationsServicesSnapshotsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[SnapshotGetListError](Errors/SnapshotGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UdfApi

> Source: [UdfApi](Api/UdfApi.cs)

<details>
<summary><code>Task&lt;V1OrganizationsUdfsAttachmentsServiceIdResponse&gt; UdfAttach(Guid organizationId, string functionName, Guid serviceId, V1OrganizationsUdfsAttachmentsServiceIdRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Attaches one UDF version to a service, replacing the current version when necessary. When version is omitted, the latest ready version is attached.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfAttach(organizationId, functionName, serviceId, body);
    // TODO: Handle 'response' of type V1OrganizationsUdfsAttachmentsServiceIdResponse
}
catch (SdkException<UdfAttachError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfsAttachmentsServiceId400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfsAttachmentsServiceId400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>functionName</code> | <code>string</code> | Name of the UDF. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |
| <code>body</code> | <code>[V1OrganizationsUdfsAttachmentsServiceIdRequest?](Models/V1OrganizationsUdfsAttachmentsServiceIdRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsAttachmentsServiceIdResponse](Models/V1OrganizationsUdfsAttachmentsServiceIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfAttachError](Errors/UdfAttachError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfsAttachmentsServiceIdResponse&gt; UdfAttachmentGet(Guid organizationId, string functionName, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the current attachment of a UDF to one service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfAttachmentGet(organizationId, functionName, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsUdfsAttachmentsServiceIdResponse
}
catch (SdkException<UdfAttachmentGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfsAttachmentsServiceId400Error21(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfsAttachmentsServiceId400Error21
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>functionName</code> | <code>string</code> | Name of the UDF. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsAttachmentsServiceIdResponse](Models/V1OrganizationsUdfsAttachmentsServiceIdResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfAttachmentGetError](Errors/UdfAttachmentGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfsAttachmentsResponse&gt; UdfAttachmentList(Guid organizationId, string functionName, string? cursor, int? limit = 100, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the current service attachments for a UDF, with at most one attachment per service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfAttachmentList(organizationId, functionName, cursor);
    // TODO: Handle 'response' of type V1OrganizationsUdfsAttachmentsResponse
}
catch (SdkException<UdfAttachmentListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfsAttachments400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfsAttachments400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>functionName</code> | <code>string</code> | Name of the UDF. |
| <code>cursor</code> | <code>string?</code> | Cursor returned in `pagination.nextCursor` from the previous page. |
| <code>limit</code> | <code>int?</code> | Maximum number of records to return per page. Defaults to 100. Maximum is 100.<br>**Default**: 100 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsAttachmentsResponse](Models/V1OrganizationsUdfsAttachmentsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfAttachmentListError](Errors/UdfAttachmentListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfsResponse&gt; UdfCreate(Guid organizationId, UdfCreateRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Creates a new UDF. See [User-defined functions in Cloud](https://clickhouse.com/docs/products/cloud/features/sql-console-features/user-defined-functions).

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfCreate(organizationId, body);
    // TODO: Handle 'response' of type V1OrganizationsUdfsResponse
}
catch (SdkException<UdfCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfs400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfs400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>body</code> | <code>[UdfCreateRequest2?](Models/AnyOf/UdfCreateRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsResponse](Models/V1OrganizationsUdfsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfCreateError](Errors/UdfCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfsResponse2&gt; UdfDelete(Guid organizationId, string functionName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Deletes every version of a UDF and detaches it from all services. Removal from services completes asynchronously.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfDelete(organizationId, functionName);
    // TODO: Handle 'response' of type V1OrganizationsUdfsResponse2
}
catch (SdkException<UdfDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfs400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfs400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>functionName</code> | <code>string</code> | Name of the UDF. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsResponse2](Models/V1OrganizationsUdfsResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfDeleteError](Errors/UdfDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfsAttachmentsServiceIdResponse2&gt; UdfDetach(Guid organizationId, string functionName, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Detaches a UDF from a service.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfDetach(organizationId, functionName, serviceId);
    // TODO: Handle 'response' of type V1OrganizationsUdfsAttachmentsServiceIdResponse2
}
catch (SdkException<UdfDetachError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfsAttachmentsServiceId400Error21(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfsAttachmentsServiceId400Error21
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>functionName</code> | <code>string</code> | Name of the UDF. |
| <code>serviceId</code> | <code>Guid</code> | ID of the requested service. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsAttachmentsServiceIdResponse2](Models/V1OrganizationsUdfsAttachmentsServiceIdResponse2.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfDetachError](Errors/UdfDetachError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfsResponse&gt; UdfGet(Guid organizationId, string functionName, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the latest version of a UDF.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfGet(organizationId, functionName);
    // TODO: Handle 'response' of type V1OrganizationsUdfsResponse
}
catch (SdkException<UdfGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfs400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfs400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>functionName</code> | <code>string</code> | Name of the UDF. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsResponse](Models/V1OrganizationsUdfsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfGetError](Errors/UdfGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfsResponse1&gt; UdfList(Guid organizationId, string? cursor, int? limit = 100, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the latest version of each UDF in the organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfList(organizationId, cursor);
    // TODO: Handle 'response' of type V1OrganizationsUdfsResponse1
}
catch (SdkException<UdfListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfs400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfs400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>cursor</code> | <code>string?</code> | Cursor returned in `pagination.nextCursor` from the previous page. |
| <code>limit</code> | <code>int?</code> | Maximum number of records to return per page. Defaults to 100. Maximum is 100.<br>**Default**: 100 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsResponse1](Models/V1OrganizationsUdfsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfListError](Errors/UdfListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfUploadsUrlResponse&gt; UdfUploadSessionCreate(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Creates an org-scoped presigned application/zip upload URL. Callers must use an upload ID for only one create or version attempt and request a new upload URL when retrying.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfUploadSessionCreate(organizationId);
    // TODO: Handle 'response' of type V1OrganizationsUdfUploadsUrlResponse
}
catch (SdkException<UdfUploadSessionCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfUploadsUrl400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfUploadsUrl400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfUploadsUrlResponse](Models/V1OrganizationsUdfUploadsUrlResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfUploadSessionCreateError](Errors/UdfUploadSessionCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfsVersionsResponse&gt; UdfVersionCreate(Guid organizationId, string functionName, UdfVersionCreateRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Consumes a source archive, assigns a version, and starts the UDF build. Optional configuration fields omitted from the request use the defaults documented in the request schema; values are not inherited from the previous version. Retry by requesting a new upload URL and re-uploading.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfVersionCreate(organizationId, functionName, body);
    // TODO: Handle 'response' of type V1OrganizationsUdfsVersionsResponse
}
catch (SdkException<UdfVersionCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfsVersions400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfsVersions400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>functionName</code> | <code>string</code> | Name of the UDF. |
| <code>body</code> | <code>[UdfVersionCreateRequest2?](Models/AnyOf/UdfVersionCreateRequest2.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsVersionsResponse](Models/V1OrganizationsUdfsVersionsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfVersionCreateError](Errors/UdfVersionCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfsVersionsVersionResponse&gt; UdfVersionDelete(Guid organizationId, string functionName, int version, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Deletes a UDF version. The UDF must not be attached to any services.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfVersionDelete(organizationId, functionName, version);
    // TODO: Handle 'response' of type V1OrganizationsUdfsVersionsVersionResponse
}
catch (SdkException<UdfVersionDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfsVersionsVersion400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfsVersionsVersion400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>functionName</code> | <code>string</code> | Name of the UDF. |
| <code>version</code> | <code>int</code> | Version number of the UDF. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsVersionsVersionResponse](Models/V1OrganizationsUdfsVersionsVersionResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfVersionDeleteError](Errors/UdfVersionDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsUdfsVersionsResponse1&gt; UdfVersionList(Guid organizationId, string functionName, string? cursor, int? limit = 100, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns all versions of a UDF.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UdfApi.UdfVersionList(organizationId, functionName, cursor);
    // TODO: Handle 'response' of type V1OrganizationsUdfsVersionsResponse1
}
catch (SdkException<UdfVersionListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsUdfsVersions400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsUdfsVersions400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>functionName</code> | <code>string</code> | Name of the UDF. |
| <code>cursor</code> | <code>string?</code> | Cursor returned in `pagination.nextCursor` from the previous page. |
| <code>limit</code> | <code>int?</code> | Maximum number of records to return per page. Defaults to 100. Maximum is 100.<br>**Default**: 100 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsUdfsVersionsResponse1](Models/V1OrganizationsUdfsVersionsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[UdfVersionListError](Errors/UdfVersionListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## UserManagement

> Source: [UserManagement](Api/UserManagement.cs)

<details>
<summary><code>Task&lt;V1OrganizationsInvitationsResponse1&gt; InvitationCreate(Guid organizationId, InvitationPostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates organization invitation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserManagement.InvitationCreate(organizationId, body);
    // TODO: Handle 'response' of type V1OrganizationsInvitationsResponse1
}
catch (SdkException<InvitationCreateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsInvitations400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsInvitations400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization to invite a user to. |
| <code>body</code> | <code>[InvitationPostRequest?](Models/InvitationPostRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsInvitationsResponse1](Models/V1OrganizationsInvitationsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InvitationCreateError](Errors/InvitationCreateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsInvitationsResponse3&gt; InvitationDelete(Guid organizationId, Guid invitationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deletes a single organization invitation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserManagement.InvitationDelete(organizationId, invitationId);
    // TODO: Handle 'response' of type V1OrganizationsInvitationsResponse3
}
catch (SdkException<InvitationDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsInvitations400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsInvitations400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization that has the invitation. |
| <code>invitationId</code> | <code>Guid</code> | ID of the requested organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsInvitationsResponse3](Models/V1OrganizationsInvitationsResponse3.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InvitationDeleteError](Errors/InvitationDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsInvitationsResponse1&gt; InvitationGet(Guid organizationId, Guid invitationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns details for a single organization invitation.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserManagement.InvitationGet(organizationId, invitationId);
    // TODO: Handle 'response' of type V1OrganizationsInvitationsResponse1
}
catch (SdkException<InvitationGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsInvitations400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsInvitations400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>invitationId</code> | <code>Guid</code> | ID of the requested organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsInvitationsResponse1](Models/V1OrganizationsInvitationsResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InvitationGetError](Errors/InvitationGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsInvitationsResponse&gt; InvitationGetList(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns list of all organization invitations.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserManagement.InvitationGetList(organizationId);
    // TODO: Handle 'response' of type V1OrganizationsInvitationsResponse
}
catch (SdkException<InvitationGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsInvitations400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsInvitations400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsInvitationsResponse](Models/V1OrganizationsInvitationsResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[InvitationGetListError](Errors/InvitationGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsMembersResponse3&gt; MemberDelete(Guid organizationId, Guid userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Removes a user from the organization

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserManagement.MemberDelete(organizationId, userId);
    // TODO: Handle 'response' of type V1OrganizationsMembersResponse3
}
catch (SdkException<MemberDeleteError> ex)
{
    if (ex.Error.TryGetV1OrganizationsMembers400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsMembers400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |
| <code>userId</code> | <code>Guid</code> | ID of the requested user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsMembersResponse3](Models/V1OrganizationsMembersResponse3.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MemberDeleteError](Errors/MemberDeleteError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsMembersResponse1&gt; MemberGet(Guid organizationId, Guid userId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a single organization member details.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserManagement.MemberGet(organizationId, userId);
    // TODO: Handle 'response' of type V1OrganizationsMembersResponse1
}
catch (SdkException<MemberGetError> ex)
{
    if (ex.Error.TryGetV1OrganizationsMembers400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsMembers400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization the member is part of. |
| <code>userId</code> | <code>Guid</code> | ID of the requested user. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsMembersResponse1](Models/V1OrganizationsMembersResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MemberGetError](Errors/MemberGetError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsMembersResponse&gt; MemberGetList(Guid organizationId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a list of all members in the organization.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserManagement.MemberGetList(organizationId);
    // TODO: Handle 'response' of type V1OrganizationsMembersResponse
}
catch (SdkException<MemberGetListError> ex)
{
    if (ex.Error.TryGetV1OrganizationsMembers400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsMembers400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the requested organization. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsMembersResponse](Models/V1OrganizationsMembersResponse.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MemberGetListError](Errors/MemberGetListError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;V1OrganizationsMembersResponse1&gt; MemberUpdate(Guid organizationId, Guid userId, MemberPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates organization member role.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.UserManagement.MemberUpdate(organizationId, userId, body);
    // TODO: Handle 'response' of type V1OrganizationsMembersResponse1
}
catch (SdkException<MemberUpdateError> ex)
{
    if (ex.Error.TryGetV1OrganizationsMembers400Error1(out var error))
    {
        // TODO: Handle 'error' of type V1OrganizationsMembers400Error1
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>organizationId</code> | <code>Guid</code> | ID of the organization the member is part of. |
| <code>userId</code> | <code>Guid</code> | ID of the user to patch |
| <code>body</code> | <code>[MemberPatchRequest?](Models/MemberPatchRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[V1OrganizationsMembersResponse1](Models/V1OrganizationsMembersResponse1.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[MemberUpdateError](Errors/MemberUpdateError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

