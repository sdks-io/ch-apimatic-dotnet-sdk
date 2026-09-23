using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class OrganizationPrivateEndpointConfigGetListError : ApiError
{
    private readonly Optional<V1OrganizationsPrivateEndpointConfig400Error1> _v1OrganizationsPrivateEndpointConfig400Error1Value;

    private readonly Optional<V1OrganizationsPrivateEndpointConfig500Error1> _v1OrganizationsPrivateEndpointConfig500Error1Value;

    private OrganizationPrivateEndpointConfigGetListError(Optional<V1OrganizationsPrivateEndpointConfig400Error1> v1OrganizationsPrivateEndpointConfig400Error1Value,
        Optional<V1OrganizationsPrivateEndpointConfig500Error1> v1OrganizationsPrivateEndpointConfig500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsPrivateEndpointConfig400Error1Value = v1OrganizationsPrivateEndpointConfig400Error1Value;
        _v1OrganizationsPrivateEndpointConfig500Error1Value = v1OrganizationsPrivateEndpointConfig500Error1Value;
    }

    private static OrganizationPrivateEndpointConfigGetListError AsV1OrganizationsPrivateEndpointConfig400Error1(V1OrganizationsPrivateEndpointConfig400Error1 value) =>
        new(Optional<V1OrganizationsPrivateEndpointConfig400Error1>.Some(value), default, default);

    private static OrganizationPrivateEndpointConfigGetListError AsV1OrganizationsPrivateEndpointConfig500Error1(V1OrganizationsPrivateEndpointConfig500Error1 value) =>
        new(default, Optional<V1OrganizationsPrivateEndpointConfig500Error1>.Some(value), default);

    private static OrganizationPrivateEndpointConfigGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsPrivateEndpointConfig400Error1(out V1OrganizationsPrivateEndpointConfig400Error1 value) =>
        _v1OrganizationsPrivateEndpointConfig400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsPrivateEndpointConfig500Error1(out V1OrganizationsPrivateEndpointConfig500Error1 value) =>
        _v1OrganizationsPrivateEndpointConfig500Error1Value.TryGetValue(out value);

    internal static Task<OrganizationPrivateEndpointConfigGetListError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsPrivateEndpointConfig400Error1>(response, ct).As(AsV1OrganizationsPrivateEndpointConfig400Error1),
            500 => FromJson<V1OrganizationsPrivateEndpointConfig500Error1>(response, ct).As(AsV1OrganizationsPrivateEndpointConfig500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OrganizationPrivateEndpointConfigGetListErrorResponse : IErrorResponse<OrganizationPrivateEndpointConfigGetListError>
{
    public static OrganizationPrivateEndpointConfigGetListErrorResponse Instance { get; } = new();

    private OrganizationPrivateEndpointConfigGetListErrorResponse()
    {
    }

    public Task<OrganizationPrivateEndpointConfigGetListError> Map(HttpResponseMessage response,
        CancellationToken ct) => OrganizationPrivateEndpointConfigGetListError.Create(response, ct);
}
