using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresInstanceRestoreError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresRestoredService400Error1> _v1OrganizationsPostgresRestoredService400Error1Value;

    private readonly Optional<V1OrganizationsPostgresRestoredService500Error1> _v1OrganizationsPostgresRestoredService500Error1Value;

    private PostgresInstanceRestoreError(Optional<V1OrganizationsPostgresRestoredService400Error1> v1OrganizationsPostgresRestoredService400Error1Value,
        Optional<V1OrganizationsPostgresRestoredService500Error1> v1OrganizationsPostgresRestoredService500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresRestoredService400Error1Value = v1OrganizationsPostgresRestoredService400Error1Value;
        _v1OrganizationsPostgresRestoredService500Error1Value = v1OrganizationsPostgresRestoredService500Error1Value;
    }

    private static PostgresInstanceRestoreError AsV1OrganizationsPostgresRestoredService400Error1(V1OrganizationsPostgresRestoredService400Error1 value) =>
        new(Optional<V1OrganizationsPostgresRestoredService400Error1>.Some(value), default, default);

    private static PostgresInstanceRestoreError AsV1OrganizationsPostgresRestoredService500Error1(V1OrganizationsPostgresRestoredService500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresRestoredService500Error1>.Some(value), default);

    private static PostgresInstanceRestoreError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresRestoredService400Error1(out V1OrganizationsPostgresRestoredService400Error1 value) =>
        _v1OrganizationsPostgresRestoredService400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresRestoredService500Error1(out V1OrganizationsPostgresRestoredService500Error1 value) =>
        _v1OrganizationsPostgresRestoredService500Error1Value.TryGetValue(out value);

    internal static Task<PostgresInstanceRestoreError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresRestoredService400Error1>(response, ct).As(AsV1OrganizationsPostgresRestoredService400Error1),
            500 => FromJson<V1OrganizationsPostgresRestoredService500Error1>(response, ct).As(AsV1OrganizationsPostgresRestoredService500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresInstanceRestoreErrorResponse : IErrorResponse<PostgresInstanceRestoreError>
{
    public static PostgresInstanceRestoreErrorResponse Instance { get; } = new();

    private PostgresInstanceRestoreErrorResponse()
    {
    }

    public Task<PostgresInstanceRestoreError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresInstanceRestoreError.Create(response, ct);
}
