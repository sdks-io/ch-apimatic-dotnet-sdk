using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ActivityGetListError : ApiError
{
    private readonly Optional<V1OrganizationsActivities400Error1> _v1OrganizationsActivities400Error1Value;

    private readonly Optional<V1OrganizationsActivities500Error1> _v1OrganizationsActivities500Error1Value;

    private ActivityGetListError(Optional<V1OrganizationsActivities400Error1> v1OrganizationsActivities400Error1Value,
        Optional<V1OrganizationsActivities500Error1> v1OrganizationsActivities500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsActivities400Error1Value = v1OrganizationsActivities400Error1Value;
        _v1OrganizationsActivities500Error1Value = v1OrganizationsActivities500Error1Value;
    }

    private static ActivityGetListError AsV1OrganizationsActivities400Error1(V1OrganizationsActivities400Error1 value) =>
        new(Optional<V1OrganizationsActivities400Error1>.Some(value), default, default);

    private static ActivityGetListError AsV1OrganizationsActivities500Error1(V1OrganizationsActivities500Error1 value) =>
        new(default, Optional<V1OrganizationsActivities500Error1>.Some(value), default);

    private static ActivityGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsActivities400Error1(out V1OrganizationsActivities400Error1 value) =>
        _v1OrganizationsActivities400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsActivities500Error1(out V1OrganizationsActivities500Error1 value) =>
        _v1OrganizationsActivities500Error1Value.TryGetValue(out value);

    internal static Task<ActivityGetListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsActivities400Error1>(response, ct).As(AsV1OrganizationsActivities400Error1),
            500 => FromJson<V1OrganizationsActivities500Error1>(response, ct).As(AsV1OrganizationsActivities500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ActivityGetListErrorResponse : IErrorResponse<ActivityGetListError>
{
    public static ActivityGetListErrorResponse Instance { get; } = new();

    private ActivityGetListErrorResponse()
    {
    }

    public Task<ActivityGetListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ActivityGetListError.Create(response, ct);
}
