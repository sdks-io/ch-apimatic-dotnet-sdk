using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ActiveBalancesGetError : ApiError
{
    private readonly Optional<V1OrganizationsActiveBalances400Error1> _v1OrganizationsActiveBalances400Error1Value;

    private readonly Optional<V1OrganizationsActiveBalances500Error1> _v1OrganizationsActiveBalances500Error1Value;

    private ActiveBalancesGetError(Optional<V1OrganizationsActiveBalances400Error1> v1OrganizationsActiveBalances400Error1Value,
        Optional<V1OrganizationsActiveBalances500Error1> v1OrganizationsActiveBalances500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsActiveBalances400Error1Value = v1OrganizationsActiveBalances400Error1Value;
        _v1OrganizationsActiveBalances500Error1Value = v1OrganizationsActiveBalances500Error1Value;
    }

    private static ActiveBalancesGetError AsV1OrganizationsActiveBalances400Error1(V1OrganizationsActiveBalances400Error1 value) =>
        new(Optional<V1OrganizationsActiveBalances400Error1>.Some(value), default, default);

    private static ActiveBalancesGetError AsV1OrganizationsActiveBalances500Error1(V1OrganizationsActiveBalances500Error1 value) =>
        new(default, Optional<V1OrganizationsActiveBalances500Error1>.Some(value), default);

    private static ActiveBalancesGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsActiveBalances400Error1(out V1OrganizationsActiveBalances400Error1 value) =>
        _v1OrganizationsActiveBalances400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsActiveBalances500Error1(out V1OrganizationsActiveBalances500Error1 value) =>
        _v1OrganizationsActiveBalances500Error1Value.TryGetValue(out value);

    internal static Task<ActiveBalancesGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsActiveBalances400Error1>(response, ct).As(AsV1OrganizationsActiveBalances400Error1),
            500 => FromJson<V1OrganizationsActiveBalances500Error1>(response, ct).As(AsV1OrganizationsActiveBalances500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ActiveBalancesGetErrorResponse : IErrorResponse<ActiveBalancesGetError>
{
    public static ActiveBalancesGetErrorResponse Instance { get; } = new();

    private ActiveBalancesGetErrorResponse()
    {
    }

    public Task<ActiveBalancesGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ActiveBalancesGetError.Create(response, ct);
}
