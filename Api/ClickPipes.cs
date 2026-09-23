using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core;
using OpenApiSpecForClickHouseCloud.Core.Exceptions;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Request;
using OpenApiSpecForClickHouseCloud.Core.Response;
using OpenApiSpecForClickHouseCloud.Errors;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Api;

public sealed class ClickPipes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ClickPipes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get CDC ClickPipes scaling
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the ClickPipe.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesCdcScalingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeCdcScalingGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get scaling settings for database ClickPipes (PostgreSQL, MySQL, MongoDB, BigQuery).
    /// <para>
    /// The infrastructure is shared between all database ClickPipes in the service, both for initial load and CDC. For billing purposes, 2 CPU cores and 8 GB of RAM <see href="https://clickhouse.com/docs/cloud/manage/billing/overview#clickpipes-for-postgres-cdc">correspond</see> to one compute unit.
    /// </para>
    /// <para>
    /// <b>Note:</b> For Kafka, Kinesis, and object storage pipes (S3, GCS, Azure Blob), see <see href="#tag/ClickPipes/operation/clickPipeGet">Get ClickPipe</see>.
    /// </para>
    /// <para>
    /// <b>This endpoint becomes available once at least one database ClickPipe was provisioned.</b>
    /// </para>
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesCdcScalingResponse> ClickPipeCdcScalingGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipesCdcScaling"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickpipesCdcScalingResponse>(),
            ClickPipeCdcScalingGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update CDC ClickPipes scaling
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the ClickPipe.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesCdcScalingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeCdcScalingUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update scaling settings for database ClickPipes (PostgreSQL, MySQL, MongoDB, BigQuery).
    /// <para>
    /// The infrastructure is shared between all database ClickPipes in the service, both for initial load and CDC. Scaling settings may take a few minutes to fully propagate.
    /// </para>
    /// <para>
    /// For billing purposes, 2 CPU cores and 8 GB of RAM <see href="https://clickhouse.com/docs/cloud/manage/billing/overview#clickpipes-for-postgres-cdc">correspond</see> to one compute unit. If your organization tier changes, database ClickPipes will be <see href="https://clickhouse.com/docs/cloud/manage/billing/overview#compute">rescaled</see> appropriately.
    /// </para>
    /// <para>
    /// <b>Note:</b> For Kafka, Kinesis, and object storage pipes (S3, GCS, Azure Blob), see <see href="#tag/ClickPipes/operation/clickPipeGet">Get ClickPipe</see>.
    /// </para>
    /// <para>
    /// <b>This endpoint becomes available once at least one database ClickPipe was provisioned.</b>
    /// </para>
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesCdcScalingResponse> ClickPipeCdcScalingUpdate(Guid organizationId,
        Guid serviceId,
        ClickPipesCdcScalingPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipesCdcScaling"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickpipesCdcScalingResponse>(),
            ClickPipeCdcScalingUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create ClickPipe
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service to create the ClickPipe for.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new ClickPipe.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesResponse1> ClickPipeCreate(Guid organizationId,
        Guid serviceId,
        ClickPipePostRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickpipesResponse1>(),
            ClickPipeCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete ClickPipe
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the ClickPipe.</param>
    /// <param name="clickPipeId">ID of the ClickPipe to delete.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesClickPipeIdResponse2"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete the specified ClickPipe.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesClickPipeIdResponse2> ClickPipeDelete(Guid organizationId,
        Guid serviceId,
        Guid clickPipeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes/{clickPipeId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickPipeId", clickPipeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickpipesClickPipeIdResponse2>(),
            ClickPipeDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get ClickPipe
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the ClickPipe.</param>
    /// <param name="clickPipeId">ID of the requested ClickPipe.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesClickPipeIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the specified ClickPipe.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesClickPipeIdResponse> ClickPipeGet(Guid organizationId,
        Guid serviceId,
        Guid clickPipeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes/{clickPipeId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickPipeId", clickPipeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickpipesClickPipeIdResponse>(),
            ClickPipeGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List ClickPipes
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the ClickPipe.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of ClickPipes.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesResponse> ClickPipeGetList(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickpipesResponse>(),
            ClickPipeGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Create reverse private endpoint
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the Reverse Private Endpoint.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeReversePrivateEndpointCreateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new reverse private endpoint.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1> ClickPipeReversePrivateEndpointCreate(Guid organizationId,
        Guid serviceId,
        CreateReversePrivateEndpoint? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipesReversePrivateEndpoints"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1>(),
            ClickPipeReversePrivateEndpointCreateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Delete reverse private endpoint
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the Reverse Private Endpoint.</param>
    /// <param name="reversePrivateEndpointId">ID of the reverse private endpoint to delete.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeReversePrivateEndpointDeleteError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete the reverse private endpoint with the specified ID.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1> ClickPipeReversePrivateEndpointDelete(Guid organizationId,
        Guid serviceId,
        Guid reversePrivateEndpointId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipesReversePrivateEndpoints/{reversePrivateEndpointId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("reversePrivateEndpointId", reversePrivateEndpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1>(),
            ClickPipeReversePrivateEndpointDeleteErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get reverse private endpoint
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the Reverse Private Endpoint.</param>
    /// <param name="reversePrivateEndpointId">ID of the reverse private endpoint to get.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeReversePrivateEndpointGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the reverse private endpoint with the specified ID.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse> ClickPipeReversePrivateEndpointGet(Guid organizationId,
        Guid serviceId,
        Guid reversePrivateEndpointId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipesReversePrivateEndpoints/{reversePrivateEndpointId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("reversePrivateEndpointId", reversePrivateEndpointId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse>(),
            ClickPipeReversePrivateEndpointGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// List reverse private endpoints
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the Reverse Private Endpoint.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeReversePrivateEndpointGetListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of reverse private endpoints for the specified service.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse> ClickPipeReversePrivateEndpointGetList(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipesReversePrivateEndpoints"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse>(),
            ClickPipeReversePrivateEndpointGetListErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update reverse private endpoint
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the Reverse Private Endpoint.</param>
    /// <param name="reversePrivateEndpointId">ID of the reverse private endpoint to update.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeReversePrivateEndpointUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update mutable fields for an existing reverse private endpoint. customPrivateDnsMappings is a full replacement list. Use an empty array to clear mappings.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse> ClickPipeReversePrivateEndpointUpdate(Guid organizationId,
        Guid serviceId,
        Guid reversePrivateEndpointId,
        UpdateReversePrivateEndpoint? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipesReversePrivateEndpoints/{reversePrivateEndpointId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("reversePrivateEndpointId", reversePrivateEndpointId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse>(),
            ClickPipeReversePrivateEndpointUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update ClickPipe scaling
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the ClickPipe.</param>
    /// <param name="clickPipeId">ID of the ClickPipe to update scaling settings.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesClickPipeIdScalingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeScalingUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Change scaling settings for the specified ClickPipe. This endpoint supports Kafka, Kinesis, and object storage pipes (S3, GCS, Azure Blob).
    /// <para>
    /// <b>Note:</b> For database ClickPipes (PostgreSQL, MySQL, MongoDB, BigQuery), use the <see href="#tag/ClickPipes/operation/clickPipeCdcScalingUpdate">Update CDC ClickPipes scaling</see> endpoint instead.
    /// </para>
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesClickPipeIdScalingResponse> ClickPipeScalingUpdate(Guid organizationId,
        Guid serviceId,
        Guid clickPipeId,
        ClickPipeScalingPatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes/{clickPipeId}/scaling"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickPipeId", clickPipeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickpipesClickPipeIdScalingResponse>(),
            ClickPipeScalingUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Discover ClickPipe source schema
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service to run schema discovery against.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesSchemaDiscoveryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeSchemaDiscoveryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Infers the schema (field names and ClickHouse data types) of a ClickPipe source without creating a pipe. Supported for Kafka, Kinesis, Pub/Sub, and object storage sources. Object storage inference runs on the destination service, which must be running.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesSchemaDiscoveryResponse> ClickPipeSchemaDiscovery(Guid organizationId,
        Guid serviceId,
        ClickPipeSchemaDiscoveryRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes/schemaDiscovery"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickpipesSchemaDiscoveryResponse>(),
            ClickPipeSchemaDiscoveryErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get ClickPipe settings
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the ClickPipe.</param>
    /// <param name="clickPipeId">ID of the ClickPipe to get settings for.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeSettingsGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the advanced settings for the specified ClickPipe.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse> ClickPipeSettingsGet(Guid organizationId,
        Guid serviceId,
        Guid clickPipeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes/{clickPipeId}/settings"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickPipeId", clickPipeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse>(),
            ClickPipeSettingsGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update ClickPipe settings
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the ClickPipe.</param>
    /// <param name="clickPipeId">ID of the ClickPipe to update settings for.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeSettingsUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the advanced settings for the specified ClickPipe. Send key-value pairs where values can be strings, numbers, or booleans.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse> ClickPipeSettingsUpdate(Guid organizationId,
        Guid serviceId,
        Guid clickPipeId,
        ClickPipeSettingsPutRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes/{clickPipeId}/settings"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickPipeId", clickPipeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse>(),
            ClickPipeSettingsUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update ClickPipe state
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service that owns the ClickPipe.</param>
    /// <param name="clickPipeId">ID of the ClickPipe to update state.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesClickPipeIdStateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeStateUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Start, stop or resync ClickPipe. Stopping a ClickPipe will stop the ingestion process from any state. Starting is allowed for ClickPipes in the "Stopped" state or with a "Failed" state. Resyncing is only for Postgres and MySQL pipes and can be done from any state.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesClickPipeIdStateResponse> ClickPipeStateUpdate(Guid organizationId,
        Guid serviceId,
        Guid clickPipeId,
        ClickPipeStatePatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes/{clickPipeId}/state"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickPipeId", clickPipeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickpipesClickPipeIdStateResponse>(),
            ClickPipeStateUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Update ClickPipe
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service to create the ClickPipe for.</param>
    /// <param name="clickPipeId">ID of the requested ClickPipe.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesClickPipeIdResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipeUpdateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the specified ClickPipe. Source fields not present in the per-source update schemas are immutable after creation. For Kafka sources, values submitted for immutable fields (type, format, brokers, topics, consumerGroup, offset, schemaRegistry, exactlyOnce) are not applied, except schema registry credentials, which are rejected.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesClickPipeIdResponse> ClickPipeUpdate(Guid organizationId,
        Guid serviceId,
        Guid clickPipeId,
        ClickPipePatchRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes/{clickPipeId}"),
            [new TemplateParam("organizationId", organizationId),
                new TemplateParam("serviceId", serviceId),
                new TemplateParam("clickPipeId", clickPipeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<V1OrganizationsServicesClickpipesClickPipeIdResponse>(),
            ClickPipeUpdateErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get ClickPipes service context
    /// </summary>
    /// <param name="organizationId">ID of the organization that owns the service.</param>
    /// <param name="serviceId">ID of the service to get ClickPipes context for.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsServicesClickpipesContextResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ClickPipesServiceContextGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>This endpoint is in beta.</b> API contract is stable, and no breaking changes are expected in the future. &lt;br /&gt;&lt;br /&gt; Returns service-level ClickPipes capabilities and Private Preview workload identity context, including the GCP service account to grant access to customer source resources.
    /// </remarks>
    public Task<V1OrganizationsServicesClickpipesContextResponse> ClickPipesServiceContextGet(Guid organizationId,
        Guid serviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/services/{serviceId}/clickpipes/context"),
            [new TemplateParam("organizationId", organizationId), new TemplateParam("serviceId", serviceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsServicesClickpipesContextResponse>(),
            ClickPipesServiceContextGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
