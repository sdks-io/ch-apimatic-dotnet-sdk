using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackCreateRoleError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackRoles400Error1> _v1OrganizationsServicesClickstackRoles400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackRoles500Error1> _v1OrganizationsServicesClickstackRoles500Error1Value;

    private ClickStackCreateRoleError(Optional<V1OrganizationsServicesClickstackRoles400Error1> v1OrganizationsServicesClickstackRoles400Error1Value,
        Optional<V1OrganizationsServicesClickstackRoles500Error1> v1OrganizationsServicesClickstackRoles500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackRoles400Error1Value = v1OrganizationsServicesClickstackRoles400Error1Value;
        _v1OrganizationsServicesClickstackRoles500Error1Value = v1OrganizationsServicesClickstackRoles500Error1Value;
    }

    private static ClickStackCreateRoleError AsV1OrganizationsServicesClickstackRoles400Error1(V1OrganizationsServicesClickstackRoles400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackRoles400Error1>.Some(value), default, default);

    private static ClickStackCreateRoleError AsV1OrganizationsServicesClickstackRoles500Error1(V1OrganizationsServicesClickstackRoles500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackRoles500Error1>.Some(value), default);

    private static ClickStackCreateRoleError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackRoles400Error1(out V1OrganizationsServicesClickstackRoles400Error1 value) =>
        _v1OrganizationsServicesClickstackRoles400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackRoles500Error1(out V1OrganizationsServicesClickstackRoles500Error1 value) =>
        _v1OrganizationsServicesClickstackRoles500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackCreateRoleError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackRoles400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackRoles400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackRoles500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackRoles500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackCreateRoleErrorResponse : IErrorResponse<ClickStackCreateRoleError>
{
    public static ClickStackCreateRoleErrorResponse Instance { get; } = new();

    private ClickStackCreateRoleErrorResponse()
    {
    }

    public Task<ClickStackCreateRoleError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackCreateRoleError.Create(response, ct);
}
