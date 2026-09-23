using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class OrganizationPrometheusDiscoveryGetError : ApiError
{
    private readonly Optional<V1OrganizationsPrometheusDiscovery400Error1> _v1OrganizationsPrometheusDiscovery400Error1Value;

    private readonly Optional<V1OrganizationsPrometheusDiscovery500Error1> _v1OrganizationsPrometheusDiscovery500Error1Value;

    private OrganizationPrometheusDiscoveryGetError(Optional<V1OrganizationsPrometheusDiscovery400Error1> v1OrganizationsPrometheusDiscovery400Error1Value,
        Optional<V1OrganizationsPrometheusDiscovery500Error1> v1OrganizationsPrometheusDiscovery500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPrometheusDiscovery400Error1Value = v1OrganizationsPrometheusDiscovery400Error1Value;
        _v1OrganizationsPrometheusDiscovery500Error1Value = v1OrganizationsPrometheusDiscovery500Error1Value;
    }

    private static OrganizationPrometheusDiscoveryGetError AsV1OrganizationsPrometheusDiscovery400Error1(V1OrganizationsPrometheusDiscovery400Error1 value) =>
        new(Optional<V1OrganizationsPrometheusDiscovery400Error1>.Some(value), default, default);

    private static OrganizationPrometheusDiscoveryGetError AsV1OrganizationsPrometheusDiscovery500Error1(V1OrganizationsPrometheusDiscovery500Error1 value) =>
        new(default, Optional<V1OrganizationsPrometheusDiscovery500Error1>.Some(value), default);

    private static OrganizationPrometheusDiscoveryGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPrometheusDiscovery400Error1(out V1OrganizationsPrometheusDiscovery400Error1 value) =>
        _v1OrganizationsPrometheusDiscovery400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPrometheusDiscovery500Error1(out V1OrganizationsPrometheusDiscovery500Error1 value) =>
        _v1OrganizationsPrometheusDiscovery500Error1Value.TryGetValue(out value);

    internal static Task<OrganizationPrometheusDiscoveryGetError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPrometheusDiscovery400Error1>(response, ct).As(AsV1OrganizationsPrometheusDiscovery400Error1),
            500 => FromJson<V1OrganizationsPrometheusDiscovery500Error1>(response, ct).As(AsV1OrganizationsPrometheusDiscovery500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OrganizationPrometheusDiscoveryGetErrorResponse : IErrorResponse<OrganizationPrometheusDiscoveryGetError>
{
    public static OrganizationPrometheusDiscoveryGetErrorResponse Instance { get; } = new();

    private OrganizationPrometheusDiscoveryGetErrorResponse()
    {
    }

    public Task<OrganizationPrometheusDiscoveryGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OrganizationPrometheusDiscoveryGetError.Create(response, ct);
}
