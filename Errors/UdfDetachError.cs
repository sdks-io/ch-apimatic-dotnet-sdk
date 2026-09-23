using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UdfDetachError : ApiError
{
    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId400Error21> _v1OrganizationsUdfsAttachmentsServiceId400Error21Value;

    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId404Error1> _v1OrganizationsUdfsAttachmentsServiceId404Error1Value;

    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId409Error1> _v1OrganizationsUdfsAttachmentsServiceId409Error1Value;

    private readonly Optional<V1OrganizationsUdfsAttachmentsServiceId500Error1> _v1OrganizationsUdfsAttachmentsServiceId500Error1Value;

    private UdfDetachError(Optional<V1OrganizationsUdfsAttachmentsServiceId400Error21> v1OrganizationsUdfsAttachmentsServiceId400Error21Value,
        Optional<V1OrganizationsUdfsAttachmentsServiceId404Error1> v1OrganizationsUdfsAttachmentsServiceId404Error1Value,
        Optional<V1OrganizationsUdfsAttachmentsServiceId409Error1> v1OrganizationsUdfsAttachmentsServiceId409Error1Value,
        Optional<V1OrganizationsUdfsAttachmentsServiceId500Error1> v1OrganizationsUdfsAttachmentsServiceId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUdfsAttachmentsServiceId400Error21Value = v1OrganizationsUdfsAttachmentsServiceId400Error21Value;
        _v1OrganizationsUdfsAttachmentsServiceId404Error1Value = v1OrganizationsUdfsAttachmentsServiceId404Error1Value;
        _v1OrganizationsUdfsAttachmentsServiceId409Error1Value = v1OrganizationsUdfsAttachmentsServiceId409Error1Value;
        _v1OrganizationsUdfsAttachmentsServiceId500Error1Value = v1OrganizationsUdfsAttachmentsServiceId500Error1Value;
    }

    private static UdfDetachError AsV1OrganizationsUdfsAttachmentsServiceId400Error21(V1OrganizationsUdfsAttachmentsServiceId400Error21 value) =>
        new(Optional<V1OrganizationsUdfsAttachmentsServiceId400Error21>.Some(value), default, default, default, default);

    private static UdfDetachError AsV1OrganizationsUdfsAttachmentsServiceId404Error1(V1OrganizationsUdfsAttachmentsServiceId404Error1 value) =>
        new(default, Optional<V1OrganizationsUdfsAttachmentsServiceId404Error1>.Some(value), default, default, default);

    private static UdfDetachError AsV1OrganizationsUdfsAttachmentsServiceId409Error1(V1OrganizationsUdfsAttachmentsServiceId409Error1 value) =>
        new(default, default, Optional<V1OrganizationsUdfsAttachmentsServiceId409Error1>.Some(value), default, default);

    private static UdfDetachError AsV1OrganizationsUdfsAttachmentsServiceId500Error1(V1OrganizationsUdfsAttachmentsServiceId500Error1 value) =>
        new(default, default, default, Optional<V1OrganizationsUdfsAttachmentsServiceId500Error1>.Some(value), default);

    private static UdfDetachError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId400Error21(out V1OrganizationsUdfsAttachmentsServiceId400Error21 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId400Error21Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId404Error1(out V1OrganizationsUdfsAttachmentsServiceId404Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId409Error1(out V1OrganizationsUdfsAttachmentsServiceId409Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId409Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsAttachmentsServiceId500Error1(out V1OrganizationsUdfsAttachmentsServiceId500Error1 value) =>
        _v1OrganizationsUdfsAttachmentsServiceId500Error1Value.TryGetValue(out value);

    internal static Task<UdfDetachError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUdfsAttachmentsServiceId400Error21>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId400Error21),
            404 => FromJson<V1OrganizationsUdfsAttachmentsServiceId404Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId404Error1),
            409 => FromJson<V1OrganizationsUdfsAttachmentsServiceId409Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId409Error1),
            500 => FromJson<V1OrganizationsUdfsAttachmentsServiceId500Error1>(response, ct).As(AsV1OrganizationsUdfsAttachmentsServiceId500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UdfDetachErrorResponse : IErrorResponse<UdfDetachError>
{
    public static UdfDetachErrorResponse Instance { get; } = new();

    private UdfDetachErrorResponse()
    {
    }

    public Task<UdfDetachError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UdfDetachError.Create(response, ct);
}
