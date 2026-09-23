using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeReversePrivateEndpointGetListError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1> _v1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1> _v1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1Value;

    private ClickPipeReversePrivateEndpointGetListError(Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1> v1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1Value,
        Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1> v1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1Value =
            v1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1Value;
        _v1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1Value =
            v1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1Value;
    }

    private static ClickPipeReversePrivateEndpointGetListError AsV1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1(V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1>.Some(value), default, default);

    private static ClickPipeReversePrivateEndpointGetListError AsV1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1(V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1>.Some(value), default);

    private static ClickPipeReversePrivateEndpointGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1 value) =>
        _v1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1 value) =>
        _v1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeReversePrivateEndpointGetListError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeReversePrivateEndpointGetListErrorResponse : IErrorResponse<ClickPipeReversePrivateEndpointGetListError>
{
    public static ClickPipeReversePrivateEndpointGetListErrorResponse Instance { get; } = new();

    private ClickPipeReversePrivateEndpointGetListErrorResponse()
    {
    }

    public Task<ClickPipeReversePrivateEndpointGetListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeReversePrivateEndpointGetListError.Create(response, ct);
}
