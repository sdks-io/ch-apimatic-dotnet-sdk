# Prometheus

```csharp
PrometheusApi prometheusApi = client.PrometheusApi;
```

## Class Name

`PrometheusApi`

## Methods

* [Organization Prometheus Get](../../doc/controllers/prometheus.md#organization-prometheus-get)
* [Organization Prometheus Discovery Get](../../doc/controllers/prometheus.md#organization-prometheus-discovery-get)
* [Instance Prometheus Get](../../doc/controllers/prometheus.md#instance-prometheus-get)
* [Postgres Org Prometheus Get](../../doc/controllers/prometheus.md#postgres-org-prometheus-get)
* [Postgres Instance Prometheus Get](../../doc/controllers/prometheus.md#postgres-instance-prometheus-get)


# Organization Prometheus Get

**This endpoint is deprecated.**

Deprecated. Use the Prometheus service discovery endpoint (/v1/organizations/{organizationId}/prometheus/discovery) instead. This endpoint is not available for new organizations; contact ClickHouse support to request access. Returns Prometheus metrics for the services in an organization that the caller is authorized to view. Services the caller lacks view access to are omitted.

```csharp
OrganizationPrometheusGetAsync(
    Guid organizationId,
    string filteredMetrics = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `filteredMetrics` | `string` | Query, Optional | Return a filtered list of Prometheus metrics. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type string.

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<string> result = await prometheusApi.OrganizationPrometheusGetAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPrometheus400ErrorException)
    {
       // TODO: Handle V1OrganizationsPrometheus400ErrorException exception here
    }
    if (e is V1OrganizationsPrometheus500ErrorException)
    {
       // TODO: Handle V1OrganizationsPrometheus500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPrometheus400ErrorException`](../../doc/models/v1-organizations-prometheus-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPrometheus500ErrorException`](../../doc/models/v1-organizations-prometheus-500-error-exception.md) |


# Organization Prometheus Discovery Get

Returns one Prometheus scrape target per service in the organization, in the [HTTP service discovery](https://prometheus.io/docs/prometheus/latest/http_sd/) (`http_sd`) format. Only services the API key is authorized to view are included; services that are being deleted or have been deleted are omitted.

Point an [`http_sd_configs`](https://prometheus.io/docs/prometheus/latest/configuration/configuration/#http_sd_config) job at this endpoint to discover and scrape all services in the organization automatically. Prometheus refreshes the target list on every discovery poll, so newly created and deleted services are picked up without configuration changes.

Discovered targets scrape with `filtered_metrics=true` by default; pass `?filtered_metrics=false` to this endpoint to discover unfiltered targets. See the [Prometheus integration guide](https://clickhouse.com/docs/integrations/prometheus) for more on the exported metrics.

```csharp
OrganizationPrometheusDiscoveryGetAsync(
    Guid organizationId,
    string filteredMetrics = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `filteredMetrics` | `string` | Query, Optional | Whether discovered targets scrape a filtered list of metrics. Sets the filtered_metrics parameter on each discovered target. Defaults to true. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.PrometheusDiscoveryTargetGroup>](../../doc/models/prometheus-discovery-target-group.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string filteredMetrics = "true";
try
{
    ApiResponse<List<PrometheusDiscoveryTargetGroup>> result = await prometheusApi.OrganizationPrometheusDiscoveryGetAsync(
        organizationId,
        filteredMetrics
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPrometheusDiscovery400ErrorException)
    {
       // TODO: Handle V1OrganizationsPrometheusDiscovery400ErrorException exception here
    }
    if (e is V1OrganizationsPrometheusDiscovery500ErrorException)
    {
       // TODO: Handle V1OrganizationsPrometheusDiscovery500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPrometheusDiscovery400ErrorException`](../../doc/models/v1-organizations-prometheus-discovery-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPrometheusDiscovery500ErrorException`](../../doc/models/v1-organizations-prometheus-discovery-500-error-exception.md) |


# Instance Prometheus Get

Returns prometheus metrics for a service.

```csharp
InstancePrometheusGetAsync(
    Guid organizationId,
    Guid serviceId,
    string filteredMetrics = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `filteredMetrics` | `string` | Query, Optional | Return a filtered list of Prometheus metrics. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type string.

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<string> result = await prometheusApi.InstancePrometheusGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesPrometheus400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesPrometheus400ErrorException exception here
    }
    if (e is V1OrganizationsServicesPrometheus500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesPrometheus500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesPrometheus400ErrorException`](../../doc/models/v1-organizations-services-prometheus-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesPrometheus500ErrorException`](../../doc/models/v1-organizations-services-prometheus-500-error-exception.md) |


# Postgres Org Prometheus Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns Prometheus metrics for all PostgreSQL services in an organization. Maximum 100 services supported.

```csharp
PostgresOrgPrometheusGetAsync(
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

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type string.

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<string> result = await prometheusApi.PostgresOrgPrometheusGetAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresPrometheus400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresPrometheus400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresPrometheus500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresPrometheus500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresPrometheus400ErrorException`](../../doc/models/v1-organizations-postgres-prometheus-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresPrometheus500ErrorException`](../../doc/models/v1-organizations-postgres-prometheus-500-error-exception.md) |


# Postgres Instance Prometheus Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns Prometheus metrics for a PostgreSQL service.

```csharp
PostgresInstancePrometheusGetAsync(
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

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type string.

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid postgresId = new Guid("00000dcc-0000-0000-0000-000000000000");
try
{
    ApiResponse<string> result = await prometheusApi.PostgresInstancePrometheusGetAsync(
        organizationId,
        postgresId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsPostgresPrometheus400ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresPrometheus400ErrorException exception here
    }
    if (e is V1OrganizationsPostgresPrometheus500ErrorException)
    {
       // TODO: Handle V1OrganizationsPostgresPrometheus500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsPostgresPrometheus400ErrorException`](../../doc/models/v1-organizations-postgres-prometheus-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsPostgresPrometheus500ErrorException`](../../doc/models/v1-organizations-postgres-prometheus-500-error-exception.md) |

