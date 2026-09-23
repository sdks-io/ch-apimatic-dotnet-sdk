using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackGetRoleError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1> _v1OrganizationsServicesClickstackRolesClickStackRoleId400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1> _v1OrganizationsServicesClickstackRolesClickStackRoleId500Error1Value;

    private ClickStackGetRoleError(Optional<V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1> v1OrganizationsServicesClickstackRolesClickStackRoleId400Error1Value,
        Optional<V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1> v1OrganizationsServicesClickstackRolesClickStackRoleId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackRolesClickStackRoleId400Error1Value =
            v1OrganizationsServicesClickstackRolesClickStackRoleId400Error1Value;
        _v1OrganizationsServicesClickstackRolesClickStackRoleId500Error1Value =
            v1OrganizationsServicesClickstackRolesClickStackRoleId500Error1Value;
    }

    private static ClickStackGetRoleError AsV1OrganizationsServicesClickstackRolesClickStackRoleId400Error1(V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1>.Some(value), default, default);

    private static ClickStackGetRoleError AsV1OrganizationsServicesClickstackRolesClickStackRoleId500Error1(V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1>.Some(value), default);

    private static ClickStackGetRoleError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId400Error1(out V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1 value) =>
        _v1OrganizationsServicesClickstackRolesClickStackRoleId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackRolesClickStackRoleId500Error1(out V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1 value) =>
        _v1OrganizationsServicesClickstackRolesClickStackRoleId500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackGetRoleError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackRolesClickStackRoleId400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackRolesClickStackRoleId400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackRolesClickStackRoleId500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackRolesClickStackRoleId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackGetRoleErrorResponse : IErrorResponse<ClickStackGetRoleError>
{
    public static ClickStackGetRoleErrorResponse Instance { get; } = new();

    private ClickStackGetRoleErrorResponse()
    {
    }

    public Task<ClickStackGetRoleError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackGetRoleError.Create(response, ct);
}
