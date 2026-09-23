using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackUpdateAlertError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1> _v1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1> _v1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1Value;

    private ClickStackUpdateAlertError(Optional<V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1> v1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1Value,
        Optional<V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1> v1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1Value =
            v1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1Value;
        _v1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1Value =
            v1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1Value;
    }

    private static ClickStackUpdateAlertError AsV1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1(V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1>.Some(value), default, default);

    private static ClickStackUpdateAlertError AsV1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1(V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1>.Some(value), default);

    private static ClickStackUpdateAlertError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1(out V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1 value) =>
        _v1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1(out V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1 value) =>
        _v1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackUpdateAlertError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackAlertsClickStackAlertId400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackAlertsClickStackAlertId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackUpdateAlertErrorResponse : IErrorResponse<ClickStackUpdateAlertError>
{
    public static ClickStackUpdateAlertErrorResponse Instance { get; } = new();

    private ClickStackUpdateAlertErrorResponse()
    {
    }

    public Task<ClickStackUpdateAlertError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackUpdateAlertError.Create(response, ct);
}
