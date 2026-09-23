using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresInstanceConfigPostError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresConfig400Error1> _v1OrganizationsPostgresConfig400Error1Value;

    private readonly Optional<V1OrganizationsPostgresConfig500Error1> _v1OrganizationsPostgresConfig500Error1Value;

    private PostgresInstanceConfigPostError(Optional<V1OrganizationsPostgresConfig400Error1> v1OrganizationsPostgresConfig400Error1Value,
        Optional<V1OrganizationsPostgresConfig500Error1> v1OrganizationsPostgresConfig500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresConfig400Error1Value = v1OrganizationsPostgresConfig400Error1Value;
        _v1OrganizationsPostgresConfig500Error1Value = v1OrganizationsPostgresConfig500Error1Value;
    }

    private static PostgresInstanceConfigPostError AsV1OrganizationsPostgresConfig400Error1(V1OrganizationsPostgresConfig400Error1 value) =>
        new(Optional<V1OrganizationsPostgresConfig400Error1>.Some(value), default, default);

    private static PostgresInstanceConfigPostError AsV1OrganizationsPostgresConfig500Error1(V1OrganizationsPostgresConfig500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresConfig500Error1>.Some(value), default);

    private static PostgresInstanceConfigPostError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresConfig400Error1(out V1OrganizationsPostgresConfig400Error1 value) =>
        _v1OrganizationsPostgresConfig400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresConfig500Error1(out V1OrganizationsPostgresConfig500Error1 value) =>
        _v1OrganizationsPostgresConfig500Error1Value.TryGetValue(out value);

    internal static Task<PostgresInstanceConfigPostError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresConfig400Error1>(response, ct).As(AsV1OrganizationsPostgresConfig400Error1),
            500 => FromJson<V1OrganizationsPostgresConfig500Error1>(response, ct).As(AsV1OrganizationsPostgresConfig500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresInstanceConfigPostErrorResponse : IErrorResponse<PostgresInstanceConfigPostError>
{
    public static PostgresInstanceConfigPostErrorResponse Instance { get; } = new();

    private PostgresInstanceConfigPostErrorResponse()
    {
    }

    public Task<PostgresInstanceConfigPostError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresInstanceConfigPostError.Create(response, ct);
}
