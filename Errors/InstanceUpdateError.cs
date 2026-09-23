using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class InstanceUpdateError : ApiError
{
    private readonly Optional<V1OrganizationsServices400Error1> _v1OrganizationsServices400Error1Value;

    private readonly Optional<V1OrganizationsServices500Error1> _v1OrganizationsServices500Error1Value;

    private InstanceUpdateError(Optional<V1OrganizationsServices400Error1> v1OrganizationsServices400Error1Value,
        Optional<V1OrganizationsServices500Error1> v1OrganizationsServices500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServices400Error1Value = v1OrganizationsServices400Error1Value;
        _v1OrganizationsServices500Error1Value = v1OrganizationsServices500Error1Value;
    }

    private static InstanceUpdateError AsV1OrganizationsServices400Error1(V1OrganizationsServices400Error1 value) =>
        new(Optional<V1OrganizationsServices400Error1>.Some(value), default, default);

    private static InstanceUpdateError AsV1OrganizationsServices500Error1(V1OrganizationsServices500Error1 value) =>
        new(default, Optional<V1OrganizationsServices500Error1>.Some(value), default);

    private static InstanceUpdateError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServices400Error1(out V1OrganizationsServices400Error1 value) =>
        _v1OrganizationsServices400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServices500Error1(out V1OrganizationsServices500Error1 value) =>
        _v1OrganizationsServices500Error1Value.TryGetValue(out value);

    internal static Task<InstanceUpdateError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServices400Error1>(response, ct).As(AsV1OrganizationsServices400Error1),
            500 => FromJson<V1OrganizationsServices500Error1>(response, ct).As(AsV1OrganizationsServices500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class InstanceUpdateErrorResponse : IErrorResponse<InstanceUpdateError>
{
    public static InstanceUpdateErrorResponse Instance { get; } = new();

    private InstanceUpdateErrorResponse()
    {
    }

    public Task<InstanceUpdateError> Map(HttpResponseMessage response, CancellationToken ct) =>
        InstanceUpdateError.Create(response, ct);
}
