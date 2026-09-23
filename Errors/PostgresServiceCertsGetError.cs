using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class PostgresServiceCertsGetError : ApiError
{
    private readonly Optional<V1OrganizationsPostgresCaCertificates400Error1> _v1OrganizationsPostgresCaCertificates400Error1Value;

    private readonly Optional<V1OrganizationsPostgresCaCertificates500Error1> _v1OrganizationsPostgresCaCertificates500Error1Value;

    private PostgresServiceCertsGetError(Optional<V1OrganizationsPostgresCaCertificates400Error1> v1OrganizationsPostgresCaCertificates400Error1Value,
        Optional<V1OrganizationsPostgresCaCertificates500Error1> v1OrganizationsPostgresCaCertificates500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPostgresCaCertificates400Error1Value = v1OrganizationsPostgresCaCertificates400Error1Value;
        _v1OrganizationsPostgresCaCertificates500Error1Value = v1OrganizationsPostgresCaCertificates500Error1Value;
    }

    private static PostgresServiceCertsGetError AsV1OrganizationsPostgresCaCertificates400Error1(V1OrganizationsPostgresCaCertificates400Error1 value) =>
        new(Optional<V1OrganizationsPostgresCaCertificates400Error1>.Some(value), default, default);

    private static PostgresServiceCertsGetError AsV1OrganizationsPostgresCaCertificates500Error1(V1OrganizationsPostgresCaCertificates500Error1 value) =>
        new(default, Optional<V1OrganizationsPostgresCaCertificates500Error1>.Some(value), default);

    private static PostgresServiceCertsGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPostgresCaCertificates400Error1(out V1OrganizationsPostgresCaCertificates400Error1 value) =>
        _v1OrganizationsPostgresCaCertificates400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPostgresCaCertificates500Error1(out V1OrganizationsPostgresCaCertificates500Error1 value) =>
        _v1OrganizationsPostgresCaCertificates500Error1Value.TryGetValue(out value);

    internal static Task<PostgresServiceCertsGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPostgresCaCertificates400Error1>(response, ct).As(AsV1OrganizationsPostgresCaCertificates400Error1),
            500 => FromJson<V1OrganizationsPostgresCaCertificates500Error1>(response, ct).As(AsV1OrganizationsPostgresCaCertificates500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostgresServiceCertsGetErrorResponse : IErrorResponse<PostgresServiceCertsGetError>
{
    public static PostgresServiceCertsGetErrorResponse Instance { get; } = new();

    private PostgresServiceCertsGetErrorResponse()
    {
    }

    public Task<PostgresServiceCertsGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostgresServiceCertsGetError.Create(response, ct);
}
