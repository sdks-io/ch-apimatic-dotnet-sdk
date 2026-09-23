using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class CreditBalancesGetError : ApiError
{
    private readonly Optional<V1OrganizationsCreditBalances400Error1> _v1OrganizationsCreditBalances400Error1Value;

    private readonly Optional<V1OrganizationsCreditBalances500Error1> _v1OrganizationsCreditBalances500Error1Value;

    private CreditBalancesGetError(Optional<V1OrganizationsCreditBalances400Error1> v1OrganizationsCreditBalances400Error1Value,
        Optional<V1OrganizationsCreditBalances500Error1> v1OrganizationsCreditBalances500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsCreditBalances400Error1Value = v1OrganizationsCreditBalances400Error1Value;
        _v1OrganizationsCreditBalances500Error1Value = v1OrganizationsCreditBalances500Error1Value;
    }

    private static CreditBalancesGetError AsV1OrganizationsCreditBalances400Error1(V1OrganizationsCreditBalances400Error1 value) =>
        new(Optional<V1OrganizationsCreditBalances400Error1>.Some(value), default, default);

    private static CreditBalancesGetError AsV1OrganizationsCreditBalances500Error1(V1OrganizationsCreditBalances500Error1 value) =>
        new(default, Optional<V1OrganizationsCreditBalances500Error1>.Some(value), default);

    private static CreditBalancesGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsCreditBalances400Error1(out V1OrganizationsCreditBalances400Error1 value) =>
        _v1OrganizationsCreditBalances400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsCreditBalances500Error1(out V1OrganizationsCreditBalances500Error1 value) =>
        _v1OrganizationsCreditBalances500Error1Value.TryGetValue(out value);

    internal static Task<CreditBalancesGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsCreditBalances400Error1>(response, ct).As(AsV1OrganizationsCreditBalances400Error1),
            500 => FromJson<V1OrganizationsCreditBalances500Error1>(response, ct).As(AsV1OrganizationsCreditBalances500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreditBalancesGetErrorResponse : IErrorResponse<CreditBalancesGetError>
{
    public static CreditBalancesGetErrorResponse Instance { get; } = new();

    private CreditBalancesGetErrorResponse()
    {
    }

    public Task<CreditBalancesGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreditBalancesGetError.Create(response, ct);
}
