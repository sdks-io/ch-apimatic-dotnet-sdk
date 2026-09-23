using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackGetSourceError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1> _v1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1> _v1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1Value;

    private ClickStackGetSourceError(Optional<V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1> v1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1Value,
        Optional<V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1> v1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1Value =
            v1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1Value;
        _v1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1Value =
            v1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1Value;
    }

    private static ClickStackGetSourceError AsV1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1(V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1>.Some(value), default, default);

    private static ClickStackGetSourceError AsV1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1(V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1>.Some(value), default);

    private static ClickStackGetSourceError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1(out V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1 value) =>
        _v1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1(out V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1 value) =>
        _v1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackGetSourceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackSourcesClickStackSourceId400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackSourcesClickStackSourceId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackGetSourceErrorResponse : IErrorResponse<ClickStackGetSourceError>
{
    public static ClickStackGetSourceErrorResponse Instance { get; } = new();

    private ClickStackGetSourceErrorResponse()
    {
    }

    public Task<ClickStackGetSourceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackGetSourceError.Create(response, ct);
}
