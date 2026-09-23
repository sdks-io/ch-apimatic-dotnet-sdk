using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ServiceClickhouseSettingsUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickhouseSettings400Error1> _v1OrganizationsServicesClickhouseSettings400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickhouseSettings500Error1> _v1OrganizationsServicesClickhouseSettings500Error1Value;

    private ServiceClickhouseSettingsUpdateError(Optional<V1OrganizationsServicesClickhouseSettings400Error1> v1OrganizationsServicesClickhouseSettings400Error1Value,
        Optional<V1OrganizationsServicesClickhouseSettings500Error1> v1OrganizationsServicesClickhouseSettings500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickhouseSettings400Error1Value = v1OrganizationsServicesClickhouseSettings400Error1Value;
        _v1OrganizationsServicesClickhouseSettings500Error1Value = v1OrganizationsServicesClickhouseSettings500Error1Value;
    }

    private static ServiceClickhouseSettingsUpdateError AsV1OrganizationsServicesClickhouseSettings400Error1(V1OrganizationsServicesClickhouseSettings400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickhouseSettings400Error1>.Some(value), default, default);

    private static ServiceClickhouseSettingsUpdateError AsV1OrganizationsServicesClickhouseSettings500Error1(V1OrganizationsServicesClickhouseSettings500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickhouseSettings500Error1>.Some(value), default);

    private static ServiceClickhouseSettingsUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickhouseSettings400Error1(out V1OrganizationsServicesClickhouseSettings400Error1 value) =>
        _v1OrganizationsServicesClickhouseSettings400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickhouseSettings500Error1(out V1OrganizationsServicesClickhouseSettings500Error1 value) =>
        _v1OrganizationsServicesClickhouseSettings500Error1Value.TryGetValue(out value);

    internal static Task<ServiceClickhouseSettingsUpdateError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickhouseSettings400Error1>(response, ct).As(AsV1OrganizationsServicesClickhouseSettings400Error1),
            500 => FromJson<V1OrganizationsServicesClickhouseSettings500Error1>(response, ct).As(AsV1OrganizationsServicesClickhouseSettings500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ServiceClickhouseSettingsUpdateErrorResponse : IErrorResponse<ServiceClickhouseSettingsUpdateError>
{
    public static ServiceClickhouseSettingsUpdateErrorResponse Instance { get; } = new();

    private ServiceClickhouseSettingsUpdateErrorResponse()
    {
    }

    public Task<ServiceClickhouseSettingsUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ServiceClickhouseSettingsUpdateError.Create(response, ct);
}
