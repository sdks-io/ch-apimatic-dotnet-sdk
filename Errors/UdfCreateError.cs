using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class UdfCreateError : ApiError
{
    private readonly Optional<V1OrganizationsUdfs400Error1> _v1OrganizationsUdfs400Error1Value;

    private readonly Optional<V1OrganizationsUdfs403Error1> _v1OrganizationsUdfs403Error1Value;

    private readonly Optional<V1OrganizationsUdfs409Error1> _v1OrganizationsUdfs409Error1Value;

    private readonly Optional<V1OrganizationsUdfs410Error1> _v1OrganizationsUdfs410Error1Value;

    private readonly Optional<V1OrganizationsUdfs500Error1> _v1OrganizationsUdfs500Error1Value;

    private UdfCreateError(Optional<V1OrganizationsUdfs400Error1> v1OrganizationsUdfs400Error1Value,
        Optional<V1OrganizationsUdfs403Error1> v1OrganizationsUdfs403Error1Value,
        Optional<V1OrganizationsUdfs409Error1> v1OrganizationsUdfs409Error1Value,
        Optional<V1OrganizationsUdfs410Error1> v1OrganizationsUdfs410Error1Value,
        Optional<V1OrganizationsUdfs500Error1> v1OrganizationsUdfs500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsUdfs400Error1Value = v1OrganizationsUdfs400Error1Value;
        _v1OrganizationsUdfs403Error1Value = v1OrganizationsUdfs403Error1Value;
        _v1OrganizationsUdfs409Error1Value = v1OrganizationsUdfs409Error1Value;
        _v1OrganizationsUdfs410Error1Value = v1OrganizationsUdfs410Error1Value;
        _v1OrganizationsUdfs500Error1Value = v1OrganizationsUdfs500Error1Value;
    }

    private static UdfCreateError AsV1OrganizationsUdfs400Error1(V1OrganizationsUdfs400Error1 value) =>
        new(Optional<V1OrganizationsUdfs400Error1>.Some(value), default, default, default, default, default);

    private static UdfCreateError AsV1OrganizationsUdfs403Error1(V1OrganizationsUdfs403Error1 value) =>
        new(default, Optional<V1OrganizationsUdfs403Error1>.Some(value), default, default, default, default);

    private static UdfCreateError AsV1OrganizationsUdfs409Error1(V1OrganizationsUdfs409Error1 value) =>
        new(default, default, Optional<V1OrganizationsUdfs409Error1>.Some(value), default, default, default);

    private static UdfCreateError AsV1OrganizationsUdfs410Error1(V1OrganizationsUdfs410Error1 value) =>
        new(default, default, default, Optional<V1OrganizationsUdfs410Error1>.Some(value), default, default);

    private static UdfCreateError AsV1OrganizationsUdfs500Error1(V1OrganizationsUdfs500Error1 value) =>
        new(default, default, default, default, Optional<V1OrganizationsUdfs500Error1>.Some(value), default);

    private static UdfCreateError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsUdfs400Error1(out V1OrganizationsUdfs400Error1 value) =>
        _v1OrganizationsUdfs400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfs403Error1(out V1OrganizationsUdfs403Error1 value) =>
        _v1OrganizationsUdfs403Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfs409Error1(out V1OrganizationsUdfs409Error1 value) =>
        _v1OrganizationsUdfs409Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfs410Error1(out V1OrganizationsUdfs410Error1 value) =>
        _v1OrganizationsUdfs410Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsUdfs500Error1(out V1OrganizationsUdfs500Error1 value) =>
        _v1OrganizationsUdfs500Error1Value.TryGetValue(out value);

    internal static Task<UdfCreateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsUdfs400Error1>(response, ct).As(AsV1OrganizationsUdfs400Error1),
            403 => FromJson<V1OrganizationsUdfs403Error1>(response, ct).As(AsV1OrganizationsUdfs403Error1),
            409 => FromJson<V1OrganizationsUdfs409Error1>(response, ct).As(AsV1OrganizationsUdfs409Error1),
            410 => FromJson<V1OrganizationsUdfs410Error1>(response, ct).As(AsV1OrganizationsUdfs410Error1),
            500 => FromJson<V1OrganizationsUdfs500Error1>(response, ct).As(AsV1OrganizationsUdfs500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UdfCreateErrorResponse : IErrorResponse<UdfCreateError>
{
    public static UdfCreateErrorResponse Instance { get; } = new();

    private UdfCreateErrorResponse()
    {
    }

    public Task<UdfCreateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UdfCreateError.Create(response, ct);
}
