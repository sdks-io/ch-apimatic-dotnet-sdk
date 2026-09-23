using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeReversePrivateEndpointUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1> _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1> _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1Value;

    private ClickPipeReversePrivateEndpointUpdateError(Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1> v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1Value,
        Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1> v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1Value =
            v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1Value;
        _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1Value =
            v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1Value;
    }

    private static ClickPipeReversePrivateEndpointUpdateError AsV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1(V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1>.Some(value),
            default,
            default);

    private static ClickPipeReversePrivateEndpointUpdateError AsV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1(V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1 value) =>
        new(default,
            Optional<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1>.Some(value),
            default);

    private static ClickPipeReversePrivateEndpointUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1 value) =>
        _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1 value) =>
        _v1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeReversePrivateEndpointUpdateError> Create(HttpResponseMessage response,
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

internal sealed class ClickPipeReversePrivateEndpointUpdateErrorResponse : IErrorResponse<ClickPipeReversePrivateEndpointUpdateError>
{
    public static ClickPipeReversePrivateEndpointUpdateErrorResponse Instance { get; } = new();

    private ClickPipeReversePrivateEndpointUpdateErrorResponse()
    {
    }

    public Task<ClickPipeReversePrivateEndpointUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeReversePrivateEndpointUpdateError.Create(response, ct);
}
