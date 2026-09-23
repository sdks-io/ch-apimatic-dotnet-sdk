using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class InstanceScalingUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServicesScaling400Error1> _v1OrganizationsServicesScaling400Error1Value;

    private readonly Optional<V1OrganizationsServicesScaling500Error1> _v1OrganizationsServicesScaling500Error1Value;

    private InstanceScalingUpdateError(Optional<V1OrganizationsServicesScaling400Error1> v1OrganizationsServicesScaling400Error1Value,
        Optional<V1OrganizationsServicesScaling500Error1> v1OrganizationsServicesScaling500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesScaling400Error1Value = v1OrganizationsServicesScaling400Error1Value;
        _v1OrganizationsServicesScaling500Error1Value = v1OrganizationsServicesScaling500Error1Value;
    }

    private static InstanceScalingUpdateError AsV1OrganizationsServicesScaling400Error1(V1OrganizationsServicesScaling400Error1 value) =>
        new(Optional<V1OrganizationsServicesScaling400Error1>.Some(value), default, default);

    private static InstanceScalingUpdateError AsV1OrganizationsServicesScaling500Error1(V1OrganizationsServicesScaling500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesScaling500Error1>.Some(value), default);

    private static InstanceScalingUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesScaling400Error1(out V1OrganizationsServicesScaling400Error1 value) =>
        _v1OrganizationsServicesScaling400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesScaling500Error1(out V1OrganizationsServicesScaling500Error1 value) =>
        _v1OrganizationsServicesScaling500Error1Value.TryGetValue(out value);

    internal static Task<InstanceScalingUpdateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesScaling400Error1>(response, ct).As(AsV1OrganizationsServicesScaling400Error1),
            500 => FromJson<V1OrganizationsServicesScaling500Error1>(response, ct).As(AsV1OrganizationsServicesScaling500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class InstanceScalingUpdateErrorResponse : IErrorResponse<InstanceScalingUpdateError>
{
    public static InstanceScalingUpdateErrorResponse Instance { get; } = new();

    private InstanceScalingUpdateErrorResponse()
    {
    }

    public Task<InstanceScalingUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        InstanceScalingUpdateError.Create(response, ct);
}
