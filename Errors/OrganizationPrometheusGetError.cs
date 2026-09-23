using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class OrganizationPrometheusGetError : ApiError
{
    private readonly Optional<V1OrganizationsPrometheus400Error1> _v1OrganizationsPrometheus400Error1Value;

    private readonly Optional<V1OrganizationsPrometheus500Error1> _v1OrganizationsPrometheus500Error1Value;

    private OrganizationPrometheusGetError(Optional<V1OrganizationsPrometheus400Error1> v1OrganizationsPrometheus400Error1Value,
        Optional<V1OrganizationsPrometheus500Error1> v1OrganizationsPrometheus500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPrometheus400Error1Value = v1OrganizationsPrometheus400Error1Value;
        _v1OrganizationsPrometheus500Error1Value = v1OrganizationsPrometheus500Error1Value;
    }

    private static OrganizationPrometheusGetError AsV1OrganizationsPrometheus400Error1(V1OrganizationsPrometheus400Error1 value) =>
        new(Optional<V1OrganizationsPrometheus400Error1>.Some(value), default, default);

    private static OrganizationPrometheusGetError AsV1OrganizationsPrometheus500Error1(V1OrganizationsPrometheus500Error1 value) =>
        new(default, Optional<V1OrganizationsPrometheus500Error1>.Some(value), default);

    private static OrganizationPrometheusGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPrometheus400Error1(out V1OrganizationsPrometheus400Error1 value) =>
        _v1OrganizationsPrometheus400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPrometheus500Error1(out V1OrganizationsPrometheus500Error1 value) =>
        _v1OrganizationsPrometheus500Error1Value.TryGetValue(out value);

    internal static Task<OrganizationPrometheusGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPrometheus400Error1>(response, ct).As(AsV1OrganizationsPrometheus400Error1),
            500 => FromJson<V1OrganizationsPrometheus500Error1>(response, ct).As(AsV1OrganizationsPrometheus500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OrganizationPrometheusGetErrorResponse : IErrorResponse<OrganizationPrometheusGetError>
{
    public static OrganizationPrometheusGetErrorResponse Instance { get; } = new();

    private OrganizationPrometheusGetErrorResponse()
    {
    }

    public Task<OrganizationPrometheusGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OrganizationPrometheusGetError.Create(response, ct);
}
