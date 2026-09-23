using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackUpdateSavedSearchError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1> _v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1> _v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1Value;

    private ClickStackUpdateSavedSearchError(Optional<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1> v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1Value,
        Optional<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1> v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1Value =
            v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1Value;
        _v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1Value =
            v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1Value;
    }

    private static ClickStackUpdateSavedSearchError AsV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1(V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1>.Some(value),
            default,
            default);

    private static ClickStackUpdateSavedSearchError AsV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1(V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1 value) =>
        new(default,
            Optional<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1>.Some(value),
            default);

    private static ClickStackUpdateSavedSearchError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1(out V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1 value) =>
        _v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1(out V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1 value) =>
        _v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackUpdateSavedSearchError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1>(response,
                ct).As(AsV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1>(response,
                ct).As(AsV1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackUpdateSavedSearchErrorResponse : IErrorResponse<ClickStackUpdateSavedSearchError>
{
    public static ClickStackUpdateSavedSearchErrorResponse Instance { get; } = new();

    private ClickStackUpdateSavedSearchErrorResponse()
    {
    }

    public Task<ClickStackUpdateSavedSearchError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackUpdateSavedSearchError.Create(response, ct);
}
