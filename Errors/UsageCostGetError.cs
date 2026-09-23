using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UsageCostGetError : ApiError
{
    private readonly Optional<V1OrganizationsUsageCost400Error1> _v1OrganizationsUsageCost400Error1Value;

    private readonly Optional<V1OrganizationsUsageCost500Error1> _v1OrganizationsUsageCost500Error1Value;

    private UsageCostGetError(Optional<V1OrganizationsUsageCost400Error1> v1OrganizationsUsageCost400Error1Value,
        Optional<V1OrganizationsUsageCost500Error1> v1OrganizationsUsageCost500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUsageCost400Error1Value = v1OrganizationsUsageCost400Error1Value;
        _v1OrganizationsUsageCost500Error1Value = v1OrganizationsUsageCost500Error1Value;
    }

    private static UsageCostGetError AsV1OrganizationsUsageCost400Error1(V1OrganizationsUsageCost400Error1 value) =>
        new(Optional<V1OrganizationsUsageCost400Error1>.Some(value), default, default);

    private static UsageCostGetError AsV1OrganizationsUsageCost500Error1(V1OrganizationsUsageCost500Error1 value) =>
        new(default, Optional<V1OrganizationsUsageCost500Error1>.Some(value), default);

    private static UsageCostGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUsageCost400Error1(out V1OrganizationsUsageCost400Error1 value) =>
        _v1OrganizationsUsageCost400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUsageCost500Error1(out V1OrganizationsUsageCost500Error1 value) =>
        _v1OrganizationsUsageCost500Error1Value.TryGetValue(out value);

    internal static Task<UsageCostGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUsageCost400Error1>(response, ct).As(AsV1OrganizationsUsageCost400Error1),
            500 => FromJson<V1OrganizationsUsageCost500Error1>(response, ct).As(AsV1OrganizationsUsageCost500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UsageCostGetErrorResponse : IErrorResponse<UsageCostGetError>
{
    public static UsageCostGetErrorResponse Instance { get; } = new();

    private UsageCostGetErrorResponse()
    {
    }

    public Task<UsageCostGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UsageCostGetError.Create(response, ct);
}
