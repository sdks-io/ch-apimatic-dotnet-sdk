using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeDeleteError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesClickPipeId400Error1> _v1OrganizationsServicesClickpipesClickPipeId400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesClickPipeId500Error1> _v1OrganizationsServicesClickpipesClickPipeId500Error1Value;

    private ClickPipeDeleteError(Optional<V1OrganizationsServicesClickpipesClickPipeId400Error1> v1OrganizationsServicesClickpipesClickPipeId400Error1Value,
        Optional<V1OrganizationsServicesClickpipesClickPipeId500Error1> v1OrganizationsServicesClickpipesClickPipeId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesClickPipeId400Error1Value =
            v1OrganizationsServicesClickpipesClickPipeId400Error1Value;
        _v1OrganizationsServicesClickpipesClickPipeId500Error1Value =
            v1OrganizationsServicesClickpipesClickPipeId500Error1Value;
    }

    private static ClickPipeDeleteError AsV1OrganizationsServicesClickpipesClickPipeId400Error1(V1OrganizationsServicesClickpipesClickPipeId400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesClickPipeId400Error1>.Some(value), default, default);

    private static ClickPipeDeleteError AsV1OrganizationsServicesClickpipesClickPipeId500Error1(V1OrganizationsServicesClickpipesClickPipeId500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipesClickPipeId500Error1>.Some(value), default);

    private static ClickPipeDeleteError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesClickPipeId400Error1(out V1OrganizationsServicesClickpipesClickPipeId400Error1 value) =>
        _v1OrganizationsServicesClickpipesClickPipeId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesClickPipeId500Error1(out V1OrganizationsServicesClickpipesClickPipeId500Error1 value) =>
        _v1OrganizationsServicesClickpipesClickPipeId500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeDeleteError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesClickPipeId400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesClickPipeId400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesClickPipeId500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesClickPipeId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeDeleteErrorResponse : IErrorResponse<ClickPipeDeleteError>
{
    public static ClickPipeDeleteErrorResponse Instance { get; } = new();

    private ClickPipeDeleteErrorResponse()
    {
    }

    public Task<ClickPipeDeleteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeDeleteError.Create(response, ct);
}
