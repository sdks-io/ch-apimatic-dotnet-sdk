# Postgres

```csharp
PostgresApi postgresApi = client.PostgresApi;
```

## Class Name

`PostgresApi`

## Methods

* [Postgres Service Create](../../doc/controllers/postgres.md#postgres-service-create)
* [Postgres Service Get List](../../doc/controllers/postgres.md#postgres-service-get-list)
* [Postgres Service Get](../../doc/controllers/postgres.md#postgres-service-get)
* [Postgres Service Delete](../../doc/controllers/postgres.md#postgres-service-delete)
* [Postgres Service Patch](../../doc/controllers/postgres.md#postgres-service-patch)
* [Postgres Service Certs Get](../../doc/controllers/postgres.md#postgres-service-certs-get)
* [Postgres Instance Restore](../../doc/controllers/postgres.md#postgres-instance-restore)
* [Postgres Service Set Password](../../doc/controllers/postgres.md#postgres-service-set-password)
* [Postgres Service Patch State](../../doc/controllers/postgres.md#postgres-service-patch-state)
* [Postgres Instance Create Read Replica](../../doc/controllers/postgres.md#postgres-instance-create-read-replica)
* [Postgres Instance Config Get](../../doc/controllers/postgres.md#postgres-instance-config-get)
* [Postgres Instance Config Post](../../doc/controllers/postgres.md#postgres-instance-config-post)
* [Postgres Instance Config Patch](../../doc/controllers/postgres.md#postgres-instance-config-patch)
* [Postgres Instance Metrics Get](../../doc/controllers/postgres.md#postgres-instance-metrics-get)
* [Slow Query Patterns Get List](../../doc/controllers/postgres.md#slow-query-patterns-get-list)
* [Slow Query Pattern Get](../../doc/controllers/postgres.md#slow-query-pattern-get)
* [Postgres Logs Get List](../../doc/controllers/postgres.md#postgres-logs-get-list)


# Postgres Service Create

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Creates a new Postgres service in the organization and returns it. The service is started asynchronously.

```csharp
PostgresServiceCreateAsync(
    Guid organizationId,
    Models.PostgresServicePostRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that will own the service. |
| `body` | [`PostgresServicePostRequest`](../../doc/models/postgres-service-post-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresResponse](../../doc/models/v1-organizations-postgres-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
PostgresServicePostRequest body = new PostgresServicePostRequest
{
    Name = "name6",
    Provider = CloudProvider.Aws,
    Region = "region2",
    Size = VmSize.EnumR6Id32Xlarge,
    PgConfig = new PostgresConfiguration
    {
        MaxConnections = PostgresConfigurationMaxConnections.FromNumber(100),
    },
    PgBouncerConfig = new Dictionary<string, string>
    {
        ["default_pool_size"] = "16",
    },
};

try
{
    ApiResponse<V1OrganizationsPostgresResponse> result = await postgresApi.PostgresServiceCreateAsync(
        organizationId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgres400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgres400ErrorException exception here
    }
    if (e is V1OrganizationsPostgres500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgres500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgres400ErrorException`](../../doc/models/v1-organizations-postgres-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgres500ErrorException`](../../doc/models/v1-organizations-postgres-500-error-exception.md) |


# Postgres Service Get List

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns a list of all Postgres services in the organization.

```csharp
PostgresServiceGetListAsync(
    Guid organizationId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the services. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresResponse1](../../doc/models/v1-organizations-postgres-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsPostgresResponse1> result = await postgresApi.PostgresServiceGetListAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgres400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgres400ErrorException exception here
    }
    if (e is V1OrganizationsPostgres500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgres500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgres400ErrorException`](../../doc/models/v1-organizations-postgres-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgres500ErrorException`](../../doc/models/v1-organizations-postgres-500-error-exception.md) |


# Postgres Service Get

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns a Postgres service that belongs to the organization

```csharp
PostgresServiceGetAsync(
    Guid organizationId,
    Guid postgresId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresResponse](../../doc/models/v1-organizations-postgres-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsPostgresResponse> result = await postgresApi.PostgresServiceGetAsync(
        organizationId,
        postgresId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgres400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgres400ErrorException exception here
    }
    if (e is V1OrganizationsPostgres500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgres500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgres400ErrorException`](../../doc/models/v1-organizations-postgres-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgres500ErrorException`](../../doc/models/v1-organizations-postgres-500-error-exception.md) |


# Postgres Service Delete

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Deletes a Postgres service that belongs to the organization

```csharp
PostgresServiceDeleteAsync(
    Guid organizationId,
    Guid postgresId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresResponse3](../../doc/models/v1-organizations-postgres-response-3.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsPostgresResponse3> result = await postgresApi.PostgresServiceDeleteAsync(
        organizationId,
        postgresId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgres400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgres400ErrorException exception here
    }
    if (e is V1OrganizationsPostgres500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgres500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgres400ErrorException`](../../doc/models/v1-organizations-postgres-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgres500ErrorException`](../../doc/models/v1-organizations-postgres-500-error-exception.md) |


# Postgres Service Patch

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Update a Postgres service that belongs to the organization. **WARNING:** Changing the name also updates the host name and certificates for the service.

```csharp
PostgresServicePatchAsync(
    Guid organizationId,
    Guid postgresId,
    Models.PostgresServicePatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |
| `body` | [`PostgresServicePatchRequest`](../../doc/models/postgres-service-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresResponse](../../doc/models/v1-organizations-postgres-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsPostgresResponse> result = await postgresApi.PostgresServicePatchAsync(
        organizationId,
        postgresId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgres400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgres400ErrorException exception here
    }
    if (e is V1OrganizationsPostgres500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgres500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgres400ErrorException`](../../doc/models/v1-organizations-postgres-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgres500ErrorException`](../../doc/models/v1-organizations-postgres-500-error-exception.md) |


# Postgres Service Certs Get

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Download CA certificates for a PostgreSQL service

```csharp
PostgresServiceCertsGetAsync(
    Guid organizationId,
    Guid postgresId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type dynamic.

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
try
{
    ApiResponse<dynamic> result = await postgresApi.PostgresServiceCertsGetAsync(
        organizationId,
        postgresId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresCaCertificates400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresCaCertificates400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresCaCertificates500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresCaCertificates500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresCaCertificates400ErrorException`](../../doc/models/v1-organizations-postgres-ca-certificates-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresCaCertificates500ErrorException`](../../doc/models/v1-organizations-postgres-ca-certificates-500-error-exception.md) |


# Postgres Instance Restore

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Restore a Postgres database from continuous backup, optionally at a specific point in time.

```csharp
PostgresInstanceRestoreAsync(
    Guid organizationId,
    Guid postgresId,
    Models.PostgresServiceRestoreRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |
| `body` | [`PostgresServiceRestoreRequest`](../../doc/models/postgres-service-restore-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresRestoredServiceResponse](../../doc/models/v1-organizations-postgres-restored-service-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
PostgresServiceRestoreRequest body = new PostgresServiceRestoreRequest
{
    Name = "name6",
    RestoreTarget = DateTime.ParseExact("03/31/2026 18:17:37", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    PgConfig = new PostgresConfiguration
    {
        MaxConnections = PostgresConfigurationMaxConnections.FromNumber(100),
    },
    PgBouncerConfig = new Dictionary<string, string>
    {
        ["default_pool_size"] = "16",
    },
};

try
{
    ApiResponse<V1OrganizationsPostgresRestoredServiceResponse> result = await postgresApi.PostgresInstanceRestoreAsync(
        organizationId,
        postgresId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresRestoredService400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresRestoredService400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresRestoredService500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresRestoredService500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresRestoredService400ErrorException`](../../doc/models/v1-organizations-postgres-restored-service-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresRestoredService500ErrorException`](../../doc/models/v1-organizations-postgres-restored-service-500-error-exception.md) |


# Postgres Service Set Password

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Sets a new password for a Postgres service's superuser account.

```csharp
PostgresServiceSetPasswordAsync(
    Guid organizationId,
    Guid postgresId,
    Models.PostgresServiceSetPassword body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |
| `body` | [`PostgresServiceSetPassword`](../../doc/models/postgres-service-set-password.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresPasswordResponse](../../doc/models/v1-organizations-postgres-password-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsPostgresPasswordResponse> result = await postgresApi.PostgresServiceSetPasswordAsync(
        organizationId,
        postgresId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresPassword400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresPassword400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresPassword500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresPassword500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresPassword400ErrorException`](../../doc/models/v1-organizations-postgres-password-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresPassword500ErrorException`](../../doc/models/v1-organizations-postgres-password-500-error-exception.md) |


# Postgres Service Patch State

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Initiate a process for a Postgres service:

* restart: Initiates a service restart
* promote: Promotes a read replica to primary
* switchover: Switch a primary over to a standby

```csharp
PostgresServicePatchStateAsync(
    Guid organizationId,
    Guid postgresId,
    Models.PostgresServiceSetState body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |
| `body` | [`PostgresServiceSetState`](../../doc/models/postgres-service-set-state.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresStateResponse](../../doc/models/v1-organizations-postgres-state-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsPostgresStateResponse> result = await postgresApi.PostgresServicePatchStateAsync(
        organizationId,
        postgresId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresState400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresState400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresState500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresState500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresState400ErrorException`](../../doc/models/v1-organizations-postgres-state-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresState500ErrorException`](../../doc/models/v1-organizations-postgres-state-500-error-exception.md) |


# Postgres Instance Create Read Replica

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Initiate the process to create a new read replica for a Postgres service.

```csharp
PostgresInstanceCreateReadReplicaAsync(
    Guid organizationId,
    Guid postgresId,
    Models.PostgresServiceReadReplicaRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |
| `body` | [`PostgresServiceReadReplicaRequest`](../../doc/models/postgres-service-read-replica-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresReadReplicaResponse](../../doc/models/v1-organizations-postgres-read-replica-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
PostgresServiceReadReplicaRequest body = new PostgresServiceReadReplicaRequest
{
    Name = "name6",
    PgConfig = new PostgresConfiguration
    {
        MaxConnections = PostgresConfigurationMaxConnections.FromNumber(100),
    },
    PgBouncerConfig = new Dictionary<string, string>
    {
        ["default_pool_size"] = "16",
    },
};

try
{
    ApiResponse<V1OrganizationsPostgresReadReplicaResponse> result = await postgresApi.PostgresInstanceCreateReadReplicaAsync(
        organizationId,
        postgresId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresReadReplica400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresReadReplica400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresReadReplica500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresReadReplica500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresReadReplica400ErrorException`](../../doc/models/v1-organizations-postgres-read-replica-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresReadReplica500ErrorException`](../../doc/models/v1-organizations-postgres-read-replica-500-error-exception.md) |


# Postgres Instance Config Get

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns the configuration data for a Postgres service and its PgBouncer service.

```csharp
PostgresInstanceConfigGetAsync(
    Guid organizationId,
    Guid postgresId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresConfigResponse](../../doc/models/v1-organizations-postgres-config-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsPostgresConfigResponse> result = await postgresApi.PostgresInstanceConfigGetAsync(
        organizationId,
        postgresId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresConfig400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresConfig400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresConfig500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresConfig500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresConfig400ErrorException`](../../doc/models/v1-organizations-postgres-config-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresConfig500ErrorException`](../../doc/models/v1-organizations-postgres-config-500-error-exception.md) |


# Postgres Instance Config Post

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Replace the existing Postgres service and pgBouncer configuration.

```csharp
PostgresInstanceConfigPostAsync(
    Guid organizationId,
    Guid postgresId,
    Models.PostgresInstanceConfig body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |
| `body` | [`PostgresInstanceConfig`](../../doc/models/postgres-instance-config.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresConfigResponse1](../../doc/models/v1-organizations-postgres-config-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
PostgresInstanceConfig body = new PostgresInstanceConfig
{
    PgConfig = new PostgresConfiguration
    {
        MaxConnections = PostgresConfigurationMaxConnections.FromNumber(100),
    },
    PgBouncerConfig = new Dictionary<string, string>
    {
        ["default_pool_size"] = "16",
    },
};

try
{
    ApiResponse<V1OrganizationsPostgresConfigResponse1> result = await postgresApi.PostgresInstanceConfigPostAsync(
        organizationId,
        postgresId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresConfig400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresConfig400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresConfig500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresConfig500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresConfig400ErrorException`](../../doc/models/v1-organizations-postgres-config-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresConfig500ErrorException`](../../doc/models/v1-organizations-postgres-config-500-error-exception.md) |


# Postgres Instance Config Patch

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Update the existing Postgres service and pgBouncer configuration.

```csharp
PostgresInstanceConfigPatchAsync(
    Guid organizationId,
    Guid postgresId,
    Models.PostgresInstanceConfig body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |
| `body` | [`PostgresInstanceConfig`](../../doc/models/postgres-instance-config.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresConfigResponse1](../../doc/models/v1-organizations-postgres-config-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
PostgresInstanceConfig body = new PostgresInstanceConfig
{
    PgConfig = new PostgresConfiguration
    {
        MaxConnections = PostgresConfigurationMaxConnections.FromNumber(100),
    },
    PgBouncerConfig = new Dictionary<string, string>
    {
        ["default_pool_size"] = "16",
    },
};

try
{
    ApiResponse<V1OrganizationsPostgresConfigResponse1> result = await postgresApi.PostgresInstanceConfigPatchAsync(
        organizationId,
        postgresId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresConfig400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresConfig400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresConfig500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresConfig500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresConfig400ErrorException`](../../doc/models/v1-organizations-postgres-config-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresConfig500ErrorException`](../../doc/models/v1-organizations-postgres-config-500-error-exception.md) |


# Postgres Instance Metrics Get

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns bucketed time-series metrics for a PostgreSQL service over the requested window (CPU, memory, disk, network, connections, cache hit ratio, throughput, transactions, and more). Use this to chart or analyze how a service behaved over time.

```csharp
PostgresInstanceMetricsGetAsync(
    Guid organizationId,
    Guid postgresId,
    DateTime fromDate,
    DateTime toDate,
    int? bucketSizeSeconds = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the Postgres service. |
| `fromDate` | `DateTime` | Query, Required | Inclusive start of the time window (RFC 3339 date-time). |
| `toDate` | `DateTime` | Query, Required | Exclusive end of the time window (RFC 3339 date-time). |
| `bucketSizeSeconds` | `int?` | Query, Optional | Time-series bucket size in seconds. When omitted, a bucket size is derived from the requested window. Requests are capped at 250 data points.<br><br>**Constraints**: `>= 1` |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresMetricsResponse](../../doc/models/v1-organizations-postgres-metrics-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
DateTime fromDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
DateTime toDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
try
{
    ApiResponse<V1OrganizationsPostgresMetricsResponse> result = await postgresApi.PostgresInstanceMetricsGetAsync(
        organizationId,
        postgresId,
        fromDate,
        toDate
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresMetrics400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresMetrics400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresMetrics500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresMetrics500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresMetrics400ErrorException`](../../doc/models/v1-organizations-postgres-metrics-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresMetrics500ErrorException`](../../doc/models/v1-organizations-postgres-metrics-500-error-exception.md) |


# Slow Query Patterns Get List

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns aggregate metrics for the slowest query patterns observed on a Postgres service during the given time window. Use this to discover which queries dominate total execution time, CPU, I/O, or WAL generation.

```csharp
SlowQueryPatternsGetListAsync(
    Guid organizationId,
    Guid postgresId,
    DateTime fromDate,
    DateTime toDate,
    string dbName = null,
    string dbUser = null,
    string dbOperation = null,
    string app = null,
    Models.SortBy? sortBy = Models.SortBy.TotalDuration,
    Models.SortOrder1? sortOrder = Models.SortOrder1.Desc,
    int? limit = 20,
    int? offset = 0)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |
| `fromDate` | `DateTime` | Query, Required | Inclusive start of the time window (RFC 3339 date-time). |
| `toDate` | `DateTime` | Query, Required | Exclusive end of the time window (RFC 3339 date-time). |
| `dbName` | `string` | Query, Optional | Database name filter. |
| `dbUser` | `string` | Query, Optional | Database user filter. |
| `dbOperation` | `string` | Query, Optional | Database operation filter (for example, SELECT, INSERT, UPDATE, DELETE, UTILITY). |
| `app` | `string` | Query, Optional | Application name filter. |
| `sortBy` | [`SortBy?`](../../doc/models/sort-by.md) | Query, Optional | Field to sort results by.<br><br>**Default**: `SortBy.total_duration` |
| `sortOrder` | [`SortOrder1?`](../../doc/models/sort-order-1.md) | Query, Optional | Sort order. One of `asc` or `desc`.<br><br>**Default**: `SortOrder1.desc` |
| `limit` | `int?` | Query, Optional | Maximum number of results to return.<br><br>**Default**: `20`<br><br>**Constraints**: `>= 1`, `<= 500` |
| `offset` | `int?` | Query, Optional | Number of results to skip before returning.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0` |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresSlowQueryPatternsResponse](../../doc/models/v1-organizations-postgres-slow-query-patterns-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
DateTime fromDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
DateTime toDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
SortBy? sortBy = SortBy.TotalDuration;
SortOrder1? sortOrder = SortOrder1.Desc;
int? limit = 20;
int? offset = 0;
try
{
    ApiResponse<V1OrganizationsPostgresSlowQueryPatternsResponse> result = await postgresApi.SlowQueryPatternsGetListAsync(
        organizationId,
        postgresId,
        fromDate,
        toDate,
        null,
        null,
        null,
        null,
        sortBy,
        sortOrder,
        limit,
        offset
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresSlowQueryPatterns400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresSlowQueryPatterns400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresSlowQueryPatterns500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresSlowQueryPatterns500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresSlowQueryPatterns400ErrorException`](../../doc/models/v1-organizations-postgres-slow-query-patterns-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresSlowQueryPatterns500ErrorException`](../../doc/models/v1-organizations-postgres-slow-query-patterns-500-error-exception.md) |


# Slow Query Pattern Get

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns aggregate metrics for a single slow query pattern together with its most recent individual executions.

```csharp
SlowQueryPatternGetAsync(
    Guid organizationId,
    Guid postgresId,
    string queryId,
    string dbName,
    string dbUser,
    string dbOperation,
    string app = null,
    DateTime? timestamp = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |
| `queryId` | `string` | Template, Required | Stable identifier for the query pattern. |
| `dbName` | `string` | Query, Required | Database name filter. |
| `dbUser` | `string` | Query, Required | Database user filter. |
| `dbOperation` | `string` | Query, Required | Database operation filter (for example, SELECT, INSERT, UPDATE, DELETE, UTILITY). |
| `app` | `string` | Query, Optional | Application name filter. |
| `timestamp` | `DateTime?` | Query, Optional | Timestamp of a specific execution (RFC 3339). |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse](../../doc/models/v1-organizations-postgres-slow-query-patterns-query-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
string queryId = "queryId6";
string dbName = "db_name6";
string dbUser = "db_user2";
string dbOperation = "db_operation2";
try
{
    ApiResponse<V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse> result = await postgresApi.SlowQueryPatternGetAsync(
        organizationId,
        postgresId,
        queryId,
        dbName,
        dbUser,
        dbOperation
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresSlowQueryPatternsQueryId400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresSlowQueryPatternsQueryId400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresSlowQueryPatternsQueryId500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresSlowQueryPatternsQueryId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresSlowQueryPatternsQueryId400ErrorException`](../../doc/models/v1-organizations-postgres-slow-query-patterns-query-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresSlowQueryPatternsQueryId500ErrorException`](../../doc/models/v1-organizations-postgres-slow-query-patterns-query-id-500-error-exception.md) |


# Postgres Logs Get List

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns PostgreSQL server log entries for a Postgres service within the given time window, most recent first by default (override with `sort_order`). Results are paginated with `limit`/`offset`; advance `offset` until a page returns fewer than `limit` entries to read the full window. The time range must not exceed 30 days, and `to_date` must be after `from_date`.

```csharp
PostgresLogsGetListAsync(
    Guid organizationId,
    Guid postgresId,
    DateTime fromDate,
    DateTime toDate,
    string bodyContains = null,
    string severity = null,
    Models.SortOrder1? sortOrder = Models.SortOrder1.Desc,
    int? limit = 50,
    int? offset = 0)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the Postgres service. |
| `postgresId` | `Guid` | Template, Required | ID of the requested Postgres service. |
| `fromDate` | `DateTime` | Query, Required | Inclusive start of the time window (RFC 3339 date-time). |
| `toDate` | `DateTime` | Query, Required | Inclusive end of the time window (RFC 3339 date-time). |
| `bodyContains` | `string` | Query, Optional | Case-sensitive substring the log body must contain. |
| `severity` | `string` | Query, Optional | Filter to log entries with this PostgreSQL severity (for example, ERROR, WARNING, LOG). |
| `sortOrder` | [`SortOrder1?`](../../doc/models/sort-order-1.md) | Query, Optional | Sort order. One of `asc` or `desc`.<br><br>**Default**: `SortOrder1.desc` |
| `limit` | `int?` | Query, Optional | Maximum number of results to return.<br><br>**Default**: `50`<br><br>**Constraints**: `>= 1`, `<= 2000` |
| `offset` | `int?` | Query, Optional | Number of results to skip before returning.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0` |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsPostgresLogsResponse](../../doc/models/v1-organizations-postgres-logs-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
DateTime fromDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
DateTime toDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind);
SortOrder1? sortOrder = SortOrder1.Desc;
int? limit = 50;
int? offset = 0;
try
{
    ApiResponse<V1OrganizationsPostgresLogsResponse> result = await postgresApi.PostgresLogsGetListAsync(
        organizationId,
        postgresId,
        fromDate,
        toDate,
        null,
        null,
        sortOrder,
        limit,
        offset
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresLogs400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresLogs400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresLogs500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresLogs500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresLogs400ErrorException`](../../doc/models/v1-organizations-postgres-logs-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresLogs500ErrorException`](../../doc/models/v1-organizations-postgres-logs-500-error-exception.md) |

