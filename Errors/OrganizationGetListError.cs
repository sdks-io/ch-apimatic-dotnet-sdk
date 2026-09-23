using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class OrganizationGetListError : ApiError
{
    private readonly Optional<V1Organizations400Error1> _v1Organizations400Error1Value;

    private readonly Optional<V1Organizations500Error1> _v1Organizations500Error1Value;

    private OrganizationGetListError(Optional<V1Organizations400Error1> v1Organizations400Error1Value,
        Optional<V1Organizations500Error1> v1Organizations500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1Organizations400Error1Value = v1Organizations400Error1Value;
        _v1Organizations500Error1Value = v1Organizations500Error1Value;
    }

    private static OrganizationGetListError AsV1Organizations400Error1(V1Organizations400Error1 value) =>
        new(Optional<V1Organizations400Error1>.Some(value), default, default);

    private static OrganizationGetListError AsV1Organizations500Error1(V1Organizations500Error1 value) =>
        new(default, Optional<V1Organizations500Error1>.Some(value), default);

    private static OrganizationGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1Organizations400Error1(out V1Organizations400Error1 value) =>
        _v1Organizations400Error1Value.TryGetValue(out value);

    public bool TryGetV1Organizations500Error1(out V1Organizations500Error1 value) =>
        _v1Organizations500Error1Value.TryGetValue(out value);

    internal static Task<OrganizationGetListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1Organizations400Error1>(response, ct).As(AsV1Organizations400Error1),
            500 => FromJson<V1Organizations500Error1>(response, ct).As(AsV1Organizations500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OrganizationGetListErrorResponse : IErrorResponse<OrganizationGetListError>
{
    public static OrganizationGetListErrorResponse Instance { get; } = new();

    private OrganizationGetListErrorResponse()
    {
    }

    public Task<OrganizationGetListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OrganizationGetListError.Create(response, ct);
}
