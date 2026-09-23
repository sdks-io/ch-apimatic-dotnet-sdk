# Query AP Iendpoints

```csharp
QueryApIendpointsApi queryApIendpointsApi = client.QueryApIendpointsApi;
```

## Class Name

`QueryApIendpointsApi`

## Methods

* [Query Api Endpoint Create](../../doc/controllers/query-ap-iendpoints.md#query-api-endpoint-create)
* [Query Api Endpoint List](../../doc/controllers/query-ap-iendpoints.md#query-api-endpoint-list)
* [Query Api Endpoint Delete](../../doc/controllers/query-ap-iendpoints.md#query-api-endpoint-delete)
* [Query Api Endpoint Get](../../doc/controllers/query-ap-iendpoints.md#query-api-endpoint-get)
* [Query Api Endpoint Update](../../doc/controllers/query-ap-iendpoints.md#query-api-endpoint-update)


# Query Api Endpoint Create

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Creates a Query API endpoint.

```csharp
QueryApiEndpointCreateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.PublicQueryApiEndpointRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `body` | [`PublicQueryApiEndpointRequest`](../../doc/models/public-query-api-endpoint-request.md) | Body, Optional | - |

## Response Type

**201**: The Query API endpoint was created.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesQueryApiEndpointsResponse](../../doc/models/v1-organizations-services-query-api-endpoints-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesQueryApiEndpointsResponse> result = await queryApiEndpointsApi.QueryApiEndpointCreateAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesQueryApiEndpoints400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpoints400ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpoints403ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpoints403ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpoints404ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpoints404ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpoints500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpoints500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. | [`V1OrganizationsServicesQueryApiEndpoints400ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-400-error-exception.md) |
| 403 | The request is forbidden. | [`V1OrganizationsServicesQueryApiEndpoints403ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-403-error-exception.md) |
| 404 | Service not found. | [`V1OrganizationsServicesQueryApiEndpoints404ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-404-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesQueryApiEndpoints500ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-500-error-exception.md) |


# Query Api Endpoint List

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns all active Query API endpoints for the service.

```csharp
QueryApiEndpointListAsync(
    Guid organizationId,
    Guid serviceId,
    string cursor = null,
    int? limit = 100)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `cursor` | `string` | Query, Optional | Cursor returned in `pagination.nextCursor` from the previous page. |
| `limit` | `int?` | Query, Optional | Maximum number of records to return per page. Defaults to 100. Maximum is 100.<br><br>**Default**: `100`<br><br>**Constraints**: `>= 1`, `<= 100` |

## Response Type

**200**: Successful response.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesQueryApiEndpointsResponse1](../../doc/models/v1-organizations-services-query-api-endpoints-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
int? limit = 100;
try
{
    ApiResponse<V1OrganizationsServicesQueryApiEndpointsResponse1> result = await queryApiEndpointsApi.QueryApiEndpointListAsync(
        organizationId,
        serviceId,
        null,
        limit
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesQueryApiEndpoints400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpoints400ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpoints403ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpoints403ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpoints404ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpoints404ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpoints500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpoints500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. | [`V1OrganizationsServicesQueryApiEndpoints400ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-400-error-exception.md) |
| 403 | The request is forbidden. | [`V1OrganizationsServicesQueryApiEndpoints403ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-403-error-exception.md) |
| 404 | Service not found. | [`V1OrganizationsServicesQueryApiEndpoints404ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-404-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesQueryApiEndpoints500ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-500-error-exception.md) |


# Query Api Endpoint Delete

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Deletes a Query API endpoint.

```csharp
QueryApiEndpointDeleteAsync(
    Guid organizationId,
    Guid serviceId,
    Guid endpointId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `endpointId` | `Guid` | Template, Required | ID of the requested Query API endpoint. |

## Response Type

**200**: The Query API endpoint was deleted.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid endpointId = new Guid("00001c70-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse> result = await queryApiEndpointsApi.QueryApiEndpointDeleteAsync(
        organizationId,
        serviceId,
        endpointId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId403ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId403ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId409ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId409ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId400ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-400-error-exception.md) |
| 403 | The request is forbidden. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId403ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-403-error-exception.md) |
| 404 | Query API endpoint not found. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-404-error-exception.md) |
| 409 | Query API endpoint can not be managed via this API. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId409ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-409-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-500-error-exception.md) |


# Query Api Endpoint Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns a Query API endpoint.

```csharp
QueryApiEndpointGetAsync(
    Guid organizationId,
    Guid serviceId,
    Guid endpointId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `endpointId` | `Guid` | Template, Required | ID of the requested Query API endpoint. |

## Response Type

**200**: Successful response.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid endpointId = new Guid("00001c70-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1> result = await queryApiEndpointsApi.QueryApiEndpointGetAsync(
        organizationId,
        serviceId,
        endpointId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId403ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId403ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId400ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-400-error-exception.md) |
| 403 | The request is forbidden. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId403ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-403-error-exception.md) |
| 404 | Query API endpoint not found. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-404-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-500-error-exception.md) |


# Query Api Endpoint Update

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Updates a Query API endpoint.

```csharp
QueryApiEndpointUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Guid endpointId,
    Models.PublicQueryApiEndpointRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `endpointId` | `Guid` | Template, Required | ID of the requested Query API endpoint. |
| `body` | [`PublicQueryApiEndpointRequest`](../../doc/models/public-query-api-endpoint-request.md) | Body, Optional | - |

## Response Type

**200**: The Query API endpoint was updated.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid endpointId = new Guid("00001c70-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1> result = await queryApiEndpointsApi.QueryApiEndpointUpdateAsync(
        organizationId,
        serviceId,
        endpointId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId400Error3Exception)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId400Error3Exception exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId403ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId403ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId409ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId409ErrorException exception here
    }
    if (e is V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId400Error3Exception`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-400-error-3-exception.md) |
| 403 | The request is forbidden. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId403ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-403-error-exception.md) |
| 404 | Query API endpoint not found. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId404ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-404-error-exception.md) |
| 409 | Query API endpoint can not be managed via this API. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId409ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-409-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesQueryApiEndpointsEndpointId500ErrorException`](../../doc/models/v1-organizations-services-query-api-endpoints-endpoint-id-500-error-exception.md) |

