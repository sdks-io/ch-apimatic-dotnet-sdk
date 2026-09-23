using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class BackupGetListError : ApiError
{
    private readonly Optional<V1OrganizationsServicesBackups400Error1> _v1OrganizationsServicesBackups400Error1Value;

    private readonly Optional<V1OrganizationsServicesBackups500Error1> _v1OrganizationsServicesBackups500Error1Value;

    private BackupGetListError(Optional<V1OrganizationsServicesBackups400Error1> v1OrganizationsServicesBackups400Error1Value,
        Optional<V1OrganizationsServicesBackups500Error1> v1OrganizationsServicesBackups500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesBackups400Error1Value = v1OrganizationsServicesBackups400Error1Value;
        _v1OrganizationsServicesBackups500Error1Value = v1OrganizationsServicesBackups500Error1Value;
    }

    private static BackupGetListError AsV1OrganizationsServicesBackups400Error1(V1OrganizationsServicesBackups400Error1 value) =>
        new(Optional<V1OrganizationsServicesBackups400Error1>.Some(value), default, default);

    private static BackupGetListError AsV1OrganizationsServicesBackups500Error1(V1OrganizationsServicesBackups500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesBackups500Error1>.Some(value), default);

    private static BackupGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesBackups400Error1(out V1OrganizationsServicesBackups400Error1 value) =>
        _v1OrganizationsServicesBackups400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesBackups500Error1(out V1OrganizationsServicesBackups500Error1 value) =>
        _v1OrganizationsServicesBackups500Error1Value.TryGetValue(out value);

    internal static Task<BackupGetListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesBackups400Error1>(response, ct).As(AsV1OrganizationsServicesBackups400Error1),
            500 => FromJson<V1OrganizationsServicesBackups500Error1>(response, ct).As(AsV1OrganizationsServicesBackups500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BackupGetListErrorResponse : IErrorResponse<BackupGetListError>
{
    public static BackupGetListErrorResponse Instance { get; } = new();

    private BackupGetListErrorResponse()
    {
    }

    public Task<BackupGetListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BackupGetListError.Create(response, ct);
}
