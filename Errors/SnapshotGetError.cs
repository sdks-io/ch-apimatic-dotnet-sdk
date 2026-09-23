using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class SnapshotGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesSnapshotsSnapshotId400Error1> _v1OrganizationsServicesSnapshotsSnapshotId400Error1Value;

    private readonly Optional<V1OrganizationsServicesSnapshotsSnapshotId500Error1> _v1OrganizationsServicesSnapshotsSnapshotId500Error1Value;

    private SnapshotGetError(Optional<V1OrganizationsServicesSnapshotsSnapshotId400Error1> v1OrganizationsServicesSnapshotsSnapshotId400Error1Value,
        Optional<V1OrganizationsServicesSnapshotsSnapshotId500Error1> v1OrganizationsServicesSnapshotsSnapshotId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesSnapshotsSnapshotId400Error1Value = v1OrganizationsServicesSnapshotsSnapshotId400Error1Value;
        _v1OrganizationsServicesSnapshotsSnapshotId500Error1Value = v1OrganizationsServicesSnapshotsSnapshotId500Error1Value;
    }

    private static SnapshotGetError AsV1OrganizationsServicesSnapshotsSnapshotId400Error1(V1OrganizationsServicesSnapshotsSnapshotId400Error1 value) =>
        new(Optional<V1OrganizationsServicesSnapshotsSnapshotId400Error1>.Some(value), default, default);

    private static SnapshotGetError AsV1OrganizationsServicesSnapshotsSnapshotId500Error1(V1OrganizationsServicesSnapshotsSnapshotId500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesSnapshotsSnapshotId500Error1>.Some(value), default);

    private static SnapshotGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesSnapshotsSnapshotId400Error1(out V1OrganizationsServicesSnapshotsSnapshotId400Error1 value) =>
        _v1OrganizationsServicesSnapshotsSnapshotId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesSnapshotsSnapshotId500Error1(out V1OrganizationsServicesSnapshotsSnapshotId500Error1 value) =>
        _v1OrganizationsServicesSnapshotsSnapshotId500Error1Value.TryGetValue(out value);

    internal static Task<SnapshotGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesSnapshotsSnapshotId400Error1>(response, ct).As(AsV1OrganizationsServicesSnapshotsSnapshotId400Error1),
            500 => FromJson<V1OrganizationsServicesSnapshotsSnapshotId500Error1>(response, ct).As(AsV1OrganizationsServicesSnapshotsSnapshotId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SnapshotGetErrorResponse : IErrorResponse<SnapshotGetError>
{
    public static SnapshotGetErrorResponse Instance { get; } = new();

    private SnapshotGetErrorResponse()
    {
    }

    public Task<SnapshotGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SnapshotGetError.Create(response, ct);
}
