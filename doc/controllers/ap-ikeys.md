# AP Ikeys

```csharp
ApIkeysApi apIkeysApi = client.ApIkeysApi;
```

## Class Name

`ApIkeysApi`

## Methods

* [Openapi Key Get List](../../doc/controllers/ap-ikeys.md#openapi-key-get-list)
* [Openapi Key Create](../../doc/controllers/ap-ikeys.md#openapi-key-create)
* [Openapi Key Get](../../doc/controllers/ap-ikeys.md#openapi-key-get)
* [Openapi Key Update](../../doc/controllers/ap-ikeys.md#openapi-key-update)
* [Openapi Key Delete](../../doc/controllers/ap-ikeys.md#openapi-key-delete)


# Openapi Key Get List

Returns a list of keys in the organization, ordered by creation date, oldest first. Results are capped at `limit` (default and maximum 250) per page. Every response carries `limit`, `totalCount` and `nextCursor`; pass `nextCursor` as the `cursor` query parameter to fetch the next page, repeating until it is null.

```csharp
OpenapiKeyGetListAsync(
    Guid organizationId,
    int? limit = 250,
    string cursor = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `limit` | `int?` | Query, Optional | Maximum number of results to return.<br><br>**Default**: `250`<br><br>**Constraints**: `>= 1`, `<= 250` |
| `cursor` | `string` | Query, Optional | Opaque cursor from a previous response's `nextCursor`, marking where to resume the list. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsKeysResponse](../../doc/models/v1-organizations-keys-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
int? limit = 250;
try
{
    ApiResponse<V1OrganizationsKeysResponse> result = await apiKeysApi.OpenapiKeyGetListAsync(
        organizationId,
        limit
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsKeys400ErrorException)
    {
       // TODO: Handle V1OrganizationsKeys400ErrorException exception here
    }
    if (e is V1OrganizationsKeys500ErrorException)
    {
       // TODO: Handle V1OrganizationsKeys500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsKeys400ErrorException`](../../doc/models/v1-organizations-keys-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsKeys500ErrorException`](../../doc/models/v1-organizations-keys-500-error-exception.md) |


# Openapi Key Create

Creates new API key.

```csharp
OpenapiKeyCreateAsync(
    Guid organizationId,
    Models.ApiKeyPostRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that will own the key. |
| `body` | [`ApiKeyPostRequest`](../../doc/models/api-key-post-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsKeysResponse1](../../doc/models/v1-organizations-keys-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsKeysResponse1> result = await apiKeysApi.OpenapiKeyCreateAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsKeys400ErrorException)
    {
       // TODO: Handle V1OrganizationsKeys400ErrorException exception here
    }
    if (e is V1OrganizationsKeys500ErrorException)
    {
       // TODO: Handle V1OrganizationsKeys500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsKeys400ErrorException`](../../doc/models/v1-organizations-keys-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsKeys500ErrorException`](../../doc/models/v1-organizations-keys-500-error-exception.md) |


# Openapi Key Get

Returns a single key details.

```csharp
OpenapiKeyGetAsync(
    Guid organizationId,
    Guid keyId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `keyId` | `Guid` | Template, Required | ID of the requested key. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsKeysResponse2](../../doc/models/v1-organizations-keys-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid keyId = new Guid("00001b3a-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsKeysResponse2> result = await apiKeysApi.OpenapiKeyGetAsync(
        organizationId,
        keyId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsKeys400ErrorException)
    {
       // TODO: Handle V1OrganizationsKeys400ErrorException exception here
    }
    if (e is V1OrganizationsKeys500ErrorException)
    {
       // TODO: Handle V1OrganizationsKeys500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsKeys400ErrorException`](../../doc/models/v1-organizations-keys-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsKeys500ErrorException`](../../doc/models/v1-organizations-keys-500-error-exception.md) |


# Openapi Key Update

Updates API key properties.

```csharp
OpenapiKeyUpdateAsync(
    Guid organizationId,
    Guid keyId,
    Models.ApiKeyPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the key. |
| `keyId` | `Guid` | Template, Required | ID of the key to update. |
| `body` | [`ApiKeyPatchRequest`](../../doc/models/api-key-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsKeysResponse2](../../doc/models/v1-organizations-keys-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid keyId = new Guid("00001b3a-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsKeysResponse2> result = await apiKeysApi.OpenapiKeyUpdateAsync(
        organizationId,
        keyId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsKeys400ErrorException)
    {
       // TODO: Handle V1OrganizationsKeys400ErrorException exception here
    }
    if (e is V1OrganizationsKeys500ErrorException)
    {
       // TODO: Handle V1OrganizationsKeys500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsKeys400ErrorException`](../../doc/models/v1-organizations-keys-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsKeys500ErrorException`](../../doc/models/v1-organizations-keys-500-error-exception.md) |


# Openapi Key Delete

Deletes API key. Only a key not used to authenticate the active request can be deleted.

```csharp
OpenapiKeyDeleteAsync(
    Guid organizationId,
    Guid keyId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the key. |
| `keyId` | `Guid` | Template, Required | ID of the key to delete. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsKeysResponse4](../../doc/models/v1-organizations-keys-response-4.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid keyId = new Guid("00001b3a-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsKeysResponse4> result = await apiKeysApi.OpenapiKeyDeleteAsync(
        organizationId,
        keyId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsKeys400ErrorException)
    {
       // TODO: Handle V1OrganizationsKeys400ErrorException exception here
    }
    if (e is V1OrganizationsKeys500ErrorException)
    {
       // TODO: Handle V1OrganizationsKeys500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsKeys400ErrorException`](../../doc/models/v1-organizations-keys-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsKeys500ErrorException`](../../doc/models/v1-organizations-keys-500-error-exception.md) |

