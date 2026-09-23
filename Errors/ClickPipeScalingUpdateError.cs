using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeScalingUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesClickPipeIdScaling400Error1> _v1OrganizationsServicesClickpipesClickPipeIdScaling400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesClickPipeIdScaling500Error1> _v1OrganizationsServicesClickpipesClickPipeIdScaling500Error1Value;

    private ClickPipeScalingUpdateError(Optional<V1OrganizationsServicesClickpipesClickPipeIdScaling400Error1> v1OrganizationsServicesClickpipesClickPipeIdScaling400Error1Value,
        Optional<V1OrganizationsServicesClickpipesClickPipeIdScaling500Error1> v1OrganizationsServicesClickpipesClickPipeIdScaling500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesClickPipeIdScaling400Error1Value =
            v1OrganizationsServicesClickpipesClickPipeIdScaling400Error1Value;
        _v1OrganizationsServicesClickpipesClickPipeIdScaling500Error1Value =
            v1OrganizationsServicesClickpipesClickPipeIdScaling500Error1Value;
    }

    private static ClickPipeScalingUpdateError AsV1OrganizationsServicesClickpipesClickPipeIdScaling400Error1(V1OrganizationsServicesClickpipesClickPipeIdScaling400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesClickPipeIdScaling400Error1>.Some(value), default, default);

    private static ClickPipeScalingUpdateError AsV1OrganizationsServicesClickpipesClickPipeIdScaling500Error1(V1OrganizationsServicesClickpipesClickPipeIdScaling500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipesClickPipeIdScaling500Error1>.Some(value), default);

    private static ClickPipeScalingUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesClickPipeIdScaling400Error1(out V1OrganizationsServicesClickpipesClickPipeIdScaling400Error1 value) =>
        _v1OrganizationsServicesClickpipesClickPipeIdScaling400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesClickPipeIdScaling500Error1(out V1OrganizationsServicesClickpipesClickPipeIdScaling500Error1 value) =>
        _v1OrganizationsServicesClickpipesClickPipeIdScaling500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeScalingUpdateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesClickPipeIdScaling400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesClickPipeIdScaling400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesClickPipeIdScaling500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesClickPipeIdScaling500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeScalingUpdateErrorResponse : IErrorResponse<ClickPipeScalingUpdateError>
{
    public static ClickPipeScalingUpdateErrorResponse Instance { get; } = new();

    private ClickPipeScalingUpdateErrorResponse()
    {
    }

    public Task<ClickPipeScalingUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeScalingUpdateError.Create(response, ct);
}
