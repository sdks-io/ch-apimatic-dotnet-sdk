using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class OpenapiKeyDeleteError : ApiError
{
    private readonly Optional<V1OrganizationsKeys400Error1> _v1OrganizationsKeys400Error1Value;

    private readonly Optional<V1OrganizationsKeys500Error1> _v1OrganizationsKeys500Error1Value;

    private OpenapiKeyDeleteError(Optional<V1OrganizationsKeys400Error1> v1OrganizationsKeys400Error1Value,
        Optional<V1OrganizationsKeys500Error1> v1OrganizationsKeys500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsKeys400Error1Value = v1OrganizationsKeys400Error1Value;
        _v1OrganizationsKeys500Error1Value = v1OrganizationsKeys500Error1Value;
    }

    private static OpenapiKeyDeleteError AsV1OrganizationsKeys400Error1(V1OrganizationsKeys400Error1 value) =>
        new(Optional<V1OrganizationsKeys400Error1>.Some(value), default, default);

    private static OpenapiKeyDeleteError AsV1OrganizationsKeys500Error1(V1OrganizationsKeys500Error1 value) =>
        new(default, Optional<V1OrganizationsKeys500Error1>.Some(value), default);

    private static OpenapiKeyDeleteError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsKeys400Error1(out V1OrganizationsKeys400Error1 value) =>
        _v1OrganizationsKeys400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsKeys500Error1(out V1OrganizationsKeys500Error1 value) =>
        _v1OrganizationsKeys500Error1Value.TryGetValue(out value);

    internal static Task<OpenapiKeyDeleteError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsKeys400Error1>(response, ct).As(AsV1OrganizationsKeys400Error1),
            500 => FromJson<V1OrganizationsKeys500Error1>(response, ct).As(AsV1OrganizationsKeys500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OpenapiKeyDeleteErrorResponse : IErrorResponse<OpenapiKeyDeleteError>
{
    public static OpenapiKeyDeleteErrorResponse Instance { get; } = new();

    private OpenapiKeyDeleteErrorResponse()
    {
    }

    public Task<OpenapiKeyDeleteError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OpenapiKeyDeleteError.Create(response, ct);
}
