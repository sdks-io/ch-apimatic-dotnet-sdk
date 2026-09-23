using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class BackupConfigurationGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesBackupConfiguration400Error1> _v1OrganizationsServicesBackupConfiguration400Error1Value;

    private readonly Optional<V1OrganizationsServicesBackupConfiguration500Error1> _v1OrganizationsServicesBackupConfiguration500Error1Value;

    private BackupConfigurationGetError(Optional<V1OrganizationsServicesBackupConfiguration400Error1> v1OrganizationsServicesBackupConfiguration400Error1Value,
        Optional<V1OrganizationsServicesBackupConfiguration500Error1> v1OrganizationsServicesBackupConfiguration500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesBackupConfiguration400Error1Value = v1OrganizationsServicesBackupConfiguration400Error1Value;
        _v1OrganizationsServicesBackupConfiguration500Error1Value = v1OrganizationsServicesBackupConfiguration500Error1Value;
    }

    private static BackupConfigurationGetError AsV1OrganizationsServicesBackupConfiguration400Error1(V1OrganizationsServicesBackupConfiguration400Error1 value) =>
        new(Optional<V1OrganizationsServicesBackupConfiguration400Error1>.Some(value), default, default);

    private static BackupConfigurationGetError AsV1OrganizationsServicesBackupConfiguration500Error1(V1OrganizationsServicesBackupConfiguration500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesBackupConfiguration500Error1>.Some(value), default);

    private static BackupConfigurationGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesBackupConfiguration400Error1(out V1OrganizationsServicesBackupConfiguration400Error1 value) =>
        _v1OrganizationsServicesBackupConfiguration400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesBackupConfiguration500Error1(out V1OrganizationsServicesBackupConfiguration500Error1 value) =>
        _v1OrganizationsServicesBackupConfiguration500Error1Value.TryGetValue(out value);

    internal static Task<BackupConfigurationGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesBackupConfiguration400Error1>(response, ct).As(AsV1OrganizationsServicesBackupConfiguration400Error1),
            500 => FromJson<V1OrganizationsServicesBackupConfiguration500Error1>(response, ct).As(AsV1OrganizationsServicesBackupConfiguration500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BackupConfigurationGetErrorResponse : IErrorResponse<BackupConfigurationGetError>
{
    public static BackupConfigurationGetErrorResponse Instance { get; } = new();

    private BackupConfigurationGetErrorResponse()
    {
    }

    public Task<BackupConfigurationGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BackupConfigurationGetError.Create(response, ct);
}
