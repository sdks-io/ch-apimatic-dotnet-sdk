using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeCdcScalingGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesCdcScaling400Error1> _v1OrganizationsServicesClickpipesCdcScaling400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesCdcScaling500Error1> _v1OrganizationsServicesClickpipesCdcScaling500Error1Value;

    private ClickPipeCdcScalingGetError(Optional<V1OrganizationsServicesClickpipesCdcScaling400Error1> v1OrganizationsServicesClickpipesCdcScaling400Error1Value,
        Optional<V1OrganizationsServicesClickpipesCdcScaling500Error1> v1OrganizationsServicesClickpipesCdcScaling500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesCdcScaling400Error1Value =
            v1OrganizationsServicesClickpipesCdcScaling400Error1Value;
        _v1OrganizationsServicesClickpipesCdcScaling500Error1Value =
            v1OrganizationsServicesClickpipesCdcScaling500Error1Value;
    }

    private static ClickPipeCdcScalingGetError AsV1OrganizationsServicesClickpipesCdcScaling400Error1(V1OrganizationsServicesClickpipesCdcScaling400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesCdcScaling400Error1>.Some(value), default, default);

    private static ClickPipeCdcScalingGetError AsV1OrganizationsServicesClickpipesCdcScaling500Error1(V1OrganizationsServicesClickpipesCdcScaling500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipesCdcScaling500Error1>.Some(value), default);

    private static ClickPipeCdcScalingGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesCdcScaling400Error1(out V1OrganizationsServicesClickpipesCdcScaling400Error1 value) =>
        _v1OrganizationsServicesClickpipesCdcScaling400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesCdcScaling500Error1(out V1OrganizationsServicesClickpipesCdcScaling500Error1 value) =>
        _v1OrganizationsServicesClickpipesCdcScaling500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeCdcScalingGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesCdcScaling400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesCdcScaling400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesCdcScaling500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesCdcScaling500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeCdcScalingGetErrorResponse : IErrorResponse<ClickPipeCdcScalingGetError>
{
    public static ClickPipeCdcScalingGetErrorResponse Instance { get; } = new();

    private ClickPipeCdcScalingGetErrorResponse()
    {
    }

    public Task<ClickPipeCdcScalingGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeCdcScalingGetError.Create(response, ct);
}
