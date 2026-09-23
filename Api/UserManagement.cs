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

public sealed class UserManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UserManagement(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an invitation
    /// </summary>
    /// <param name="organizationId">ID of the organization to invite a user to.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsInvitationsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InvitationCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates organization invitation.
    /// </remarks>
    public Task<V1OrganizationsInvitationsResponse1> InvitationCreate(Guid organizationId,
        InvitationPostRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/invitations"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsInvitationsResponse1>(),
            InvitationCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete organization invitation
    /// </summary>
    /// <param name="organizationId">ID of the organization that has the invitation.</param>
    /// <param name="invitationId">ID of the requested organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsInvitationsResponse3"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InvitationDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a single organization invitation.
    /// </remarks>
    public Task<V1OrganizationsInvitationsResponse3> InvitationDelete(Guid organizationId,
        Guid invitationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/invitations/{invitationId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("invitationId", invitationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsInvitationsResponse3>(),
            InvitationDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get invitation details
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="invitationId">ID of the requested organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsInvitationsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InvitationGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details for a single organization invitation.
    /// </remarks>
    public Task<V1OrganizationsInvitationsResponse1> InvitationGet(Guid organizationId,
        Guid invitationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/invitations/{invitationId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("invitationId", invitationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsInvitationsResponse1>(),
            InvitationGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List all invitations
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsInvitationsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="InvitationGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns list of all organization invitations.
    /// </remarks>
    public Task<V1OrganizationsInvitationsResponse> InvitationGetList(Guid organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/invitations"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsInvitationsResponse>(),
            InvitationGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Remove an organization member
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="userId">ID of the requested user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsMembersResponse3"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MemberDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a user from the organization
    /// </remarks>
    public Task<V1OrganizationsMembersResponse3> MemberDelete(Guid organizationId,
        Guid userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/members/{userId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("userId", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsMembersResponse3>(),
            MemberDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get member details
    /// </summary>
    /// <param name="organizationId">ID of the organization the member is part of.</param>
    /// <param name="userId">ID of the requested user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsMembersResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MemberGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single organization member details.
    /// </remarks>
    public Task<V1OrganizationsMembersResponse1> MemberGet(Guid organizationId,
        Guid userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/members/{userId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("userId", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsMembersResponse1>(),
            MemberGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List organization members
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsMembersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MemberGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all members in the organization.
    /// </remarks>
    public Task<V1OrganizationsMembersResponse> MemberGetList(Guid organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/members"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsMembersResponse>(),
            MemberGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update organization member
    /// </summary>
    /// <param name="organizationId">ID of the organization the member is part of.</param>
    /// <param name="userId">ID of the user to patch</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsMembersResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="MemberUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates organization member role.
    /// </remarks>
    public Task<V1OrganizationsMembersResponse1> MemberUpdate(Guid organizationId,
        Guid userId,
        MemberPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/members/{userId}"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("userId", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsMembersResponse1>(),
            MemberUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
