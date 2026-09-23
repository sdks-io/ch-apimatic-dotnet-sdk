# Click Pipes

```csharp
ClickPipesApi clickPipesApi = client.ClickPipesApi;
```

## Class Name

`ClickPipesApi`

## Methods

* [Click Pipe Get List](../../doc/controllers/click-pipes.md#click-pipe-get-list)
* [Click Pipe Create](../../doc/controllers/click-pipes.md#click-pipe-create)
* [Click Pipes Service Context Get](../../doc/controllers/click-pipes.md#click-pipes-service-context-get)
* [Click Pipe Get](../../doc/controllers/click-pipes.md#click-pipe-get)
* [Click Pipe Update](../../doc/controllers/click-pipes.md#click-pipe-update)
* [Click Pipe Delete](../../doc/controllers/click-pipes.md#click-pipe-delete)
* [Click Pipe Settings Get](../../doc/controllers/click-pipes.md#click-pipe-settings-get)
* [Click Pipe Settings Update](../../doc/controllers/click-pipes.md#click-pipe-settings-update)
* [Click Pipe Schema Discovery](../../doc/controllers/click-pipes.md#click-pipe-schema-discovery)
* [Click Pipe Scaling Update](../../doc/controllers/click-pipes.md#click-pipe-scaling-update)
* [Click Pipe State Update](../../doc/controllers/click-pipes.md#click-pipe-state-update)
* [Click Pipe Cdc Scaling Get](../../doc/controllers/click-pipes.md#click-pipe-cdc-scaling-get)
* [Click Pipe Cdc Scaling Update](../../doc/controllers/click-pipes.md#click-pipe-cdc-scaling-update)
* [Click Pipe Reverse Private Endpoint Get List](../../doc/controllers/click-pipes.md#click-pipe-reverse-private-endpoint-get-list)
* [Click Pipe Reverse Private Endpoint Create](../../doc/controllers/click-pipes.md#click-pipe-reverse-private-endpoint-create)
* [Click Pipe Reverse Private Endpoint Get](../../doc/controllers/click-pipes.md#click-pipe-reverse-private-endpoint-get)
* [Click Pipe Reverse Private Endpoint Delete](../../doc/controllers/click-pipes.md#click-pipe-reverse-private-endpoint-delete)
* [Click Pipe Reverse Private Endpoint Update](../../doc/controllers/click-pipes.md#click-pipe-reverse-private-endpoint-update)


# Click Pipe Get List

Returns a list of ClickPipes.

```csharp
ClickPipeGetListAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the ClickPipe. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesResponse](../../doc/models/v1-organizations-services-clickpipes-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesResponse> result = await clickPipesApi.ClickPipeGetListAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipes400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipes400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipes500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipes500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipes400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipes500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-500-error-exception.md) |


# Click Pipe Create

Create a new ClickPipe.

```csharp
ClickPipeCreateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ClickPipePostRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service to create the ClickPipe for. |
| `body` | [`ClickPipePostRequest`](../../doc/models/click-pipe-post-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesResponse1](../../doc/models/v1-organizations-services-clickpipes-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesResponse1> result = await clickPipesApi.ClickPipeCreateAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipes400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipes400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipes500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipes500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipes400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipes500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-500-error-exception.md) |


# Click Pipes Service Context Get

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns service-level ClickPipes capabilities and Private Preview workload identity context, including the GCP service account to grant access to customer source resources.

```csharp
ClickPipesServiceContextGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service to get ClickPipes context for. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesContextResponse](../../doc/models/v1-organizations-services-clickpipes-context-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesContextResponse> result = await clickPipesApi.ClickPipesServiceContextGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesContext400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesContext400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesContext500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesContext500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesContext400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-context-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesContext500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-context-500-error-exception.md) |


# Click Pipe Get

Returns the specified ClickPipe.

```csharp
ClickPipeGetAsync(
    Guid organizationId,
    Guid serviceId,
    Guid clickPipeId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the ClickPipe. |
| `clickPipeId` | `Guid` | Template, Required | ID of the requested ClickPipe. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesClickPipeIdResponse](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid clickPipeId = new Guid("000014a6-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesClickPipeIdResponse> result = await clickPipesApi.ClickPipeGetAsync(
        organizationId,
        serviceId,
        clickPipeId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesClickPipeId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesClickPipeId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesClickPipeId400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesClickPipeId500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-500-error-exception.md) |


# Click Pipe Update

Update the specified ClickPipe. Source fields not present in the per-source update schemas are immutable after creation. For Kafka sources, values submitted for immutable fields (type, format, brokers, topics, consumerGroup, offset, schemaRegistry, exactlyOnce) are not applied, except schema registry credentials, which are rejected.

```csharp
ClickPipeUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Guid clickPipeId,
    Models.ClickPipePatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service to create the ClickPipe for. |
| `clickPipeId` | `Guid` | Template, Required | ID of the requested ClickPipe. |
| `body` | [`ClickPipePatchRequest`](../../doc/models/click-pipe-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesClickPipeIdResponse](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid clickPipeId = new Guid("000014a6-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesClickPipeIdResponse> result = await clickPipesApi.ClickPipeUpdateAsync(
        organizationId,
        serviceId,
        clickPipeId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesClickPipeId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesClickPipeId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesClickPipeId400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesClickPipeId500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-500-error-exception.md) |


# Click Pipe Delete

Delete the specified ClickPipe.

```csharp
ClickPipeDeleteAsync(
    Guid organizationId,
    Guid serviceId,
    Guid clickPipeId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the ClickPipe. |
| `clickPipeId` | `Guid` | Template, Required | ID of the ClickPipe to delete. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesClickPipeIdResponse2](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid clickPipeId = new Guid("000014a6-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesClickPipeIdResponse2> result = await clickPipesApi.ClickPipeDeleteAsync(
        organizationId,
        serviceId,
        clickPipeId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesClickPipeId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesClickPipeId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesClickPipeId400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesClickPipeId500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-500-error-exception.md) |


# Click Pipe Settings Get

Returns the advanced settings for the specified ClickPipe.

```csharp
ClickPipeSettingsGetAsync(
    Guid organizationId,
    Guid serviceId,
    Guid clickPipeId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the ClickPipe. |
| `clickPipeId` | `Guid` | Template, Required | ID of the ClickPipe to get settings for. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-settings-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid clickPipeId = new Guid("000014a6-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse> result = await clickPipesApi.ClickPipeSettingsGetAsync(
        organizationId,
        serviceId,
        clickPipeId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesClickPipeIdSettings400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeIdSettings400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesClickPipeIdSettings500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeIdSettings500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesClickPipeIdSettings400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-settings-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesClickPipeIdSettings500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-settings-500-error-exception.md) |


# Click Pipe Settings Update

Update the advanced settings for the specified ClickPipe. Send key-value pairs where values can be strings, numbers, or booleans.

```csharp
ClickPipeSettingsUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Guid clickPipeId,
    Models.ClickPipeSettingsPutRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the ClickPipe. |
| `clickPipeId` | `Guid` | Template, Required | ID of the ClickPipe to update settings for. |
| `body` | [`ClickPipeSettingsPutRequest`](../../doc/models/click-pipe-settings-put-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-settings-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid clickPipeId = new Guid("000014a6-0000-0000-0000-000000000000");
ClickPipeSettingsPutRequest body = new ClickPipeSettingsPutRequest
{
    StreamingMaxInsertWaitMs = 5000,
    ObjectStorageConcurrency = 1,
    ObjectStoragePollingIntervalMs = 30000,
    ObjectStorageMaxInsertBytes = 10737418240L,
    ObjectStorageMaxFileCount = 100,
    ClickhouseMaxThreads = 8,
    ClickhouseMaxInsertThreads = 1,
    ClickhouseMinInsertBlockSizeBytes = 1073741824,
    ClickhouseMaxDownloadThreads = 4,
    ClickhouseParallelDistributedInsertSelect = 2,
    KafkaReadCommitted = false,
    ObjectStorageUseClusterFunction = true,
    ClickhouseParallelViewProcessing = false,
};

try
{
    ApiResponse<V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse> result = await clickPipesApi.ClickPipeSettingsUpdateAsync(
        organizationId,
        serviceId,
        clickPipeId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesClickPipeIdSettings400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeIdSettings400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesClickPipeIdSettings500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeIdSettings500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesClickPipeIdSettings400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-settings-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesClickPipeIdSettings500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-settings-500-error-exception.md) |


# Click Pipe Schema Discovery

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Infers the schema (field names and ClickHouse data types) of a ClickPipe source without creating a pipe. Supported for Kafka, Kinesis, Pub/Sub, and object storage sources. Object storage inference runs on the destination service, which must be running.

```csharp
ClickPipeSchemaDiscoveryAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ClickPipeSchemaDiscoveryRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service to run schema discovery against. |
| `body` | [`ClickPipeSchemaDiscoveryRequest`](../../doc/models/click-pipe-schema-discovery-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesSchemaDiscoveryResponse](../../doc/models/v1-organizations-services-clickpipes-schema-discovery-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesSchemaDiscoveryResponse> result = await clickPipesApi.ClickPipeSchemaDiscoveryAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesSchemaDiscovery400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesSchemaDiscovery400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesSchemaDiscovery500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesSchemaDiscovery500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesSchemaDiscovery400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-schema-discovery-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesSchemaDiscovery500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-schema-discovery-500-error-exception.md) |


# Click Pipe Scaling Update

Change scaling settings for the specified ClickPipe. This endpoint supports Kafka, Kinesis, and object storage pipes (S3, GCS, Azure Blob).

**Note:** For database ClickPipes (PostgreSQL, MySQL, MongoDB, BigQuery), use the [Update CDC ClickPipes scaling](#tag/ClickPipes/operation/clickPipeCdcScalingUpdate) endpoint instead.

```csharp
ClickPipeScalingUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Guid clickPipeId,
    Models.ClickPipeScalingPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the ClickPipe. |
| `clickPipeId` | `Guid` | Template, Required | ID of the ClickPipe to update scaling settings. |
| `body` | [`ClickPipeScalingPatchRequest`](../../doc/models/click-pipe-scaling-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesClickPipeIdScalingResponse](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-scaling-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid clickPipeId = new Guid("000014a6-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesClickPipeIdScalingResponse> result = await clickPipesApi.ClickPipeScalingUpdateAsync(
        organizationId,
        serviceId,
        clickPipeId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesClickPipeIdScaling400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeIdScaling400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesClickPipeIdScaling500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeIdScaling500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesClickPipeIdScaling400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-scaling-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesClickPipeIdScaling500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-scaling-500-error-exception.md) |


# Click Pipe State Update

Start, stop or resync ClickPipe. Stopping a ClickPipe will stop the ingestion process from any state. Starting is allowed for ClickPipes in the "Stopped" state or with a "Failed" state. Resyncing is only for Postgres and MySQL pipes and can be done from any state.

```csharp
ClickPipeStateUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Guid clickPipeId,
    Models.ClickPipeStatePatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the ClickPipe. |
| `clickPipeId` | `Guid` | Template, Required | ID of the ClickPipe to update state. |
| `body` | [`ClickPipeStatePatchRequest`](../../doc/models/click-pipe-state-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesClickPipeIdStateResponse](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-state-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid clickPipeId = new Guid("000014a6-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesClickPipeIdStateResponse> result = await clickPipesApi.ClickPipeStateUpdateAsync(
        organizationId,
        serviceId,
        clickPipeId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesClickPipeIdState400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeIdState400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesClickPipeIdState500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesClickPipeIdState500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesClickPipeIdState400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-state-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesClickPipeIdState500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-click-pipe-id-state-500-error-exception.md) |


# Click Pipe Cdc Scaling Get

Get scaling settings for database ClickPipes (PostgreSQL, MySQL, MongoDB, BigQuery).

The infrastructure is shared between all database ClickPipes in the service, both for initial load and CDC. For billing purposes, 2 CPU cores and 8 GB of RAM [correspond](https://clickhouse.com/docs/cloud/manage/billing/overview#clickpipes-for-postgres-cdc) to one compute unit.

**Note:** For Kafka, Kinesis, and object storage pipes (S3, GCS, Azure Blob), see [Get ClickPipe](#tag/ClickPipes/operation/clickPipeGet).

**This endpoint becomes available once at least one database ClickPipe was provisioned.**

```csharp
ClickPipeCdcScalingGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the ClickPipe. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesCdcScalingResponse](../../doc/models/v1-organizations-services-clickpipes-cdc-scaling-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesCdcScalingResponse> result = await clickPipesApi.ClickPipeCdcScalingGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesCdcScaling400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesCdcScaling400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesCdcScaling500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesCdcScaling500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesCdcScaling400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-cdc-scaling-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesCdcScaling500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-cdc-scaling-500-error-exception.md) |


# Click Pipe Cdc Scaling Update

Update scaling settings for database ClickPipes (PostgreSQL, MySQL, MongoDB, BigQuery).

The infrastructure is shared between all database ClickPipes in the service, both for initial load and CDC. Scaling settings may take a few minutes to fully propagate.

For billing purposes, 2 CPU cores and 8 GB of RAM [correspond](https://clickhouse.com/docs/cloud/manage/billing/overview#clickpipes-for-postgres-cdc) to one compute unit. If your organization tier changes, database ClickPipes will be [rescaled](https://clickhouse.com/docs/cloud/manage/billing/overview#compute) appropriately.

**Note:** For Kafka, Kinesis, and object storage pipes (S3, GCS, Azure Blob), see [Get ClickPipe](#tag/ClickPipes/operation/clickPipeGet).

**This endpoint becomes available once at least one database ClickPipe was provisioned.**

```csharp
ClickPipeCdcScalingUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.ClickPipesCdcScalingPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the ClickPipe. |
| `body` | [`ClickPipesCdcScalingPatchRequest`](../../doc/models/click-pipes-cdc-scaling-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesCdcScalingResponse](../../doc/models/v1-organizations-services-clickpipes-cdc-scaling-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
ClickPipesCdcScalingPatchRequest body = new ClickPipesCdcScalingPatchRequest
{
    ReplicaCpuMillicores = 2000,
    ReplicaMemoryGb = 8,
};

try
{
    ApiResponse<V1OrganizationsServicesClickpipesCdcScalingResponse> result = await clickPipesApi.ClickPipeCdcScalingUpdateAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesCdcScaling400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesCdcScaling400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesCdcScaling500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesCdcScaling500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesCdcScaling400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-cdc-scaling-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesCdcScaling500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-cdc-scaling-500-error-exception.md) |


# Click Pipe Reverse Private Endpoint Get List

Returns a list of reverse private endpoints for the specified service.

```csharp
ClickPipeReversePrivateEndpointGetListAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the Reverse Private Endpoint. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse> result = await clickPipesApi.ClickPipeReversePrivateEndpointGetListAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesReversePrivateEndpoints400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesReversePrivateEndpoints400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesReversePrivateEndpoints500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesReversePrivateEndpoints500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesReversePrivateEndpoints400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesReversePrivateEndpoints500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-500-error-exception.md) |


# Click Pipe Reverse Private Endpoint Create

Create a new reverse private endpoint.

```csharp
ClickPipeReversePrivateEndpointCreateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.CreateReversePrivateEndpoint body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the Reverse Private Endpoint. |
| `body` | [`CreateReversePrivateEndpoint`](../../doc/models/create-reverse-private-endpoint.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
CreateReversePrivateEndpoint body = new CreateReversePrivateEndpoint
{
    Description = "My reverse private endpoint",
    Type = Type1.VpcEndpointService,
    VpcEndpointServiceName = "com.amazonaws.vpce.us-east-1.vpce-svc-12345678901234567",
    VpcResourceConfigurationId = "rcfg-12345678901234567",
    VpcResourceShareArn = "arn:aws:ram:us-east-1:123456789012:resource-share/share-12345678901234567",
    MskClusterArn = "arn:aws:kafka:us-east-1:123456789012:cluster/my-cluster",
    MskAuthentication = MskAuthentication.SaslIam,
    GcpServiceAttachment = "projects/my-project/regions/us-central1/serviceAttachments/my-service",
    CustomPrivateDnsMappings = new List<CustomPrivateDnsMapping>
    {
        new CustomPrivateDnsMapping
        {
            PrivateDnsName = "my-service.example.com",
        },
        new CustomPrivateDnsMapping
        {
            PrivateDnsName = "*.example.com",
        },
    },
};

try
{
    ApiResponse<V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1> result = await clickPipesApi.ClickPipeReversePrivateEndpointCreateAsync(
        organizationId,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesReversePrivateEndpoints400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesReversePrivateEndpoints400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesReversePrivateEndpoints500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesReversePrivateEndpoints500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesReversePrivateEndpoints400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesReversePrivateEndpoints500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-500-error-exception.md) |


# Click Pipe Reverse Private Endpoint Get

Returns the reverse private endpoint with the specified ID.

```csharp
ClickPipeReversePrivateEndpointGetAsync(
    Guid organizationId,
    Guid serviceId,
    Guid reversePrivateEndpointId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the Reverse Private Endpoint. |
| `reversePrivateEndpointId` | `Guid` | Template, Required | ID of the reverse private endpoint to get. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-reverse-private-endpoint-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid reversePrivateEndpointId = new Guid("00001af2-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse> result = await clickPipesApi.ClickPipeReversePrivateEndpointGetAsync(
        organizationId,
        serviceId,
        reversePrivateEndpointId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-reverse-private-endpoint-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-reverse-private-endpoint-id-500-error-exception.md) |


# Click Pipe Reverse Private Endpoint Delete

Delete the reverse private endpoint with the specified ID.

```csharp
ClickPipeReversePrivateEndpointDeleteAsync(
    Guid organizationId,
    Guid serviceId,
    Guid reversePrivateEndpointId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the Reverse Private Endpoint. |
| `reversePrivateEndpointId` | `Guid` | Template, Required | ID of the reverse private endpoint to delete. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-reverse-private-endpoint-id-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid reversePrivateEndpointId = new Guid("00001af2-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1> result = await clickPipesApi.ClickPipeReversePrivateEndpointDeleteAsync(
        organizationId,
        serviceId,
        reversePrivateEndpointId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-reverse-private-endpoint-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-reverse-private-endpoint-id-500-error-exception.md) |


# Click Pipe Reverse Private Endpoint Update

Update mutable fields for an existing reverse private endpoint. customPrivateDnsMappings is a full replacement list. Use an empty array to clear mappings.

```csharp
ClickPipeReversePrivateEndpointUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Guid reversePrivateEndpointId,
    Models.UpdateReversePrivateEndpoint body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service that owns the Reverse Private Endpoint. |
| `reversePrivateEndpointId` | `Guid` | Template, Required | ID of the reverse private endpoint to update. |
| `body` | [`UpdateReversePrivateEndpoint`](../../doc/models/update-reverse-private-endpoint.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-reverse-private-endpoint-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid reversePrivateEndpointId = new Guid("00001af2-0000-0000-0000-000000000000");
UpdateReversePrivateEndpoint body = new UpdateReversePrivateEndpoint
{
    CustomPrivateDnsMappings = new List<CustomPrivateDnsMapping>
    {
        new CustomPrivateDnsMapping
        {
            PrivateDnsName = "my-service.example.com",
        },
        new CustomPrivateDnsMapping
        {
            PrivateDnsName = "*.example.com",
        },
    },
};

try
{
    ApiResponse<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse> result = await clickPipesApi.ClickPipeReversePrivateEndpointUpdateAsync(
        organizationId,
        serviceId,
        reversePrivateEndpointId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400ErrorException`](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-reverse-private-endpoint-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500ErrorException`](../../doc/models/v1-organizations-services-clickpipes-reverse-private-endpoints-reverse-private-endpoint-id-500-error-exception.md) |

