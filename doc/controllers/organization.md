# Organization

```csharp
OrganizationApi organizationApi = client.OrganizationApi;
```

## Class Name

`OrganizationApi`

## Methods

* [Organization Get List](../../doc/controllers/organization.md#organization-get-list)
* [Organization Get](../../doc/controllers/organization.md#organization-get)
* [Organization Update](../../doc/controllers/organization.md#organization-update)
* [Organization Quotas Get List](../../doc/controllers/organization.md#organization-quotas-get-list)
* [Organization Quota Get](../../doc/controllers/organization.md#organization-quota-get)
* [Activity Get List](../../doc/controllers/organization.md#activity-get-list)
* [Activity Get](../../doc/controllers/organization.md#activity-get)
* [Organization Private Endpoint Config Get List](../../doc/controllers/organization.md#organization-private-endpoint-config-get-list)
* [Organization Byoc Infrastructure Create](../../doc/controllers/organization.md#organization-byoc-infrastructure-create)
* [Organization Byoc Infrastructure Delete](../../doc/controllers/organization.md#organization-byoc-infrastructure-delete)
* [Organization Byoc Infrastructure Update](../../doc/controllers/organization.md#organization-byoc-infrastructure-update)


# Organization Get List

Returns a list with a single organization associated with the API key in the request.

```csharp
OrganizationGetListAsync()
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsResponse](../../doc/models/v1-organizations-response.md).

## Example Usage

```csharp
try
{
    ApiResponse<V1OrganizationsResponse> result = await organizationApi.OrganizationGetListAsync();
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1Organizations400ErrorException)
    {
       // TODO: Handle V1Organizations400ErrorException exception here
    }
    if (e is V1Organizations500ErrorException)
    {
       // TODO: Handle V1Organizations500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1Organizations400ErrorException`](../../doc/models/v1-organizations-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1Organizations500ErrorException`](../../doc/models/v1-organizations-500-error-exception.md) |


# Organization Get

Returns details of a single organization. In order to get the details, the auth key must belong to the organization.

```csharp
OrganizationGetAsync(
    Guid organizationId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsResponse1](../../doc/models/v1-organizations-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsResponse1> result = await organizationApi.OrganizationGetAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1Organizations400ErrorException)
    {
       // TODO: Handle V1Organizations400ErrorException exception here
    }
    if (e is V1Organizations500ErrorException)
    {
       // TODO: Handle V1Organizations500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1Organizations400ErrorException`](../../doc/models/v1-organizations-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1Organizations500ErrorException`](../../doc/models/v1-organizations-500-error-exception.md) |


# Organization Update

Updates organization fields. Requires ADMIN auth key role.

```csharp
OrganizationUpdateAsync(
    Guid organizationId,
    Models.OrganizationPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization to update. |
| `body` | [`OrganizationPatchRequest`](../../doc/models/organization-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsResponse1](../../doc/models/v1-organizations-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsResponse1> result = await organizationApi.OrganizationUpdateAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1Organizations400ErrorException)
    {
       // TODO: Handle V1Organizations400ErrorException exception here
    }
    if (e is V1Organizations500ErrorException)
    {
       // TODO: Handle V1Organizations500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1Organizations400ErrorException`](../../doc/models/v1-organizations-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1Organizations500ErrorException`](../../doc/models/v1-organizations-500-error-exception.md) |


# Organization Quotas Get List

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the resource quotas enforced for the organization together with their current usage where available. Quotas that do not apply to the organization are omitted. Quota values reflect the limits currently enforced, so they can be polled to detect changes, for example after a billing status change. The response contains one entry per quota code; quotas enforced per resource may additionally appear under resource-scoped endpoints in the future.

```csharp
OrganizationQuotasGetListAsync(
    Guid organizationId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsQuotasResponse](../../doc/models/v1-organizations-quotas-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsQuotasResponse> result = await organizationApi.OrganizationQuotasGetListAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsQuotas400ErrorException)
    {
       // TODO: Handle V1OrganizationsQuotas400ErrorException exception here
    }
    if (e is V1OrganizationsQuotas500ErrorException)
    {
       // TODO: Handle V1OrganizationsQuotas500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsQuotas400ErrorException`](../../doc/models/v1-organizations-quotas-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsQuotas500ErrorException`](../../doc/models/v1-organizations-quotas-500-error-exception.md) |


# Organization Quota Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns a single organization quota identified by its quota code. Responds with a not found error when the quota code is unknown or the quota does not apply to the organization.

```csharp
OrganizationQuotaGetAsync(
    Guid organizationId,
    string quotaCode)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `quotaCode` | `string` | Template, Required | Code of the requested quota. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsQuotasResponse1](../../doc/models/v1-organizations-quotas-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string quotaCode = "quotaCode2";
try
{
    ApiResponse<V1OrganizationsQuotasResponse1> result = await organizationApi.OrganizationQuotaGetAsync(
        organizationId,
        quotaCode
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsQuotas400ErrorException)
    {
       // TODO: Handle V1OrganizationsQuotas400ErrorException exception here
    }
    if (e is V1OrganizationsQuotas500ErrorException)
    {
       // TODO: Handle V1OrganizationsQuotas500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsQuotas400ErrorException`](../../doc/models/v1-organizations-quotas-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsQuotas500ErrorException`](../../doc/models/v1-organizations-quotas-500-error-exception.md) |


# Activity Get List

Returns a list of all organization activities.

```csharp
ActivityGetListAsync(
    Guid organizationId,
    DateTime? fromDate = null,
    DateTime? toDate = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `fromDate` | `DateTime?` | Query, Optional | A starting date for a search |
| `toDate` | `DateTime?` | Query, Optional | An ending date for a search |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsActivitiesResponse](../../doc/models/v1-organizations-activities-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsActivitiesResponse> result = await organizationApi.ActivityGetListAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsActivities400ErrorException)
    {
       // TODO: Handle V1OrganizationsActivities400ErrorException exception here
    }
    if (e is V1OrganizationsActivities500ErrorException)
    {
       // TODO: Handle V1OrganizationsActivities500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsActivities400ErrorException`](../../doc/models/v1-organizations-activities-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsActivities500ErrorException`](../../doc/models/v1-organizations-activities-500-error-exception.md) |


# Activity Get

Returns a single organization activity by ID.

```csharp
ActivityGetAsync(
    Guid organizationId,
    string activityId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `activityId` | `string` | Template, Required | ID of the requested activity. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsActivitiesResponse1](../../doc/models/v1-organizations-activities-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string activityId = "activityId2";
try
{
    ApiResponse<V1OrganizationsActivitiesResponse1> result = await organizationApi.ActivityGetAsync(
        organizationId,
        activityId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsActivities400ErrorException)
    {
       // TODO: Handle V1OrganizationsActivities400ErrorException exception here
    }
    if (e is V1OrganizationsActivities500ErrorException)
    {
       // TODO: Handle V1OrganizationsActivities500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsActivities400ErrorException`](../../doc/models/v1-organizations-activities-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsActivities500ErrorException`](../../doc/models/v1-organizations-activities-500-error-exception.md) |


# Organization Private Endpoint Config Get List

**This endpoint is deprecated.**

Deprecated. Please follow [documentation](https://clickhouse.com/docs/manage/security/aws-privatelink#add-endpoint-id-to-services-allow-list) for the updated process.

```csharp
OrganizationPrivateEndpointConfigGetListAsync(
    Guid organizationId,
    string cloudProvider,
    string regionId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `cloudProvider` | `string` | Query, Required | Cloud provider identifier. One of aws, gcp, or azure. |
| `regionId` | `string` | Query, Required | Region identifier within specific cloud providers. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPrivateEndpointConfigResponse](../../doc/models/v1-organizations-private-endpoint-config-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string cloudProvider = "cloud_provider6";
string regionId = "region_id6";
try
{
    ApiResponse<V1OrganizationsPrivateEndpointConfigResponse> result = await organizationApi.OrganizationPrivateEndpointConfigGetListAsync(
        organizationId,
        cloudProvider,
        regionId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPrivateEndpointConfig400ErrorException)
    {
       // TODO: Handle V1OrganizationsPrivateEndpointConfig400ErrorException exception here
    }
    if (e is V1OrganizationsPrivateEndpointConfig500ErrorException)
    {
       // TODO: Handle V1OrganizationsPrivateEndpointConfig500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPrivateEndpointConfig400ErrorException`](../../doc/models/v1-organizations-private-endpoint-config-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPrivateEndpointConfig500ErrorException`](../../doc/models/v1-organizations-private-endpoint-config-500-error-exception.md) |


# Organization Byoc Infrastructure Create

Create a new BYOC Infrastructure in the organization. Returns the configuration of the newly created infrastructure

```csharp
OrganizationByocInfrastructureCreateAsync(
    Guid organizationId,
    Models.ByocInfrastructurePostRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `body` | [`ByocInfrastructurePostRequest`](../../doc/models/byoc-infrastructure-post-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsByocInfrastructureResponse](../../doc/models/v1-organizations-byoc-infrastructure-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsByocInfrastructureResponse> result = await organizationApi.OrganizationByocInfrastructureCreateAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsByocInfrastructure400ErrorException)
    {
       // TODO: Handle V1OrganizationsByocInfrastructure400ErrorException exception here
    }
    if (e is V1OrganizationsByocInfrastructure500ErrorException)
    {
       // TODO: Handle V1OrganizationsByocInfrastructure500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsByocInfrastructure400ErrorException`](../../doc/models/v1-organizations-byoc-infrastructure-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsByocInfrastructure500ErrorException`](../../doc/models/v1-organizations-byoc-infrastructure-500-error-exception.md) |


# Organization Byoc Infrastructure Delete

Removes a BYOC Infrastructure from the organization

```csharp
OrganizationByocInfrastructureDeleteAsync(
    Guid organizationId,
    Guid byocInfrastructureId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `byocInfrastructureId` | `Guid` | Template, Required | ID of the requested BYOC Infrastructure |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsByocInfrastructureResponse1](../../doc/models/v1-organizations-byoc-infrastructure-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid byocInfrastructureId = new Guid("00000e02-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsByocInfrastructureResponse1> result = await organizationApi.OrganizationByocInfrastructureDeleteAsync(
        organizationId,
        byocInfrastructureId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsByocInfrastructure400ErrorException)
    {
       // TODO: Handle V1OrganizationsByocInfrastructure400ErrorException exception here
    }
    if (e is V1OrganizationsByocInfrastructure500ErrorException)
    {
       // TODO: Handle V1OrganizationsByocInfrastructure500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsByocInfrastructure400ErrorException`](../../doc/models/v1-organizations-byoc-infrastructure-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsByocInfrastructure500ErrorException`](../../doc/models/v1-organizations-byoc-infrastructure-500-error-exception.md) |


# Organization Byoc Infrastructure Update

Update configuration of the BYOC infrastructure. Returns the modified infrastructure

```csharp
OrganizationByocInfrastructureUpdateAsync(
    Guid organizationId,
    Guid byocInfrastructureId,
    Models.ByocInfrastructurePatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `byocInfrastructureId` | `Guid` | Template, Required | ID of the requested BYOC Infrastructure |
| `body` | [`ByocInfrastructurePatchRequest`](../../doc/models/byoc-infrastructure-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsByocInfrastructureResponse](../../doc/models/v1-organizations-byoc-infrastructure-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid byocInfrastructureId = new Guid("00000e02-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsByocInfrastructureResponse> result = await organizationApi.OrganizationByocInfrastructureUpdateAsync(
        organizationId,
        byocInfrastructureId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsByocInfrastructure400ErrorException)
    {
       // TODO: Handle V1OrganizationsByocInfrastructure400ErrorException exception here
    }
    if (e is V1OrganizationsByocInfrastructure500ErrorException)
    {
       // TODO: Handle V1OrganizationsByocInfrastructure500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsByocInfrastructure400ErrorException`](../../doc/models/v1-organizations-byoc-infrastructure-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsByocInfrastructure500ErrorException`](../../doc/models/v1-organizations-byoc-infrastructure-500-error-exception.md) |

