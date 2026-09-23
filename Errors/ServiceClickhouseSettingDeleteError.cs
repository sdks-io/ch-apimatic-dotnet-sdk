using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ServiceClickhouseSettingDeleteError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickhouseSettingsSettingName400Error1> _v1OrganizationsServicesClickhouseSettingsSettingName400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickhouseSettingsSettingName500Error1> _v1OrganizationsServicesClickhouseSettingsSettingName500Error1Value;

    private ServiceClickhouseSettingDeleteError(Optional<V1OrganizationsServicesClickhouseSettingsSettingName400Error1> v1OrganizationsServicesClickhouseSettingsSettingName400Error1Value,
        Optional<V1OrganizationsServicesClickhouseSettingsSettingName500Error1> v1OrganizationsServicesClickhouseSettingsSettingName500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickhouseSettingsSettingName400Error1Value =
            v1OrganizationsServicesClickhouseSettingsSettingName400Error1Value;
        _v1OrganizationsServicesClickhouseSettingsSettingName500Error1Value =
            v1OrganizationsServicesClickhouseSettingsSettingName500Error1Value;
    }

    private static ServiceClickhouseSettingDeleteError AsV1OrganizationsServicesClickhouseSettingsSettingName400Error1(V1OrganizationsServicesClickhouseSettingsSettingName400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickhouseSettingsSettingName400Error1>.Some(value), default, default);

    private static ServiceClickhouseSettingDeleteError AsV1OrganizationsServicesClickhouseSettingsSettingName500Error1(V1OrganizationsServicesClickhouseSettingsSettingName500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickhouseSettingsSettingName500Error1>.Some(value), default);

    private static ServiceClickhouseSettingDeleteError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickhouseSettingsSettingName400Error1(out V1OrganizationsServicesClickhouseSettingsSettingName400Error1 value) =>
        _v1OrganizationsServicesClickhouseSettingsSettingName400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickhouseSettingsSettingName500Error1(out V1OrganizationsServicesClickhouseSettingsSettingName500Error1 value) =>
        _v1OrganizationsServicesClickhouseSettingsSettingName500Error1Value.TryGetValue(out value);

    internal static Task<ServiceClickhouseSettingDeleteError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickhouseSettingsSettingName400Error1>(response, ct).As(AsV1OrganizationsServicesClickhouseSettingsSettingName400Error1),
            500 => FromJson<V1OrganizationsServicesClickhouseSettingsSettingName500Error1>(response, ct).As(AsV1OrganizationsServicesClickhouseSettingsSettingName500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ServiceClickhouseSettingDeleteErrorResponse : IErrorResponse<ServiceClickhouseSettingDeleteError>
{
    public static ServiceClickhouseSettingDeleteErrorResponse Instance { get; } = new();

    private ServiceClickhouseSettingDeleteErrorResponse()
    {
    }

    public Task<ServiceClickhouseSettingDeleteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ServiceClickhouseSettingDeleteError.Create(response, ct);
}
