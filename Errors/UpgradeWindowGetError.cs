using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UpgradeWindowGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesUpgradeWindow400Error1> _v1OrganizationsServicesUpgradeWindow400Error1Value;

    private readonly Optional<V1OrganizationsServicesUpgradeWindow500Error1> _v1OrganizationsServicesUpgradeWindow500Error1Value;

    private UpgradeWindowGetError(Optional<V1OrganizationsServicesUpgradeWindow400Error1> v1OrganizationsServicesUpgradeWindow400Error1Value,
        Optional<V1OrganizationsServicesUpgradeWindow500Error1> v1OrganizationsServicesUpgradeWindow500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesUpgradeWindow400Error1Value = v1OrganizationsServicesUpgradeWindow400Error1Value;
        _v1OrganizationsServicesUpgradeWindow500Error1Value = v1OrganizationsServicesUpgradeWindow500Error1Value;
    }

    private static UpgradeWindowGetError AsV1OrganizationsServicesUpgradeWindow400Error1(V1OrganizationsServicesUpgradeWindow400Error1 value) =>
        new(Optional<V1OrganizationsServicesUpgradeWindow400Error1>.Some(value), default, default);

    private static UpgradeWindowGetError AsV1OrganizationsServicesUpgradeWindow500Error1(V1OrganizationsServicesUpgradeWindow500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesUpgradeWindow500Error1>.Some(value), default);

    private static UpgradeWindowGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesUpgradeWindow400Error1(out V1OrganizationsServicesUpgradeWindow400Error1 value) =>
        _v1OrganizationsServicesUpgradeWindow400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesUpgradeWindow500Error1(out V1OrganizationsServicesUpgradeWindow500Error1 value) =>
        _v1OrganizationsServicesUpgradeWindow500Error1Value.TryGetValue(out value);

    internal static Task<UpgradeWindowGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesUpgradeWindow400Error1>(response, ct).As(AsV1OrganizationsServicesUpgradeWindow400Error1),
            500 => FromJson<V1OrganizationsServicesUpgradeWindow500Error1>(response, ct).As(AsV1OrganizationsServicesUpgradeWindow500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpgradeWindowGetErrorResponse : IErrorResponse<UpgradeWindowGetError>
{
    public static UpgradeWindowGetErrorResponse Instance { get; } = new();

    private UpgradeWindowGetErrorResponse()
    {
    }

    public Task<UpgradeWindowGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpgradeWindowGetError.Create(response, ct);
}
