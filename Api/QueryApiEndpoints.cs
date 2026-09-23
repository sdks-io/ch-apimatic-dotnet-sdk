using System;
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

public sealed class QueryApiEndpoints
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal QueryApiEndpoints(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create a Query API endpoint
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesQueryApiEndpointsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryApiEndpointCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Creates a Query API endpoint.
    /// </remarks>
    public Task<V1OrganizationsServicesQueryApiEndpointsResponse> QueryApiEndpointCreate(Guid organizationId,
        Guid serviceId,
        PublicQueryApiEndpointRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/query-api-endpoints"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesQueryApiEndpointsResponse>(),
            QueryApiEndpointCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a Query API endpoint
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="endpointId">ID of the requested Query API endpoint.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryApiEndpointDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Deletes a Query API endpoint.
    /// </remarks>
    public Task<V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse> QueryApiEndpointDelete(Guid organizationId,
        Guid serviceId,
        Guid endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/query-api-endpoints/{endpointId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("endpointId", endpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse>(),
            QueryApiEndpointDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get a Query API endpoint
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="endpointId">ID of the requested Query API endpoint.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryApiEndpointGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns a Query API endpoint.
    /// </remarks>
    public Task<V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1> QueryApiEndpointGet(Guid organizationId,
        Guid serviceId,
        Guid endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/query-api-endpoints/{endpointId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("endpointId", endpointId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1>(),
            QueryApiEndpointGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List Query API endpoints
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="cursor">Cursor returned in <c>pagination.nextCursor</c> from the previous page.</param>
    /// <param name="limit">Maximum number of records to return per page. Defaults to 100. Maximum is 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesQueryApiEndpointsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryApiEndpointListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns all active Query API endpoints for the service.
    /// </remarks>
    public Task<V1OrganizationsServicesQueryApiEndpointsResponse1> QueryApiEndpointList(Guid organizationId,
        Guid serviceId,
        string? cursor,
        int? limit = 100,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/query-api-endpoints"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesQueryApiEndpointsResponse1>(),
            QueryApiEndpointListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update a Query API endpoint
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="endpointId">ID of the requested Query API endpoint.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="QueryApiEndpointUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Updates a Query API endpoint.
    /// </remarks>
    public Task<V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1> QueryApiEndpointUpdate(Guid organizationId,
        Guid serviceId,
        Guid endpointId,
        PublicQueryApiEndpointRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/query-api-endpoints/{endpointId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("endpointId", endpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesQueryApiEndpointsEndpointIdResponse1>(),
            QueryApiEndpointUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
