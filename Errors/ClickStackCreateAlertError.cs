using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackCreateAlertError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackAlerts400Error1> _v1OrganizationsServicesClickstackAlerts400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackAlerts500Error1> _v1OrganizationsServicesClickstackAlerts500Error1Value;

    private ClickStackCreateAlertError(Optional<V1OrganizationsServicesClickstackAlerts400Error1> v1OrganizationsServicesClickstackAlerts400Error1Value,
        Optional<V1OrganizationsServicesClickstackAlerts500Error1> v1OrganizationsServicesClickstackAlerts500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackAlerts400Error1Value = v1OrganizationsServicesClickstackAlerts400Error1Value;
        _v1OrganizationsServicesClickstackAlerts500Error1Value = v1OrganizationsServicesClickstackAlerts500Error1Value;
    }

    private static ClickStackCreateAlertError AsV1OrganizationsServicesClickstackAlerts400Error1(V1OrganizationsServicesClickstackAlerts400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackAlerts400Error1>.Some(value), default, default);

    private static ClickStackCreateAlertError AsV1OrganizationsServicesClickstackAlerts500Error1(V1OrganizationsServicesClickstackAlerts500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackAlerts500Error1>.Some(value), default);

    private static ClickStackCreateAlertError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackAlerts400Error1(out V1OrganizationsServicesClickstackAlerts400Error1 value) =>
        _v1OrganizationsServicesClickstackAlerts400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackAlerts500Error1(out V1OrganizationsServicesClickstackAlerts500Error1 value) =>
        _v1OrganizationsServicesClickstackAlerts500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackCreateAlertError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackAlerts400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackAlerts400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackAlerts500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackAlerts500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackCreateAlertErrorResponse : IErrorResponse<ClickStackCreateAlertError>
{
    public static ClickStackCreateAlertErrorResponse Instance { get; } = new();

    private ClickStackCreateAlertErrorResponse()
    {
    }

    public Task<ClickStackCreateAlertError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackCreateAlertError.Create(response, ct);
}
