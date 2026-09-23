using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresLogsGetListError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresLogs400Error1> _v1OrganizationsPostgresLogs400Error1Value;

    private readonly Optional<V1OrganizationsPostgresLogs500Error1> _v1OrganizationsPostgresLogs500Error1Value;

    private PostgresLogsGetListError(Optional<V1OrganizationsPostgresLogs400Error1> v1OrganizationsPostgresLogs400Error1Value,
        Optional<V1OrganizationsPostgresLogs500Error1> v1OrganizationsPostgresLogs500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresLogs400Error1Value = v1OrganizationsPostgresLogs400Error1Value;
        _v1OrganizationsPostgresLogs500Error1Value = v1OrganizationsPostgresLogs500Error1Value;
    }

    private static PostgresLogsGetListError AsV1OrganizationsPostgresLogs400Error1(V1OrganizationsPostgresLogs400Error1 value) =>
        new(Optional<V1OrganizationsPostgresLogs400Error1>.Some(value), default, default);

    private static PostgresLogsGetListError AsV1OrganizationsPostgresLogs500Error1(V1OrganizationsPostgresLogs500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresLogs500Error1>.Some(value), default);

    private static PostgresLogsGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresLogs400Error1(out V1OrganizationsPostgresLogs400Error1 value) =>
        _v1OrganizationsPostgresLogs400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresLogs500Error1(out V1OrganizationsPostgresLogs500Error1 value) =>
        _v1OrganizationsPostgresLogs500Error1Value.TryGetValue(out value);

    internal static Task<PostgresLogsGetListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresLogs400Error1>(response, ct).As(AsV1OrganizationsPostgresLogs400Error1),
            500 => FromJson<V1OrganizationsPostgresLogs500Error1>(response, ct).As(AsV1OrganizationsPostgresLogs500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresLogsGetListErrorResponse : IErrorResponse<PostgresLogsGetListError>
{
    public static PostgresLogsGetListErrorResponse Instance { get; } = new();

    private PostgresLogsGetListErrorResponse()
    {
    }

    public Task<PostgresLogsGetListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresLogsGetListError.Create(response, ct);
}
