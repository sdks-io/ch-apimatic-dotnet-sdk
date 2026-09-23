using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresInstanceConfigGetError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresConfig400Error1> _v1OrganizationsPostgresConfig400Error1Value;

    private readonly Optional<V1OrganizationsPostgresConfig500Error1> _v1OrganizationsPostgresConfig500Error1Value;

    private PostgresInstanceConfigGetError(Optional<V1OrganizationsPostgresConfig400Error1> v1OrganizationsPostgresConfig400Error1Value,
        Optional<V1OrganizationsPostgresConfig500Error1> v1OrganizationsPostgresConfig500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresConfig400Error1Value = v1OrganizationsPostgresConfig400Error1Value;
        _v1OrganizationsPostgresConfig500Error1Value = v1OrganizationsPostgresConfig500Error1Value;
    }

    private static PostgresInstanceConfigGetError AsV1OrganizationsPostgresConfig400Error1(V1OrganizationsPostgresConfig400Error1 value) =>
        new(Optional<V1OrganizationsPostgresConfig400Error1>.Some(value), default, default);

    private static PostgresInstanceConfigGetError AsV1OrganizationsPostgresConfig500Error1(V1OrganizationsPostgresConfig500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresConfig500Error1>.Some(value), default);

    private static PostgresInstanceConfigGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresConfig400Error1(out V1OrganizationsPostgresConfig400Error1 value) =>
        _v1OrganizationsPostgresConfig400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresConfig500Error1(out V1OrganizationsPostgresConfig500Error1 value) =>
        _v1OrganizationsPostgresConfig500Error1Value.TryGetValue(out value);

    internal static Task<PostgresInstanceConfigGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresConfig400Error1>(response, ct).As(AsV1OrganizationsPostgresConfig400Error1),
            500 => FromJson<V1OrganizationsPostgresConfig500Error1>(response, ct).As(AsV1OrganizationsPostgresConfig500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresInstanceConfigGetErrorResponse : IErrorResponse<PostgresInstanceConfigGetError>
{
    public static PostgresInstanceConfigGetErrorResponse Instance { get; } = new();

    private PostgresInstanceConfigGetErrorResponse()
    {
    }

    public Task<PostgresInstanceConfigGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresInstanceConfigGetError.Create(response, ct);
}
