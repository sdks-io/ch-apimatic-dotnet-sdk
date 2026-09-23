using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ScalingScheduleGetError : ApiError
{
    private readonly Optional<V1OrganizationsServicesScalingSchedule400Error1> _v1OrganizationsServicesScalingSchedule400Error1Value;

    private readonly Optional<V1OrganizationsServicesScalingSchedule500Error1> _v1OrganizationsServicesScalingSchedule500Error1Value;

    private ScalingScheduleGetError(Optional<V1OrganizationsServicesScalingSchedule400Error1> v1OrganizationsServicesScalingSchedule400Error1Value,
        Optional<V1OrganizationsServicesScalingSchedule500Error1> v1OrganizationsServicesScalingSchedule500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesScalingSchedule400Error1Value = v1OrganizationsServicesScalingSchedule400Error1Value;
        _v1OrganizationsServicesScalingSchedule500Error1Value = v1OrganizationsServicesScalingSchedule500Error1Value;
    }

    private static ScalingScheduleGetError AsV1OrganizationsServicesScalingSchedule400Error1(V1OrganizationsServicesScalingSchedule400Error1 value) =>
        new(Optional<V1OrganizationsServicesScalingSchedule400Error1>.Some(value), default, default);

    private static ScalingScheduleGetError AsV1OrganizationsServicesScalingSchedule500Error1(V1OrganizationsServicesScalingSchedule500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesScalingSchedule500Error1>.Some(value), default);

    private static ScalingScheduleGetError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesScalingSchedule400Error1(out V1OrganizationsServicesScalingSchedule400Error1 value) =>
        _v1OrganizationsServicesScalingSchedule400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesScalingSchedule500Error1(out V1OrganizationsServicesScalingSchedule500Error1 value) =>
        _v1OrganizationsServicesScalingSchedule500Error1Value.TryGetValue(out value);

    internal static Task<ScalingScheduleGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesScalingSchedule400Error1>(response, ct).As(AsV1OrganizationsServicesScalingSchedule400Error1),
            500 => FromJson<V1OrganizationsServicesScalingSchedule500Error1>(response, ct).As(AsV1OrganizationsServicesScalingSchedule500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ScalingScheduleGetErrorResponse : IErrorResponse<ScalingScheduleGetError>
{
    public static ScalingScheduleGetErrorResponse Instance { get; } = new();

    private ScalingScheduleGetErrorResponse()
    {
    }

    public Task<ScalingScheduleGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ScalingScheduleGetError.Create(response, ct);
}
