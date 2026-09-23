using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ServiceClickhouseSettingsListGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickhouseSettings400Error1> _v1OrganizationsServicesClickhouseSettings400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickhouseSettings500Error1> _v1OrganizationsServicesClickhouseSettings500Error1Value;

    private ServiceClickhouseSettingsListGetError(Optional<V1OrganizationsServicesClickhouseSettings400Error1> v1OrganizationsServicesClickhouseSettings400Error1Value,
        Optional<V1OrganizationsServicesClickhouseSettings500Error1> v1OrganizationsServicesClickhouseSettings500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickhouseSettings400Error1Value = v1OrganizationsServicesClickhouseSettings400Error1Value;
        _v1OrganizationsServicesClickhouseSettings500Error1Value = v1OrganizationsServicesClickhouseSettings500Error1Value;
    }

    private static ServiceClickhouseSettingsListGetError AsV1OrganizationsServicesClickhouseSettings400Error1(V1OrganizationsServicesClickhouseSettings400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickhouseSettings400Error1>.Some(value), default, default);

    private static ServiceClickhouseSettingsListGetError AsV1OrganizationsServicesClickhouseSettings500Error1(V1OrganizationsServicesClickhouseSettings500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickhouseSettings500Error1>.Some(value), default);

    private static ServiceClickhouseSettingsListGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickhouseSettings400Error1(out V1OrganizationsServicesClickhouseSettings400Error1 value) =>
        _v1OrganizationsServicesClickhouseSettings400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickhouseSettings500Error1(out V1OrganizationsServicesClickhouseSettings500Error1 value) =>
        _v1OrganizationsServicesClickhouseSettings500Error1Value.TryGetValue(out value);

    internal static Task<ServiceClickhouseSettingsListGetError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickhouseSettings400Error1>(response, ct).As(AsV1OrganizationsServicesClickhouseSettings400Error1),
            500 => FromJson<V1OrganizationsServicesClickhouseSettings500Error1>(response, ct).As(AsV1OrganizationsServicesClickhouseSettings500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ServiceClickhouseSettingsListGetErrorResponse : IErrorResponse<ServiceClickhouseSettingsListGetError>
{
    public static ServiceClickhouseSettingsListGetErrorResponse Instance { get; } = new();

    private ServiceClickhouseSettingsListGetErrorResponse()
    {
    }

    public Task<ServiceClickhouseSettingsListGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ServiceClickhouseSettingsListGetError.Create(response, ct);
}
