using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class InstanceQueryEndpointDeleteError : ApiError
{
    private readonly Optional<V1OrganizationsServicesServiceQueryEndpoint400Error1> _v1OrganizationsServicesServiceQueryEndpoint400Error1Value;

    private readonly Optional<V1OrganizationsServicesServiceQueryEndpoint500Error1> _v1OrganizationsServicesServiceQueryEndpoint500Error1Value;

    private InstanceQueryEndpointDeleteError(Optional<V1OrganizationsServicesServiceQueryEndpoint400Error1> v1OrganizationsServicesServiceQueryEndpoint400Error1Value,
        Optional<V1OrganizationsServicesServiceQueryEndpoint500Error1> v1OrganizationsServicesServiceQueryEndpoint500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesServiceQueryEndpoint400Error1Value =
            v1OrganizationsServicesServiceQueryEndpoint400Error1Value;
        _v1OrganizationsServicesServiceQueryEndpoint500Error1Value =
            v1OrganizationsServicesServiceQueryEndpoint500Error1Value;
    }

    private static InstanceQueryEndpointDeleteError AsV1OrganizationsServicesServiceQueryEndpoint400Error1(V1OrganizationsServicesServiceQueryEndpoint400Error1 value) =>
        new(Optional<V1OrganizationsServicesServiceQueryEndpoint400Error1>.Some(value), default, default);

    private static InstanceQueryEndpointDeleteError AsV1OrganizationsServicesServiceQueryEndpoint500Error1(V1OrganizationsServicesServiceQueryEndpoint500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesServiceQueryEndpoint500Error1>.Some(value), default);

    private static InstanceQueryEndpointDeleteError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesServiceQueryEndpoint400Error1(out V1OrganizationsServicesServiceQueryEndpoint400Error1 value) =>
        _v1OrganizationsServicesServiceQueryEndpoint400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesServiceQueryEndpoint500Error1(out V1OrganizationsServicesServiceQueryEndpoint500Error1 value) =>
        _v1OrganizationsServicesServiceQueryEndpoint500Error1Value.TryGetValue(out value);

    internal static Task<InstanceQueryEndpointDeleteError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesServiceQueryEndpoint400Error1>(response, ct).As(AsV1OrganizationsServicesServiceQueryEndpoint400Error1),
            500 => FromJson<V1OrganizationsServicesServiceQueryEndpoint500Error1>(response, ct).As(AsV1OrganizationsServicesServiceQueryEndpoint500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class InstanceQueryEndpointDeleteErrorResponse : IErrorResponse<InstanceQueryEndpointDeleteError>
{
    public static InstanceQueryEndpointDeleteErrorResponse Instance { get; } = new();

    private InstanceQueryEndpointDeleteErrorResponse()
    {
    }

    public Task<InstanceQueryEndpointDeleteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        InstanceQueryEndpointDeleteError.Create(response, ct);
}
