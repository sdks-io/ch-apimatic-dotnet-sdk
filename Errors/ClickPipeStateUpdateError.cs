using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeStateUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesClickPipeIdState400Error1> _v1OrganizationsServicesClickpipesClickPipeIdState400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesClickPipeIdState500Error1> _v1OrganizationsServicesClickpipesClickPipeIdState500Error1Value;

    private ClickPipeStateUpdateError(Optional<V1OrganizationsServicesClickpipesClickPipeIdState400Error1> v1OrganizationsServicesClickpipesClickPipeIdState400Error1Value,
        Optional<V1OrganizationsServicesClickpipesClickPipeIdState500Error1> v1OrganizationsServicesClickpipesClickPipeIdState500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesClickPipeIdState400Error1Value =
            v1OrganizationsServicesClickpipesClickPipeIdState400Error1Value;
        _v1OrganizationsServicesClickpipesClickPipeIdState500Error1Value =
            v1OrganizationsServicesClickpipesClickPipeIdState500Error1Value;
    }

    private static ClickPipeStateUpdateError AsV1OrganizationsServicesClickpipesClickPipeIdState400Error1(V1OrganizationsServicesClickpipesClickPipeIdState400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesClickPipeIdState400Error1>.Some(value), default, default);

    private static ClickPipeStateUpdateError AsV1OrganizationsServicesClickpipesClickPipeIdState500Error1(V1OrganizationsServicesClickpipesClickPipeIdState500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipesClickPipeIdState500Error1>.Some(value), default);

    private static ClickPipeStateUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesClickPipeIdState400Error1(out V1OrganizationsServicesClickpipesClickPipeIdState400Error1 value) =>
        _v1OrganizationsServicesClickpipesClickPipeIdState400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesClickPipeIdState500Error1(out V1OrganizationsServicesClickpipesClickPipeIdState500Error1 value) =>
        _v1OrganizationsServicesClickpipesClickPipeIdState500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeStateUpdateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesClickPipeIdState400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesClickPipeIdState400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesClickPipeIdState500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesClickPipeIdState500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeStateUpdateErrorResponse : IErrorResponse<ClickPipeStateUpdateError>
{
    public static ClickPipeStateUpdateErrorResponse Instance { get; } = new();

    private ClickPipeStateUpdateErrorResponse()
    {
    }

    public Task<ClickPipeStateUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeStateUpdateError.Create(response, ct);
}
