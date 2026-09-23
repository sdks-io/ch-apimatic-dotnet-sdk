using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class QueryApiEndpointCreateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesQueryApiEndpoints400Error1> _v1OrganizationsServicesQueryApiEndpoints400Error1Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpoints403Error1> _v1OrganizationsServicesQueryApiEndpoints403Error1Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpoints404Error1> _v1OrganizationsServicesQueryApiEndpoints404Error1Value;

    private readonly Optional<V1OrganizationsServicesQueryApiEndpoints500Error1> _v1OrganizationsServicesQueryApiEndpoints500Error1Value;

    private QueryApiEndpointCreateError(Optional<V1OrganizationsServicesQueryApiEndpoints400Error1> v1OrganizationsServicesQueryApiEndpoints400Error1Value,
        Optional<V1OrganizationsServicesQueryApiEndpoints403Error1> v1OrganizationsServicesQueryApiEndpoints403Error1Value,
        Optional<V1OrganizationsServicesQueryApiEndpoints404Error1> v1OrganizationsServicesQueryApiEndpoints404Error1Value,
        Optional<V1OrganizationsServicesQueryApiEndpoints500Error1> v1OrganizationsServicesQueryApiEndpoints500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesQueryApiEndpoints400Error1Value = v1OrganizationsServicesQueryApiEndpoints400Error1Value;
        _v1OrganizationsServicesQueryApiEndpoints403Error1Value = v1OrganizationsServicesQueryApiEndpoints403Error1Value;
        _v1OrganizationsServicesQueryApiEndpoints404Error1Value = v1OrganizationsServicesQueryApiEndpoints404Error1Value;
        _v1OrganizationsServicesQueryApiEndpoints500Error1Value = v1OrganizationsServicesQueryApiEndpoints500Error1Value;
    }

    private static QueryApiEndpointCreateError AsV1OrganizationsServicesQueryApiEndpoints400Error1(V1OrganizationsServicesQueryApiEndpoints400Error1 value) =>
        new(Optional<V1OrganizationsServicesQueryApiEndpoints400Error1>.Some(value), default, default, default, default);

    private static QueryApiEndpointCreateError AsV1OrganizationsServicesQueryApiEndpoints403Error1(V1OrganizationsServicesQueryApiEndpoints403Error1 value) =>
        new(default, Optional<V1OrganizationsServicesQueryApiEndpoints403Error1>.Some(value), default, default, default);

    private static QueryApiEndpointCreateError AsV1OrganizationsServicesQueryApiEndpoints404Error1(V1OrganizationsServicesQueryApiEndpoints404Error1 value) =>
        new(default, default, Optional<V1OrganizationsServicesQueryApiEndpoints404Error1>.Some(value), default, default);

    private static QueryApiEndpointCreateError AsV1OrganizationsServicesQueryApiEndpoints500Error1(V1OrganizationsServicesQueryApiEndpoints500Error1 value) =>
        new(default, default, default, Optional<V1OrganizationsServicesQueryApiEndpoints500Error1>.Some(value), default);

    private static QueryApiEndpointCreateError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesQueryApiEndpoints400Error1(out V1OrganizationsServicesQueryApiEndpoints400Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpoints400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpoints403Error1(out V1OrganizationsServicesQueryApiEndpoints403Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpoints403Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpoints404Error1(out V1OrganizationsServicesQueryApiEndpoints404Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpoints404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesQueryApiEndpoints500Error1(out V1OrganizationsServicesQueryApiEndpoints500Error1 value) =>
        _v1OrganizationsServicesQueryApiEndpoints500Error1Value.TryGetValue(out value);

    internal static Task<QueryApiEndpointCreateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesQueryApiEndpoints400Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpoints400Error1),
            403 => FromJson<V1OrganizationsServicesQueryApiEndpoints403Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpoints403Error1),
            404 => FromJson<V1OrganizationsServicesQueryApiEndpoints404Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpoints404Error1),
            500 => FromJson<V1OrganizationsServicesQueryApiEndpoints500Error1>(response, ct).As(AsV1OrganizationsServicesQueryApiEndpoints500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class QueryApiEndpointCreateErrorResponse : IErrorResponse<QueryApiEndpointCreateError>
{
    public static QueryApiEndpointCreateErrorResponse Instance { get; } = new();

    private QueryApiEndpointCreateErrorResponse()
    {
    }

    public Task<QueryApiEndpointCreateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        QueryApiEndpointCreateError.Create(response, ct);
}
