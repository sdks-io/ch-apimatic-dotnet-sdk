using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class SlowQueryPatternGetError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresSlowQueryPatternsQueryId400Error1> _v1OrganizationsPostgresSlowQueryPatternsQueryId400Error1Value;

    private readonly Optional<V1OrganizationsPostgresSlowQueryPatternsQueryId500Error1> _v1OrganizationsPostgresSlowQueryPatternsQueryId500Error1Value;

    private SlowQueryPatternGetError(Optional<V1OrganizationsPostgresSlowQueryPatternsQueryId400Error1> v1OrganizationsPostgresSlowQueryPatternsQueryId400Error1Value,
        Optional<V1OrganizationsPostgresSlowQueryPatternsQueryId500Error1> v1OrganizationsPostgresSlowQueryPatternsQueryId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresSlowQueryPatternsQueryId400Error1Value =
            v1OrganizationsPostgresSlowQueryPatternsQueryId400Error1Value;
        _v1OrganizationsPostgresSlowQueryPatternsQueryId500Error1Value =
            v1OrganizationsPostgresSlowQueryPatternsQueryId500Error1Value;
    }

    private static SlowQueryPatternGetError AsV1OrganizationsPostgresSlowQueryPatternsQueryId400Error1(V1OrganizationsPostgresSlowQueryPatternsQueryId400Error1 value) =>
        new(Optional<V1OrganizationsPostgresSlowQueryPatternsQueryId400Error1>.Some(value), default, default);

    private static SlowQueryPatternGetError AsV1OrganizationsPostgresSlowQueryPatternsQueryId500Error1(V1OrganizationsPostgresSlowQueryPatternsQueryId500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresSlowQueryPatternsQueryId500Error1>.Some(value), default);

    private static SlowQueryPatternGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresSlowQueryPatternsQueryId400Error1(out V1OrganizationsPostgresSlowQueryPatternsQueryId400Error1 value) =>
        _v1OrganizationsPostgresSlowQueryPatternsQueryId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresSlowQueryPatternsQueryId500Error1(out V1OrganizationsPostgresSlowQueryPatternsQueryId500Error1 value) =>
        _v1OrganizationsPostgresSlowQueryPatternsQueryId500Error1Value.TryGetValue(out value);

    internal static Task<SlowQueryPatternGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresSlowQueryPatternsQueryId400Error1>(response, ct).As(AsV1OrganizationsPostgresSlowQueryPatternsQueryId400Error1),
            500 => FromJson<V1OrganizationsPostgresSlowQueryPatternsQueryId500Error1>(response, ct).As(AsV1OrganizationsPostgresSlowQueryPatternsQueryId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SlowQueryPatternGetErrorResponse : IErrorResponse<SlowQueryPatternGetError>
{
    public static SlowQueryPatternGetErrorResponse Instance { get; } = new();

    private SlowQueryPatternGetErrorResponse()
    {
    }

    public Task<SlowQueryPatternGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SlowQueryPatternGetError.Create(response, ct);
}
