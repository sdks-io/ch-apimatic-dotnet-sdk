using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackListDashboardsError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackDashboards400Error1> _v1OrganizationsServicesClickstackDashboards400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackDashboards500Error1> _v1OrganizationsServicesClickstackDashboards500Error1Value;

    private ClickStackListDashboardsError(Optional<V1OrganizationsServicesClickstackDashboards400Error1> v1OrganizationsServicesClickstackDashboards400Error1Value,
        Optional<V1OrganizationsServicesClickstackDashboards500Error1> v1OrganizationsServicesClickstackDashboards500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackDashboards400Error1Value =
            v1OrganizationsServicesClickstackDashboards400Error1Value;
        _v1OrganizationsServicesClickstackDashboards500Error1Value =
            v1OrganizationsServicesClickstackDashboards500Error1Value;
    }

    private static ClickStackListDashboardsError AsV1OrganizationsServicesClickstackDashboards400Error1(V1OrganizationsServicesClickstackDashboards400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackDashboards400Error1>.Some(value), default, default);

    private static ClickStackListDashboardsError AsV1OrganizationsServicesClickstackDashboards500Error1(V1OrganizationsServicesClickstackDashboards500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackDashboards500Error1>.Some(value), default);

    private static ClickStackListDashboardsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackDashboards400Error1(out V1OrganizationsServicesClickstackDashboards400Error1 value) =>
        _v1OrganizationsServicesClickstackDashboards400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackDashboards500Error1(out V1OrganizationsServicesClickstackDashboards500Error1 value) =>
        _v1OrganizationsServicesClickstackDashboards500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackListDashboardsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackDashboards400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackDashboards400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackDashboards500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackDashboards500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackListDashboardsErrorResponse : IErrorResponse<ClickStackListDashboardsError>
{
    public static ClickStackListDashboardsErrorResponse Instance { get; } = new();

    private ClickStackListDashboardsErrorResponse()
    {
    }

    public Task<ClickStackListDashboardsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackListDashboardsError.Create(response, ct);
}
