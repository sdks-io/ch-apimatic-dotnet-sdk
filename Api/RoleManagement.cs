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

public sealed class RoleManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal RoleManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a role
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="roleId">ID of the requested role.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsRolesResponse4"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationRoleDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an existing custom role. System roles cannot be deleted. This operation will remove the role and all its associated policies.
    /// </remarks>
    public Task<V1OrganizationsRolesResponse4> OrganizationRoleDelete(Guid organizationId,
        Guid roleId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/roles/{roleId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("roleId", roleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsRolesResponse4>(),
            OrganizationRoleDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get role details
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="roleId">ID of the requested role.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsRolesResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationRoleGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details for a specific role.
    /// </remarks>
    public Task<V1OrganizationsRolesResponse1> OrganizationRoleGet(Guid organizationId,
        Guid roleId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/roles/{roleId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("roleId", roleId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsRolesResponse1>(),
            OrganizationRoleGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update a role
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="roleId">ID of the requested role.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsRolesResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationRolePatchError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing custom role. System roles cannot be updated. All fields are optional - only provided fields will be updated.
    /// </remarks>
    public Task<V1OrganizationsRolesResponse1> OrganizationRolePatch(Guid organizationId,
        Guid roleId,
        RoleUpdateRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/roles/{roleId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("roleId", roleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsRolesResponse1>(),
            OrganizationRolePatchErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create a new role
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsRolesResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationRolePostError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new custom role for an organization with specified policies and actors.
    /// </remarks>
    public Task<V1OrganizationsRolesResponse1> OrganizationRolePost(Guid organizationId,
        RoleCreateRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/roles"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsRolesResponse1>(),
            OrganizationRolePostErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List all available roles for an organization
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsRolesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="OrganizationRolesGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all available roles (system + custom) for an organization.
    /// </remarks>
    public Task<V1OrganizationsRolesResponse> OrganizationRolesGetList(Guid organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/roles"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsRolesResponse>(),
            OrganizationRolesGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
