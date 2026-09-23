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

namespace OpenApiSpecForClickHouseCloud.Api;

public sealed class OrganizationApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OrganizationApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Organization activity
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="activityId">ID of the requested activity.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsActivitiesResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ActivityGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single organization activity by ID.
    /// </remarks>
    public Task<V1OrganizationsActivitiesResponse1> ActivityGet(Guid organizationId,
        string activityId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/activities/{activityId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("activityId", activityId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsActivitiesResponse1>(),
            ActivityGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List of organization activities
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="fromDate">A starting date for a search</param>
    /// <param name="toDate">An ending date for a search</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsActivitiesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ActivityGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all organization activities.
    /// </remarks>
    public Task<V1OrganizationsActivitiesResponse> ActivityGetList(Guid organizationId,
        DateTimeOffset? fromDate,
        DateTimeOffset? toDate,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/activities"),
            [new TemplateParam("organizationId", organizationId)],
            [new Param("from_date", fromDate?.ToIso8601()), new Param("to_date", toDate?.ToIso8601())],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsActivitiesResponse>(),
            ActivityGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create BYOC Infrastructure
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsByocInfrastructureResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationByocInfrastructureCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new BYOC Infrastructure in the organization. Returns the configuration of the newly created infrastructure
    /// </remarks>
    public Task<V1OrganizationsByocInfrastructureResponse> OrganizationByocInfrastructureCreate(Guid organizationId,
        ByocInfrastructurePostRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/byocInfrastructure"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsByocInfrastructureResponse>(),
            OrganizationByocInfrastructureCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Remove a BYOC infrastructure
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="byocInfrastructureId">ID of the requested BYOC Infrastructure</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsByocInfrastructureResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationByocInfrastructureDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a BYOC Infrastructure from the organization
    /// </remarks>
    public Task<V1OrganizationsByocInfrastructureResponse1> OrganizationByocInfrastructureDelete(Guid organizationId,
        Guid byocInfrastructureId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/byocInfrastructure/{byocInfrastructureId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("byocInfrastructureId", byocInfrastructureId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsByocInfrastructureResponse1>(),
            OrganizationByocInfrastructureDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update BYOC Infrastructure
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="byocInfrastructureId">ID of the requested BYOC Infrastructure</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsByocInfrastructureResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationByocInfrastructureUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update configuration of the BYOC infrastructure. Returns the modified infrastructure
    /// </remarks>
    public Task<V1OrganizationsByocInfrastructureResponse> OrganizationByocInfrastructureUpdate(Guid organizationId,
        Guid byocInfrastructureId,
        ByocInfrastructurePatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/byocInfrastructure/{byocInfrastructureId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("byocInfrastructureId", byocInfrastructureId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsByocInfrastructureResponse>(),
            OrganizationByocInfrastructureUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get organization details
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details of a single organization. In order to get the details, the auth key must belong to the organization.
    /// </remarks>
    public Task<V1OrganizationsResponse1> OrganizationGet(Guid organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsResponse1>(),
            OrganizationGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get list of available organizations
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list with a single organization associated with the API key in the request.
    /// </remarks>
    public Task<V1OrganizationsResponse> OrganizationGetList(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsResponse>(),
            OrganizationGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get private endpoint configuration for region within cloud provider for an organization
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="cloudProvider">Cloud provider identifier. One of aws, gcp, or azure.</param>
    /// <param name="regionId">Region identifier within specific cloud providers.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsPrivateEndpointConfigResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationPrivateEndpointConfigGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated. Please follow <see href="https://clickhouse.com/docs/manage/security/aws-privatelink#add-endpoint-id-to-services-allow-list">documentation</see> for the updated process.
    /// </remarks>
    public Task<V1OrganizationsPrivateEndpointConfigResponse> OrganizationPrivateEndpointConfigGetList(Guid organizationId,
        string cloudProvider,
        string regionId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/privateEndpointConfig"),
            [new TemplateParam("organizationId", organizationId)],
            [new Param("cloud_provider", cloudProvider), new Param("region_id", regionId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsPrivateEndpointConfigResponse>(),
            OrganizationPrivateEndpointConfigGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get organization quota details
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="quotaCode">Code of the requested quota.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsQuotasResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationQuotaGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns a single organization quota identified by its quota code. Responds with a not found error when the quota code is unknown or the quota does not apply to the organization.
    /// </remarks>
    public Task<V1OrganizationsQuotasResponse1> OrganizationQuotaGet(Guid organizationId,
        string quotaCode,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/quotas/{quotaCode}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("quotaCode", quotaCode)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsQuotasResponse1>(),
            OrganizationQuotaGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get organization quotas
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsQuotasResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationQuotasGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns the resource quotas enforced for the organization together with their current usage where available. Quotas that do not apply to the organization are omitted. Quota values reflect the limits currently enforced, so they can be polled to detect changes, for example after a billing status change. The response contains one entry per quota code; quotas enforced per resource may additionally appear under resource-scoped endpoints in the future.
    /// </remarks>
    public Task<V1OrganizationsQuotasResponse> OrganizationQuotasGetList(Guid organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/quotas"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsQuotasResponse>(),
            OrganizationQuotasGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update organization details
    /// </summary>
    /// <param name="organizationId">ID of the organization to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates organization fields. Requires ADMIN auth key role.
    /// </remarks>
    public Task<V1OrganizationsResponse1> OrganizationUpdate(Guid organizationId,
        OrganizationPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsResponse1>(),
            OrganizationUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
