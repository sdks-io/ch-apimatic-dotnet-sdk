using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class QueryApiEndpointDeleteError : ApiError
{
    private readonly Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1> _v1OrganizationsServicesQueryApiEndpointsEndpointId400Error1Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1> _v1OrganizationsServicesQueryApiEndpointsEndpointId403Error1Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1> _v1OrganizationsServicesQueryApiEndpointsEndpointId404Error1Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1> _v1OrganizationsServicesQueryApiEndpointsEndpointId409Error1Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1> _v1OrganizationsServicesQueryApiEndpointsEndpointId500Error1Value;

    private QueryApiEndpointDeleteError(Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1> v1OrganizationsServicesQueryApiEndpointsEndpointId400Error1Value,
        Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1> v1OrganizationsServicesQueryApiEndpointsEndpointId403Error1Value,
        Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1> v1OrganizationsServicesQueryApiEndpointsEndpointId404Error1Value,
        Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1> v1OrganizationsServicesQueryApiEndpointsEndpointId409Error1Value,
        Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1> v1OrganizationsServicesQueryApiEndpointsEndpointId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesQueryApiEndpointsEndpointId400Error1Value =
            v1OrganizationsServicesQueryApiEndpointsEndpointId400Error1Value;
        _v1OrganizationsServicesQueryApiEndpointsEndpointId403Error1Value =
            v1OrganizationsServicesQueryApiEndpointsEndpointId403Error1Value;
        _v1OrganizationsServicesQueryApiEndpointsEndpointId404Error1Value =
            v1OrganizationsServicesQueryApiEndpointsEndpointId404Error1Value;
        _v1OrganizationsServicesQueryApiEndpointsEndpointId409Error1Value =
            v1OrganizationsServicesQueryApiEndpointsEndpointId409Error1Value;
        _v1OrganizationsServicesQueryApiEndpointsEndpointId500Error1Value =
            v1OrganizationsServicesQueryApiEndpointsEndpointId500Error1Value;
    }

    private static QueryApiEndpointDeleteError AsV1OrganizationsServicesQueryApiEndpointsEndpointId400Error1(V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1 value) =>
        new(Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static QueryApiEndpointDeleteError AsV1OrganizationsServicesQueryApiEndpointsEndpointId403Error1(V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1 value) =>
        new(default,
            Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static QueryApiEndpointDeleteError AsV1OrganizationsServicesQueryApiEndpointsEndpointId404Error1(V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1 value) =>
        new(default,
            default,
            Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1>.Some(value),
            default,
            default,
            default);

    private static QueryApiEndpointDeleteError AsV1OrganizationsServicesQueryApiEndpointsEndpointId409Error1(V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1 value) =>
        new(default,
            default,
            default,
            Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1>.Some(value),
            default,
            default);

    private static QueryApiEndpointDeleteError AsV1OrganizationsServicesQueryApiEndpointsEndpointId500Error1(V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1>.Some(value),
            default);

    private static QueryApiEndpointDeleteError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId400Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpointsEndpointId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId403Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpointsEndpointId403Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId404Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpointsEndpointId404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId409Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpointsEndpointId409Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId500Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpointsEndpointId500Error1Value.TryGetValue(out value);

    internal static Task<QueryApiEndpointDeleteError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesQueryApiEndpointsEndpointId400Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpointsEndpointId400Error1),
            403 => FromJson<V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpointsEndpointId403Error1),
            404 => FromJson<V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpointsEndpointId404Error1),
            409 => FromJson<V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpointsEndpointId409Error1),
            500 => FromJson<V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpointsEndpointId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryApiEndpointDeleteErrorResponse : IErrorResponse<QueryApiEndpointDeleteError>
{
    public static QueryApiEndpointDeleteErrorResponse Instance { get; } = new();

    private QueryApiEndpointDeleteErrorResponse()
    {
    }

    public Task<QueryApiEndpointDeleteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryApiEndpointDeleteError.Create(response, ct);
}
