using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresServiceGetListError : ApiError
{
    private readonly Optional<V1OrganizationsPostgres400Error1> _v1OrganizationsPostgres400Error1Value;

    private readonly Optional<V1OrganizationsPostgres500Error1> _v1OrganizationsPostgres500Error1Value;

    private PostgresServiceGetListError(Optional<V1OrganizationsPostgres400Error1> v1OrganizationsPostgres400Error1Value,
        Optional<V1OrganizationsPostgres500Error1> v1OrganizationsPostgres500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgres400Error1Value = v1OrganizationsPostgres400Error1Value;
        _v1OrganizationsPostgres500Error1Value = v1OrganizationsPostgres500Error1Value;
    }

    private static PostgresServiceGetListError AsV1OrganizationsPostgres400Error1(V1OrganizationsPostgres400Error1 value) =>
        new(Optional<V1OrganizationsPostgres400Error1>.Some(value), default, default);

    private static PostgresServiceGetListError AsV1OrganizationsPostgres500Error1(V1OrganizationsPostgres500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgres500Error1>.Some(value), default);

    private static PostgresServiceGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgres400Error1(out V1OrganizationsPostgres400Error1 value) =>
        _v1OrganizationsPostgres400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgres500Error1(out V1OrganizationsPostgres500Error1 value) =>
        _v1OrganizationsPostgres500Error1Value.TryGetValue(out value);

    internal static Task<PostgresServiceGetListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgres400Error1>(response, ct).As(AsV1OrganizationsPostgres400Error1),
            500 => FromJson<V1OrganizationsPostgres500Error1>(response, ct).As(AsV1OrganizationsPostgres500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresServiceGetListErrorResponse : IErrorResponse<PostgresServiceGetListError>
{
    public static PostgresServiceGetListErrorResponse Instance { get; } = new();

    private PostgresServiceGetListErrorResponse()
    {
    }

    public Task<PostgresServiceGetListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresServiceGetListError.Create(response, ct);
}
