# Service

```csharp
ServiceApi serviceApi = client.ServiceApi;
```

## Class Name

`ServiceApi`

## Methods

* [Service Profiles List](../../doc/controllers/service.md#service-profiles-list)
* [Instance Get List](../../doc/controllers/service.md#instance-get-list)
* [Instance Create](../../doc/controllers/service.md#instance-create)
* [Instance Get](../../doc/controllers/service.md#instance-get)
* [Instance Update](../../doc/controllers/service.md#instance-update)
* [Instance Delete](../../doc/controllers/service.md#instance-delete)
* [Instance Private Endpoint Config Get](../../doc/controllers/service.md#instance-private-endpoint-config-get)
* [Instance Query Endpoint Get](../../doc/controllers/service.md#instance-query-endpoint-get)
* [Instance Query Endpoint Delete](../../doc/controllers/service.md#instance-query-endpoint-delete)
* [Instance Query Endpoint Upsert](../../doc/controllers/service.md#instance-query-endpoint-upsert)
* [Instance State Update](../../doc/controllers/service.md#instance-state-update)
* [Instance Scaling Update](../../doc/controllers/service.md#instance-scaling-update)
* [Instance Replica Scaling Update](../../doc/controllers/service.md#instance-replica-scaling-update)
* [Instance Password Update](../../doc/controllers/service.md#instance-password-update)
* [Instance Private Endpoint Create](../../doc/controllers/service.md#instance-private-endpoint-create)
* [Scaling Schedule Get](../../doc/controllers/service.md#scaling-schedule-get)
* [Scaling Schedule Upsert](../../doc/controllers/service.md#scaling-schedule-upsert)
* [Scaling Schedule Delete](../../doc/controllers/service.md#scaling-schedule-delete)
* [Upgrade Window Get](../../doc/controllers/service.md#upgrade-window-get)
* [Upgrade Window Update](../../doc/controllers/service.md#upgrade-window-update)
* [Upgrade Window Delete](../../doc/controllers/service.md#upgrade-window-delete)
* [Service Clickhouse Settings List Get](../../doc/controllers/service.md#service-clickhouse-settings-list-get)
* [Service Clickhouse Settings Update](../../doc/controllers/service.md#service-clickhouse-settings-update)
* [Service Clickhouse Settings Schema Get](../../doc/controllers/service.md#service-clickhouse-settings-schema-get)
* [Service Clickhouse Setting Get](../../doc/controllers/service.md#service-clickhouse-setting-get)
* [Service Clickhouse Setting Delete](../../doc/controllers/service.md#service-clickhouse-setting-delete)


# Service Profiles List

Returns the custom instance profiles the organization can use in a region. Pass byoc_id to list the profiles configured for a BYOC infrastructure; the region is then taken from the infrastructure and region_id may be omitted. The list is empty when the organization tier does not include custom hardware profiles.

```csharp
ServiceProfilesListAsync(
    Guid organizationId,
    string regionId = null,
    Guid? byocId = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization to list available profiles for. |
| `regionId` | `string` | Query, Optional | Region to list profiles for, e.g. us-east-1. Required unless byoc_id is set; when both are set it must match the BYOC infrastructure's region. |
| `byocId` | `Guid?` | Query, Optional | ID of the BYOC infrastructure to list profiles for. BYOC profiles are only returned when this is set. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServiceProfilesResponse](../../doc/models/v1-organizations-service-profiles-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServiceProfilesResponse> result = await serviceApi.ServiceProfilesListAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServiceProfiles400ErrorException)
    {
       // TODO: Handle V1OrganizationsServiceProfiles400ErrorException exception here
    }
    if (e is V1OrganizationsServiceProfiles500ErrorException)
    {
       // TODO: Handle V1OrganizationsServiceProfiles500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServiceProfiles400ErrorException`](../../doc/models/v1-organizations-service-profiles-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServiceProfiles500ErrorException`](../../doc/models/v1-organizations-service-profiles-500-error-exception.md) |


# Instance Get List

Returns a list of all services in the organization.

```csharp
InstanceGetListAsync(
    Guid organizationId,
    List<string> filter = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `filter` | `List<string>` | Query, Optional | Filter criteria to apply when retrieving the resource. Currently, only filtering by resource tags is supported. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesResponse](../../doc/models/v1-organizations-services-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
List<string> filter = new List<string>
{
    "tag:Environment=Production",
    "tag:Department=Engineering",
    "tag:isActive",
};

try
{
    ApiResponse<V1OrganizationsServicesResponse> result = await serviceApi.InstanceGetListAsync(
        organizationId,
        filter
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServices400ErrorException)
    {
       // TODO: Handle V1OrganizationsServices400ErrorException exception here
    }
    if (e is V1OrganizationsServices500ErrorException)
    {
       // TODO: Handle V1OrganizationsServices500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServices400ErrorException`](../../doc/models/v1-organizations-services-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServices500ErrorException`](../../doc/models/v1-organizations-services-500-error-exception.md) |


# Instance Create

Creates a new service in the organization, and returns the current service state and a password to access the service. The service is started asynchronously.

```csharp
InstanceCreateAsync(
    Guid organizationId,
    Models.ServicePostRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that will own the service. |
| `body` | [`ServicePostRequest`](../../doc/models/service-post-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesResponse1](../../doc/models/v1-organizations-services-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
ServicePostRequest body = new ServicePostRequest
{
    MinTotalMemoryGb = 48,
    MaxTotalMemoryGb = 360,
    AutoscalingMode = AutoscalingMode4.Vertical,
    MinReplicaMemoryGb = 16,
    MaxReplicaMemoryGb = 120,
    NumReplicas = 3,
    MinReplicas = 1,
    MaxReplicas = 5,
};

try
{
    ApiResponse<V1OrganizationsServicesResponse1> result = await serviceApi.InstanceCreateAsync(
        organizationId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServices400ErrorException)
    {
       // TODO: Handle V1OrganizationsServices400ErrorException exception here
    }
    if (e is V1OrganizationsServices500ErrorException)
    {
       // TODO: Handle V1OrganizationsServices500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServices400ErrorException`](../../doc/models/v1-organizations-services-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServices500ErrorException`](../../doc/models/v1-organizations-services-500-error-exception.md) |


# Instance Get

Returns a service that belongs to the organization

```csharp
InstanceGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesResponse2](../../doc/models/v1-organizations-services-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesResponse2> result = await serviceApi.InstanceGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServices400ErrorException)
    {
       // TODO: Handle V1OrganizationsServices400ErrorException exception here
    }
    if (e is V1OrganizationsServices500ErrorException)
    {
       // TODO: Handle V1OrganizationsServices500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServices400ErrorException`](../../doc/models/v1-organizations-services-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServices500ErrorException`](../../doc/models/v1-organizations-services-500-error-exception.md) |


# Instance Update

Updates basic service details like service name or IP access list.

```csharp
InstanceUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ServicePatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service to update. |
| `body` | [`ServicePatchRequest`](../../doc/models/service-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesResponse2](../../doc/models/v1-organizations-services-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesResponse2> result = await serviceApi.InstanceUpdateAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServices400ErrorException)
    {
       // TODO: Handle V1OrganizationsServices400ErrorException exception here
    }
    if (e is V1OrganizationsServices500ErrorException)
    {
       // TODO: Handle V1OrganizationsServices500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServices400ErrorException`](../../doc/models/v1-organizations-services-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServices500ErrorException`](../../doc/models/v1-organizations-services-500-error-exception.md) |


# Instance Delete

Deletes the service. The service must be in stopped state and is deleted asynchronously after this method call.

```csharp
InstanceDeleteAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service to delete. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesResponse4](../../doc/models/v1-organizations-services-response-4.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesResponse4> result = await serviceApi.InstanceDeleteAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServices400ErrorException)
    {
       // TODO: Handle V1OrganizationsServices400ErrorException exception here
    }
    if (e is V1OrganizationsServices500ErrorException)
    {
       // TODO: Handle V1OrganizationsServices500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServices400ErrorException`](../../doc/models/v1-organizations-services-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServices500ErrorException`](../../doc/models/v1-organizations-services-500-error-exception.md) |


# Instance Private Endpoint Config Get

Information required to set up a private endpoint

```csharp
InstancePrivateEndpointConfigGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesPrivateEndpointConfigResponse](../../doc/models/v1-organizations-services-private-endpoint-config-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesPrivateEndpointConfigResponse> result = await serviceApi.InstancePrivateEndpointConfigGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesPrivateEndpointConfig400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesPrivateEndpointConfig400ErrorException exception here
    }
    if (e is V1OrganizationsServicesPrivateEndpointConfig500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesPrivateEndpointConfig500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesPrivateEndpointConfig400ErrorException`](../../doc/models/v1-organizations-services-private-endpoint-config-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesPrivateEndpointConfig500ErrorException`](../../doc/models/v1-organizations-services-private-endpoint-config-500-error-exception.md) |


# Instance Query Endpoint Get

Get the configuration for the service query endpoint that allows executing queries via API.

```csharp
InstanceQueryEndpointGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesServiceQueryEndpointResponse](../../doc/models/v1-organizations-services-service-query-endpoint-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesServiceQueryEndpointResponse> result = await serviceApi.InstanceQueryEndpointGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesServiceQueryEndpoint400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesServiceQueryEndpoint400ErrorException exception here
    }
    if (e is V1OrganizationsServicesServiceQueryEndpoint500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesServiceQueryEndpoint500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesServiceQueryEndpoint400ErrorException`](../../doc/models/v1-organizations-services-service-query-endpoint-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesServiceQueryEndpoint500ErrorException`](../../doc/models/v1-organizations-services-service-query-endpoint-500-error-exception.md) |


# Instance Query Endpoint Delete

Removes the service query endpoint.

```csharp
InstanceQueryEndpointDeleteAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesServiceQueryEndpointResponse1](../../doc/models/v1-organizations-services-service-query-endpoint-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesServiceQueryEndpointResponse1> result = await serviceApi.InstanceQueryEndpointDeleteAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesServiceQueryEndpoint400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesServiceQueryEndpoint400ErrorException exception here
    }
    if (e is V1OrganizationsServicesServiceQueryEndpoint500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesServiceQueryEndpoint500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesServiceQueryEndpoint400ErrorException`](../../doc/models/v1-organizations-services-service-query-endpoint-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesServiceQueryEndpoint500ErrorException`](../../doc/models/v1-organizations-services-service-query-endpoint-500-error-exception.md) |


# Instance Query Endpoint Upsert

Create the service query endpoint that allows executing queries via API.

```csharp
InstanceQueryEndpointUpsertAsync(
    Guid organizationId,
    Guid serviceId,
    Models.InstanceServiceQueryApiEndpointsPostRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `body` | [`InstanceServiceQueryApiEndpointsPostRequest`](../../doc/models/instance-service-query-api-endpoints-post-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesServiceQueryEndpointResponse](../../doc/models/v1-organizations-services-service-query-endpoint-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesServiceQueryEndpointResponse> result = await serviceApi.InstanceQueryEndpointUpsertAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesServiceQueryEndpoint400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesServiceQueryEndpoint400ErrorException exception here
    }
    if (e is V1OrganizationsServicesServiceQueryEndpoint500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesServiceQueryEndpoint500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesServiceQueryEndpoint400ErrorException`](../../doc/models/v1-organizations-services-service-query-endpoint-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesServiceQueryEndpoint500ErrorException`](../../doc/models/v1-organizations-services-service-query-endpoint-500-error-exception.md) |


# Instance State Update

Starts, stops, or wakes a service. The `start` and `stop` commands require the `control-plane:service:manage` permission on the service. The `awake` command requires only `control-plane:service:view` and applies to an idle service; it does not start a stopped service.

```csharp
InstanceStateUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ServiceStatePatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service to update state. |
| `body` | [`ServiceStatePatchRequest`](../../doc/models/service-state-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesStateResponse](../../doc/models/v1-organizations-services-state-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesStateResponse> result = await serviceApi.InstanceStateUpdateAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesState400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesState400ErrorException exception here
    }
    if (e is V1OrganizationsServicesState500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesState500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesState400ErrorException`](../../doc/models/v1-organizations-services-state-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesState500ErrorException`](../../doc/models/v1-organizations-services-state-500-error-exception.md) |


# Instance Scaling Update

**This endpoint is deprecated.**

Updates minimum and maximum total memory limits and idle mode scaling behavior for the service. The memory settings are available only for "production" services and must be a multiple of 12 starting from 24GB. Please contact support to enable adjustment of numReplicas.

```csharp
InstanceScalingUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ServiceScalingPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service to update scaling parameters. |
| `body` | [`ServiceScalingPatchRequest`](../../doc/models/service-scaling-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesScalingResponse](../../doc/models/v1-organizations-services-scaling-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ServiceScalingPatchRequest body = new ServiceScalingPatchRequest
{
    MinTotalMemoryGb = 48,
    MaxTotalMemoryGb = 360,
    NumReplicas = 3,
};

try
{
    ApiResponse<V1OrganizationsServicesScalingResponse> result = await serviceApi.InstanceScalingUpdateAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesScaling400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesScaling400ErrorException exception here
    }
    if (e is V1OrganizationsServicesScaling500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesScaling500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesScaling400ErrorException`](../../doc/models/v1-organizations-services-scaling-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesScaling500ErrorException`](../../doc/models/v1-organizations-services-scaling-500-error-exception.md) |


# Instance Replica Scaling Update

Updates minimum and maximum memory limits per replica and idle mode scaling behavior for the service. Supports both vertical autoscaling (fixed replica count, variable memory) and horizontal autoscaling (variable replica count, fixed memory). The memory settings are available only for "production" services and must be a multiple of 4 starting from 8GB. For vertical autoscaling, please contact support to enable adjustment of numReplicas. For horizontal autoscaling (autoscalingMode "horizontal" with minReplicas/maxReplicas), contact support to enable the feature for your organization.

```csharp
InstanceReplicaScalingUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ServiceReplicaScalingPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service to update scaling parameters. |
| `body` | [`ServiceReplicaScalingPatchRequest`](../../doc/models/service-replica-scaling-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesReplicaScalingResponse](../../doc/models/v1-organizations-services-replica-scaling-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ServiceReplicaScalingPatchRequest body = new ServiceReplicaScalingPatchRequest
{
    MinReplicaMemoryGb = 16,
    MaxReplicaMemoryGb = 120,
    AutoscalingMode = AutoscalingMode6.Vertical,
    NumReplicas = 3,
    MinReplicas = 1,
    MaxReplicas = 5,
};

try
{
    ApiResponse<V1OrganizationsServicesReplicaScalingResponse> result = await serviceApi.InstanceReplicaScalingUpdateAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesReplicaScaling400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesReplicaScaling400ErrorException exception here
    }
    if (e is V1OrganizationsServicesReplicaScaling500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesReplicaScaling500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesReplicaScaling400ErrorException`](../../doc/models/v1-organizations-services-replica-scaling-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesReplicaScaling500ErrorException`](../../doc/models/v1-organizations-services-replica-scaling-500-error-exception.md) |


# Instance Password Update

Sets a new password for the service

```csharp
InstancePasswordUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ServicePasswordPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service to update password. |
| `body` | [`ServicePasswordPatchRequest`](../../doc/models/service-password-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesPasswordResponse](../../doc/models/v1-organizations-services-password-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesPasswordResponse> result = await serviceApi.InstancePasswordUpdateAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesPassword400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesPassword400ErrorException exception here
    }
    if (e is V1OrganizationsServicesPassword500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesPassword500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesPassword400ErrorException`](../../doc/models/v1-organizations-services-password-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesPassword500ErrorException`](../../doc/models/v1-organizations-services-password-500-error-exception.md) |


# Instance Private Endpoint Create

Create a new private endpoint. The private endpoint will be associated with this service and organization

```csharp
InstancePrivateEndpointCreateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ServicPrivateEndpointePostRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `body` | [`ServicPrivateEndpointePostRequest`](../../doc/models/servic-private-endpointe-post-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesPrivateEndpointResponse](../../doc/models/v1-organizations-services-private-endpoint-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesPrivateEndpointResponse> result = await serviceApi.InstancePrivateEndpointCreateAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesPrivateEndpoint400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesPrivateEndpoint400ErrorException exception here
    }
    if (e is V1OrganizationsServicesPrivateEndpoint500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesPrivateEndpoint500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesPrivateEndpoint400ErrorException`](../../doc/models/v1-organizations-services-private-endpoint-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesPrivateEndpoint500ErrorException`](../../doc/models/v1-organizations-services-private-endpoint-500-error-exception.md) |


# Scaling Schedule Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the autoscaling schedule for a service. Returns 404 if no schedule has been configured or if the schedule was cleared. Requires the scheduled autoscaling feature to be enabled for the organization.

```csharp
ScalingScheduleGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesScalingScheduleResponse](../../doc/models/v1-organizations-services-scaling-schedule-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesScalingScheduleResponse> result = await serviceApi.ScalingScheduleGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesScalingSchedule400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesScalingSchedule400ErrorException exception here
    }
    if (e is V1OrganizationsServicesScalingSchedule500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesScalingSchedule500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesScalingSchedule400ErrorException`](../../doc/models/v1-organizations-services-scaling-schedule-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesScalingSchedule500ErrorException`](../../doc/models/v1-organizations-services-scaling-schedule-500-error-exception.md) |


# Scaling Schedule Upsert

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Creates or fully replaces the autoscaling schedule for a service. Pass an empty `entries` array to clear the schedule — a subsequent GET will return 404, and the response will contain an empty `baseConfig` (all fields absent). The base scaling config (applied when no entry is active) is managed separately via the `replicaScaling` endpoint. Requires the scheduled autoscaling feature to be enabled for the organization.

```csharp
ScalingScheduleUpsertAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ScalingSchedulePostRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |
| `body` | [`ScalingSchedulePostRequest`](../../doc/models/scaling-schedule-post-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesScalingScheduleResponse](../../doc/models/v1-organizations-services-scaling-schedule-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ScalingSchedulePostRequest body = new ScalingSchedulePostRequest
{
    Entries = new List<ScalingScheduleEntryRequest>
    {
        new ScalingScheduleEntryRequest
        {
            Name = "Business hours",
            Weekdays = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
            },
            StartHourUtc = 9,
            EndHourUtc = 17,
            AutoscalingMode = AutoscalingMode2.Vertical,
            MinReplicaMemoryGb = 16,
            MaxReplicaMemoryGb = 16,
            NumReplicas = 3,
            MinReplicas = 2,
            MaxReplicas = 3,
        },
    },
};

try
{
    ApiResponse<V1OrganizationsServicesScalingScheduleResponse> result = await serviceApi.ScalingScheduleUpsertAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesScalingSchedule400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesScalingSchedule400ErrorException exception here
    }
    if (e is V1OrganizationsServicesScalingSchedule500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesScalingSchedule500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesScalingSchedule400ErrorException`](../../doc/models/v1-organizations-services-scaling-schedule-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesScalingSchedule500ErrorException`](../../doc/models/v1-organizations-services-scaling-schedule-500-error-exception.md) |


# Scaling Schedule Delete

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Deletes the autoscaling schedule for a service. If a schedule entry is currently active, the base scaling config is restored to the instance before the schedule is removed. Returns 404 if no schedule exists. Requires the scheduled autoscaling feature to be enabled for the organization.

```csharp
ScalingScheduleDeleteAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesScalingScheduleResponse2](../../doc/models/v1-organizations-services-scaling-schedule-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesScalingScheduleResponse2> result = await serviceApi.ScalingScheduleDeleteAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesScalingSchedule400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesScalingSchedule400ErrorException exception here
    }
    if (e is V1OrganizationsServicesScalingSchedule500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesScalingSchedule500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesScalingSchedule400ErrorException`](../../doc/models/v1-organizations-services-scaling-schedule-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesScalingSchedule500ErrorException`](../../doc/models/v1-organizations-services-scaling-schedule-500-error-exception.md) |


# Upgrade Window Get

Returns the configured upgrade window for a service.

Errors:

- 401: missing, invalid, or disabled API key.
- 403: caller lacks `control-plane:service:view` on the service.
- 404: service does not exist, is not visible to the caller, or no upgrade window has been configured.

```csharp
UpgradeWindowGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesUpgradeWindowResponse](../../doc/models/v1-organizations-services-upgrade-window-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesUpgradeWindowResponse> result = await serviceApi.UpgradeWindowGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesUpgradeWindow400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesUpgradeWindow400ErrorException exception here
    }
    if (e is V1OrganizationsServicesUpgradeWindow500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesUpgradeWindow500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesUpgradeWindow400ErrorException`](../../doc/models/v1-organizations-services-upgrade-window-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesUpgradeWindow500ErrorException`](../../doc/models/v1-organizations-services-upgrade-window-500-error-exception.md) |


# Upgrade Window Update

Creates or fully replaces the upgrade window for a service. The upgrade window currently lasts 6 hours from `startHourUtc`. The upgrade window can only be set on primary services; secondary services inherit the primary service window.

Errors:

- 400: invalid field values (`weekday` not in 0–6, `startHourUtc` not in {0, 6, 12, 18}), or the service is a secondary service.
- 401: missing, invalid, or disabled API key.
- 403: caller lacks `control-plane:service:manage` on the service, or the organization does not have the scheduled upgrades feature enabled.
- 404: service does not exist or is not visible to the caller.

```csharp
UpgradeWindowUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.UpgradeWindowPutRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |
| `body` | [`UpgradeWindowPutRequest`](../../doc/models/upgrade-window-put-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesUpgradeWindowResponse](../../doc/models/v1-organizations-services-upgrade-window-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
UpgradeWindowPutRequest body = new UpgradeWindowPutRequest
{
    Weekday = 3,
    StartHourUtc = StartHourUtc1.Hour12,
};

try
{
    ApiResponse<V1OrganizationsServicesUpgradeWindowResponse> result = await serviceApi.UpgradeWindowUpdateAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesUpgradeWindow400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesUpgradeWindow400ErrorException exception here
    }
    if (e is V1OrganizationsServicesUpgradeWindow500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesUpgradeWindow500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesUpgradeWindow400ErrorException`](../../doc/models/v1-organizations-services-upgrade-window-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesUpgradeWindow500ErrorException`](../../doc/models/v1-organizations-services-upgrade-window-500-error-exception.md) |


# Upgrade Window Delete

Deletes the upgrade window for a service, restoring the default scheduling behaviour. The upgrade window can only be deleted on primary services. Deletion succeeds even if the organization has lost the scheduled upgrades entitlement, so a window can be cleared after entitlement loss.

Errors:

- 400: the service is a secondary service.
- 401: missing, invalid, or disabled API key.
- 403: caller lacks `control-plane:service:manage` on the service.
- 404: service does not exist, is not visible to the caller, or no upgrade window is configured.

```csharp
UpgradeWindowDeleteAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesUpgradeWindowResponse2](../../doc/models/v1-organizations-services-upgrade-window-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesUpgradeWindowResponse2> result = await serviceApi.UpgradeWindowDeleteAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesUpgradeWindow400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesUpgradeWindow400ErrorException exception here
    }
    if (e is V1OrganizationsServicesUpgradeWindow500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesUpgradeWindow500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesUpgradeWindow400ErrorException`](../../doc/models/v1-organizations-services-upgrade-window-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesUpgradeWindow500ErrorException`](../../doc/models/v1-organizations-services-upgrade-window-500-error-exception.md) |


# Service Clickhouse Settings List Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the configured ClickHouse settings for the service. Only settings that have been explicitly set are included.

```csharp
ServiceClickhouseSettingsListGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickhouseSettingsResponse](../../doc/models/v1-organizations-services-clickhouse-settings-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickhouseSettingsResponse> result = await serviceApi.ServiceClickhouseSettingsListGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickhouseSettings400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickhouseSettings400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickhouseSettings500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickhouseSettings500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickhouseSettings400ErrorException`](../../doc/models/v1-organizations-services-clickhouse-settings-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickhouseSettings500ErrorException`](../../doc/models/v1-organizations-services-clickhouse-settings-500-error-exception.md) |


# Service Clickhouse Settings Update

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Updates one or more ClickHouse settings for the service. To reset a setting to its platform default, use the [DELETE single setting](#tag/Service/operation/serviceClickhouseSettingDelete) endpoint. Use the [schema endpoint](#tag/Service/operation/serviceClickhouseSettingsSchemaGet) to discover which settings are configurable.

```csharp
ServiceClickhouseSettingsUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ServiceClickhouseSettingsPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |
| `body` | [`ServiceClickhouseSettingsPatchRequest`](../../doc/models/service-clickhouse-settings-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickhouseSettingsResponse1](../../doc/models/v1-organizations-services-clickhouse-settings-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ServiceClickhouseSettingsPatchRequest body = new ServiceClickhouseSettingsPatchRequest
{
    Settings = new Dictionary<string, ServiceClickhouseSettingValue>
    {
        ["compatibility"] = ServiceClickhouseSettingValue.FromString("26.2"),
        ["max_query_size"] = ServiceClickhouseSettingValue.FromNumber(262144),
    },
};

try
{
    ApiResponse<V1OrganizationsServicesClickhouseSettingsResponse1> result = await serviceApi.ServiceClickhouseSettingsUpdateAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickhouseSettings400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickhouseSettings400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickhouseSettings500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickhouseSettings500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickhouseSettings400ErrorException`](../../doc/models/v1-organizations-services-clickhouse-settings-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickhouseSettings500ErrorException`](../../doc/models/v1-organizations-services-clickhouse-settings-500-error-exception.md) |


# Service Clickhouse Settings Schema Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the schema of all configurable ClickHouse settings, including types, valid values, descriptions, and warnings.

```csharp
ServiceClickhouseSettingsSchemaGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickhouseSettingsSchemaResponse](../../doc/models/v1-organizations-services-clickhouse-settings-schema-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickhouseSettingsSchemaResponse> result = await serviceApi.ServiceClickhouseSettingsSchemaGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickhouseSettingsSchema400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickhouseSettingsSchema400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickhouseSettingsSchema500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickhouseSettingsSchema500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickhouseSettingsSchema400ErrorException`](../../doc/models/v1-organizations-services-clickhouse-settings-schema-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickhouseSettingsSchema500ErrorException`](../../doc/models/v1-organizations-services-clickhouse-settings-schema-500-error-exception.md) |


# Service Clickhouse Setting Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the current value of a ClickHouse setting for the service. Use the [schema endpoint](#tag/Service/operation/serviceClickhouseSettingsSchemaGet) to discover which settings are configurable.

```csharp
ServiceClickhouseSettingGetAsync(
    Guid organizationId,
    Guid serviceId,
    string settingName)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |
| `settingName` | `string` | Template, Required | Name of the setting to retrieve. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickhouseSettingsSettingNameResponse](../../doc/models/v1-organizations-services-clickhouse-settings-setting-name-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string settingName = "settingName0";
try
{
    ApiResponse<V1OrganizationsServicesClickhouseSettingsSettingNameResponse> result = await serviceApi.ServiceClickhouseSettingGetAsync(
        organizationId,
        serviceId,
        settingName
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickhouseSettingsSettingName400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickhouseSettingsSettingName400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickhouseSettingsSettingName500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickhouseSettingsSettingName500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickhouseSettingsSettingName400ErrorException`](../../doc/models/v1-organizations-services-clickhouse-settings-setting-name-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickhouseSettingsSettingName500ErrorException`](../../doc/models/v1-organizations-services-clickhouse-settings-setting-name-500-error-exception.md) |


# Service Clickhouse Setting Delete

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Removes a previously-configured ClickHouse setting, reverting its effective value to the platform default. Settings under `spec.extraConfig.server.*` (e.g. `keep_alive_timeout`, `shared_merge_tree_disable_merges_and_mutations_assignment`) trigger a ClickHouse server rollout restart; other settings propagate to all replicas after a short delay. Deleting a setting that was never configured is a no-op (200 OK).

```csharp
ServiceClickhouseSettingDeleteAsync(
    Guid organizationId,
    Guid serviceId,
    string settingName)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |
| `settingName` | `string` | Template, Required | Name of the setting to reset. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickhouseSettingsSettingNameResponse1](../../doc/models/v1-organizations-services-clickhouse-settings-setting-name-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
string settingName = "settingName0";
try
{
    ApiResponse<V1OrganizationsServicesClickhouseSettingsSettingNameResponse1> result = await serviceApi.ServiceClickhouseSettingDeleteAsync(
        organizationId,
        serviceId,
        settingName
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickhouseSettingsSettingName400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickhouseSettingsSettingName400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickhouseSettingsSettingName500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickhouseSettingsSettingName500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickhouseSettingsSettingName400ErrorException`](../../doc/models/v1-organizations-services-clickhouse-settings-setting-name-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickhouseSettingsSettingName500ErrorException`](../../doc/models/v1-organizations-services-clickhouse-settings-setting-name-500-error-exception.md) |

