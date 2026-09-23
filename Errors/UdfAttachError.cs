using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UdfAttachError : ApiError
{
    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId400Error1> _v1OrganizationsUdfsAttachmentsServiceId400Error1Value;

    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId404Error1> _v1OrganizationsUdfsAttachmentsServiceId404Error1Value;

    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId409Error1> _v1OrganizationsUdfsAttachmentsServiceId409Error1Value;

    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId422Error1> _v1OrganizationsUdfsAttachmentsServiceId422Error1Value;

    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId424Error1> _v1OrganizationsUdfsAttachmentsServiceId424Error1Value;

    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId500Error1> _v1OrganizationsUdfsAttachmentsServiceId500Error1Value;

    private UdfAttachError(Optional<V1OrganizationsUdfsAttachmentsServiceId400Error1> v1OrganizationsUdfsAttachmentsServiceId400Error1Value,
        Optional<V1OrganizationsUdfsAttachmentsServiceId404Error1> v1OrganizationsUdfsAttachmentsServiceId404Error1Value,
        Optional<V1OrganizationsUdfsAttachmentsServiceId409Error1> v1OrganizationsUdfsAttachmentsServiceId409Error1Value,
        Optional<V1OrganizationsUdfsAttachmentsServiceId422Error1> v1OrganizationsUdfsAttachmentsServiceId422Error1Value,
        Optional<V1OrganizationsUdfsAttachmentsServiceId424Error1> v1OrganizationsUdfsAttachmentsServiceId424Error1Value,
        Optional<V1OrganizationsUdfsAttachmentsServiceId500Error1> v1OrganizationsUdfsAttachmentsServiceId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUdfsAttachmentsServiceId400Error1Value = v1OrganizationsUdfsAttachmentsServiceId400Error1Value;
        _v1OrganizationsUdfsAttachmentsServiceId404Error1Value = v1OrganizationsUdfsAttachmentsServiceId404Error1Value;
        _v1OrganizationsUdfsAttachmentsServiceId409Error1Value = v1OrganizationsUdfsAttachmentsServiceId409Error1Value;
        _v1OrganizationsUdfsAttachmentsServiceId422Error1Value = v1OrganizationsUdfsAttachmentsServiceId422Error1Value;
        _v1OrganizationsUdfsAttachmentsServiceId424Error1Value = v1OrganizationsUdfsAttachmentsServiceId424Error1Value;
        _v1OrganizationsUdfsAttachmentsServiceId500Error1Value = v1OrganizationsUdfsAttachmentsServiceId500Error1Value;
    }

    private static UdfAttachError AsV1OrganizationsUdfsAttachmentsServiceId400Error1(V1OrganizationsUdfsAttachmentsServiceId400Error1 value) =>
        new(Optional<V1OrganizationsUdfsAttachmentsServiceId400Error1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static UdfAttachError AsV1OrganizationsUdfsAttachmentsServiceId404Error1(V1OrganizationsUdfsAttachmentsServiceId404Error1 value) =>
        new(default,
            Optional<V1OrganizationsUdfsAttachmentsServiceId404Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static UdfAttachError AsV1OrganizationsUdfsAttachmentsServiceId409Error1(V1OrganizationsUdfsAttachmentsServiceId409Error1 value) =>
        new(default,
            default,
            Optional<V1OrganizationsUdfsAttachmentsServiceId409Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static UdfAttachError AsV1OrganizationsUdfsAttachmentsServiceId422Error1(V1OrganizationsUdfsAttachmentsServiceId422Error1 value) =>
        new(default,
            default,
            default,
            Optional<V1OrganizationsUdfsAttachmentsServiceId422Error1>.Some(value),
            default,
            default,
            default);

    private static UdfAttachError AsV1OrganizationsUdfsAttachmentsServiceId424Error1(V1OrganizationsUdfsAttachmentsServiceId424Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<V1OrganizationsUdfsAttachmentsServiceId424Error1>.Some(value),
            default,
            default);

    private static UdfAttachError AsV1OrganizationsUdfsAttachmentsServiceId500Error1(V1OrganizationsUdfsAttachmentsServiceId500Error1 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<V1OrganizationsUdfsAttachmentsServiceId500Error1>.Some(value),
            default);

    private static UdfAttachError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId400Error1(out V1OrganizationsUdfsAttachmentsServiceId400Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId404Error1(out V1OrganizationsUdfsAttachmentsServiceId404Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId409Error1(out V1OrganizationsUdfsAttachmentsServiceId409Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId409Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId422Error1(out V1OrganizationsUdfsAttachmentsServiceId422Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId422Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId424Error1(out V1OrganizationsUdfsAttachmentsServiceId424Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId424Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId500Error1(out V1OrganizationsUdfsAttachmentsServiceId500Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId500Error1Value.TryGetValue(out value);

    internal static Task<UdfAttachError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUdfsAttachmentsServiceId400Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId400Error1),
            404 => FromJson<V1OrganizationsUdfsAttachmentsServiceId404Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId404Error1),
            409 => FromJson<V1OrganizationsUdfsAttachmentsServiceId409Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId409Error1),
            422 => FromJson<V1OrganizationsUdfsAttachmentsServiceId422Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId422Error1),
            424 => FromJson<V1OrganizationsUdfsAttachmentsServiceId424Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId424Error1),
            500 => FromJson<V1OrganizationsUdfsAttachmentsServiceId500Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UdfAttachErrorResponse : IErrorResponse<UdfAttachError>
{
    public static UdfAttachErrorResponse Instance { get; } = new();

    private UdfAttachErrorResponse()
    {
    }

    public Task<UdfAttachError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UdfAttachError.Create(response, ct);
}
