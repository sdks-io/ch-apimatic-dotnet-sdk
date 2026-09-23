using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeSettingsUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1> _v1OrganizationsServicesClickpipesClickPipeIdSettings400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1> _v1OrganizationsServicesClickpipesClickPipeIdSettings500Error1Value;

    private ClickPipeSettingsUpdateError(Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1> v1OrganizationsServicesClickpipesClickPipeIdSettings400Error1Value,
        Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1> v1OrganizationsServicesClickpipesClickPipeIdSettings500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesClickPipeIdSettings400Error1Value =
            v1OrganizationsServicesClickpipesClickPipeIdSettings400Error1Value;
        _v1OrganizationsServicesClickpipesClickPipeIdSettings500Error1Value =
            v1OrganizationsServicesClickpipesClickPipeIdSettings500Error1Value;
    }

    private static ClickPipeSettingsUpdateError AsV1OrganizationsServicesClickpipesClickPipeIdSettings400Error1(V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1>.Some(value), default, default);

    private static ClickPipeSettingsUpdateError AsV1OrganizationsServicesClickpipesClickPipeIdSettings500Error1(V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1>.Some(value), default);

    private static ClickPipeSettingsUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesClickPipeIdSettings400Error1(out V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1 value) =>
        _v1OrganizationsServicesClickpipesClickPipeIdSettings400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesClickPipeIdSettings500Error1(out V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1 value) =>
        _v1OrganizationsServicesClickpipesClickPipeIdSettings500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeSettingsUpdateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesClickPipeIdSettings400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesClickPipeIdSettings500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeSettingsUpdateErrorResponse : IErrorResponse<ClickPipeSettingsUpdateError>
{
    public static ClickPipeSettingsUpdateErrorResponse Instance { get; } = new();

    private ClickPipeSettingsUpdateErrorResponse()
    {
    }

    public Task<ClickPipeSettingsUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeSettingsUpdateError.Create(response, ct);
}
