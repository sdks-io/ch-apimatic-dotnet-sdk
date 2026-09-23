using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipesServiceContextGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesContext400Error1> _v1OrganizationsServicesClickpipesContext400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesContext500Error1> _v1OrganizationsServicesClickpipesContext500Error1Value;

    private ClickPipesServiceContextGetError(Optional<V1OrganizationsServicesClickpipesContext400Error1> v1OrganizationsServicesClickpipesContext400Error1Value,
        Optional<V1OrganizationsServicesClickpipesContext500Error1> v1OrganizationsServicesClickpipesContext500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesContext400Error1Value = v1OrganizationsServicesClickpipesContext400Error1Value;
        _v1OrganizationsServicesClickpipesContext500Error1Value = v1OrganizationsServicesClickpipesContext500Error1Value;
    }

    private static ClickPipesServiceContextGetError AsV1OrganizationsServicesClickpipesContext400Error1(V1OrganizationsServicesClickpipesContext400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesContext400Error1>.Some(value), default, default);

    private static ClickPipesServiceContextGetError AsV1OrganizationsServicesClickpipesContext500Error1(V1OrganizationsServicesClickpipesContext500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipesContext500Error1>.Some(value), default);

    private static ClickPipesServiceContextGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesContext400Error1(out V1OrganizationsServicesClickpipesContext400Error1 value) =>
        _v1OrganizationsServicesClickpipesContext400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesContext500Error1(out V1OrganizationsServicesClickpipesContext500Error1 value) =>
        _v1OrganizationsServicesClickpipesContext500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipesServiceContextGetError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesContext400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesContext400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesContext500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesContext500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipesServiceContextGetErrorResponse : IErrorResponse<ClickPipesServiceContextGetError>
{
    public static ClickPipesServiceContextGetErrorResponse Instance { get; } = new();

    private ClickPipesServiceContextGetErrorResponse()
    {
    }

    public Task<ClickPipesServiceContextGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipesServiceContextGetError.Create(response, ct);
}
