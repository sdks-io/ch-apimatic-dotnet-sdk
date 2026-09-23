using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class QueryApiEndpointUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId400Error31> _v1OrganizationsServicesQueryApiEndpointsEndpointId400Error31Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1> _v1OrganizationsServicesQueryApiEndpointsEndpointId403Error1Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1> _v1OrganizationsServicesQueryApiEndpointsEndpointId404Error1Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1> _v1OrganizationsServicesQueryApiEndpointsEndpointId409Error1Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1> _v1OrganizationsServicesQueryApiEndpointsEndpointId500Error1Value;

    private QueryApiEndpointUpdateError(Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId400Error31> v1OrganizationsServicesQueryApiEndpointsEndpointId400Error31Value,
        Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1> v1OrganizationsServicesQueryApiEndpointsEndpointId403Error1Value,
        Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1> v1OrganizationsServicesQueryApiEndpointsEndpointId404Error1Value,
        Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1> v1OrganizationsServicesQueryApiEndpointsEndpointId409Error1Value,
        Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1> v1OrganizationsServicesQueryApiEndpointsEndpointId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesQueryApiEndpointsEndpointId400Error31Value =
            v1OrganizationsServicesQueryApiEndpointsEndpointId400Error31Value;
        _v1OrganizationsServicesQueryApiEndpointsEndpointId403Error1Value =
            v1OrganizationsServicesQueryApiEndpointsEndpointId403Error1Value;
        _v1OrganizationsServicesQueryApiEndpointsEndpointId404Error1Value =
            v1OrganizationsServicesQueryApiEndpointsEndpointId404Error1Value;
        _v1OrganizationsServicesQueryApiEndpointsEndpointId409Error1Value =
            v1OrganizationsServicesQueryApiEndpointsEndpointId409Error1Value;
        _v1OrganizationsServicesQueryApiEndpointsEndpointId500Error1Value =
            v1OrganizationsServicesQueryApiEndpointsEndpointId500Error1Value;
    }

    private static QueryApiEndpointUpdateError AsV1OrganizationsServicesQueryApiEndpointsEndpointId400Error31(V1OrganizationsServicesQueryApiEndpointsEndpointId400Error31 value) =>
        new(Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId400Error31>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static QueryApiEndpointUpdateError AsV1OrganizationsServicesQueryApiEndpointsEndpointId403Error1(V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1 value) =>
        new(default,
            Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static QueryApiEndpointUpdateError AsV1OrganizationsServicesQueryApiEndpointsEndpointId404Error1(V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1 value) =>
        new(default,
            default,
            Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1>.Some(value),
            default,
            default,
            default);

    private static QueryApiEndpointUpdateError AsV1OrganizationsServicesQueryApiEndpointsEndpointId409Error1(V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1 value) =>
        new(default,
            default,
            default,
            Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1>.Some(value),
            default,
            default);

    private static QueryApiEndpointUpdateError AsV1OrganizationsServicesQueryApiEndpointsEndpointId500Error1(V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1>.Some(value),
            default);

    private static QueryApiEndpointUpdateError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId400Error31(out V1OrganizationsServicesQueryApiEndpointsEndpointId400Error31 value) =>
        _v1OrganizationsServicesQueryApiEndpointsEndpointId400Error31Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId403Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpointsEndpointId403Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId404Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpointsEndpointId404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId409Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpointsEndpointId409Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpointsEndpointId500Error1(out V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpointsEndpointId500Error1Value.TryGetValue(out value);

    internal static Task<QueryApiEndpointUpdateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesQueryApiEndpointsEndpointId400Error31>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpointsEndpointId400Error31),
            403 => FromJson<V1OrganizationsServicesQueryApiEndpointsEndpointId403Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpointsEndpointId403Error1),
            404 => FromJson<V1OrganizationsServicesQueryApiEndpointsEndpointId404Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpointsEndpointId404Error1),
            409 => FromJson<V1OrganizationsServicesQueryApiEndpointsEndpointId409Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpointsEndpointId409Error1),
            500 => FromJson<V1OrganizationsServicesQueryApiEndpointsEndpointId500Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpointsEndpointId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryApiEndpointUpdateErrorResponse : IErrorResponse<QueryApiEndpointUpdateError>
{
    public static QueryApiEndpointUpdateErrorResponse Instance { get; } = new();

    private QueryApiEndpointUpdateErrorResponse()
    {
    }

    public Task<QueryApiEndpointUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryApiEndpointUpdateError.Create(response, ct);
}
