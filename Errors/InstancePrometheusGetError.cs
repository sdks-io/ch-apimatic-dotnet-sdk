using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class InstancePrometheusGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesPrometheus400Error1> _v1OrganizationsServicesPrometheus400Error1Value;

    private readonly Optional<V1OrganizationsServicesPrometheus500Error1> _v1OrganizationsServicesPrometheus500Error1Value;

    private InstancePrometheusGetError(Optional<V1OrganizationsServicesPrometheus400Error1> v1OrganizationsServicesPrometheus400Error1Value,
        Optional<V1OrganizationsServicesPrometheus500Error1> v1OrganizationsServicesPrometheus500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesPrometheus400Error1Value = v1OrganizationsServicesPrometheus400Error1Value;
        _v1OrganizationsServicesPrometheus500Error1Value = v1OrganizationsServicesPrometheus500Error1Value;
    }

    private static InstancePrometheusGetError AsV1OrganizationsServicesPrometheus400Error1(V1OrganizationsServicesPrometheus400Error1 value) =>
        new(Optional<V1OrganizationsServicesPrometheus400Error1>.Some(value), default, default);

    private static InstancePrometheusGetError AsV1OrganizationsServicesPrometheus500Error1(V1OrganizationsServicesPrometheus500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesPrometheus500Error1>.Some(value), default);

    private static InstancePrometheusGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesPrometheus400Error1(out V1OrganizationsServicesPrometheus400Error1 value) =>
        _v1OrganizationsServicesPrometheus400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesPrometheus500Error1(out V1OrganizationsServicesPrometheus500Error1 value) =>
        _v1OrganizationsServicesPrometheus500Error1Value.TryGetValue(out value);

    internal static Task<InstancePrometheusGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesPrometheus400Error1>(response, ct).As(AsV1OrganizationsServicesPrometheus400Error1),
            500 => FromJson<V1OrganizationsServicesPrometheus500Error1>(response, ct).As(AsV1OrganizationsServicesPrometheus500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class InstancePrometheusGetErrorResponse : IErrorResponse<InstancePrometheusGetError>
{
    public static InstancePrometheusGetErrorResponse Instance { get; } = new();

    private InstancePrometheusGetErrorResponse()
    {
    }

    public Task<InstancePrometheusGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        InstancePrometheusGetError.Create(response, ct);
}
