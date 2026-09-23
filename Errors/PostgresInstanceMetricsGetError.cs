using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresInstanceMetricsGetError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresMetrics400Error1> _v1OrganizationsPostgresMetrics400Error1Value;

    private readonly Optional<V1OrganizationsPostgresMetrics500Error1> _v1OrganizationsPostgresMetrics500Error1Value;

    private PostgresInstanceMetricsGetError(Optional<V1OrganizationsPostgresMetrics400Error1> v1OrganizationsPostgresMetrics400Error1Value,
        Optional<V1OrganizationsPostgresMetrics500Error1> v1OrganizationsPostgresMetrics500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresMetrics400Error1Value = v1OrganizationsPostgresMetrics400Error1Value;
        _v1OrganizationsPostgresMetrics500Error1Value = v1OrganizationsPostgresMetrics500Error1Value;
    }

    private static PostgresInstanceMetricsGetError AsV1OrganizationsPostgresMetrics400Error1(V1OrganizationsPostgresMetrics400Error1 value) =>
        new(Optional<V1OrganizationsPostgresMetrics400Error1>.Some(value), default, default);

    private static PostgresInstanceMetricsGetError AsV1OrganizationsPostgresMetrics500Error1(V1OrganizationsPostgresMetrics500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresMetrics500Error1>.Some(value), default);

    private static PostgresInstanceMetricsGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresMetrics400Error1(out V1OrganizationsPostgresMetrics400Error1 value) =>
        _v1OrganizationsPostgresMetrics400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresMetrics500Error1(out V1OrganizationsPostgresMetrics500Error1 value) =>
        _v1OrganizationsPostgresMetrics500Error1Value.TryGetValue(out value);

    internal static Task<PostgresInstanceMetricsGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresMetrics400Error1>(response, ct).As(AsV1OrganizationsPostgresMetrics400Error1),
            500 => FromJson<V1OrganizationsPostgresMetrics500Error1>(response, ct).As(AsV1OrganizationsPostgresMetrics500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresInstanceMetricsGetErrorResponse : IErrorResponse<PostgresInstanceMetricsGetError>
{
    public static PostgresInstanceMetricsGetErrorResponse Instance { get; } = new();

    private PostgresInstanceMetricsGetErrorResponse()
    {
    }

    public Task<PostgresInstanceMetricsGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresInstanceMetricsGetError.Create(response, ct);
}
