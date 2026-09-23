using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class BackupGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesBackupsBackupId400Error1> _v1OrganizationsServicesBackupsBackupId400Error1Value;

    private readonly Optional<V1OrganizationsServicesBackupsBackupId500Error1> _v1OrganizationsServicesBackupsBackupId500Error1Value;

    private BackupGetError(Optional<V1OrganizationsServicesBackupsBackupId400Error1> v1OrganizationsServicesBackupsBackupId400Error1Value,
        Optional<V1OrganizationsServicesBackupsBackupId500Error1> v1OrganizationsServicesBackupsBackupId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesBackupsBackupId400Error1Value = v1OrganizationsServicesBackupsBackupId400Error1Value;
        _v1OrganizationsServicesBackupsBackupId500Error1Value = v1OrganizationsServicesBackupsBackupId500Error1Value;
    }

    private static BackupGetError AsV1OrganizationsServicesBackupsBackupId400Error1(V1OrganizationsServicesBackupsBackupId400Error1 value) =>
        new(Optional<V1OrganizationsServicesBackupsBackupId400Error1>.Some(value), default, default);

    private static BackupGetError AsV1OrganizationsServicesBackupsBackupId500Error1(V1OrganizationsServicesBackupsBackupId500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesBackupsBackupId500Error1>.Some(value), default);

    private static BackupGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesBackupsBackupId400Error1(out V1OrganizationsServicesBackupsBackupId400Error1 value) =>
        _v1OrganizationsServicesBackupsBackupId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesBackupsBackupId500Error1(out V1OrganizationsServicesBackupsBackupId500Error1 value) =>
        _v1OrganizationsServicesBackupsBackupId500Error1Value.TryGetValue(out value);

    internal static Task<BackupGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesBackupsBackupId400Error1>(response, ct).As(AsV1OrganizationsServicesBackupsBackupId400Error1),
            500 => FromJson<V1OrganizationsServicesBackupsBackupId500Error1>(response, ct).As(AsV1OrganizationsServicesBackupsBackupId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BackupGetErrorResponse : IErrorResponse<BackupGetError>
{
    public static BackupGetErrorResponse Instance { get; } = new();

    private BackupGetErrorResponse()
    {
    }

    public Task<BackupGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BackupGetError.Create(response, ct);
}
