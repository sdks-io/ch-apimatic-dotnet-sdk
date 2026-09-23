using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackCreateDashboardError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackDashboards400Error1> _v1OrganizationsServicesClickstackDashboards400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackDashboards500Error1> _v1OrganizationsServicesClickstackDashboards500Error1Value;

    private ClickStackCreateDashboardError(Optional<V1OrganizationsServicesClickstackDashboards400Error1> v1OrganizationsServicesClickstackDashboards400Error1Value,
        Optional<V1OrganizationsServicesClickstackDashboards500Error1> v1OrganizationsServicesClickstackDashboards500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackDashboards400Error1Value =
            v1OrganizationsServicesClickstackDashboards400Error1Value;
        _v1OrganizationsServicesClickstackDashboards500Error1Value =
            v1OrganizationsServicesClickstackDashboards500Error1Value;
    }

    private static ClickStackCreateDashboardError AsV1OrganizationsServicesClickstackDashboards400Error1(V1OrganizationsServicesClickstackDashboards400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackDashboards400Error1>.Some(value), default, default);

    private static ClickStackCreateDashboardError AsV1OrganizationsServicesClickstackDashboards500Error1(V1OrganizationsServicesClickstackDashboards500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackDashboards500Error1>.Some(value), default);

    private static ClickStackCreateDashboardError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackDashboards400Error1(out V1OrganizationsServicesClickstackDashboards400Error1 value) =>
        _v1OrganizationsServicesClickstackDashboards400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackDashboards500Error1(out V1OrganizationsServicesClickstackDashboards500Error1 value) =>
        _v1OrganizationsServicesClickstackDashboards500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackCreateDashboardError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackDashboards400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackDashboards400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackDashboards500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackDashboards500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackCreateDashboardErrorResponse : IErrorResponse<ClickStackCreateDashboardError>
{
    public static ClickStackCreateDashboardErrorResponse Instance { get; } = new();

    private ClickStackCreateDashboardErrorResponse()
    {
    }

    public Task<ClickStackCreateDashboardError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackCreateDashboardError.Create(response, ct);
}
