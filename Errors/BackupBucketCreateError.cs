using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class BackupBucketCreateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesBackupBucket400Error1> _v1OrganizationsServicesBackupBucket400Error1Value;

    private readonly Optional<V1OrganizationsServicesBackupBucket500Error1> _v1OrganizationsServicesBackupBucket500Error1Value;

    private BackupBucketCreateError(Optional<V1OrganizationsServicesBackupBucket400Error1> v1OrganizationsServicesBackupBucket400Error1Value,
        Optional<V1OrganizationsServicesBackupBucket500Error1> v1OrganizationsServicesBackupBucket500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesBackupBucket400Error1Value = v1OrganizationsServicesBackupBucket400Error1Value;
        _v1OrganizationsServicesBackupBucket500Error1Value = v1OrganizationsServicesBackupBucket500Error1Value;
    }

    private static BackupBucketCreateError AsV1OrganizationsServicesBackupBucket400Error1(V1OrganizationsServicesBackupBucket400Error1 value) =>
        new(Optional<V1OrganizationsServicesBackupBucket400Error1>.Some(value), default, default);

    private static BackupBucketCreateError AsV1OrganizationsServicesBackupBucket500Error1(V1OrganizationsServicesBackupBucket500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesBackupBucket500Error1>.Some(value), default);

    private static BackupBucketCreateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesBackupBucket400Error1(out V1OrganizationsServicesBackupBucket400Error1 value) =>
        _v1OrganizationsServicesBackupBucket400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesBackupBucket500Error1(out V1OrganizationsServicesBackupBucket500Error1 value) =>
        _v1OrganizationsServicesBackupBucket500Error1Value.TryGetValue(out value);

    internal static Task<BackupBucketCreateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesBackupBucket400Error1>(response, ct).As(AsV1OrganizationsServicesBackupBucket400Error1),
            500 => FromJson<V1OrganizationsServicesBackupBucket500Error1>(response, ct).As(AsV1OrganizationsServicesBackupBucket500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class BackupBucketCreateErrorResponse : IErrorResponse<BackupBucketCreateError>
{
    public static BackupBucketCreateErrorResponse Instance { get; } = new();

    private BackupBucketCreateErrorResponse()
    {
    }

    public Task<BackupBucketCreateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        BackupBucketCreateError.Create(response, ct);
}
