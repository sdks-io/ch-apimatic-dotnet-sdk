using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeReversePrivateEndpointCreateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1> _v1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1> _v1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1Value;

    private ClickPipeReversePrivateEndpointCreateError(Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1> v1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1Value,
        Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1> v1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1Value =
            v1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1Value;
        _v1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1Value =
            v1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1Value;
    }

    private static ClickPipeReversePrivateEndpointCreateError AsV1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1(V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1>.Some(value), default, default);

    private static ClickPipeReversePrivateEndpointCreateError AsV1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1(V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1>.Some(value), default);

    private static ClickPipeReversePrivateEndpointCreateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1 value) =>
        _v1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1 value) =>
        _v1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeReversePrivateEndpointCreateError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeReversePrivateEndpointCreateErrorResponse : IErrorResponse<ClickPipeReversePrivateEndpointCreateError>
{
    public static ClickPipeReversePrivateEndpointCreateErrorResponse Instance { get; } = new();

    private ClickPipeReversePrivateEndpointCreateErrorResponse()
    {
    }

    public Task<ClickPipeReversePrivateEndpointCreateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeReversePrivateEndpointCreateError.Create(response, ct);
}
