using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UdfVersionDeleteError : ApiError
{
    private readonly Optional<V1OrganizationsUdfsVersionsVersion400Error1> _v1OrganizationsUdfsVersionsVersion400Error1Value;

    private readonly Optional<V1OrganizationsUdfsVersionsVersion404Error1> _v1OrganizationsUdfsVersionsVersion404Error1Value;

    private readonly Optional<V1OrganizationsUdfsVersionsVersion409Error1> _v1OrganizationsUdfsVersionsVersion409Error1Value;

    private readonly Optional<V1OrganizationsUdfsVersionsVersion500Error1> _v1OrganizationsUdfsVersionsVersion500Error1Value;

    private UdfVersionDeleteError(Optional<V1OrganizationsUdfsVersionsVersion400Error1> v1OrganizationsUdfsVersionsVersion400Error1Value,
        Optional<V1OrganizationsUdfsVersionsVersion404Error1> v1OrganizationsUdfsVersionsVersion404Error1Value,
        Optional<V1OrganizationsUdfsVersionsVersion409Error1> v1OrganizationsUdfsVersionsVersion409Error1Value,
        Optional<V1OrganizationsUdfsVersionsVersion500Error1> v1OrganizationsUdfsVersionsVersion500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUdfsVersionsVersion400Error1Value = v1OrganizationsUdfsVersionsVersion400Error1Value;
        _v1OrganizationsUdfsVersionsVersion404Error1Value = v1OrganizationsUdfsVersionsVersion404Error1Value;
        _v1OrganizationsUdfsVersionsVersion409Error1Value = v1OrganizationsUdfsVersionsVersion409Error1Value;
        _v1OrganizationsUdfsVersionsVersion500Error1Value = v1OrganizationsUdfsVersionsVersion500Error1Value;
    }

    private static UdfVersionDeleteError AsV1OrganizationsUdfsVersionsVersion400Error1(V1OrganizationsUdfsVersionsVersion400Error1 value) =>
        new(Optional<V1OrganizationsUdfsVersionsVersion400Error1>.Some(value), default, default, default, default);

    private static UdfVersionDeleteError AsV1OrganizationsUdfsVersionsVersion404Error1(V1OrganizationsUdfsVersionsVersion404Error1 value) =>
        new(default, Optional<V1OrganizationsUdfsVersionsVersion404Error1>.Some(value), default, default, default);

    private static UdfVersionDeleteError AsV1OrganizationsUdfsVersionsVersion409Error1(V1OrganizationsUdfsVersionsVersion409Error1 value) =>
        new(default, default, Optional<V1OrganizationsUdfsVersionsVersion409Error1>.Some(value), default, default);

    private static UdfVersionDeleteError AsV1OrganizationsUdfsVersionsVersion500Error1(V1OrganizationsUdfsVersionsVersion500Error1 value) =>
        new(default, default, default, Optional<V1OrganizationsUdfsVersionsVersion500Error1>.Some(value), default);

    private static UdfVersionDeleteError AsFallback(RawError value) =>
        new(default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUdfsVersionsVersion400Error1(out V1OrganizationsUdfsVersionsVersion400Error1 value) =>
        _v1OrganizationsUdfsVersionsVersion400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsVersionsVersion404Error1(out V1OrganizationsUdfsVersionsVersion404Error1 value) =>
        _v1OrganizationsUdfsVersionsVersion404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsVersionsVersion409Error1(out V1OrganizationsUdfsVersionsVersion409Error1 value) =>
        _v1OrganizationsUdfsVersionsVersion409Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsVersionsVersion500Error1(out V1OrganizationsUdfsVersionsVersion500Error1 value) =>
        _v1OrganizationsUdfsVersionsVersion500Error1Value.TryGetValue(out value);

    internal static Task<UdfVersionDeleteError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUdfsVersionsVersion400Error1>(response, ct).As(AsV1OrganizationsUdfsVersionsVersion400Error1),
            404 => FromJson<V1OrganizationsUdfsVersionsVersion404Error1>(response, ct).As(AsV1OrganizationsUdfsVersionsVersion404Error1),
            409 => FromJson<V1OrganizationsUdfsVersionsVersion409Error1>(response, ct).As(AsV1OrganizationsUdfsVersionsVersion409Error1),
            500 => FromJson<V1OrganizationsUdfsVersionsVersion500Error1>(response, ct).As(AsV1OrganizationsUdfsVersionsVersion500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UdfVersionDeleteErrorResponse : IErrorResponse<UdfVersionDeleteError>
{
    public static UdfVersionDeleteErrorResponse Instance { get; } = new();

    private UdfVersionDeleteErrorResponse()
    {
    }

    public Task<UdfVersionDeleteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UdfVersionDeleteError.Create(response, ct);
}
