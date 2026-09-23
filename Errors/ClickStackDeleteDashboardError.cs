using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackDeleteDashboardError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1> _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1> _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1Value;

    private ClickStackDeleteDashboardError(Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1> v1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1Value,
        Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1> v1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1Value =
            v1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1Value;
        _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1Value =
            v1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1Value;
    }

    private static ClickStackDeleteDashboardError AsV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1(V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1>.Some(value),
            default,
            default);

    private static ClickStackDeleteDashboardError AsV1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1(V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1 value) =>
        new(default,
            Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1>.Some(value),
            default);

    private static ClickStackDeleteDashboardError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1(out V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1 value) =>
        _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1(out V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1 value) =>
        _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackDeleteDashboardError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackDeleteDashboardErrorResponse : IErrorResponse<ClickStackDeleteDashboardError>
{
    public static ClickStackDeleteDashboardErrorResponse Instance { get; } = new();

    private ClickStackDeleteDashboardErrorResponse()
    {
    }

    public Task<ClickStackDeleteDashboardError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackDeleteDashboardError.Create(response, ct);
}
