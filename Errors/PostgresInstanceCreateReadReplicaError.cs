using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresInstanceCreateReadReplicaError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresReadReplica400Error1> _v1OrganizationsPostgresReadReplica400Error1Value;

    private readonly Optional<V1OrganizationsPostgresReadReplica500Error1> _v1OrganizationsPostgresReadReplica500Error1Value;

    private PostgresInstanceCreateReadReplicaError(Optional<V1OrganizationsPostgresReadReplica400Error1> v1OrganizationsPostgresReadReplica400Error1Value,
        Optional<V1OrganizationsPostgresReadReplica500Error1> v1OrganizationsPostgresReadReplica500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresReadReplica400Error1Value = v1OrganizationsPostgresReadReplica400Error1Value;
        _v1OrganizationsPostgresReadReplica500Error1Value = v1OrganizationsPostgresReadReplica500Error1Value;
    }

    private static PostgresInstanceCreateReadReplicaError AsV1OrganizationsPostgresReadReplica400Error1(V1OrganizationsPostgresReadReplica400Error1 value) =>
        new(Optional<V1OrganizationsPostgresReadReplica400Error1>.Some(value), default, default);

    private static PostgresInstanceCreateReadReplicaError AsV1OrganizationsPostgresReadReplica500Error1(V1OrganizationsPostgresReadReplica500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresReadReplica500Error1>.Some(value), default);

    private static PostgresInstanceCreateReadReplicaError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresReadReplica400Error1(out V1OrganizationsPostgresReadReplica400Error1 value) =>
        _v1OrganizationsPostgresReadReplica400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresReadReplica500Error1(out V1OrganizationsPostgresReadReplica500Error1 value) =>
        _v1OrganizationsPostgresReadReplica500Error1Value.TryGetValue(out value);

    internal static Task<PostgresInstanceCreateReadReplicaError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresReadReplica400Error1>(response, ct).As(AsV1OrganizationsPostgresReadReplica400Error1),
            500 => FromJson<V1OrganizationsPostgresReadReplica500Error1>(response, ct).As(AsV1OrganizationsPostgresReadReplica500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresInstanceCreateReadReplicaErrorResponse : IErrorResponse<PostgresInstanceCreateReadReplicaError>
{
    public static PostgresInstanceCreateReadReplicaErrorResponse Instance { get; } = new();

    private PostgresInstanceCreateReadReplicaErrorResponse()
    {
    }

    public Task<PostgresInstanceCreateReadReplicaError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresInstanceCreateReadReplicaError.Create(response, ct);
}
