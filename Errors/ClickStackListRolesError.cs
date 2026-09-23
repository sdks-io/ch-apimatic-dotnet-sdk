using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackListRolesError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackRoles400Error1> _v1OrganizationsServicesClickstackRoles400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackRoles500Error1> _v1OrganizationsServicesClickstackRoles500Error1Value;

    private ClickStackListRolesError(Optional<V1OrganizationsServicesClickstackRoles400Error1> v1OrganizationsServicesClickstackRoles400Error1Value,
        Optional<V1OrganizationsServicesClickstackRoles500Error1> v1OrganizationsServicesClickstackRoles500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackRoles400Error1Value = v1OrganizationsServicesClickstackRoles400Error1Value;
        _v1OrganizationsServicesClickstackRoles500Error1Value = v1OrganizationsServicesClickstackRoles500Error1Value;
    }

    private static ClickStackListRolesError AsV1OrganizationsServicesClickstackRoles400Error1(V1OrganizationsServicesClickstackRoles400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackRoles400Error1>.Some(value), default, default);

    private static ClickStackListRolesError AsV1OrganizationsServicesClickstackRoles500Error1(V1OrganizationsServicesClickstackRoles500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackRoles500Error1>.Some(value), default);

    private static ClickStackListRolesError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackRoles400Error1(out V1OrganizationsServicesClickstackRoles400Error1 value) =>
        _v1OrganizationsServicesClickstackRoles400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackRoles500Error1(out V1OrganizationsServicesClickstackRoles500Error1 value) =>
        _v1OrganizationsServicesClickstackRoles500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackListRolesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackRoles400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackRoles400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackRoles500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackRoles500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackListRolesErrorResponse : IErrorResponse<ClickStackListRolesError>
{
    public static ClickStackListRolesErrorResponse Instance { get; } = new();

    private ClickStackListRolesErrorResponse()
    {
    }

    public Task<ClickStackListRolesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackListRolesError.Create(response, ct);
}
