using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UdfAttachmentListError : ApiError
{
    private readonly Optional<V1OrganizationsUdfsAttachments400Error1> _v1OrganizationsUdfsAttachments400Error1Value;

    private readonly Optional<V1OrganizationsUdfsAttachments404Error1> _v1OrganizationsUdfsAttachments404Error1Value;

    private readonly Optional<V1OrganizationsUdfsAttachments500Error1> _v1OrganizationsUdfsAttachments500Error1Value;

    private UdfAttachmentListError(Optional<V1OrganizationsUdfsAttachments400Error1> v1OrganizationsUdfsAttachments400Error1Value,
        Optional<V1OrganizationsUdfsAttachments404Error1> v1OrganizationsUdfsAttachments404Error1Value,
        Optional<V1OrganizationsUdfsAttachments500Error1> v1OrganizationsUdfsAttachments500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUdfsAttachments400Error1Value = v1OrganizationsUdfsAttachments400Error1Value;
        _v1OrganizationsUdfsAttachments404Error1Value = v1OrganizationsUdfsAttachments404Error1Value;
        _v1OrganizationsUdfsAttachments500Error1Value = v1OrganizationsUdfsAttachments500Error1Value;
    }

    private static UdfAttachmentListError AsV1OrganizationsUdfsAttachments400Error1(V1OrganizationsUdfsAttachments400Error1 value) =>
        new(Optional<V1OrganizationsUdfsAttachments400Error1>.Some(value), default, default, default);

    private static UdfAttachmentListError AsV1OrganizationsUdfsAttachments404Error1(V1OrganizationsUdfsAttachments404Error1 value) =>
        new(default, Optional<V1OrganizationsUdfsAttachments404Error1>.Some(value), default, default);

    private static UdfAttachmentListError AsV1OrganizationsUdfsAttachments500Error1(V1OrganizationsUdfsAttachments500Error1 value) =>
        new(default, default, Optional<V1OrganizationsUdfsAttachments500Error1>.Some(value), default);

    private static UdfAttachmentListError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUdfsAttachments400Error1(out V1OrganizationsUdfsAttachments400Error1 value) =>
        _v1OrganizationsUdfsAttachments400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachments404Error1(out V1OrganizationsUdfsAttachments404Error1 value) =>
        _v1OrganizationsUdfsAttachments404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachments500Error1(out V1OrganizationsUdfsAttachments500Error1 value) =>
        _v1OrganizationsUdfsAttachments500Error1Value.TryGetValue(out value);

    internal static Task<UdfAttachmentListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUdfsAttachments400Error1>(response, ct).As(AsV1OrganizationsUdfsAttachments400Error1),
            404 => FromJson<V1OrganizationsUdfsAttachments404Error1>(response, ct).As(AsV1OrganizationsUdfsAttachments404Error1),
            500 => FromJson<V1OrganizationsUdfsAttachments500Error1>(response, ct).As(AsV1OrganizationsUdfsAttachments500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UdfAttachmentListErrorResponse : IErrorResponse<UdfAttachmentListError>
{
    public static UdfAttachmentListErrorResponse Instance { get; } = new();

    private UdfAttachmentListErrorResponse()
    {
    }

    public Task<UdfAttachmentListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UdfAttachmentListError.Create(response, ct);
}
