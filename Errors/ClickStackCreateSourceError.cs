using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackCreateSourceError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackSources400Error1> _v1OrganizationsServicesClickstackSources400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackSources500Error1> _v1OrganizationsServicesClickstackSources500Error1Value;

    private ClickStackCreateSourceError(Optional<V1OrganizationsServicesClickstackSources400Error1> v1OrganizationsServicesClickstackSources400Error1Value,
        Optional<V1OrganizationsServicesClickstackSources500Error1> v1OrganizationsServicesClickstackSources500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackSources400Error1Value = v1OrganizationsServicesClickstackSources400Error1Value;
        _v1OrganizationsServicesClickstackSources500Error1Value = v1OrganizationsServicesClickstackSources500Error1Value;
    }

    private static ClickStackCreateSourceError AsV1OrganizationsServicesClickstackSources400Error1(V1OrganizationsServicesClickstackSources400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackSources400Error1>.Some(value), default, default);

    private static ClickStackCreateSourceError AsV1OrganizationsServicesClickstackSources500Error1(V1OrganizationsServicesClickstackSources500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackSources500Error1>.Some(value), default);

    private static ClickStackCreateSourceError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackSources400Error1(out V1OrganizationsServicesClickstackSources400Error1 value) =>
        _v1OrganizationsServicesClickstackSources400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackSources500Error1(out V1OrganizationsServicesClickstackSources500Error1 value) =>
        _v1OrganizationsServicesClickstackSources500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackCreateSourceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackSources400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackSources400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackSources500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackSources500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackCreateSourceErrorResponse : IErrorResponse<ClickStackCreateSourceError>
{
    public static ClickStackCreateSourceErrorResponse Instance { get; } = new();

    private ClickStackCreateSourceErrorResponse()
    {
    }

    public Task<ClickStackCreateSourceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackCreateSourceError.Create(response, ct);
}
