using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackUpdateDashboardError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1> _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1> _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1Value;

    private ClickStackUpdateDashboardError(Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1> v1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1Value,
        Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1> v1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1Value =
            v1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1Value;
        _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1Value =
            v1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1Value;
    }

    private static ClickStackUpdateDashboardError AsV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1(V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1>.Some(value),
            default,
            default);

    private static ClickStackUpdateDashboardError AsV1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1(V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1 value) =>
        new(default,
            Optional<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1>.Some(value),
            default);

    private static ClickStackUpdateDashboardError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1(out V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1 value) =>
        _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1(out V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1 value) =>
        _v1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackUpdateDashboardError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackDashboardsClickStackDashboardId400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackDashboardsClickStackDashboardId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackUpdateDashboardErrorResponse : IErrorResponse<ClickStackUpdateDashboardError>
{
    public static ClickStackUpdateDashboardErrorResponse Instance { get; } = new();

    private ClickStackUpdateDashboardErrorResponse()
    {
    }

    public Task<ClickStackUpdateDashboardError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackUpdateDashboardError.Create(response, ct);
}
