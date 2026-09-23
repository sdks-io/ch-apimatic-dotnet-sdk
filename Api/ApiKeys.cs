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

public sealed class ApiKeys
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApiKeys(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create key
    /// </summary>
    /// <param name="organizationId">ID of the organization that will own the key.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsKeysResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OpenapiKeyCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates new API key.
    /// </remarks>
    public Task<V1OrganizationsKeysResponse1> OpenapiKeyCreate(Guid organizationId,
        ApiKeyPostRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/keys"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsKeysResponse1>(),
            OpenapiKeyCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete key
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the key.</param>
    /// <param name="keyId">ID of the key to delete.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsKeysResponse4"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OpenapiKeyDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes API key. Only a key not used to authenticate the active request can be deleted.
    /// </remarks>
    public Task<V1OrganizationsKeysResponse4> OpenapiKeyDelete(Guid organizationId,
        Guid keyId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/keys/{keyId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("keyId", keyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsKeysResponse4>(),
            OpenapiKeyDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get key details
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="keyId">ID of the requested key.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsKeysResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OpenapiKeyGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single key details.
    /// </remarks>
    public Task<V1OrganizationsKeysResponse2> OpenapiKeyGet(Guid organizationId,
        Guid keyId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/keys/{keyId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("keyId", keyId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsKeysResponse2>(),
            OpenapiKeyGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get list of keys
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="cursor">Opaque cursor from a previous response's <c>nextCursor</c>, marking where to resume the list.</param>
    /// <param name="limit">Maximum number of results to return.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsKeysResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OpenapiKeyGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of keys in the organization, ordered by creation date, oldest first. Results are capped at <c>limit</c> (default and maximum 250) per page. Every response carries <c>limit</c>, <c>totalCount</c> and <c>nextCursor</c>; pass <c>nextCursor</c> as the <c>cursor</c> query parameter to fetch the next page, repeating until it is null.
    /// </remarks>
    public Task<V1OrganizationsKeysResponse> OpenapiKeyGetList(Guid organizationId,
        string? cursor,
        int? limit = 250,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/keys"),
            [new TemplateParam("organizationId", organizationId)],
            [new Param("limit", limit), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsKeysResponse>(),
            OpenapiKeyGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update key
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the key.</param>
    /// <param name="keyId">ID of the key to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsKeysResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OpenapiKeyUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates API key properties.
    /// </remarks>
    public Task<V1OrganizationsKeysResponse2> OpenapiKeyUpdate(Guid organizationId,
        Guid keyId,
        ApiKeyPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/keys/{keyId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("keyId", keyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsKeysResponse2>(),
            OpenapiKeyUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
