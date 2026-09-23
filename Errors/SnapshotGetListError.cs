using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class SnapshotGetListError : ApiError
{
    private readonly Optional<V1OrganizationsServicesSnapshots400Error1> _v1OrganizationsServicesSnapshots400Error1Value;

    private readonly Optional<V1OrganizationsServicesSnapshots500Error1> _v1OrganizationsServicesSnapshots500Error1Value;

    private SnapshotGetListError(Optional<V1OrganizationsServicesSnapshots400Error1> v1OrganizationsServicesSnapshots400Error1Value,
        Optional<V1OrganizationsServicesSnapshots500Error1> v1OrganizationsServicesSnapshots500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesSnapshots400Error1Value = v1OrganizationsServicesSnapshots400Error1Value;
        _v1OrganizationsServicesSnapshots500Error1Value = v1OrganizationsServicesSnapshots500Error1Value;
    }

    private static SnapshotGetListError AsV1OrganizationsServicesSnapshots400Error1(V1OrganizationsServicesSnapshots400Error1 value) =>
        new(Optional<V1OrganizationsServicesSnapshots400Error1>.Some(value), default, default);

    private static SnapshotGetListError AsV1OrganizationsServicesSnapshots500Error1(V1OrganizationsServicesSnapshots500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesSnapshots500Error1>.Some(value), default);

    private static SnapshotGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesSnapshots400Error1(out V1OrganizationsServicesSnapshots400Error1 value) =>
        _v1OrganizationsServicesSnapshots400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesSnapshots500Error1(out V1OrganizationsServicesSnapshots500Error1 value) =>
        _v1OrganizationsServicesSnapshots500Error1Value.TryGetValue(out value);

    internal static Task<SnapshotGetListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesSnapshots400Error1>(response, ct).As(AsV1OrganizationsServicesSnapshots400Error1),
            500 => FromJson<V1OrganizationsServicesSnapshots500Error1>(response, ct).As(AsV1OrganizationsServicesSnapshots500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SnapshotGetListErrorResponse : IErrorResponse<SnapshotGetListError>
{
    public static SnapshotGetListErrorResponse Instance { get; } = new();

    private SnapshotGetListErrorResponse()
    {
    }

    public Task<SnapshotGetListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SnapshotGetListError.Create(response, ct);
}
