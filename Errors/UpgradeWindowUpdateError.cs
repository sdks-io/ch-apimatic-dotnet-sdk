using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UpgradeWindowUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesUpgradeWindow400Error1> _v1OrganizationsServicesUpgradeWindow400Error1Value;

    private readonly Optional<V1OrganizationsServicesUpgradeWindow500Error1> _v1OrganizationsServicesUpgradeWindow500Error1Value;

    private UpgradeWindowUpdateError(Optional<V1OrganizationsServicesUpgradeWindow400Error1> v1OrganizationsServicesUpgradeWindow400Error1Value,
        Optional<V1OrganizationsServicesUpgradeWindow500Error1> v1OrganizationsServicesUpgradeWindow500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesUpgradeWindow400Error1Value = v1OrganizationsServicesUpgradeWindow400Error1Value;
        _v1OrganizationsServicesUpgradeWindow500Error1Value = v1OrganizationsServicesUpgradeWindow500Error1Value;
    }

    private static UpgradeWindowUpdateError AsV1OrganizationsServicesUpgradeWindow400Error1(V1OrganizationsServicesUpgradeWindow400Error1 value) =>
        new(Optional<V1OrganizationsServicesUpgradeWindow400Error1>.Some(value), default, default);

    private static UpgradeWindowUpdateError AsV1OrganizationsServicesUpgradeWindow500Error1(V1OrganizationsServicesUpgradeWindow500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesUpgradeWindow500Error1>.Some(value), default);

    private static UpgradeWindowUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesUpgradeWindow400Error1(out V1OrganizationsServicesUpgradeWindow400Error1 value) =>
        _v1OrganizationsServicesUpgradeWindow400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesUpgradeWindow500Error1(out V1OrganizationsServicesUpgradeWindow500Error1 value) =>
        _v1OrganizationsServicesUpgradeWindow500Error1Value.TryGetValue(out value);

    internal static Task<UpgradeWindowUpdateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesUpgradeWindow400Error1>(response, ct).As(AsV1OrganizationsServicesUpgradeWindow400Error1),
            500 => FromJson<V1OrganizationsServicesUpgradeWindow500Error1>(response, ct).As(AsV1OrganizationsServicesUpgradeWindow500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpgradeWindowUpdateErrorResponse : IErrorResponse<UpgradeWindowUpdateError>
{
    public static UpgradeWindowUpdateErrorResponse Instance { get; } = new();

    private UpgradeWindowUpdateErrorResponse()
    {
    }

    public Task<UpgradeWindowUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpgradeWindowUpdateError.Create(response, ct);
}
