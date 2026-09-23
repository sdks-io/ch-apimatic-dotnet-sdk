using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core.ErrorResponse;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Errors;

public sealed class ClickPipeSchemaDiscoveryError : ApiError
{
    private readonly Optional<V1OrganizationsServicesClickpipesSchemaDiscovery400Error1> _v1OrganizationsServicesClickpipesSchemaDiscovery400Error1Value;

    private readonly Optional<V1OrganizationsServicesClickpipesSchemaDiscovery500Error1> _v1OrganizationsServicesClickpipesSchemaDiscovery500Error1Value;

    private ClickPipeSchemaDiscoveryError(Optional<V1OrganizationsServicesClickpipesSchemaDiscovery400Error1> v1OrganizationsServicesClickpipesSchemaDiscovery400Error1Value,
        Optional<V1OrganizationsServicesClickpipesSchemaDiscovery500Error1> v1OrganizationsServicesClickpipesSchemaDiscovery500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _v1OrganizationsServicesClickpipesSchemaDiscovery400Error1Value =
            v1OrganizationsServicesClickpipesSchemaDiscovery400Error1Value;
        _v1OrganizationsServicesClickpipesSchemaDiscovery500Error1Value =
            v1OrganizationsServicesClickpipesSchemaDiscovery500Error1Value;
    }

    private static ClickPipeSchemaDiscoveryError AsV1OrganizationsServicesClickpipesSchemaDiscovery400Error1(V1OrganizationsServicesClickpipesSchemaDiscovery400Error1 value) =>
        new(Optional<V1OrganizationsServicesClickpipesSchemaDiscovery400Error1>.Some(value), default, default);

    private static ClickPipeSchemaDiscoveryError AsV1OrganizationsServicesClickpipesSchemaDiscovery500Error1(V1OrganizationsServicesClickpipesSchemaDiscovery500Error1 value) =>
        new(default, Optional<V1OrganizationsServicesClickpipesSchemaDiscovery500Error1>.Some(value), default);

    private static ClickPipeSchemaDiscoveryError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetV1OrganizationsServicesClickpipesSchemaDiscovery400Error1(out V1OrganizationsServicesClickpipesSchemaDiscovery400Error1 value) =>
        _v1OrganizationsServicesClickpipesSchemaDiscovery400Error1Value.TryGetValue(out value);

    public bool TryGetV1OrganizationsServicesClickpipesSchemaDiscovery500Error1(out V1OrganizationsServicesClickpipesSchemaDiscovery500Error1 value) =>
        _v1OrganizationsServicesClickpipesSchemaDiscovery500Error1Value.TryGetValue(out value);

    internal static Task<ClickPipeSchemaDiscoveryError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<V1OrganizationsServicesClickpipesSchemaDiscovery400Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesSchemaDiscovery400Error1),
            500 => FromJson<V1OrganizationsServicesClickpipesSchemaDiscovery500Error1>(response, ct).As(AsV1OrganizationsServicesClickpipesSchemaDiscovery500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClickPipeSchemaDiscoveryErrorResponse : IErrorResponse<ClickPipeSchemaDiscoveryError>
{
    public static ClickPipeSchemaDiscoveryErrorResponse Instance { get; } = new();

    private ClickPipeSchemaDiscoveryErrorResponse()
    {
    }

    public Task<ClickPipeSchemaDiscoveryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClickPipeSchemaDiscoveryError.Create(response, ct);
}
