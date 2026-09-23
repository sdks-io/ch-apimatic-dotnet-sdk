using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeGetListError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipes400Error1> _v1OrganizationsServicesClickpipes400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipes500Error1> _v1OrganizationsServicesClickpipes500Error1Value;

    private ClickPipeGetListError(Optional<V1OrganizationsServicesClickpipes400Error1> v1OrganizationsServicesClickpipes400Error1Value,
        Optional<V1OrganizationsServicesClickpipes500Error1> v1OrganizationsServicesClickpipes500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipes400Error1Value = v1OrganizationsServicesClickpipes400Error1Value;
        _v1OrganizationsServicesClickpipes500Error1Value = v1OrganizationsServicesClickpipes500Error1Value;
    }

    private static ClickPipeGetListError AsV1OrganizationsServicesClickpipes400Error1(V1OrganizationsServicesClickpipes400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipes400Error1>.Some(value), default, default);

    private static ClickPipeGetListError AsV1OrganizationsServicesClickpipes500Error1(V1OrganizationsServicesClickpipes500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipes500Error1>.Some(value), default);

    private static ClickPipeGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipes400Error1(out V1OrganizationsServicesClickpipes400Error1 value) =>
        _v1OrganizationsServicesClickpipes400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipes500Error1(out V1OrganizationsServicesClickpipes500Error1 value) =>
        _v1OrganizationsServicesClickpipes500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeGetListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipes400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipes400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipes500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipes500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeGetListErrorResponse : IErrorResponse<ClickPipeGetListError>
{
    public static ClickPipeGetListErrorResponse Instance { get; } = new();

    private ClickPipeGetListErrorResponse()
    {
    }

    public Task<ClickPipeGetListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeGetListError.Create(response, ct);
}
