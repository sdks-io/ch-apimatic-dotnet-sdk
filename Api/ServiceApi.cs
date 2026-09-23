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

public sealed class ServiceApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ServiceApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create new service
    /// </summary>
    /// <param name="organizationId">ID of the organization that will own the service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new service in the organization, and returns the current service state and a password to access the service. The service is started asynchronously.
    /// </remarks>
    public Task<V1OrganizationsServicesResponse1> InstanceCreate(Guid organizationId,
        ServicePostRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesResponse1>(),
            InstanceCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete service
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service to delete.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesResponse4"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the service. The service must be in stopped state and is deleted asynchronously after this method call.
    /// </remarks>
    public Task<V1OrganizationsServicesResponse4> InstanceDelete(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesResponse4>(),
            InstanceDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get service details
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a service that belongs to the organization
    /// </remarks>
    public Task<V1OrganizationsServicesResponse2> InstanceGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesResponse2>(),
            InstanceGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List of organization services
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="filter">Filter criteria to apply when retrieving the resource. Currently, only filtering by resource tags is supported.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all services in the organization.
    /// </remarks>
    public Task<V1OrganizationsServicesResponse> InstanceGetList(Guid organizationId,
        IReadOnlyList<string>? filter,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services"),
            [new TemplateParam("organizationId", organizationId)],
            [new Param("filter", filter)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesResponse>(),
            InstanceGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update service password
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service to update password.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesPasswordResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstancePasswordUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sets a new password for the service
    /// </remarks>
    public Task<V1OrganizationsServicesPasswordResponse> InstancePasswordUpdate(Guid organizationId,
        Guid serviceId,
        ServicePasswordPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/password"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesPasswordResponse>(),
            InstancePasswordUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get private endpoint configuration
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesPrivateEndpointConfigResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstancePrivateEndpointConfigGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Information required to set up a private endpoint
    /// </remarks>
    public Task<V1OrganizationsServicesPrivateEndpointConfigResponse> InstancePrivateEndpointConfigGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/privateEndpointConfig"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesPrivateEndpointConfigResponse>(),
            InstancePrivateEndpointConfigGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create a private endpoint
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesPrivateEndpointResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstancePrivateEndpointCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new private endpoint. The private endpoint will be associated with this service and organization
    /// </remarks>
    public Task<V1OrganizationsServicesPrivateEndpointResponse> InstancePrivateEndpointCreate(Guid organizationId,
        Guid serviceId,
        ServicPrivateEndpointePostRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/privateEndpoint"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesPrivateEndpointResponse>(),
            InstancePrivateEndpointCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete the service query endpoint for a given instance
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesServiceQueryEndpointResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceQueryEndpointDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the service query endpoint.
    /// </remarks>
    public Task<V1OrganizationsServicesServiceQueryEndpointResponse1> InstanceQueryEndpointDelete(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/serviceQueryEndpoint"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesServiceQueryEndpointResponse1>(),
            InstanceQueryEndpointDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get the service query endpoint for a given instance
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesServiceQueryEndpointResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceQueryEndpointGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the configuration for the service query endpoint that allows executing queries via API.
    /// </remarks>
    public Task<V1OrganizationsServicesServiceQueryEndpointResponse> InstanceQueryEndpointGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/serviceQueryEndpoint"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesServiceQueryEndpointResponse>(),
            InstanceQueryEndpointGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Upsert the service query endpoint for a given instance
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesServiceQueryEndpointResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceQueryEndpointUpsertError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create the service query endpoint that allows executing queries via API.
    /// </remarks>
    public Task<V1OrganizationsServicesServiceQueryEndpointResponse> InstanceQueryEndpointUpsert(Guid organizationId,
        Guid serviceId,
        InstanceServiceQueryApiEndpointsPostRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/serviceQueryEndpoint"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesServiceQueryEndpointResponse>(),
            InstanceQueryEndpointUpsertErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update service auto scaling settings
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service to update scaling parameters.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesReplicaScalingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceReplicaScalingUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates minimum and maximum memory limits per replica and idle mode scaling behavior for the service. Supports both vertical autoscaling (fixed replica count, variable memory) and horizontal autoscaling (variable replica count, fixed memory). The memory settings are available only for "production" services and must be a multiple of 4 starting from 8GB. For vertical autoscaling, please contact support to enable adjustment of numReplicas. For horizontal autoscaling (autoscalingMode "horizontal" with minReplicas/maxReplicas), contact support to enable the feature for your organization.
    /// </remarks>
    public Task<V1OrganizationsServicesReplicaScalingResponse> InstanceReplicaScalingUpdate(Guid organizationId,
        Guid serviceId,
        ServiceReplicaScalingPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/replicaScaling"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesReplicaScalingResponse>(),
            InstanceReplicaScalingUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update service auto scaling settings
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service to update scaling parameters.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesScalingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceScalingUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates minimum and maximum total memory limits and idle mode scaling behavior for the service. The memory settings are available only for "production" services and must be a multiple of 12 starting from 24GB. Please contact support to enable adjustment of numReplicas.
    /// </remarks>
    public Task<V1OrganizationsServicesScalingResponse> InstanceScalingUpdate(Guid organizationId,
        Guid serviceId,
        ServiceScalingPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/scaling"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesScalingResponse>(),
            InstanceScalingUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update service state
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service to update state.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesStateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceStateUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Starts, stops, or wakes a service. The <c>start</c> and <c>stop</c> commands require the <c>control-plane:service:manage</c> permission on the service. The <c>awake</c> command requires only <c>control-plane:service:view</c> and applies to an idle service; it does not start a stopped service.
    /// </remarks>
    public Task<V1OrganizationsServicesStateResponse> InstanceStateUpdate(Guid organizationId,
        Guid serviceId,
        ServiceStatePatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/state"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesStateResponse>(),
            InstanceStateUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update service basic details
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InstanceUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates basic service details like service name or IP access list.
    /// </remarks>
    public Task<V1OrganizationsServicesResponse2> InstanceUpdate(Guid organizationId,
        Guid serviceId,
        ServicePatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesResponse2>(),
            InstanceUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete service scheduled scaling
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesScalingScheduleResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ScalingScheduleDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Deletes the autoscaling schedule for a service. If a schedule entry is currently active, the base scaling config is restored to the instance before the schedule is removed. Returns 404 if no schedule exists. Requires the scheduled autoscaling feature to be enabled for the organization.
    /// </remarks>
    public Task<V1OrganizationsServicesScalingScheduleResponse2> ScalingScheduleDelete(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/scalingSchedule"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesScalingScheduleResponse2>(),
            ScalingScheduleDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get service autoscaling schedule
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesScalingScheduleResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ScalingScheduleGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns the autoscaling schedule for a service. Returns 404 if no schedule has been configured or if the schedule was cleared. Requires the scheduled autoscaling feature to be enabled for the organization.
    /// </remarks>
    public Task<V1OrganizationsServicesScalingScheduleResponse> ScalingScheduleGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/scalingSchedule"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesScalingScheduleResponse>(),
            ScalingScheduleGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create or replace service autoscaling schedule
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesScalingScheduleResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ScalingScheduleUpsertError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Creates or fully replaces the autoscaling schedule for a service. Pass an empty <c>entries</c> array to clear the schedule — a subsequent GET will return 404, and the response will contain an empty <c>baseConfig</c> (all fields absent). The base scaling config (applied when no entry is active) is managed separately via the <c>replicaScaling</c> endpoint. Requires the scheduled autoscaling feature to be enabled for the organization.
    /// </remarks>
    public Task<V1OrganizationsServicesScalingScheduleResponse> ScalingScheduleUpsert(Guid organizationId,
        Guid serviceId,
        ScalingSchedulePostRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/scalingSchedule"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesScalingScheduleResponse>(),
            ScalingScheduleUpsertErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Reset ClickHouse setting to default
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="settingName">Name of the setting to reset.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickhouseSettingsSettingNameResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ServiceClickhouseSettingDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Removes a previously-configured ClickHouse setting, reverting its effective value to the platform default. Settings under <c>spec.extraConfig.server.*</c> (e.g. <c>keep_alive_timeout</c>, <c>shared_merge_tree_disable_merges_and_mutations_assignment</c>) trigger a ClickHouse server rollout restart; other settings propagate to all replicas after a short delay. Deleting a setting that was never configured is a no-op (200 OK).
    /// </remarks>
    public Task<V1OrganizationsServicesClickhouseSettingsSettingNameResponse1> ServiceClickhouseSettingDelete(Guid organizationId,
        Guid serviceId,
        string settingName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickhouseSettings/{settingName}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("settingName", settingName)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickhouseSettingsSettingNameResponse1>(),
            ServiceClickhouseSettingDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get ClickHouse setting
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="settingName">Name of the setting to retrieve.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickhouseSettingsSettingNameResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ServiceClickhouseSettingGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns the current value of a ClickHouse setting for the service. Use the <see href="#tag/Service/operation/serviceClickhouseSettingsSchemaGet">schema endpoint</see> to discover which settings are configurable.
    /// </remarks>
    public Task<V1OrganizationsServicesClickhouseSettingsSettingNameResponse> ServiceClickhouseSettingGet(Guid organizationId,
        Guid serviceId,
        string settingName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickhouseSettings/{settingName}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("settingName", settingName)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickhouseSettingsSettingNameResponse>(),
            ServiceClickhouseSettingGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List ClickHouse settings
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickhouseSettingsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ServiceClickhouseSettingsListGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns the configured ClickHouse settings for the service. Only settings that have been explicitly set are included.
    /// </remarks>
    public Task<V1OrganizationsServicesClickhouseSettingsResponse> ServiceClickhouseSettingsListGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickhouseSettings"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickhouseSettingsResponse>(),
            ServiceClickhouseSettingsListGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get ClickHouse settings schema
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickhouseSettingsSchemaResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ServiceClickhouseSettingsSchemaGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns the schema of all configurable ClickHouse settings, including types, valid values, descriptions, and warnings.
    /// </remarks>
    public Task<V1OrganizationsServicesClickhouseSettingsSchemaResponse> ServiceClickhouseSettingsSchemaGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickhouseSettings/schema"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickhouseSettingsSchemaResponse>(),
            ServiceClickhouseSettingsSchemaGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update ClickHouse settings
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickhouseSettingsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ServiceClickhouseSettingsUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Updates one or more ClickHouse settings for the service. To reset a setting to its platform default, use the <see href="#tag/Service/operation/serviceClickhouseSettingDelete">DELETE single setting</see> endpoint. Use the <see href="#tag/Service/operation/serviceClickhouseSettingsSchemaGet">schema endpoint</see> to discover which settings are configurable.
    /// </remarks>
    public Task<V1OrganizationsServicesClickhouseSettingsResponse1> ServiceClickhouseSettingsUpdate(Guid organizationId,
        Guid serviceId,
        ServiceClickhouseSettingsPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickhouseSettings"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickhouseSettingsResponse1>(),
            ServiceClickhouseSettingsUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List available service profiles
    /// </summary>
    /// <param name="organizationId">ID of the organization to list available profiles for.</param>
    /// <param name="regionId">Region to list profiles for, e.g. us-east-1. Required unless byoc_id is set; when both are set it must match the BYOC infrastructure's region.</param>
    /// <param name="byocId">ID of the BYOC infrastructure to list profiles for. BYOC profiles are only returned when this is set.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServiceProfilesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ServiceProfilesListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the custom instance profiles the organization can use in a region. Pass byoc_id to list the profiles configured for a BYOC infrastructure; the region is then taken from the infrastructure and region_id may be omitted. The list is empty when the organization tier does not include custom hardware profiles.
    /// </remarks>
    public Task<V1OrganizationsServiceProfilesResponse> ServiceProfilesList(Guid organizationId,
        string? regionId,
        Guid? byocId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/serviceProfiles"),
            [new TemplateParam("organizationId", organizationId)],
            [new Param("region_id", regionId), new Param("byoc_id", byocId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServiceProfilesResponse>(),
            ServiceProfilesListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete service upgrade window
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesUpgradeWindowResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpgradeWindowDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the upgrade window for a service, restoring the default scheduling behaviour. The upgrade window can only be deleted on primary services. Deletion succeeds even if the organization has lost the scheduled upgrades entitlement, so a window can be cleared after entitlement loss.
    /// <para>
    /// Errors:
    /// - 400: the service is a secondary service.
    /// - 401: missing, invalid, or disabled API key.
    /// - 403: caller lacks <c>control-plane:service:manage</c> on the service.
    /// - 404: service does not exist, is not visible to the caller, or no upgrade window is configured.
    /// </para>
    /// </remarks>
    public Task<V1OrganizationsServicesUpgradeWindowResponse2> UpgradeWindowDelete(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/upgradeWindow"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesUpgradeWindowResponse2>(),
            UpgradeWindowDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get service upgrade window
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesUpgradeWindowResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpgradeWindowGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the configured upgrade window for a service.
    /// <para>
    /// Errors:
    /// - 401: missing, invalid, or disabled API key.
    /// - 403: caller lacks <c>control-plane:service:view</c> on the service.
    /// - 404: service does not exist, is not visible to the caller, or no upgrade window has been configured.
    /// </para>
    /// </remarks>
    public Task<V1OrganizationsServicesUpgradeWindowResponse> UpgradeWindowGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/upgradeWindow"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesUpgradeWindowResponse>(),
            UpgradeWindowGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Set service upgrade window
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesUpgradeWindowResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UpgradeWindowUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or fully replaces the upgrade window for a service. The upgrade window currently lasts 6 hours from <c>startHourUtc</c>. The upgrade window can only be set on primary services; secondary services inherit the primary service window.
    /// <para>
    /// Errors:
    /// - 400: invalid field values (<c>weekday</c> not in 0–6, <c>startHourUtc</c> not in {0, 6, 12, 18}), or the service is a secondary service.
    /// - 401: missing, invalid, or disabled API key.
    /// - 403: caller lacks <c>control-plane:service:manage</c> on the service, or the organization does not have the scheduled upgrades feature enabled.
    /// - 404: service does not exist or is not visible to the caller.
    /// </para>
    /// </remarks>
    public Task<V1OrganizationsServicesUpgradeWindowResponse> UpgradeWindowUpdate(Guid organizationId,
        Guid serviceId,
        UpgradeWindowPutRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/upgradeWindow"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesUpgradeWindowResponse>(),
            UpgradeWindowUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
