using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class SnapshotConfigurationGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesSnapshotConfiguration400Error1> _v1OrganizationsServicesSnapshotConfiguration400Error1Value;

    private readonly Optional<V1OrganizationsServicesSnapshotConfiguration500Error1> _v1OrganizationsServicesSnapshotConfiguration500Error1Value;

    private SnapshotConfigurationGetError(Optional<V1OrganizationsServicesSnapshotConfiguration400Error1> v1OrganizationsServicesSnapshotConfiguration400Error1Value,
        Optional<V1OrganizationsServicesSnapshotConfiguration500Error1> v1OrganizationsServicesSnapshotConfiguration500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesSnapshotConfiguration400Error1Value =
            v1OrganizationsServicesSnapshotConfiguration400Error1Value;
        _v1OrganizationsServicesSnapshotConfiguration500Error1Value =
            v1OrganizationsServicesSnapshotConfiguration500Error1Value;
    }

    private static SnapshotConfigurationGetError AsV1OrganizationsServicesSnapshotConfiguration400Error1(V1OrganizationsServicesSnapshotConfiguration400Error1 value) =>
        new(Optional<V1OrganizationsServicesSnapshotConfiguration400Error1>.Some(value), default, default);

    private static SnapshotConfigurationGetError AsV1OrganizationsServicesSnapshotConfiguration500Error1(V1OrganizationsServicesSnapshotConfiguration500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesSnapshotConfiguration500Error1>.Some(value), default);

    private static SnapshotConfigurationGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesSnapshotConfiguration400Error1(out V1OrganizationsServicesSnapshotConfiguration400Error1 value) =>
        _v1OrganizationsServicesSnapshotConfiguration400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesSnapshotConfiguration500Error1(out V1OrganizationsServicesSnapshotConfiguration500Error1 value) =>
        _v1OrganizationsServicesSnapshotConfiguration500Error1Value.TryGetValue(out value);

    internal static Task<SnapshotConfigurationGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesSnapshotConfiguration400Error1>(response, ct).As(AsV1OrganizationsServicesSnapshotConfiguration400Error1),
            500 => FromJson<V1OrganizationsServicesSnapshotConfiguration500Error1>(response, ct).As(AsV1OrganizationsServicesSnapshotConfiguration500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SnapshotConfigurationGetErrorResponse : IErrorResponse<SnapshotConfigurationGetError>
{
    public static SnapshotConfigurationGetErrorResponse Instance { get; } = new();

    private SnapshotConfigurationGetErrorResponse()
    {
    }

    public Task<SnapshotConfigurationGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SnapshotConfigurationGetError.Create(response, ct);
}
