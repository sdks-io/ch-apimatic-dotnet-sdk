using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresServicePatchError : ApiError
{
    private readonly Optional<V1OrganizationsPostgres400Error1> _v1OrganizationsPostgres400Error1Value;

    private readonly Optional<V1OrganizationsPostgres500Error1> _v1OrganizationsPostgres500Error1Value;

    private PostgresServicePatchError(Optional<V1OrganizationsPostgres400Error1> v1OrganizationsPostgres400Error1Value,
        Optional<V1OrganizationsPostgres500Error1> v1OrganizationsPostgres500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgres400Error1Value = v1OrganizationsPostgres400Error1Value;
        _v1OrganizationsPostgres500Error1Value = v1OrganizationsPostgres500Error1Value;
    }

    private static PostgresServicePatchError AsV1OrganizationsPostgres400Error1(V1OrganizationsPostgres400Error1 value) =>
        new(Optional<V1OrganizationsPostgres400Error1>.Some(value), default, default);

    private static PostgresServicePatchError AsV1OrganizationsPostgres500Error1(V1OrganizationsPostgres500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgres500Error1>.Some(value), default);

    private static PostgresServicePatchError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgres400Error1(out V1OrganizationsPostgres400Error1 value) =>
        _v1OrganizationsPostgres400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgres500Error1(out V1OrganizationsPostgres500Error1 value) =>
        _v1OrganizationsPostgres500Error1Value.TryGetValue(out value);

    internal static Task<PostgresServicePatchError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgres400Error1>(response, ct).As(AsV1OrganizationsPostgres400Error1),
            500 => FromJson<V1OrganizationsPostgres500Error1>(response, ct).As(AsV1OrganizationsPostgres500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresServicePatchErrorResponse : IErrorResponse<PostgresServicePatchError>
{
    public static PostgresServicePatchErrorResponse Instance { get; } = new();

    private PostgresServicePatchErrorResponse()
    {
    }

    public Task<PostgresServicePatchError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresServicePatchError.Create(response, ct);
}
