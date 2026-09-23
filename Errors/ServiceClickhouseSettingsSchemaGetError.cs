using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ServiceClickhouseSettingsSchemaGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickhouseSettingsSchema400Error1> _v1OrganizationsServicesClickhouseSettingsSchema400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickhouseSettingsSchema500Error1> _v1OrganizationsServicesClickhouseSettingsSchema500Error1Value;

    private ServiceClickhouseSettingsSchemaGetError(Optional<V1OrganizationsServicesClickhouseSettingsSchema400Error1> v1OrganizationsServicesClickhouseSettingsSchema400Error1Value,
        Optional<V1OrganizationsServicesClickhouseSettingsSchema500Error1> v1OrganizationsServicesClickhouseSettingsSchema500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickhouseSettingsSchema400Error1Value =
            v1OrganizationsServicesClickhouseSettingsSchema400Error1Value;
        _v1OrganizationsServicesClickhouseSettingsSchema500Error1Value =
            v1OrganizationsServicesClickhouseSettingsSchema500Error1Value;
    }

    private static ServiceClickhouseSettingsSchemaGetError AsV1OrganizationsServicesClickhouseSettingsSchema400Error1(V1OrganizationsServicesClickhouseSettingsSchema400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickhouseSettingsSchema400Error1>.Some(value), default, default);

    private static ServiceClickhouseSettingsSchemaGetError AsV1OrganizationsServicesClickhouseSettingsSchema500Error1(V1OrganizationsServicesClickhouseSettingsSchema500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickhouseSettingsSchema500Error1>.Some(value), default);

    private static ServiceClickhouseSettingsSchemaGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickhouseSettingsSchema400Error1(out V1OrganizationsServicesClickhouseSettingsSchema400Error1 value) =>
        _v1OrganizationsServicesClickhouseSettingsSchema400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickhouseSettingsSchema500Error1(out V1OrganizationsServicesClickhouseSettingsSchema500Error1 value) =>
        _v1OrganizationsServicesClickhouseSettingsSchema500Error1Value.TryGetValue(out value);

    internal static Task<ServiceClickhouseSettingsSchemaGetError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickhouseSettingsSchema400Error1>(response, ct).As(AsV1OrganizationsServicesClickhouseSettingsSchema400Error1),
            500 => FromJson<V1OrganizationsServicesClickhouseSettingsSchema500Error1>(response, ct).As(AsV1OrganizationsServicesClickhouseSettingsSchema500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ServiceClickhouseSettingsSchemaGetErrorResponse : IErrorResponse<ServiceClickhouseSettingsSchemaGetError>
{
    public static ServiceClickhouseSettingsSchemaGetErrorResponse Instance { get; } = new();

    private ServiceClickhouseSettingsSchemaGetErrorResponse()
    {
    }

    public Task<ServiceClickhouseSettingsSchemaGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ServiceClickhouseSettingsSchemaGetError.Create(response, ct);
}
