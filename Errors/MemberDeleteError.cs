using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class MemberDeleteError : ApiError
{
    private readonly Optional<V1OrganizationsMembers400Error1> _v1OrganizationsMembers400Error1Value;

    private readonly Optional<V1OrganizationsMembers500Error1> _v1OrganizationsMembers500Error1Value;

    private MemberDeleteError(Optional<V1OrganizationsMembers400Error1> v1OrganizationsMembers400Error1Value,
        Optional<V1OrganizationsMembers500Error1> v1OrganizationsMembers500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsMembers400Error1Value = v1OrganizationsMembers400Error1Value;
        _v1OrganizationsMembers500Error1Value = v1OrganizationsMembers500Error1Value;
    }

    private static MemberDeleteError AsV1OrganizationsMembers400Error1(V1OrganizationsMembers400Error1 value) =>
        new(Optional<V1OrganizationsMembers400Error1>.Some(value), default, default);

    private static MemberDeleteError AsV1OrganizationsMembers500Error1(V1OrganizationsMembers500Error1 value) =>
        new(default, Optional<V1OrganizationsMembers500Error1>.Some(value), default);

    private static MemberDeleteError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsMembers400Error1(out V1OrganizationsMembers400Error1 value) =>
        _v1OrganizationsMembers400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsMembers500Error1(out V1OrganizationsMembers500Error1 value) =>
        _v1OrganizationsMembers500Error1Value.TryGetValue(out value);

    internal static Task<MemberDeleteError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsMembers400Error1>(response, ct).As(AsV1OrganizationsMembers400Error1),
            500 => FromJson<V1OrganizationsMembers500Error1>(response, ct).As(AsV1OrganizationsMembers500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class MemberDeleteErrorResponse : IErrorResponse<MemberDeleteError>
{
    public static MemberDeleteErrorResponse Instance { get; } = new();

    private MemberDeleteErrorResponse()
    {
    }

    public Task<MemberDeleteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        MemberDeleteError.Create(response, ct);
}
