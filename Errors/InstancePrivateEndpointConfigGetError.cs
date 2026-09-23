using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class InstancePrivateEndpointConfigGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesPrivateEndpointConfig400Error1> _v1OrganizationsServicesPrivateEndpointConfig400Error1Value;

    private readonly Optional<V1OrganizationsServicesPrivateEndpointConfig500Error1> _v1OrganizationsServicesPrivateEndpointConfig500Error1Value;

    private InstancePrivateEndpointConfigGetError(Optional<V1OrganizationsServicesPrivateEndpointConfig400Error1> v1OrganizationsServicesPrivateEndpointConfig400Error1Value,
        Optional<V1OrganizationsServicesPrivateEndpointConfig500Error1> v1OrganizationsServicesPrivateEndpointConfig500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesPrivateEndpointConfig400Error1Value =
            v1OrganizationsServicesPrivateEndpointConfig400Error1Value;
        _v1OrganizationsServicesPrivateEndpointConfig500Error1Value =
            v1OrganizationsServicesPrivateEndpointConfig500Error1Value;
    }

    private static InstancePrivateEndpointConfigGetError AsV1OrganizationsServicesPrivateEndpointConfig400Error1(V1OrganizationsServicesPrivateEndpointConfig400Error1 value) =>
        new(Optional<V1OrganizationsServicesPrivateEndpointConfig400Error1>.Some(value), default, default);

    private static InstancePrivateEndpointConfigGetError AsV1OrganizationsServicesPrivateEndpointConfig500Error1(V1OrganizationsServicesPrivateEndpointConfig500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesPrivateEndpointConfig500Error1>.Some(value), default);

    private static InstancePrivateEndpointConfigGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesPrivateEndpointConfig400Error1(out V1OrganizationsServicesPrivateEndpointConfig400Error1 value) =>
        _v1OrganizationsServicesPrivateEndpointConfig400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesPrivateEndpointConfig500Error1(out V1OrganizationsServicesPrivateEndpointConfig500Error1 value) =>
        _v1OrganizationsServicesPrivateEndpointConfig500Error1Value.TryGetValue(out value);

    internal static Task<InstancePrivateEndpointConfigGetError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesPrivateEndpointConfig400Error1>(response, ct).As(AsV1OrganizationsServicesPrivateEndpointConfig400Error1),
            500 => FromJson<V1OrganizationsServicesPrivateEndpointConfig500Error1>(response, ct).As(AsV1OrganizationsServicesPrivateEndpointConfig500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class InstancePrivateEndpointConfigGetErrorResponse : IErrorResponse<InstancePrivateEndpointConfigGetError>
{
    public static InstancePrivateEndpointConfigGetErrorResponse Instance { get; } = new();

    private InstancePrivateEndpointConfigGetErrorResponse()
    {
    }

    public Task<InstancePrivateEndpointConfigGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        InstancePrivateEndpointConfigGetError.Create(response, ct);
}
