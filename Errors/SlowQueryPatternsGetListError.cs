using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class SlowQueryPatternsGetListError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresSlowQueryPatterns400Error1> _v1OrganizationsPostgresSlowQueryPatterns400Error1Value;

    private readonly Optional<V1OrganizationsPostgresSlowQueryPatterns500Error1> _v1OrganizationsPostgresSlowQueryPatterns500Error1Value;

    private SlowQueryPatternsGetListError(Optional<V1OrganizationsPostgresSlowQueryPatterns400Error1> v1OrganizationsPostgresSlowQueryPatterns400Error1Value,
        Optional<V1OrganizationsPostgresSlowQueryPatterns500Error1> v1OrganizationsPostgresSlowQueryPatterns500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresSlowQueryPatterns400Error1Value = v1OrganizationsPostgresSlowQueryPatterns400Error1Value;
        _v1OrganizationsPostgresSlowQueryPatterns500Error1Value = v1OrganizationsPostgresSlowQueryPatterns500Error1Value;
    }

    private static SlowQueryPatternsGetListError AsV1OrganizationsPostgresSlowQueryPatterns400Error1(V1OrganizationsPostgresSlowQueryPatterns400Error1 value) =>
        new(Optional<V1OrganizationsPostgresSlowQueryPatterns400Error1>.Some(value), default, default);

    private static SlowQueryPatternsGetListError AsV1OrganizationsPostgresSlowQueryPatterns500Error1(V1OrganizationsPostgresSlowQueryPatterns500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresSlowQueryPatterns500Error1>.Some(value), default);

    private static SlowQueryPatternsGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresSlowQueryPatterns400Error1(out V1OrganizationsPostgresSlowQueryPatterns400Error1 value) =>
        _v1OrganizationsPostgresSlowQueryPatterns400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresSlowQueryPatterns500Error1(out V1OrganizationsPostgresSlowQueryPatterns500Error1 value) =>
        _v1OrganizationsPostgresSlowQueryPatterns500Error1Value.TryGetValue(out value);

    internal static Task<SlowQueryPatternsGetListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresSlowQueryPatterns400Error1>(response, ct).As(AsV1OrganizationsPostgresSlowQueryPatterns400Error1),
            500 => FromJson<V1OrganizationsPostgresSlowQueryPatterns500Error1>(response, ct).As(AsV1OrganizationsPostgresSlowQueryPatterns500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SlowQueryPatternsGetListErrorResponse : IErrorResponse<SlowQueryPatternsGetListError>
{
    public static SlowQueryPatternsGetListErrorResponse Instance { get; } = new();

    private SlowQueryPatternsGetListErrorResponse()
    {
    }

    public Task<SlowQueryPatternsGetListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SlowQueryPatternsGetListError.Create(response, ct);
}
