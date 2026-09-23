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
using OpenApiSpecForClickHouseCloud.Models.AnyOf;

namespace OpenApiSpecForClickHouseCloud.Api;

public sealed class ClickStack
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ClickStack(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ClickStack - Create Alert
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackAlertsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackCreateAlertError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Creates a new alert
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackAlertsResponse1> ClickStackCreateAlert(Guid organizationId,
        Guid serviceId,
        ClickStackCreateAlertRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/alerts"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackAlertsResponse1>(),
            ClickStackCreateAlertErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Create Dashboard
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackDashboardsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackCreateDashboardError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Creates a new dashboard
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackDashboardsResponse1> ClickStackCreateDashboard(Guid organizationId,
        Guid serviceId,
        ClickStackCreateDashboardRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/dashboards"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackDashboardsResponse1>(),
            ClickStackCreateDashboardErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Create Role
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackRolesResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackCreateRoleError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Creates a new custom role for the team.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackRolesResponse1> ClickStackCreateRole(Guid organizationId,
        Guid serviceId,
        ClickStackCreateRoleRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/roles"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackRolesResponse1>(),
            ClickStackCreateRoleErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Create Saved Search
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackSavedSearchesResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackCreateSavedSearchError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Creates a new saved search.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackSavedSearchesResponse1> ClickStackCreateSavedSearch(Guid organizationId,
        Guid serviceId,
        ClickStackSavedSearchInput? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/saved-searches"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackSavedSearchesResponse1>(),
            ClickStackCreateSavedSearchErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Create Source
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackSourcesResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackCreateSourceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Creates a new source.  The request body is a source object without the <c>id</c> field. If an <c>id</c> is sent anyway it is silently ignored (stripped before validation — the request is never rejected because of it). Granularity fields (<c>materializedViews[].minGranularity</c> and <c>metadataMaterializedViews.granularity</c>) accept the same short format the API returns (e.g. <c>5m</c>, <c>15s</c>, <c>1h</c>, <c>1d</c>).
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackSourcesResponse1> ClickStackCreateSource(Guid organizationId,
        Guid serviceId,
        ClickStackSource? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/sources"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackSourcesResponse1>(),
            ClickStackCreateSourceErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Create Webhook
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackWebhooksResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackCreateWebhookError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Creates a new webhook for the authenticated team.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackWebhooksResponse1> ClickStackCreateWebhook(Guid organizationId,
        Guid serviceId,
        ClickStackWebhookInput? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/webhooks"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackWebhooksResponse1>(),
            ClickStackCreateWebhookErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Delete Alert
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackAlertId">ClickStack Alert ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackDeleteAlertError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Deletes an alert
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2> ClickStackDeleteAlert(Guid organizationId,
        Guid serviceId,
        string clickStackAlertId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/alerts/{clickStackAlertId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackAlertId", clickStackAlertId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse2>(),
            ClickStackDeleteAlertErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Delete Dashboard
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackDashboardId">ClickStack Dashboard ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackDeleteDashboardError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Deletes a dashboard
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2> ClickStackDeleteDashboard(Guid organizationId,
        Guid serviceId,
        string clickStackDashboardId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/dashboards/{clickStackDashboardId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackDashboardId", clickStackDashboardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse2>(),
            ClickStackDeleteDashboardErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Delete Role
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackRoleId">id parameter</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackDeleteRoleError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Deletes a custom role. Predefined roles, the team default user role, and roles assigned to users cannot be deleted.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2> ClickStackDeleteRole(Guid organizationId,
        Guid serviceId,
        string clickStackRoleId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/roles/{clickStackRoleId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackRoleId", clickStackRoleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse2>(),
            ClickStackDeleteRoleErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Delete Saved Search
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackSavedSearchId">Saved search ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackDeleteSavedSearchError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Deletes a saved search and any alerts attached to it.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2> ClickStackDeleteSavedSearch(Guid organizationId,
        Guid serviceId,
        string clickStackSavedSearchId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/saved-searches/{clickStackSavedSearchId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackSavedSearchId", clickStackSavedSearchId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse2>(),
            ClickStackDeleteSavedSearchErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Delete Source
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackSourceId">Source ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackDeleteSourceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Deletes a source
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2> ClickStackDeleteSource(Guid organizationId,
        Guid serviceId,
        string clickStackSourceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/sources/{clickStackSourceId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackSourceId", clickStackSourceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse2>(),
            ClickStackDeleteSourceErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Delete Webhook
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackWebhookId">Webhook ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackDeleteWebhookError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Deletes a webhook. Blocked with a 409 while any alert still references it — reassign or remove those alerts first — so deletion never leaves an alert pointing at a missing webhook (which would silently drop notifications). Mirrors the internal webhook delete guard.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1> ClickStackDeleteWebhook(Guid organizationId,
        Guid serviceId,
        string clickStackWebhookId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/webhooks/{clickStackWebhookId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackWebhookId", clickStackWebhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse1>(),
            ClickStackDeleteWebhookErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Get Alert
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackAlertId">ClickStack Alert ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackGetAlertError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves a specific alert by ID
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse> ClickStackGetAlert(Guid organizationId,
        Guid serviceId,
        string clickStackAlertId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/alerts/{clickStackAlertId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackAlertId", clickStackAlertId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse>(),
            ClickStackGetAlertErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Get Dashboard
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackDashboardId">ClickStack Dashboard ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackGetDashboardError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves a specific dashboard by ID
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse> ClickStackGetDashboard(Guid organizationId,
        Guid serviceId,
        string clickStackDashboardId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/dashboards/{clickStackDashboardId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackDashboardId", clickStackDashboardId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse>(),
            ClickStackGetDashboardErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Get Role
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackRoleId">id parameter</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackGetRoleError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves a specific role by ID.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse> ClickStackGetRole(Guid organizationId,
        Guid serviceId,
        string clickStackRoleId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/roles/{clickStackRoleId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackRoleId", clickStackRoleId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse>(),
            ClickStackGetRoleErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Get Saved Search
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackSavedSearchId">Saved search ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackGetSavedSearchError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves a specific saved search by ID.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse> ClickStackGetSavedSearch(Guid organizationId,
        Guid serviceId,
        string clickStackSavedSearchId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/saved-searches/{clickStackSavedSearchId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackSavedSearchId", clickStackSavedSearchId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse>(),
            ClickStackGetSavedSearchErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Get Source
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackSourceId">Source ID</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackGetSourceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves a specific source by ID
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse> ClickStackGetSource(Guid organizationId,
        Guid serviceId,
        string clickStackSourceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/sources/{clickStackSourceId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackSourceId", clickStackSourceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse>(),
            ClickStackGetSourceErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - List Alerts
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="limit">Maximum number of results to return.</param>
    /// <param name="offset">Number of results to skip before returning.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackAlertsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackListAlertsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves alerts for the authenticated team (paginated). Results are capped at <c>limit</c> (default and maximum 1000). When <c>totalCount</c> exceeds the number of returned items, page with <c>limit</c>/<c>offset</c> to retrieve them all.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackAlertsResponse> ClickStackListAlerts(Guid organizationId,
        Guid serviceId,
        int? limit = 1000,
        int? offset = 0,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/alerts"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [new Param("limit", limit), new Param("offset", offset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackAlertsResponse>(),
            ClickStackListAlertsErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - List Dashboards
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackDashboardsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackListDashboardsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves a list of all dashboards for the authenticated team
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackDashboardsResponse> ClickStackListDashboards(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/dashboards"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackDashboardsResponse>(),
            ClickStackListDashboardsErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - List Roles
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackRolesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackListRolesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves all roles for the authenticated team, including predefined roles.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackRolesResponse> ClickStackListRoles(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/roles"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackRolesResponse>(),
            ClickStackListRolesErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - List Saved Searches
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="limit">Maximum number of results to return.</param>
    /// <param name="offset">Number of results to skip before returning.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackSavedSearchesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackListSavedSearchesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves saved searches for the authenticated team (paginated). Results are capped at <c>limit</c> (default and maximum 1000). When <c>totalCount</c> exceeds the number of returned items, page with <c>limit</c>/<c>offset</c> to retrieve them all.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackSavedSearchesResponse> ClickStackListSavedSearches(Guid organizationId,
        Guid serviceId,
        int? limit = 1000,
        int? offset = 0,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/saved-searches"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [new Param("limit", limit), new Param("offset", offset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackSavedSearchesResponse>(),
            ClickStackListSavedSearchesErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - List Sources
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackSourcesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackListSourcesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves a list of all sources for the authenticated team
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackSourcesResponse> ClickStackListSources(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/sources"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackSourcesResponse>(),
            ClickStackListSourcesErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - List Webhooks
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="limit">Maximum number of results to return.</param>
    /// <param name="offset">Number of results to skip before returning.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackWebhooksResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackListWebhooksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Retrieves webhooks for the authenticated team (paginated). Results are capped at <c>limit</c> (default and maximum 1000). When <c>totalCount</c> exceeds the number of returned items, page with <c>limit</c>/<c>offset</c> to retrieve them all.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackWebhooksResponse> ClickStackListWebhooks(Guid organizationId,
        Guid serviceId,
        int? limit = 1000,
        int? offset = 0,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/webhooks"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [new Param("limit", limit), new Param("offset", offset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickstackWebhooksResponse>(),
            ClickStackListWebhooksErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Update Alert
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackAlertId">ClickStack Alert ID</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackUpdateAlertError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Updates an existing alert
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse> ClickStackUpdateAlert(Guid organizationId,
        Guid serviceId,
        string clickStackAlertId,
        ClickStackUpdateAlertRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/alerts/{clickStackAlertId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackAlertId", clickStackAlertId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackAlertsClickStackAlertIdResponse>(),
            ClickStackUpdateAlertErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Update Dashboard
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackDashboardId">ClickStack Dashboard ID</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackUpdateDashboardError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Updates an existing dashboard.  <b>Concurrency:</b> This endpoint does not support optimistic concurrency control. Concurrent PUT requests for the same dashboard may silently overwrite each other, which can leave orphan tile-to-container references on layout-shape edits. Clients should serialize edits to a given dashboard.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse> ClickStackUpdateDashboard(Guid organizationId,
        Guid serviceId,
        string clickStackDashboardId,
        ClickStackUpdateDashboardRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/dashboards/{clickStackDashboardId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackDashboardId", clickStackDashboardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackDashboardsClickStackDashboardIdResponse>(),
            ClickStackUpdateDashboardErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Update Role
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackRoleId">id parameter</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackUpdateRoleError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Updates a custom role's permissions, name, and description. Predefined roles cannot be modified.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse> ClickStackUpdateRole(Guid organizationId,
        Guid serviceId,
        string clickStackRoleId,
        ClickStackUpdateRoleRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/roles/{clickStackRoleId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackRoleId", clickStackRoleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackRolesClickStackRoleIdResponse>(),
            ClickStackUpdateRoleErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Update Saved Search
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackSavedSearchId">Saved search ID</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackUpdateSavedSearchError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Updates an existing saved search. This is a full replace: send the full object. Every optional field (<c>select</c>, <c>where</c>, <c>whereLanguage</c>, <c>orderBy</c>, <c>tags</c>, <c>filters</c>) is always written and falls back to its default when omitted, so omitting a field resets it rather than preserving the stored value.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse> ClickStackUpdateSavedSearch(Guid organizationId,
        Guid serviceId,
        string clickStackSavedSearchId,
        ClickStackSavedSearchInput? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/saved-searches/{clickStackSavedSearchId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackSavedSearchId", clickStackSavedSearchId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse>(),
            ClickStackUpdateSavedSearchErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Update Source
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackSourceId">Source ID</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackUpdateSourceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Updates an existing source. The full source object must be provided; this is a replace, not a patch.  The request body is a source object without the <c>id</c> field. If an <c>id</c> is sent anyway it is silently ignored (stripped before validation — never a 400); the path parameter alone identifies the source. Granularity fields (<c>materializedViews[].minGranularity</c> and <c>metadataMaterializedViews.granularity</c>) accept the same short format the API returns (e.g. <c>5m</c>, <c>15s</c>, <c>1h</c>, <c>1d</c>).
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse> ClickStackUpdateSource(Guid organizationId,
        Guid serviceId,
        string clickStackSourceId,
        ClickStackSource? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/sources/{clickStackSourceId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackSourceId", clickStackSourceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse>(),
            ClickStackUpdateSourceErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Update Webhook
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="clickStackWebhookId">Webhook ID</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackUpdateWebhookError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Replaces an existing webhook. Readable optional fields (<c>description</c>, <c>body</c>) are a full replace: omitting them clears them. The write-only fields <c>headers</c> and <c>queryParams</c> are never returned on read, so omitting them preserves the stored values; send an explicit empty object (<c>{}</c>) to clear them. Exception: if the destination (<c>url</c> or <c>service</c>) changes, omitted <c>headers</c>/ <c>queryParams</c> are cleared rather than preserved so stored secrets are never forwarded to a new destination.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse> ClickStackUpdateWebhook(Guid organizationId,
        Guid serviceId,
        string clickStackWebhookId,
        ClickStackWebhookInput? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/webhooks/{clickStackWebhookId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickStackWebhookId", clickStackWebhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackWebhooksClickStackWebhookIdResponse>(),
            ClickStackUpdateWebhookErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// ClickStack - Validate Dashboard
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the ClickStack service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickstackDashboardsValidateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickStackValidateDashboardApiError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; ClickStack: Validates a dashboard body against the same schema and tile rules used by POST /api/v2/dashboards. The dashboard is <b>never persisted</b>. Use this endpoint at plan time (e.g. from a Terraform provider) to check that a dashboard configuration is valid before applying it.
    /// </remarks>
    public Task<V1OrganizationsServicesClickstackDashboardsValidateResponse> ClickStackValidateDashboard(Guid organizationId,
        Guid serviceId,
        ClickStackCreateDashboardRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickstack/dashboards/validate"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickstackDashboardsValidateResponse>(),
            ClickStackValidateDashboardApiErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
