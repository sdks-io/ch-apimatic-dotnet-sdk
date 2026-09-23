using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UdfVersionListError : ApiError
{
    private readonly Optional<V1OrganizationsUdfsVersions400Error1> _v1OrganizationsUdfsVersions400Error1Value;

    private readonly Optional<V1OrganizationsUdfsVersions404Error1> _v1OrganizationsUdfsVersions404Error1Value;

    private readonly Optional<V1OrganizationsUdfsVersions500Error1> _v1OrganizationsUdfsVersions500Error1Value;

    private UdfVersionListError(Optional<V1OrganizationsUdfsVersions400Error1> v1OrganizationsUdfsVersions400Error1Value,
        Optional<V1OrganizationsUdfsVersions404Error1> v1OrganizationsUdfsVersions404Error1Value,
        Optional<V1OrganizationsUdfsVersions500Error1> v1OrganizationsUdfsVersions500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUdfsVersions400Error1Value = v1OrganizationsUdfsVersions400Error1Value;
        _v1OrganizationsUdfsVersions404Error1Value = v1OrganizationsUdfsVersions404Error1Value;
        _v1OrganizationsUdfsVersions500Error1Value = v1OrganizationsUdfsVersions500Error1Value;
    }

    private static UdfVersionListError AsV1OrganizationsUdfsVersions400Error1(V1OrganizationsUdfsVersions400Error1 value) =>
        new(Optional<V1OrganizationsUdfsVersions400Error1>.Some(value), default, default, default);

    private static UdfVersionListError AsV1OrganizationsUdfsVersions404Error1(V1OrganizationsUdfsVersions404Error1 value) =>
        new(default, Optional<V1OrganizationsUdfsVersions404Error1>.Some(value), default, default);

    private static UdfVersionListError AsV1OrganizationsUdfsVersions500Error1(V1OrganizationsUdfsVersions500Error1 value) =>
        new(default, default, Optional<V1OrganizationsUdfsVersions500Error1>.Some(value), default);

    private static UdfVersionListError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUdfsVersions400Error1(out V1OrganizationsUdfsVersions400Error1 value) =>
        _v1OrganizationsUdfsVersions400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsVersions404Error1(out V1OrganizationsUdfsVersions404Error1 value) =>
        _v1OrganizationsUdfsVersions404Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfsVersions500Error1(out V1OrganizationsUdfsVersions500Error1 value) =>
        _v1OrganizationsUdfsVersions500Error1Value.TryGetValue(out value);

    internal static Task<UdfVersionListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUdfsVersions400Error1>(response, ct).As(AsV1OrganizationsUdfsVersions400Error1),
            404 => FromJson<V1OrganizationsUdfsVersions404Error1>(response, ct).As(AsV1OrganizationsUdfsVersions404Error1),
            500 => FromJson<V1OrganizationsUdfsVersions500Error1>(response, ct).As(AsV1OrganizationsUdfsVersions500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UdfVersionListErrorResponse : IErrorResponse<UdfVersionListError>
{
    public static UdfVersionListErrorResponse Instance { get; } = new();

    private UdfVersionListErrorResponse()
    {
    }

    public Task<UdfVersionListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UdfVersionListError.Create(response, ct);
}
