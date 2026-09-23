using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeReversePrivateEndpointDeleteError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1> _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1> _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1Value;

    private ClickPipeReversePrivateEndpointDeleteError(Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1> v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1Value,
        Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1> v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1Value =
            v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1Value;
        _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1Value =
            v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1Value;
    }

    private static ClickPipeReversePrivateEndpointDeleteError AsV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1(V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1>.Some(value),
            default,
            default);

    private static ClickPipeReversePrivateEndpointDeleteError AsV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1(V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1 value) =>
        new(default,
            Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1>.Some(value),
            default);

    private static ClickPipeReversePrivateEndpointDeleteError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1 value) =>
        _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1 value) =>
        _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeReversePrivateEndpointDeleteError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1>(response,
                ct).As(AsV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1>(response,
                ct).As(AsV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeReversePrivateEndpointDeleteErrorResponse : IErrorResponse<ClickPipeReversePrivateEndpointDeleteError>
{
    public static ClickPipeReversePrivateEndpointDeleteErrorResponse Instance { get; } = new();

    private ClickPipeReversePrivateEndpointDeleteErrorResponse()
    {
    }

    public Task<ClickPipeReversePrivateEndpointDeleteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeReversePrivateEndpointDeleteError.Create(response, ct);
}
