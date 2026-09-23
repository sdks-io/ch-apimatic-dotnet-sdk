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

public sealed class SnapshotApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SnapshotApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get service snapshot configuration
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesSnapshotConfigurationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SnapshotConfigurationGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns the service snapshot configuration.
    /// </remarks>
    public Task<V1OrganizationsServicesSnapshotConfigurationResponse> SnapshotConfigurationGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/snapshotConfiguration"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesSnapshotConfigurationResponse>(),
            SnapshotConfigurationGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update service snapshot configuration
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesSnapshotConfigurationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SnapshotConfigurationUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Updates the service snapshot configuration. Requires ADMIN auth key role. Enables or disables scheduled snapshots and sets the cadence; when enabled, gap and timeFrame (in minutes) must together be one of the supported (gap, timeFrame) pairs: (30, 1440), (60, 2880). Provide at least one of enabled, gap, timeFrame; omit a field to leave it unchanged (null is not accepted).
    /// </remarks>
    public Task<V1OrganizationsServicesSnapshotConfigurationResponse> SnapshotConfigurationUpdate(Guid organizationId,
        Guid serviceId,
        SnapshotConfigurationPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/snapshotConfiguration"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesSnapshotConfigurationResponse>(),
            SnapshotConfigurationUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get snapshot details
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the snapshot.</param>
    /// <param name="serviceId">ID of the service the snapshot was created from.</param>
    /// <param name="snapshotId">ID of the requested snapshot.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesSnapshotsSnapshotIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SnapshotGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns a single snapshot info.
    /// </remarks>
    public Task<V1OrganizationsServicesSnapshotsSnapshotIdResponse> SnapshotGet(Guid organizationId,
        Guid serviceId,
        Guid snapshotId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/snapshots/{snapshotId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("snapshotId", snapshotId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesSnapshotsSnapshotIdResponse>(),
            SnapshotGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List of service snapshots
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the snapshot.</param>
    /// <param name="serviceId">ID of the service the snapshot was created from.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesSnapshotsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="SnapshotGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns a list of all snapshots for the service. The most recent snapshots come first in the list.
    /// </remarks>
    public Task<V1OrganizationsServicesSnapshotsResponse> SnapshotGetList(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/snapshots"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesSnapshotsResponse>(),
            SnapshotGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
