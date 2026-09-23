using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresOrgPrometheusGetError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresPrometheus400Error1> _v1OrganizationsPostgresPrometheus400Error1Value;

    private readonly Optional<V1OrganizationsPostgresPrometheus500Error1> _v1OrganizationsPostgresPrometheus500Error1Value;

    private PostgresOrgPrometheusGetError(Optional<V1OrganizationsPostgresPrometheus400Error1> v1OrganizationsPostgresPrometheus400Error1Value,
        Optional<V1OrganizationsPostgresPrometheus500Error1> v1OrganizationsPostgresPrometheus500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresPrometheus400Error1Value = v1OrganizationsPostgresPrometheus400Error1Value;
        _v1OrganizationsPostgresPrometheus500Error1Value = v1OrganizationsPostgresPrometheus500Error1Value;
    }

    private static PostgresOrgPrometheusGetError AsV1OrganizationsPostgresPrometheus400Error1(V1OrganizationsPostgresPrometheus400Error1 value) =>
        new(Optional<V1OrganizationsPostgresPrometheus400Error1>.Some(value), default, default);

    private static PostgresOrgPrometheusGetError AsV1OrganizationsPostgresPrometheus500Error1(V1OrganizationsPostgresPrometheus500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresPrometheus500Error1>.Some(value), default);

    private static PostgresOrgPrometheusGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresPrometheus400Error1(out V1OrganizationsPostgresPrometheus400Error1 value) =>
        _v1OrganizationsPostgresPrometheus400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresPrometheus500Error1(out V1OrganizationsPostgresPrometheus500Error1 value) =>
        _v1OrganizationsPostgresPrometheus500Error1Value.TryGetValue(out value);

    internal static Task<PostgresOrgPrometheusGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresPrometheus400Error1>(response, ct).As(AsV1OrganizationsPostgresPrometheus400Error1),
            500 => FromJson<V1OrganizationsPostgresPrometheus500Error1>(response, ct).As(AsV1OrganizationsPostgresPrometheus500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresOrgPrometheusGetErrorResponse : IErrorResponse<PostgresOrgPrometheusGetError>
{
    public static PostgresOrgPrometheusGetErrorResponse Instance { get; } = new();

    private PostgresOrgPrometheusGetErrorResponse()
    {
    }

    public Task<PostgresOrgPrometheusGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresOrgPrometheusGetError.Create(response, ct);
}
