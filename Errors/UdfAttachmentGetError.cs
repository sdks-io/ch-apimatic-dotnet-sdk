using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UdfAttachmentGetError : ApiError
{
    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId400Error21> _v1OrganizationsUdfsAttachmentsServiceId400Error21Value;

    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId404Error1> _v1OrganizationsUdfsAttachmentsServiceId404Error1Value;

    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId500Error1> _v1OrganizationsUdfsAttachmentsServiceId500Error1Value;

    private UdfAttachmentGetError(Optional<V1OrganizationsUdfsAttachmentsServiceId400Error21> v1OrganizationsUdfsAttachmentsServiceId400Error21Value,
        Optional<V1OrganizationsUdfsAttachmentsServiceId404Error1> v1OrganizationsUdfsAttachmentsServiceId404Error1Value,
        Optional<V1OrganizationsUdfsAttachmentsServiceId500Error1> v1OrganizationsUdfsAttachmentsServiceId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUdfsAttachmentsServiceId400Error21Value = v1OrganizationsUdfsAttachmentsServiceId400Error21Value;
        _v1OrganizationsUdfsAttachmentsServiceId404Error1Value = v1OrganizationsUdfsAttachmentsServiceId404Error1Value;
        _v1OrganizationsUdfsAttachmentsServiceId500Error1Value = v1OrganizationsUdfsAttachmentsServiceId500Error1Value;
    }

    private static UdfAttachmentGetError AsV1OrganizationsUdfsAttachmentsServiceId400Error21(V1OrganizationsUdfsAttachmentsServiceId400Error21 value) =>
        new(Optional<V1OrganizationsUdfsAttachmentsServiceId400Error21>.Some(value), default, default, default);

    private static UdfAttachmentGetError AsV1OrganizationsUdfsAttachmentsServiceId404Error1(V1OrganizationsUdfsAttachmentsServiceId404Error1 value) =>
        new(default, Optional<V1OrganizationsUdfsAttachmentsServiceId404Error1>.Some(value), default, default);

    private static UdfAttachmentGetError AsV1OrganizationsUdfsAttachmentsServiceId500Error1(V1OrganizationsUdfsAttachmentsServiceId500Error1 value) =>
        new(default, default, Optional<V1OrganizationsUdfsAttachmentsServiceId500Error1>.Some(value), default);

    private static UdfAttachmentGetError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId400Error21(out V1OrganizationsUdfsAttachmentsServiceId400Error21 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId400Error21Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId404Error1(out V1OrganizationsUdfsAttachmentsServiceId404Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId500Error1(out V1OrganizationsUdfsAttachmentsServiceId500Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId500Error1Value.TryGetValue(out value);

    internal static Task<UdfAttachmentGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUdfsAttachmentsServiceId400Error21>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId400Error21),
            404 => FromJson<V1OrganizationsUdfsAttachmentsServiceId404Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId404Error1),
            500 => FromJson<V1OrganizationsUdfsAttachmentsServiceId500Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UdfAttachmentGetErrorResponse : IErrorResponse<UdfAttachmentGetError>
{
    public static UdfAttachmentGetErrorResponse Instance { get; } = new();

    private UdfAttachmentGetErrorResponse()
    {
    }

    public Task<UdfAttachmentGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UdfAttachmentGetError.Create(response, ct);
}
