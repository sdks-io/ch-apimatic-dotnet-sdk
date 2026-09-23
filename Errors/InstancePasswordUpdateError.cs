using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class InstancePasswordUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesPassword400Error1> _v1OrganizationsServicesPassword400Error1Value;

    private readonly Optional<V1OrganizationsServicesPassword500Error1> _v1OrganizationsServicesPassword500Error1Value;

    private InstancePasswordUpdateError(Optional<V1OrganizationsServicesPassword400Error1> v1OrganizationsServicesPassword400Error1Value,
        Optional<V1OrganizationsServicesPassword500Error1> v1OrganizationsServicesPassword500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesPassword400Error1Value = v1OrganizationsServicesPassword400Error1Value;
        _v1OrganizationsServicesPassword500Error1Value = v1OrganizationsServicesPassword500Error1Value;
    }

    private static InstancePasswordUpdateError AsV1OrganizationsServicesPassword400Error1(V1OrganizationsServicesPassword400Error1 value) =>
        new(Optional<V1OrganizationsServicesPassword400Error1>.Some(value), default, default);

    private static InstancePasswordUpdateError AsV1OrganizationsServicesPassword500Error1(V1OrganizationsServicesPassword500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesPassword500Error1>.Some(value), default);

    private static InstancePasswordUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesPassword400Error1(out V1OrganizationsServicesPassword400Error1 value) =>
        _v1OrganizationsServicesPassword400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesPassword500Error1(out V1OrganizationsServicesPassword500Error1 value) =>
        _v1OrganizationsServicesPassword500Error1Value.TryGetValue(out value);

    internal static Task<InstancePasswordUpdateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesPassword400Error1>(response, ct).As(AsV1OrganizationsServicesPassword400Error1),
            500 => FromJson<V1OrganizationsServicesPassword500Error1>(response, ct).As(AsV1OrganizationsServicesPassword500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class InstancePasswordUpdateErrorResponse : IErrorResponse<InstancePasswordUpdateError>
{
    public static InstancePasswordUpdateErrorResponse Instance { get; } = new();

    private InstancePasswordUpdateErrorResponse()
    {
    }

    public Task<InstancePasswordUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        InstancePasswordUpdateError.Create(response, ct);
}
