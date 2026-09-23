using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UdfGetError : ApiError
{
    private readonly Optional<V1OrganizationsUdfs400Error1> _v1OrganizationsUdfs400Error1Value;

    private readonly Optional<V1OrganizationsUdfs404Error1> _v1OrganizationsUdfs404Error1Value;

    private readonly Optional<V1OrganizationsUdfs500Error1> _v1OrganizationsUdfs500Error1Value;

    private UdfGetError(Optional<V1OrganizationsUdfs400Error1> v1OrganizationsUdfs400Error1Value,
        Optional<V1OrganizationsUdfs404Error1> v1OrganizationsUdfs404Error1Value,
        Optional<V1OrganizationsUdfs500Error1> v1OrganizationsUdfs500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUdfs400Error1Value = v1OrganizationsUdfs400Error1Value;
        _v1OrganizationsUdfs404Error1Value = v1OrganizationsUdfs404Error1Value;
        _v1OrganizationsUdfs500Error1Value = v1OrganizationsUdfs500Error1Value;
    }

    private static UdfGetError AsV1OrganizationsUdfs400Error1(V1OrganizationsUdfs400Error1 value) =>
        new(Optional<V1OrganizationsUdfs400Error1>.Some(value), default, default, default);

    private static UdfGetError AsV1OrganizationsUdfs404Error1(V1OrganizationsUdfs404Error1 value) =>
        new(default, Optional<V1OrganizationsUdfs404Error1>.Some(value), default, default);

    private static UdfGetError AsV1OrganizationsUdfs500Error1(V1OrganizationsUdfs500Error1 value) =>
        new(default, default, Optional<V1OrganizationsUdfs500Error1>.Some(value), default);

    private static UdfGetError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUdfs400Error1(out V1OrganizationsUdfs400Error1 value) =>
        _v1OrganizationsUdfs400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfs404Error1(out V1OrganizationsUdfs404Error1 value) =>
        _v1OrganizationsUdfs404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfs500Error1(out V1OrganizationsUdfs500Error1 value) =>
        _v1OrganizationsUdfs500Error1Value.TryGetValue(out value);

    internal static Task<UdfGetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUdfs400Error1>(response, ct).As(AsV1OrganizationsUdfs400Error1),
            404 => FromJson<V1OrganizationsUdfs404Error1>(response, ct).As(AsV1OrganizationsUdfs404Error1),
            500 => FromJson<V1OrganizationsUdfs500Error1>(response, ct).As(AsV1OrganizationsUdfs500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UdfGetErrorResponse : IErrorResponse<UdfGetError>
{
    public static UdfGetErrorResponse Instance { get; } = new();

    private UdfGetErrorResponse()
    {
    }

    public Task<UdfGetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UdfGetError.Create(response, ct);
}
