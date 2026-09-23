using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UdfUploadSessionCreateError : ApiError
{
    private readonly Optional<V1OrganizationsUdfUploadsUrl400Error1> _v1OrganizationsUdfUploadsUrl400Error1Value;

    private readonly Optional<V1OrganizationsUdfUploadsUrl500Error1> _v1OrganizationsUdfUploadsUrl500Error1Value;

    private UdfUploadSessionCreateError(Optional<V1OrganizationsUdfUploadsUrl400Error1> v1OrganizationsUdfUploadsUrl400Error1Value,
        Optional<V1OrganizationsUdfUploadsUrl500Error1> v1OrganizationsUdfUploadsUrl500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUdfUploadsUrl400Error1Value = v1OrganizationsUdfUploadsUrl400Error1Value;
        _v1OrganizationsUdfUploadsUrl500Error1Value = v1OrganizationsUdfUploadsUrl500Error1Value;
    }

    private static UdfUploadSessionCreateError AsV1OrganizationsUdfUploadsUrl400Error1(V1OrganizationsUdfUploadsUrl400Error1 value) =>
        new(Optional<V1OrganizationsUdfUploadsUrl400Error1>.Some(value), default, default);

    private static UdfUploadSessionCreateError AsV1OrganizationsUdfUploadsUrl500Error1(V1OrganizationsUdfUploadsUrl500Error1 value) =>
        new(default, Optional<V1OrganizationsUdfUploadsUrl500Error1>.Some(value), default);

    private static UdfUploadSessionCreateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUdfUploadsUrl400Error1(out V1OrganizationsUdfUploadsUrl400Error1 value) =>
        _v1OrganizationsUdfUploadsUrl400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfUploadsUrl500Error1(out V1OrganizationsUdfUploadsUrl500Error1 value) =>
        _v1OrganizationsUdfUploadsUrl500Error1Value.TryGetValue(out value);

    internal static Task<UdfUploadSessionCreateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUdfUploadsUrl400Error1>(response, ct).As(AsV1OrganizationsUdfUploadsUrl400Error1),
            500 => FromJson<V1OrganizationsUdfUploadsUrl500Error1>(response, ct).As(AsV1OrganizationsUdfUploadsUrl500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UdfUploadSessionCreateErrorResponse : IErrorResponse<UdfUploadSessionCreateError>
{
    public static UdfUploadSessionCreateErrorResponse Instance { get; } = new();

    private UdfUploadSessionCreateErrorResponse()
    {
    }

    public Task<UdfUploadSessionCreateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UdfUploadSessionCreateError.Create(response, ct);
}
