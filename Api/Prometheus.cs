using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core;
using OpenApiSpecForClickHouseCloud.Core.Exceptions;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Request;
using OpenApiSpecForClickHouseCloud.Core.Response;
using OpenApiSpecForClickHouseCloud.Errors;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Api;

public sealed class Prometheus
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Prometheus(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get service metrics
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="filteredMetrics">Return a filtered list of Prometheus metrics.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstancePrometheusGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns prometheus metrics for a service.
    /// </remarks>
    public Task<string> InstancePrometheusGet(Guid organizationId,
        Guid serviceId,
        string? filteredMetrics,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/prometheus"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [new Param("filtered_metrics", filteredMetrics)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            PlainTextResponse.CreateString(),
            InstancePrometheusGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Prometheus scrape targets
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="filteredMetrics">Whether discovered targets scrape a filtered list of metrics. Sets the filtered_metrics parameter on each discovered target. Defaults to true.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="PrometheusDiscoveryTargetGroup"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationPrometheusDiscoveryGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns one Prometheus scrape target per service in the organization, in the <see href="https://prometheus.io/docs/prometheus/latest/http_sd/">HTTP service discovery</see> (<c>http_sd</c>) format. Only services the API key is authorized to view are included; services that are being deleted or have been deleted are omitted.
    /// <para>
    /// Point an <see href="https://prometheus.io/docs/prometheus/latest/configuration/configuration/#http_sd_config"><c>http_sd_configs</c></see> job at this endpoint to discover and scrape all services in the organization automatically. Prometheus refreshes the target list on every discovery poll, so newly created and deleted services are picked up without configuration changes.
    /// </para>
    /// <para>
    /// Discovered targets scrape with <c>filtered_metrics=true</c> by default; pass <c>?filtered_metrics=false</c> to this endpoint to discover unfiltered targets. See the <see href="https://clickhouse.com/docs/integrations/prometheus">Prometheus integration guide</see> for more on the exported metrics.
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<PrometheusDiscoveryTargetGroup>> OrganizationPrometheusDiscoveryGet(Guid organizationId,
        string? filteredMetrics,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/prometheus/discovery"),
            [new TemplateParam("organizationId", organizationId)],
            [new Param("filtered_metrics", filteredMetrics)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<PrometheusDiscoveryTargetGroup>>(),
            OrganizationPrometheusDiscoveryGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get organization metrics
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="filteredMetrics">Return a filtered list of Prometheus metrics.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationPrometheusGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated. Use the Prometheus service discovery endpoint (/v1/organizations/{organizationId}/prometheus/discovery) instead. This endpoint is not available for new organizations; contact ClickHouse support to request access. Returns Prometheus metrics for the services in an organization that the caller is authorized to view. Services the caller lacks view access to are omitted.
    /// </remarks>
    public Task<string> OrganizationPrometheusGet(Guid organizationId,
        string? filteredMetrics,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/prometheus"),
            [new TemplateParam("organizationId", organizationId)],
            [new Param("filtered_metrics", filteredMetrics)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            PlainTextResponse.CreateString(),
            OrganizationPrometheusGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get PostgreSQL service metrics
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresInstancePrometheusGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns Prometheus metrics for a PostgreSQL service.
    /// </remarks>
    public Task<string> PostgresInstancePrometheusGet(Guid organizationId,
        Guid postgresId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/prometheus"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            PlainTextResponse.CreateString(),
            PostgresInstancePrometheusGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get organization PostgreSQL metrics
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresOrgPrometheusGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns Prometheus metrics for all PostgreSQL services in an organization. Maximum 100 services supported.
    /// </remarks>
    public Task<string> PostgresOrgPrometheusGet(Guid organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/prometheus"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            PlainTextResponse.CreateString(),
            PostgresOrgPrometheusGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
