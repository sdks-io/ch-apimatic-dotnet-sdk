using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class InstancePrivateEndpointCreateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesPrivateEndpoint400Error1> _v1OrganizationsServicesPrivateEndpoint400Error1Value;

    private readonly Optional<V1OrganizationsServicesPrivateEndpoint500Error1> _v1OrganizationsServicesPrivateEndpoint500Error1Value;

    private InstancePrivateEndpointCreateError(Optional<V1OrganizationsServicesPrivateEndpoint400Error1> v1OrganizationsServicesPrivateEndpoint400Error1Value,
        Optional<V1OrganizationsServicesPrivateEndpoint500Error1> v1OrganizationsServicesPrivateEndpoint500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesPrivateEndpoint400Error1Value = v1OrganizationsServicesPrivateEndpoint400Error1Value;
        _v1OrganizationsServicesPrivateEndpoint500Error1Value = v1OrganizationsServicesPrivateEndpoint500Error1Value;
    }

    private static InstancePrivateEndpointCreateError AsV1OrganizationsServicesPrivateEndpoint400Error1(V1OrganizationsServicesPrivateEndpoint400Error1 value) =>
        new(Optional<V1OrganizationsServicesPrivateEndpoint400Error1>.Some(value), default, default);

    private static InstancePrivateEndpointCreateError AsV1OrganizationsServicesPrivateEndpoint500Error1(V1OrganizationsServicesPrivateEndpoint500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesPrivateEndpoint500Error1>.Some(value), default);

    private static InstancePrivateEndpointCreateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesPrivateEndpoint400Error1(out V1OrganizationsServicesPrivateEndpoint400Error1 value) =>
        _v1OrganizationsServicesPrivateEndpoint400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesPrivateEndpoint500Error1(out V1OrganizationsServicesPrivateEndpoint500Error1 value) =>
        _v1OrganizationsServicesPrivateEndpoint500Error1Value.TryGetValue(out value);

    internal static Task<InstancePrivateEndpointCreateError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesPrivateEndpoint400Error1>(response, ct).As(AsV1OrganizationsServicesPrivateEndpoint400Error1),
            500 => FromJson<V1OrganizationsServicesPrivateEndpoint500Error1>(response, ct).As(AsV1OrganizationsServicesPrivateEndpoint500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class InstancePrivateEndpointCreateErrorResponse : IErrorResponse<InstancePrivateEndpointCreateError>
{
    public static InstancePrivateEndpointCreateErrorResponse Instance { get; } = new();

    private InstancePrivateEndpointCreateErrorResponse()
    {
    }

    public Task<InstancePrivateEndpointCreateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        InstancePrivateEndpointCreateError.Create(response, ct);
}
