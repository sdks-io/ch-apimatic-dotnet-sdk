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

public sealed class UdfApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UdfApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Attach UDF to service
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="functionName">Name of the UDF.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsAttachmentsServiceIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfAttachError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Attaches one UDF version to a service, replacing the current version when necessary. When version is omitted, the latest ready version is attached.
    /// </remarks>
    public Task<V1OrganizationsUdfsAttachmentsServiceIdResponse> UdfAttach(Guid organizationId,
        string functionName,
        Guid serviceId,
        V1OrganizationsUdfsAttachmentsServiceIdRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs/{functionName}/attachments/{serviceId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("functionName", functionName),
                new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsUdfsAttachmentsServiceIdResponse>(),
            UdfAttachErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get UDF attachment
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="functionName">Name of the UDF.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsAttachmentsServiceIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfAttachmentGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns the current attachment of a UDF to one service.
    /// </remarks>
    public Task<V1OrganizationsUdfsAttachmentsServiceIdResponse> UdfAttachmentGet(Guid organizationId,
        string functionName,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs/{functionName}/attachments/{serviceId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("functionName", functionName),
                new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsUdfsAttachmentsServiceIdResponse>(),
            UdfAttachmentGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List UDF attachments
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="functionName">Name of the UDF.</param>
    /// <param name="cursor">Cursor returned in <c>pagination.nextCursor</c> from the previous page.</param>
    /// <param name="limit">Maximum number of records to return per page. Defaults to 100. Maximum is 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsAttachmentsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfAttachmentListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns the current service attachments for a UDF, with at most one attachment per service.
    /// </remarks>
    public Task<V1OrganizationsUdfsAttachmentsResponse> UdfAttachmentList(Guid organizationId,
        string functionName,
        string? cursor,
        int? limit = 100,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs/{functionName}/attachments"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("functionName", functionName)],
            [new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsUdfsAttachmentsResponse>(),
            UdfAttachmentListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create UDF
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Creates a new UDF. See <see href="https://clickhouse.com/docs/products/cloud/features/sql-console-features/user-defined-functions">User-defined functions in Cloud</see>.
    /// </remarks>
    public Task<V1OrganizationsUdfsResponse> UdfCreate(Guid organizationId,
        UdfCreateRequest2? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsUdfsResponse>(),
            UdfCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete UDF
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="functionName">Name of the UDF.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Deletes every version of a UDF and detaches it from all services. Removal from services completes asynchronously.
    /// </remarks>
    public Task<V1OrganizationsUdfsResponse2> UdfDelete(Guid organizationId,
        string functionName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs/{functionName}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("functionName", functionName)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsUdfsResponse2>(),
            UdfDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Detach UDF from service
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="functionName">Name of the UDF.</param>
    /// <param name="serviceId">ID of the requested service.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsAttachmentsServiceIdResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfDetachError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Detaches a UDF from a service.
    /// </remarks>
    public Task<V1OrganizationsUdfsAttachmentsServiceIdResponse2> UdfDetach(Guid organizationId,
        string functionName,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs/{functionName}/attachments/{serviceId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("functionName", functionName),
                new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsUdfsAttachmentsServiceIdResponse2>(),
            UdfDetachErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get UDF
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="functionName">Name of the UDF.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns the latest version of a UDF.
    /// </remarks>
    public Task<V1OrganizationsUdfsResponse> UdfGet(Guid organizationId,
        string functionName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs/{functionName}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("functionName", functionName)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsUdfsResponse>(),
            UdfGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List UDFs
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="cursor">Cursor returned in <c>pagination.nextCursor</c> from the previous page.</param>
    /// <param name="limit">Maximum number of records to return per page. Defaults to 100. Maximum is 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns the latest version of each UDF in the organization.
    /// </remarks>
    public Task<V1OrganizationsUdfsResponse1> UdfList(Guid organizationId,
        string? cursor,
        int? limit = 100,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs"),
            [new TemplateParam("organizationId", organizationId)],
            [new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsUdfsResponse1>(),
            UdfListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create UDF upload URL
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfUploadsUrlResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfUploadSessionCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Creates an org-scoped presigned application/zip upload URL. Callers must use an upload ID for only one create or version attempt and request a new upload URL when retrying.
    /// </remarks>
    public Task<V1OrganizationsUdfUploadsUrlResponse> UdfUploadSessionCreate(Guid organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfUploads/url"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsUdfUploadsUrlResponse>(),
            UdfUploadSessionCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create UDF version
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="functionName">Name of the UDF.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsVersionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfVersionCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Consumes a source archive, assigns a version, and starts the UDF build. Optional configuration fields omitted from the request use the defaults documented in the request schema; values are not inherited from the previous version. Retry by requesting a new upload URL and re-uploading.
    /// </remarks>
    public Task<V1OrganizationsUdfsVersionsResponse> UdfVersionCreate(Guid organizationId,
        string functionName,
        UdfVersionCreateRequest2? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs/{functionName}/versions"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("functionName", functionName)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsUdfsVersionsResponse>(),
            UdfVersionCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete UDF version
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="functionName">Name of the UDF.</param>
    /// <param name="version">Version number of the UDF.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsVersionsVersionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfVersionDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Deletes a UDF version. The UDF must not be attached to any services.
    /// </remarks>
    public Task<V1OrganizationsUdfsVersionsVersionResponse> UdfVersionDelete(Guid organizationId,
        string functionName,
        int version,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs/{functionName}/versions/{version}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("functionName", functionName),
                new TemplateParam("version", version)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsUdfsVersionsVersionResponse>(),
            UdfVersionDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List UDF versions
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="functionName">Name of the UDF.</param>
    /// <param name="cursor">Cursor returned in <c>pagination.nextCursor</c> from the previous page.</param>
    /// <param name="limit">Maximum number of records to return per page. Defaults to 100. Maximum is 100.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUdfsVersionsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UdfVersionListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns all versions of a UDF.
    /// </remarks>
    public Task<V1OrganizationsUdfsVersionsResponse1> UdfVersionList(Guid organizationId,
        string functionName,
        string? cursor,
        int? limit = 100,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/udfs/{functionName}/versions"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("functionName", functionName)],
            [new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsUdfsVersionsResponse1>(),
            UdfVersionListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
