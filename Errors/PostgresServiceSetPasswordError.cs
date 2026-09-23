using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresServiceSetPasswordError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresPassword400Error1> _v1OrganizationsPostgresPassword400Error1Value;

    private readonly Optional<V1OrganizationsPostgresPassword500Error1> _v1OrganizationsPostgresPassword500Error1Value;

    private PostgresServiceSetPasswordError(Optional<V1OrganizationsPostgresPassword400Error1> v1OrganizationsPostgresPassword400Error1Value,
        Optional<V1OrganizationsPostgresPassword500Error1> v1OrganizationsPostgresPassword500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresPassword400Error1Value = v1OrganizationsPostgresPassword400Error1Value;
        _v1OrganizationsPostgresPassword500Error1Value = v1OrganizationsPostgresPassword500Error1Value;
    }

    private static PostgresServiceSetPasswordError AsV1OrganizationsPostgresPassword400Error1(V1OrganizationsPostgresPassword400Error1 value) =>
        new(Optional<V1OrganizationsPostgresPassword400Error1>.Some(value), default, default);

    private static PostgresServiceSetPasswordError AsV1OrganizationsPostgresPassword500Error1(V1OrganizationsPostgresPassword500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresPassword500Error1>.Some(value), default);

    private static PostgresServiceSetPasswordError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresPassword400Error1(out V1OrganizationsPostgresPassword400Error1 value) =>
        _v1OrganizationsPostgresPassword400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresPassword500Error1(out V1OrganizationsPostgresPassword500Error1 value) =>
        _v1OrganizationsPostgresPassword500Error1Value.TryGetValue(out value);

    internal static Task<PostgresServiceSetPasswordError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresPassword400Error1>(response, ct).As(AsV1OrganizationsPostgresPassword400Error1),
            500 => FromJson<V1OrganizationsPostgresPassword500Error1>(response, ct).As(AsV1OrganizationsPostgresPassword500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresServiceSetPasswordErrorResponse : IErrorResponse<PostgresServiceSetPasswordError>
{
    public static PostgresServiceSetPasswordErrorResponse Instance { get; } = new();

    private PostgresServiceSetPasswordErrorResponse()
    {
    }

    public Task<PostgresServiceSetPasswordError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresServiceSetPasswordError.Create(response, ct);
}
