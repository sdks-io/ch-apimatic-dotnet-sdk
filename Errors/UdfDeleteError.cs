using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UdfDeleteError : ApiError
{
    private readonly Optional<V1OrganizationsUdfs400Error1> _v1OrganizationsUdfs400Error1Value;

    private readonly Optional<V1OrganizationsUdfs404Error1> _v1OrganizationsUdfs404Error1Value;

    private readonly Optional<V1OrganizationsUdfs409Error1> _v1OrganizationsUdfs409Error1Value;

    private readonly Optional<V1OrganizationsUdfs500Error1> _v1OrganizationsUdfs500Error1Value;

    private UdfDeleteError(Optional<V1OrganizationsUdfs400Error1> v1OrganizationsUdfs400Error1Value,
        Optional<V1OrganizationsUdfs404Error1> v1OrganizationsUdfs404Error1Value,
        Optional<V1OrganizationsUdfs409Error1> v1OrganizationsUdfs409Error1Value,
        Optional<V1OrganizationsUdfs500Error1> v1OrganizationsUdfs500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUdfs400Error1Value = v1OrganizationsUdfs400Error1Value;
        _v1OrganizationsUdfs404Error1Value = v1OrganizationsUdfs404Error1Value;
        _v1OrganizationsUdfs409Error1Value = v1OrganizationsUdfs409Error1Value;
        _v1OrganizationsUdfs500Error1Value = v1OrganizationsUdfs500Error1Value;
    }

    private static UdfDeleteError AsV1OrganizationsUdfs400Error1(V1OrganizationsUdfs400Error1 value) =>
        new(Optional<V1OrganizationsUdfs400Error1>.Some(value), default, default, default, default);

    private static UdfDeleteError AsV1OrganizationsUdfs404Error1(V1OrganizationsUdfs404Error1 value) =>
        new(default, Optional<V1OrganizationsUdfs404Error1>.Some(value), default, default, default);

    private static UdfDeleteError AsV1OrganizationsUdfs409Error1(V1OrganizationsUdfs409Error1 value) =>
        new(default, default, Optional<V1OrganizationsUdfs409Error1>.Some(value), default, default);

    private static UdfDeleteError AsV1OrganizationsUdfs500Error1(V1OrganizationsUdfs500Error1 value) =>
        new(default, default, default, Optional<V1OrganizationsUdfs500Error1>.Some(value), default);

    private static UdfDeleteError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUdfs400Error1(out V1OrganizationsUdfs400Error1 value) =>
        _v1OrganizationsUdfs400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfs404Error1(out V1OrganizationsUdfs404Error1 value) =>
        _v1OrganizationsUdfs404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfs409Error1(out V1OrganizationsUdfs409Error1 value) =>
        _v1OrganizationsUdfs409Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfs500Error1(out V1OrganizationsUdfs500Error1 value) =>
        _v1OrganizationsUdfs500Error1Value.TryGetValue(out value);

    internal static Task<UdfDeleteError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUdfs400Error1>(response, ct).As(AsV1OrganizationsUdfs400Error1),
            404 => FromJson<V1OrganizationsUdfs404Error1>(response, ct).As(AsV1OrganizationsUdfs404Error1),
            409 => FromJson<V1OrganizationsUdfs409Error1>(response, ct).As(AsV1OrganizationsUdfs409Error1),
            500 => FromJson<V1OrganizationsUdfs500Error1>(response, ct).As(AsV1OrganizationsUdfs500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UdfDeleteErrorResponse : IErrorResponse<UdfDeleteError>
{
    public static UdfDeleteErrorResponse Instance { get; } = new();

    private UdfDeleteErrorResponse()
    {
    }

    public Task<UdfDeleteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UdfDeleteError.Create(response, ct);
}
