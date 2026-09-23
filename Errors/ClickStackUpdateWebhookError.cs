using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackUpdateWebhookError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1> _v1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1> _v1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1Value;

    private ClickStackUpdateWebhookError(Optional<V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1> v1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1Value,
        Optional<V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1> v1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1Value =
            v1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1Value;
        _v1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1Value =
            v1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1Value;
    }

    private static ClickStackUpdateWebhookError AsV1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1(V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1>.Some(value),
            default,
            default);

    private static ClickStackUpdateWebhookError AsV1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1(V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1 value) =>
        new(default,
            Optional<V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1>.Some(value),
            default);

    private static ClickStackUpdateWebhookError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1(out V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1 value) =>
        _v1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1(out V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1 value) =>
        _v1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackUpdateWebhookError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackWebhooksClickStackWebhookId400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackWebhooksClickStackWebhookId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackUpdateWebhookErrorResponse : IErrorResponse<ClickStackUpdateWebhookError>
{
    public static ClickStackUpdateWebhookErrorResponse Instance { get; } = new();

    private ClickStackUpdateWebhookErrorResponse()
    {
    }

    public Task<ClickStackUpdateWebhookError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackUpdateWebhookError.Create(response, ct);
}
