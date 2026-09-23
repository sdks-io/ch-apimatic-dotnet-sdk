using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class OrganizationQuotasGetListError : ApiError
{
    private readonly Optional<V1OrganizationsQuotas400Error1> _v1OrganizationsQuotas400Error1Value;

    private readonly Optional<V1OrganizationsQuotas500Error1> _v1OrganizationsQuotas500Error1Value;

    private OrganizationQuotasGetListError(Optional<V1OrganizationsQuotas400Error1> v1OrganizationsQuotas400Error1Value,
        Optional<V1OrganizationsQuotas500Error1> v1OrganizationsQuotas500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsQuotas400Error1Value = v1OrganizationsQuotas400Error1Value;
        _v1OrganizationsQuotas500Error1Value = v1OrganizationsQuotas500Error1Value;
    }

    private static OrganizationQuotasGetListError AsV1OrganizationsQuotas400Error1(V1OrganizationsQuotas400Error1 value) =>
        new(Optional<V1OrganizationsQuotas400Error1>.Some(value), default, default);

    private static OrganizationQuotasGetListError AsV1OrganizationsQuotas500Error1(V1OrganizationsQuotas500Error1 value) =>
        new(default, Optional<V1OrganizationsQuotas500Error1>.Some(value), default);

    private static OrganizationQuotasGetListError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsQuotas400Error1(out V1OrganizationsQuotas400Error1 value) =>
        _v1OrganizationsQuotas400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsQuotas500Error1(out V1OrganizationsQuotas500Error1 value) =>
        _v1OrganizationsQuotas500Error1Value.TryGetValue(out value);

    internal static Task<OrganizationQuotasGetListError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsQuotas400Error1>(response, ct).As(AsV1OrganizationsQuotas400Error1),
            500 => FromJson<V1OrganizationsQuotas500Error1>(response, ct).As(AsV1OrganizationsQuotas500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OrganizationQuotasGetListErrorResponse : IErrorResponse<OrganizationQuotasGetListError>
{
    public static OrganizationQuotasGetListErrorResponse Instance { get; } = new();

    private OrganizationQuotasGetListErrorResponse()
    {
    }

    public Task<OrganizationQuotasGetListError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OrganizationQuotasGetListError.Create(response, ct);
}
