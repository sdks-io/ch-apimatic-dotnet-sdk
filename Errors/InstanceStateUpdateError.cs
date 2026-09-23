using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class InstanceStateUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesState400Error1> _v1OrganizationsServicesState400Error1Value;

    private readonly Optional<V1OrganizationsServicesState500Error1> _v1OrganizationsServicesState500Error1Value;

    private InstanceStateUpdateError(Optional<V1OrganizationsServicesState400Error1> v1OrganizationsServicesState400Error1Value,
        Optional<V1OrganizationsServicesState500Error1> v1OrganizationsServicesState500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesState400Error1Value = v1OrganizationsServicesState400Error1Value;
        _v1OrganizationsServicesState500Error1Value = v1OrganizationsServicesState500Error1Value;
    }

    private static InstanceStateUpdateError AsV1OrganizationsServicesState400Error1(V1OrganizationsServicesState400Error1 value) =>
        new(Optional<V1OrganizationsServicesState400Error1>.Some(value), default, default);

    private static InstanceStateUpdateError AsV1OrganizationsServicesState500Error1(V1OrganizationsServicesState500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesState500Error1>.Some(value), default);

    private static InstanceStateUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesState400Error1(out V1OrganizationsServicesState400Error1 value) =>
        _v1OrganizationsServicesState400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesState500Error1(out V1OrganizationsServicesState500Error1 value) =>
        _v1OrganizationsServicesState500Error1Value.TryGetValue(out value);

    internal static Task<InstanceStateUpdateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesState400Error1>(response, ct).As(AsV1OrganizationsServicesState400Error1),
            500 => FromJson<V1OrganizationsServicesState500Error1>(response, ct).As(AsV1OrganizationsServicesState500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class InstanceStateUpdateErrorResponse : IErrorResponse<InstanceStateUpdateError>
{
    public static InstanceStateUpdateErrorResponse Instance { get; } = new();

    private InstanceStateUpdateErrorResponse()
    {
    }

    public Task<InstanceStateUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        InstanceStateUpdateError.Create(response, ct);
}
