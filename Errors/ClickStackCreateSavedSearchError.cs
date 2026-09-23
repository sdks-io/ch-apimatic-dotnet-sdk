using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackCreateSavedSearchError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackSavedSearches400Error1> _v1OrganizationsServicesClickstackSavedSearches400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackSavedSearches500Error1> _v1OrganizationsServicesClickstackSavedSearches500Error1Value;

    private ClickStackCreateSavedSearchError(Optional<V1OrganizationsServicesClickstackSavedSearches400Error1> v1OrganizationsServicesClickstackSavedSearches400Error1Value,
        Optional<V1OrganizationsServicesClickstackSavedSearches500Error1> v1OrganizationsServicesClickstackSavedSearches500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackSavedSearches400Error1Value =
            v1OrganizationsServicesClickstackSavedSearches400Error1Value;
        _v1OrganizationsServicesClickstackSavedSearches500Error1Value =
            v1OrganizationsServicesClickstackSavedSearches500Error1Value;
    }

    private static ClickStackCreateSavedSearchError AsV1OrganizationsServicesClickstackSavedSearches400Error1(V1OrganizationsServicesClickstackSavedSearches400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackSavedSearches400Error1>.Some(value), default, default);

    private static ClickStackCreateSavedSearchError AsV1OrganizationsServicesClickstackSavedSearches500Error1(V1OrganizationsServicesClickstackSavedSearches500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackSavedSearches500Error1>.Some(value), default);

    private static ClickStackCreateSavedSearchError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackSavedSearches400Error1(out V1OrganizationsServicesClickstackSavedSearches400Error1 value) =>
        _v1OrganizationsServicesClickstackSavedSearches400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackSavedSearches500Error1(out V1OrganizationsServicesClickstackSavedSearches500Error1 value) =>
        _v1OrganizationsServicesClickstackSavedSearches500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackCreateSavedSearchError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackSavedSearches400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackSavedSearches400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackSavedSearches500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackSavedSearches500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackCreateSavedSearchErrorResponse : IErrorResponse<ClickStackCreateSavedSearchError>
{
    public static ClickStackCreateSavedSearchErrorResponse Instance { get; } = new();

    private ClickStackCreateSavedSearchErrorResponse()
    {
    }

    public Task<ClickStackCreateSavedSearchError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackCreateSavedSearchError.Create(response, ct);
}
