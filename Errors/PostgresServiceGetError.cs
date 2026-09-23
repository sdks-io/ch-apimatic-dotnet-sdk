using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresServiceGetError : ApiError
{
    private readonly Optional<V1OrganizationsPostgres400Error1> _v1OrganizationsPostgres400Error1Value;

    private readonly Optional<V1OrganizationsPostgres500Error1> _v1OrganizationsPostgres500Error1Value;

    private PostgresServiceGetError(Optional<V1OrganizationsPostgres400Error1> v1OrganizationsPostgres400Error1Value,
        Optional<V1OrganizationsPostgres500Error1> v1OrganizationsPostgres500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgres400Error1Value = v1OrganizationsPostgres400Error1Value;
        _v1OrganizationsPostgres500Error1Value = v1OrganizationsPostgres500Error1Value;
    }

    private static PostgresServiceGetError AsV1OrganizationsPostgres400Error1(V1OrganizationsPostgres400Error1 value) =>
        new(Optional<V1OrganizationsPostgres400Error1>.Some(value), default, default);

    private static PostgresServiceGetError AsV1OrganizationsPostgres500Error1(V1OrganizationsPostgres500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgres500Error1>.Some(value), default);

    private static PostgresServiceGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgres400Error1(out V1OrganizationsPostgres400Error1 value) =>
        _v1OrganizationsPostgres400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgres500Error1(out V1OrganizationsPostgres500Error1 value) =>
        _v1OrganizationsPostgres500Error1Value.TryGetValue(out value);

    internal static Task<PostgresServiceGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgres400Error1>(response, ct).As(AsV1OrganizationsPostgres400Error1),
            500 => FromJson<V1OrganizationsPostgres500Error1>(response, ct).As(AsV1OrganizationsPostgres500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresServiceGetErrorResponse : IErrorResponse<PostgresServiceGetError>
{
    public static PostgresServiceGetErrorResponse Instance { get; } = new();

    private PostgresServiceGetErrorResponse()
    {
    }

    public Task<PostgresServiceGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresServiceGetError.Create(response, ct);
}
