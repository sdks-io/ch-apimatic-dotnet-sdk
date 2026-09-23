using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class InvitationCreateError : ApiError
{
    private readonly Optional<V1OrganizationsInvitations400Error1> _v1OrganizationsInvitations400Error1Value;

    private readonly Optional<V1OrganizationsInvitations500Error1> _v1OrganizationsInvitations500Error1Value;

    private InvitationCreateError(Optional<V1OrganizationsInvitations400Error1> v1OrganizationsInvitations400Error1Value,
        Optional<V1OrganizationsInvitations500Error1> v1OrganizationsInvitations500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsInvitations400Error1Value = v1OrganizationsInvitations400Error1Value;
        _v1OrganizationsInvitations500Error1Value = v1OrganizationsInvitations500Error1Value;
    }

    private static InvitationCreateError AsV1OrganizationsInvitations400Error1(V1OrganizationsInvitations400Error1 value) =>
        new(Optional<V1OrganizationsInvitations400Error1>.Some(value), default, default);

    private static InvitationCreateError AsV1OrganizationsInvitations500Error1(V1OrganizationsInvitations500Error1 value) =>
        new(default, Optional<V1OrganizationsInvitations500Error1>.Some(value), default);

    private static InvitationCreateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsInvitations400Error1(out V1OrganizationsInvitations400Error1 value) =>
        _v1OrganizationsInvitations400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsInvitations500Error1(out V1OrganizationsInvitations500Error1 value) =>
        _v1OrganizationsInvitations500Error1Value.TryGetValue(out value);

    internal static Task<InvitationCreateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsInvitations400Error1>(response, ct).As(AsV1OrganizationsInvitations400Error1),
            500 => FromJson<V1OrganizationsInvitations500Error1>(response, ct).As(AsV1OrganizationsInvitations500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class InvitationCreateErrorResponse : IErrorResponse<InvitationCreateError>
{
    public static InvitationCreateErrorResponse Instance { get; } = new();

    private InvitationCreateErrorResponse()
    {
    }

    public Task<InvitationCreateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        InvitationCreateError.Create(response, ct);
}
