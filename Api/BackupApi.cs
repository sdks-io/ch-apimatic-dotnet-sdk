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

public sealed class BackupApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal BackupApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create service backup bucket
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesBackupBucketResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BackupBucketCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Create service backup bucket. Requires ADMIN auth key role.
    /// </remarks>
    public Task<V1OrganizationsServicesBackupBucketResponse> BackupBucketCreate(Guid organizationId,
        Guid serviceId,
        BackupBucketPostRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/backupBucket"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesBackupBucketResponse>(),
            BackupBucketCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete service backup bucket
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesBackupBucketResponse3"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BackupBucketDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Delete service backup bucket. Requires ADMIN auth key role.
    /// </remarks>
    public Task<V1OrganizationsServicesBackupBucketResponse3> BackupBucketDelete(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/backupBucket"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesBackupBucketResponse3>(),
            BackupBucketDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get service backup bucket
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesBackupBucketResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BackupBucketGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns the service backup bucket.
    /// </remarks>
    public Task<V1OrganizationsServicesBackupBucketResponse> BackupBucketGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/backupBucket"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesBackupBucketResponse>(),
            BackupBucketGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update service backup bucket
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesBackupBucketResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BackupBucketUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Update service backup bucket. Requires ADMIN auth key role. The secrets of the specified bucket provider are always required
    /// </remarks>
    public Task<V1OrganizationsServicesBackupBucketResponse> BackupBucketUpdate(Guid organizationId,
        Guid serviceId,
        BackupBucketPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/backupBucket"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesBackupBucketResponse>(),
            BackupBucketUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get service backup configuration
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesBackupConfigurationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BackupConfigurationGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the service backup configuration.
    /// </remarks>
    public Task<V1OrganizationsServicesBackupConfigurationResponse> BackupConfigurationGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/backupConfiguration"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesBackupConfigurationResponse>(),
            BackupConfigurationGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update service backup configuration
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesBackupConfigurationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BackupConfigurationUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates service backup configuration. Requires ADMIN auth key role. Setting the properties with null value, will reset the properties to theirs default values.
    /// </remarks>
    public Task<V1OrganizationsServicesBackupConfigurationResponse> BackupConfigurationUpdate(Guid organizationId,
        Guid serviceId,
        BackupConfigurationPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/backupConfiguration"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesBackupConfigurationResponse>(),
            BackupConfigurationUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get backup details
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the backup.</param>
    /// <param name="serviceId">ID of the service the backup was created from.</param>
    /// <param name="backupId">ID of the requested backup.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesBackupsBackupIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BackupGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single backup info.
    /// </remarks>
    public Task<V1OrganizationsServicesBackupsBackupIdResponse> BackupGet(Guid organizationId,
        Guid serviceId,
        Guid backupId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/backups/{backupId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("backupId", backupId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesBackupsBackupIdResponse>(),
            BackupGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List of service backups
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the backup.</param>
    /// <param name="serviceId">ID of the service the backup was created from.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesBackupsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="BackupGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all backups for the service. The most recent backups comes first in the list.
    /// </remarks>
    public Task<V1OrganizationsServicesBackupsResponse> BackupGetList(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/backups"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesBackupsResponse>(),
            BackupGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
