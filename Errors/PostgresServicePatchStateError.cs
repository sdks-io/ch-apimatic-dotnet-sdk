using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresServicePatchStateError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresState400Error1> _v1OrganizationsPostgresState400Error1Value;

    private readonly Optional<V1OrganizationsPostgresState500Error1> _v1OrganizationsPostgresState500Error1Value;

    private PostgresServicePatchStateError(Optional<V1OrganizationsPostgresState400Error1> v1OrganizationsPostgresState400Error1Value,
        Optional<V1OrganizationsPostgresState500Error1> v1OrganizationsPostgresState500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresState400Error1Value = v1OrganizationsPostgresState400Error1Value;
        _v1OrganizationsPostgresState500Error1Value = v1OrganizationsPostgresState500Error1Value;
    }

    private static PostgresServicePatchStateError AsV1OrganizationsPostgresState400Error1(V1OrganizationsPostgresState400Error1 value) =>
        new(Optional<V1OrganizationsPostgresState400Error1>.Some(value), default, default);

    private static PostgresServicePatchStateError AsV1OrganizationsPostgresState500Error1(V1OrganizationsPostgresState500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresState500Error1>.Some(value), default);

    private static PostgresServicePatchStateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresState400Error1(out V1OrganizationsPostgresState400Error1 value) =>
        _v1OrganizationsPostgresState400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresState500Error1(out V1OrganizationsPostgresState500Error1 value) =>
        _v1OrganizationsPostgresState500Error1Value.TryGetValue(out value);

    internal static Task<PostgresServicePatchStateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresState400Error1>(response, ct).As(AsV1OrganizationsPostgresState400Error1),
            500 => FromJson<V1OrganizationsPostgresState500Error1>(response, ct).As(AsV1OrganizationsPostgresState500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresServicePatchStateErrorResponse : IErrorResponse<PostgresServicePatchStateError>
{
    public static PostgresServicePatchStateErrorResponse Instance { get; } = new();

    private PostgresServicePatchStateErrorResponse()
    {
    }

    public Task<PostgresServicePatchStateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresServicePatchStateError.Create(response, ct);
}
