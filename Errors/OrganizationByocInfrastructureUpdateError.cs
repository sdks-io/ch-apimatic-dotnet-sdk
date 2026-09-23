using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class OrganizationByocInfrastructureUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsByocInfrastructure400Error1> _v1OrganizationsByocInfrastructure400Error1Value;

    private readonly Optional<V1OrganizationsByocInfrastructure500Error1> _v1OrganizationsByocInfrastructure500Error1Value;

    private OrganizationByocInfrastructureUpdateError(Optional<V1OrganizationsByocInfrastructure400Error1> v1OrganizationsByocInfrastructure400Error1Value,
        Optional<V1OrganizationsByocInfrastructure500Error1> v1OrganizationsByocInfrastructure500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsByocInfrastructure400Error1Value = v1OrganizationsByocInfrastructure400Error1Value;
        _v1OrganizationsByocInfrastructure500Error1Value = v1OrganizationsByocInfrastructure500Error1Value;
    }

    private static OrganizationByocInfrastructureUpdateError AsV1OrganizationsByocInfrastructure400Error1(V1OrganizationsByocInfrastructure400Error1 value) =>
        new(Optional<V1OrganizationsByocInfrastructure400Error1>.Some(value), default, default);

    private static OrganizationByocInfrastructureUpdateError AsV1OrganizationsByocInfrastructure500Error1(V1OrganizationsByocInfrastructure500Error1 value) =>
        new(default, Optional<V1OrganizationsByocInfrastructure500Error1>.Some(value), default);

    private static OrganizationByocInfrastructureUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsByocInfrastructure400Error1(out V1OrganizationsByocInfrastructure400Error1 value) =>
        _v1OrganizationsByocInfrastructure400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsByocInfrastructure500Error1(out V1OrganizationsByocInfrastructure500Error1 value) =>
        _v1OrganizationsByocInfrastructure500Error1Value.TryGetValue(out value);

    internal static Task<OrganizationByocInfrastructureUpdateError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsByocInfrastructure400Error1>(response, ct).As(AsV1OrganizationsByocInfrastructure400Error1),
            500 => FromJson<V1OrganizationsByocInfrastructure500Error1>(response, ct).As(AsV1OrganizationsByocInfrastructure500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class OrganizationByocInfrastructureUpdateErrorResponse : IErrorResponse<OrganizationByocInfrastructureUpdateError>
{
    public static OrganizationByocInfrastructureUpdateErrorResponse Instance { get; } = new();

    private OrganizationByocInfrastructureUpdateErrorResponse()
    {
    }

    public Task<OrganizationByocInfrastructureUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        OrganizationByocInfrastructureUpdateError.Create(response, ct);
}
