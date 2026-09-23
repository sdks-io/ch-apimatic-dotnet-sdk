using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core;
using OpenApiSpecForClickHouseCloud.Core.Exceptions;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Request;
using OpenApiSpecForClickHouseCloud.Core.Response;
using OpenApiSpecForClickHouseCloud.Errors;
using OpenApiSpecForClickHouseCloud.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Api;

public sealed class Postgres
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Postgres(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get PostgreSQL service configuration
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresConfigResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresInstanceConfigGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns the configuration data for a Postgres service and its PgBouncer service.
    /// </remarks>
    public Task<V1OrganizationsPostgresConfigResponse> PostgresInstanceConfigGet(Guid organizationId,
        Guid postgresId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/config"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsPostgresConfigResponse>(),
            PostgresInstanceConfigGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update Postgres service configuration
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresConfigResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresInstanceConfigPatchError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Update the existing Postgres service and pgBouncer configuration.
    /// </remarks>
    public Task<V1OrganizationsPostgresConfigResponse1> PostgresInstanceConfigPatch(Guid organizationId,
        Guid postgresId,
        PostgresInstanceConfig? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/config"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsPostgresConfigResponse1>(),
            PostgresInstanceConfigPatchErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Replace Postgres service configuration
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresConfigResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresInstanceConfigPostError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Replace the existing Postgres service and pgBouncer configuration.
    /// </remarks>
    public Task<V1OrganizationsPostgresConfigResponse1> PostgresInstanceConfigPost(Guid organizationId,
        Guid postgresId,
        PostgresInstanceConfig? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/config"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsPostgresConfigResponse1>(),
            PostgresInstanceConfigPostErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create a read replica for a Postgres service
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresReadReplicaResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresInstanceCreateReadReplicaError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Initiate the process to create a new read replica for a Postgres service.
    /// </remarks>
    public Task<V1OrganizationsPostgresReadReplicaResponse> PostgresInstanceCreateReadReplica(Guid organizationId,
        Guid postgresId,
        PostgresServiceReadReplicaRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/readReplica"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsPostgresReadReplicaResponse>(),
            PostgresInstanceCreateReadReplicaErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Postgres time-series metrics
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the Postgres service.</param>
    /// <param name="fromDate">Inclusive start of the time window (RFC 3339 date-time).</param>
    /// <param name="toDate">Exclusive end of the time window (RFC 3339 date-time).</param>
    /// <param name="bucketSizeSeconds">Time-series bucket size in seconds. When omitted, a bucket size is derived from the requested window. Requests are capped at 250 data points.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresMetricsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresInstanceMetricsGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns bucketed time-series metrics for a PostgreSQL service over the requested window (CPU, memory, disk, network, connections, cache hit ratio, throughput, transactions, and more). Use this to chart or analyze how a service behaved over time.
    /// </remarks>
    public Task<V1OrganizationsPostgresMetricsResponse> PostgresInstanceMetricsGet(Guid organizationId,
        Guid postgresId,
        DateTimeOffset fromDate,
        DateTimeOffset toDate,
        int? bucketSizeSeconds,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/metrics"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [new Param("from_date", fromDate.ToIso8601()),
                new Param("to_date", toDate.ToIso8601()),
                new Param("bucket_size_seconds", bucketSizeSeconds)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsPostgresMetricsResponse>(),
            PostgresInstanceMetricsGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Restore a Postgres service
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresRestoredServiceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresInstanceRestoreError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Restore a Postgres database from continuous backup, optionally at a specific point in time.
    /// </remarks>
    public Task<V1OrganizationsPostgresRestoredServiceResponse> PostgresInstanceRestore(Guid organizationId,
        Guid postgresId,
        PostgresServiceRestoreRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/restoredService"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsPostgresRestoredServiceResponse>(),
            PostgresInstanceRestoreErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Postgres server logs
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="fromDate">Inclusive start of the time window (RFC 3339 date-time).</param>
    /// <param name="toDate">Inclusive end of the time window (RFC 3339 date-time).</param>
    /// <param name="bodyContains">Case-sensitive substring the log body must contain.</param>
    /// <param name="severity">Filter to log entries with this PostgreSQL severity (for example, ERROR, WARNING, LOG).</param>
    /// <param name="sortOrder">Sort order. One of <c>asc</c> or <c>desc</c>.</param>
    /// <param name="limit">Maximum number of results to return.</param>
    /// <param name="offset">Number of results to skip before returning.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresLogsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresLogsGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns PostgreSQL server log entries for a Postgres service within the given time window, most recent first by default (override with <c>sort_order</c>). Results are paginated with <c>limit</c>/<c>offset</c>; advance <c>offset</c> until a page returns fewer than <c>limit</c> entries to read the full window. The time range must not exceed 30 days, and <c>to_date</c> must be after <c>from_date</c>.
    /// </remarks>
    public Task<V1OrganizationsPostgresLogsResponse> PostgresLogsGetList(Guid organizationId,
        Guid postgresId,
        DateTimeOffset fromDate,
        DateTimeOffset toDate,
        string? bodyContains,
        string? severity,
        SortOrder1? sortOrder,
        int? limit = 50,
        int? offset = 0,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/logs"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [new Param("from_date", fromDate.ToIso8601()),
                new Param("to_date", toDate.ToIso8601()),
                new Param("body_contains", bodyContains),
                new Param("severity", severity),
                new Param("sort_order", sortOrder),
                new Param("limit", limit),
                new Param("offset", offset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsPostgresLogsResponse>(),
            PostgresLogsGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get Postgres CA certs
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresServiceCertsGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Download CA certificates for a PostgreSQL service
    /// </remarks>
    public Task PostgresServiceCertsGet(Guid organizationId,
        Guid postgresId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/caCertificates"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            PostgresServiceCertsGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create new Postgres service
    /// </summary>
    /// <param name="organizationId">ID of the organization that will own the service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresServiceCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Creates a new Postgres service in the organization and returns it. The service is started asynchronously.
    /// </remarks>
    public Task<V1OrganizationsPostgresResponse> PostgresServiceCreate(Guid organizationId,
        PostgresServicePostRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsPostgresResponse>(),
            PostgresServiceCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a PostgreSQL service
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresResponse3"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresServiceDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Deletes a Postgres service that belongs to the organization
    /// </remarks>
    public Task<V1OrganizationsPostgresResponse3> PostgresServiceDelete(Guid organizationId,
        Guid postgresId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsPostgresResponse3>(),
            PostgresServiceDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get PostgreSQL service details
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresServiceGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns a Postgres service that belongs to the organization
    /// </remarks>
    public Task<V1OrganizationsPostgresResponse> PostgresServiceGet(Guid organizationId,
        Guid postgresId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsPostgresResponse>(),
            PostgresServiceGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List of organization Postgres services
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the services.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresServiceGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns a list of all Postgres services in the organization.
    /// </remarks>
    public Task<V1OrganizationsPostgresResponse1> PostgresServiceGetList(Guid organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsPostgresResponse1>(),
            PostgresServiceGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update a PostgreSQL service
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresServicePatchError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Update a Postgres service that belongs to the organization. <b>WARNING:</b> Changing the name also updates the host name and certificates for the service.
    /// </remarks>
    public Task<V1OrganizationsPostgresResponse> PostgresServicePatch(Guid organizationId,
        Guid postgresId,
        PostgresServicePatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsPostgresResponse>(),
            PostgresServicePatchErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update Postgres service state
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresStateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresServicePatchStateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Initiate a process for a Postgres service:
    /// * restart: Initiates a service restart
    /// * promote: Promotes a read replica to primary
    /// * switchover: Switch a primary over to a standby
    /// </remarks>
    public Task<V1OrganizationsPostgresStateResponse> PostgresServicePatchState(Guid organizationId,
        Guid postgresId,
        PostgresServiceSetState? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/state"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsPostgresStateResponse>(),
            PostgresServicePatchStateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update Postgres superuser password
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresPasswordResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostgresServiceSetPasswordError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Sets a new password for a Postgres service's superuser account.
    /// </remarks>
    public Task<V1OrganizationsPostgresPasswordResponse> PostgresServiceSetPassword(Guid organizationId,
        Guid postgresId,
        PostgresServiceSetPassword? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/password"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsPostgresPasswordResponse>(),
            PostgresServiceSetPasswordErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get a Postgres slow query pattern with recent executions
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="queryId">Stable identifier for the query pattern.</param>
    /// <param name="dbName">Database name filter.</param>
    /// <param name="dbUser">Database user filter.</param>
    /// <param name="dbOperation">Database operation filter (for example, SELECT, INSERT, UPDATE, DELETE, UTILITY).</param>
    /// <param name="app">Application name filter.</param>
    /// <param name="timestamp">Timestamp of a specific execution (RFC 3339).</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SlowQueryPatternGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns aggregate metrics for a single slow query pattern together with its most recent individual executions.
    /// </remarks>
    public Task<V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse> SlowQueryPatternGet(Guid organizationId,
        Guid postgresId,
        string queryId,
        string dbName,
        string dbUser,
        string dbOperation,
        string? app,
        DateTimeOffset? timestamp,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/slowQueryPatterns/{queryId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("postgresId", postgresId),
                new TemplateParam("queryId", queryId)],
            [new Param("db_name", dbName),
                new Param("db_user", dbUser),
                new Param("db_operation", dbOperation),
                new Param("app", app),
                new Param("timestamp", timestamp?.ToIso8601())],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsPostgresSlowQueryPatternsQueryIdResponse>(),
            SlowQueryPatternGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Postgres slow query patterns
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the Postgres service.</param>
    /// <param name="postgresId">ID of the requested Postgres service.</param>
    /// <param name="fromDate">Inclusive start of the time window (RFC 3339 date-time).</param>
    /// <param name="toDate">Exclusive end of the time window (RFC 3339 date-time).</param>
    /// <param name="dbName">Database name filter.</param>
    /// <param name="dbUser">Database user filter.</param>
    /// <param name="dbOperation">Database operation filter (for example, SELECT, INSERT, UPDATE, DELETE, UTILITY).</param>
    /// <param name="app">Application name filter.</param>
    /// <param name="sortBy">Field to sort results by.</param>
    /// <param name="sortOrder">Sort order. One of <c>asc</c> or <c>desc</c>.</param>
    /// <param name="limit">Maximum number of results to return.</param>
    /// <param name="offset">Number of results to skip before returning.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPostgresSlowQueryPatternsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SlowQueryPatternsGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns aggregate metrics for the slowest query patterns observed on a Postgres service during the given time window. Use this to discover which queries dominate total execution time, CPU, I/O, or WAL generation.
    /// </remarks>
    public Task<V1OrganizationsPostgresSlowQueryPatternsResponse> SlowQueryPatternsGetList(Guid organizationId,
        Guid postgresId,
        DateTimeOffset fromDate,
        DateTimeOffset toDate,
        string? dbName,
        string? dbUser,
        string? dbOperation,
        string? app,
        SortBy? sortBy,
        SortOrder1? sortOrder,
        int? limit = 20,
        int? offset = 0,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/postgres/{postgresId}/slowQueryPatterns"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("postgresId", postgresId)],
            [new Param("from_date", fromDate.ToIso8601()),
                new Param("to_date", toDate.ToIso8601()),
                new Param("db_name", dbName),
                new Param("db_user", dbUser),
                new Param("db_operation", dbOperation),
                new Param("app", app),
                new Param("sort_by", sortBy),
                new Param("sort_order", sortOrder),
                new Param("limit", limit),
                new Param("offset", offset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsPostgresSlowQueryPatternsResponse>(),
            SlowQueryPatternsGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
