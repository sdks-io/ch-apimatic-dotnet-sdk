using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class OrganizationRoleGetError : ApiError
{
    private readonly Optional<V1OrganizationsRoles400Error1> _v1OrganizationsRoles400Error1Value;

    private readonly Optional<V1OrganizationsRoles500Error1> _v1OrganizationsRoles500Error1Value;

    private OrganizationRoleGetError(Optional<V1OrganizationsRoles400Error1> v1OrganizationsRoles400Error1Value,
        Optional<V1OrganizationsRoles500Error1> v1OrganizationsRoles500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsRoles400Error1Value = v1OrganizationsRoles400Error1Value;
        _v1OrganizationsRoles500Error1Value = v1OrganizationsRoles500Error1Value;
    }

    private static OrganizationRoleGetError AsV1OrganizationsRoles400Error1(V1OrganizationsRoles400Error1 value) =>
        new(Optional<V1OrganizationsRoles400Error1>.Some(value), default, default);

    private static OrganizationRoleGetError AsV1OrganizationsRoles500Error1(V1OrganizationsRoles500Error1 value) =>
        new(default, Optional<V1OrganizationsRoles500Error1>.Some(value), default);

    private static OrganizationRoleGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsRoles400Error1(out V1OrganizationsRoles400Error1 value) =>
        _v1OrganizationsRoles400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsRoles500Error1(out V1OrganizationsRoles500Error1 value) =>
        _v1OrganizationsRoles500Error1Value.TryGetValue(out value);

    internal static Task<OrganizationRoleGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsRoles400Error1>(response, ct).As(AsV1OrganizationsRoles400Error1),
            500 => FromJson<V1OrganizationsRoles500Error1>(response, ct).As(AsV1OrganizationsRoles500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OrganizationRoleGetErrorResponse : IErrorResponse<OrganizationRoleGetError>
{
    public static OrganizationRoleGetErrorResponse Instance { get; } = new();

    private OrganizationRoleGetErrorResponse()
    {
    }

    public Task<OrganizationRoleGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OrganizationRoleGetError.Create(response, ct);
}
