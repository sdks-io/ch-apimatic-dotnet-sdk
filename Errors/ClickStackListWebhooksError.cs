using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickStackListWebhooksError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickstackWebhooks400Error1> _v1OrganizationsServicesClickstackWebhooks400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickstackWebhooks500Error1> _v1OrganizationsServicesClickstackWebhooks500Error1Value;

    private ClickStackListWebhooksError(Optional<V1OrganizationsServicesClickstackWebhooks400Error1> v1OrganizationsServicesClickstackWebhooks400Error1Value,
        Optional<V1OrganizationsServicesClickstackWebhooks500Error1> v1OrganizationsServicesClickstackWebhooks500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickstackWebhooks400Error1Value = v1OrganizationsServicesClickstackWebhooks400Error1Value;
        _v1OrganizationsServicesClickstackWebhooks500Error1Value = v1OrganizationsServicesClickstackWebhooks500Error1Value;
    }

    private static ClickStackListWebhooksError AsV1OrganizationsServicesClickstackWebhooks400Error1(V1OrganizationsServicesClickstackWebhooks400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickstackWebhooks400Error1>.Some(value), default, default);

    private static ClickStackListWebhooksError AsV1OrganizationsServicesClickstackWebhooks500Error1(V1OrganizationsServicesClickstackWebhooks500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickstackWebhooks500Error1>.Some(value), default);

    private static ClickStackListWebhooksError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickstackWebhooks400Error1(out V1OrganizationsServicesClickstackWebhooks400Error1 value) =>
        _v1OrganizationsServicesClickstackWebhooks400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickstackWebhooks500Error1(out V1OrganizationsServicesClickstackWebhooks500Error1 value) =>
        _v1OrganizationsServicesClickstackWebhooks500Error1Value.TryGetValue(out value);

    internal static Task<ClickStackListWebhooksError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickstackWebhooks400Error1>(response, ct).As(AsV1OrganizationsServicesClickstackWebhooks400Error1),
            500 => FromJson<V1OrganizationsServicesClickstackWebhooks500Error1>(response, ct).As(AsV1OrganizationsServicesClickstackWebhooks500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickStackListWebhooksErrorResponse : IErrorResponse<ClickStackListWebhooksError>
{
    public static ClickStackListWebhooksErrorResponse Instance { get; } = new();

    private ClickStackListWebhooksErrorResponse()
    {
    }

    public Task<ClickStackListWebhooksError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickStackListWebhooksError.Create(response, ct);
}
