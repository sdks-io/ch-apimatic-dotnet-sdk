using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeSettingsGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1> _v1OrganizationsServicesClickpipesClickPipeIdSettings400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1> _v1OrganizationsServicesClickpipesClickPipeIdSettings500Error1Value;

    private ClickPipeSettingsGetError(Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1> v1OrganizationsServicesClickpipesClickPipeIdSettings400Error1Value,
        Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1> v1OrganizationsServicesClickpipesClickPipeIdSettings500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesClickPipeIdSettings400Error1Value =
            v1OrganizationsServicesClickpipesClickPipeIdSettings400Error1Value;
        _v1OrganizationsServicesClickpipesClickPipeIdSettings500Error1Value =
            v1OrganizationsServicesClickpipesClickPipeIdSettings500Error1Value;
    }

    private static ClickPipeSettingsGetError AsV1OrganizationsServicesClickpipesClickPipeIdSettings400Error1(V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1>.Some(value), default, default);

    private static ClickPipeSettingsGetError AsV1OrganizationsServicesClickpipesClickPipeIdSettings500Error1(V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1>.Some(value), default);

    private static ClickPipeSettingsGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesClickPipeIdSettings400Error1(out V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1 value) =>
        _v1OrganizationsServicesClickpipesClickPipeIdSettings400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesClickPipeIdSettings500Error1(out V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1 value) =>
        _v1OrganizationsServicesClickpipesClickPipeIdSettings500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeSettingsGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesClickPipeIdSettings400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesClickPipeIdSettings500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeSettingsGetErrorResponse : IErrorResponse<ClickPipeSettingsGetError>
{
    public static ClickPipeSettingsGetErrorResponse Instance { get; } = new();

    private ClickPipeSettingsGetErrorResponse()
    {
    }

    public Task<ClickPipeSettingsGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeSettingsGetError.Create(response, ct);
}
