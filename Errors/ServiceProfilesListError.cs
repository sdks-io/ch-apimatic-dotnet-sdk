using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ServiceProfilesListError : ApiError
{
    private readonly Optional<V1OrganizationsServiceProfiles400Error1> _v1OrganizationsServiceProfiles400Error1Value;

    private readonly Optional<V1OrganizationsServiceProfiles500Error1> _v1OrganizationsServiceProfiles500Error1Value;

    private ServiceProfilesListError(Optional<V1OrganizationsServiceProfiles400Error1> v1OrganizationsServiceProfiles400Error1Value,
        Optional<V1OrganizationsServiceProfiles500Error1> v1OrganizationsServiceProfiles500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServiceProfiles400Error1Value = v1OrganizationsServiceProfiles400Error1Value;
        _v1OrganizationsServiceProfiles500Error1Value = v1OrganizationsServiceProfiles500Error1Value;
    }

    private static ServiceProfilesListError AsV1OrganizationsServiceProfiles400Error1(V1OrganizationsServiceProfiles400Error1 value) =>
        new(Optional<V1OrganizationsServiceProfiles400Error1>.Some(value), default, default);

    private static ServiceProfilesListError AsV1OrganizationsServiceProfiles500Error1(V1OrganizationsServiceProfiles500Error1 value) =>
        new(default, Optional<V1OrganizationsServiceProfiles500Error1>.Some(value), default);

    private static ServiceProfilesListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServiceProfiles400Error1(out V1OrganizationsServiceProfiles400Error1 value) =>
        _v1OrganizationsServiceProfiles400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServiceProfiles500Error1(out V1OrganizationsServiceProfiles500Error1 value) =>
        _v1OrganizationsServiceProfiles500Error1Value.TryGetValue(out value);

    internal static Task<ServiceProfilesListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServiceProfiles400Error1>(response, ct).As(AsV1OrganizationsServiceProfiles400Error1),
            500 => FromJson<V1OrganizationsServiceProfiles500Error1>(response, ct).As(AsV1OrganizationsServiceProfiles500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ServiceProfilesListErrorResponse : IErrorResponse<ServiceProfilesListError>
{
    public static ServiceProfilesListErrorResponse Instance { get; } = new();

    private ServiceProfilesListErrorResponse()
    {
    }

    public Task<ServiceProfilesListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ServiceProfilesListError.Create(response, ct);
}
