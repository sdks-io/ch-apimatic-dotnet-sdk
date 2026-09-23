using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackValidateDashboardApiError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackDashboardsValidate400Error1> _v1OrganizationsServicesClickstackDashboardsValidate400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackDashboardsValidate500Error1> _v1OrganizationsServicesClickstackDashboardsValidate500Error1Value;

    private ClickStackValidateDashboardApiError(Optional<V1OrganizationsServicesClickstackDashboardsValidate400Error1> v1OrganizationsServicesClickstackDashboardsValidate400Error1Value,
        Optional<V1OrganizationsServicesClickstackDashboardsValidate500Error1> v1OrganizationsServicesClickstackDashboardsValidate500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackDashboardsValidate400Error1Value =
            v1OrganizationsServicesClickstackDashboardsValidate400Error1Value;
        _v1OrganizationsServicesClickstackDashboardsValidate500Error1Value =
            v1OrganizationsServicesClickstackDashboardsValidate500Error1Value;
    }

    private static ClickStackValidateDashboardApiError AsV1OrganizationsServicesClickstackDashboardsValidate400Error1(V1OrganizationsServicesClickstackDashboardsValidate400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackDashboardsValidate400Error1>.Some(value), default, default);

    private static ClickStackValidateDashboardApiError AsV1OrganizationsServicesClickstackDashboardsValidate500Error1(V1OrganizationsServicesClickstackDashboardsValidate500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackDashboardsValidate500Error1>.Some(value), default);

    private static ClickStackValidateDashboardApiError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackDashboardsValidate400Error1(out V1OrganizationsServicesClickstackDashboardsValidate400Error1 value) =>
        _v1OrganizationsServicesClickstackDashboardsValidate400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackDashboardsValidate500Error1(out V1OrganizationsServicesClickstackDashboardsValidate500Error1 value) =>
        _v1OrganizationsServicesClickstackDashboardsValidate500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackValidateDashboardApiError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackDashboardsValidate400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackDashboardsValidate400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackDashboardsValidate500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackDashboardsValidate500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackValidateDashboardApiErrorResponse : IErrorResponse<ClickStackValidateDashboardApiError>
{
    public static ClickStackValidateDashboardApiErrorResponse Instance { get; } = new();

    private ClickStackValidateDashboardApiErrorResponse()
    {
    }

    public Task<ClickStackValidateDashboardApiError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackValidateDashboardApiError.Create(response, ct);
}
