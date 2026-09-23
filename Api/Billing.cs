using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OpenApiSpecForClickHouseCloud.Core;
using OpenApiSpecForClickHouseCloud.Core.Exceptions;
using OpenApiSpecForClickHouseCloud.Core.Extensions;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Request;
using OpenApiSpecForClickHouseCloud.Core.Response;
using OpenApiSpecForClickHouseCloud.Errors;
using OpenApiSpecForClickHouseCloud.Models;

namespace OpenApiSpecForClickHouseCloud.Api;

public sealed class Billing
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Billing(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get organization active prepaid balances
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="limit">Maximum number of results to return.</param>
    /// <param name="offset">Number of results to skip before returning.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsActiveBalancesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="ActiveBalancesGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// DEPRECATED. Use the <c>/v1/organizations/{organizationId}/creditBalances</c> endpoint instead. &lt;br /&gt;&lt;br /&gt; Returns the active prepaid credit balances for the organization, each with its own balance ID and remaining credits, along with the total remaining credits across all active balances. A balance is active when it has started, has not expired, and has credits remaining. Balances are ordered by expiration date, soonest first, and the returned page is capped at <c>limit</c> (default and maximum 100). When <c>totalCount</c> exceeds the number of returned balances, page with <c>limit</c>/<c>offset</c> to retrieve them all. <c>totalRemainingPrepaidCredits</c> always covers every active balance, not just the returned page.
    /// </remarks>
    public Task<V1OrganizationsActiveBalancesResponse> ActiveBalancesGet(Guid organizationId,
        int? limit = 100,
        int? offset = 0,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/activeBalances"),
            [new TemplateParam("organizationId", organizationId)],
            [new Param("limit", limit), new Param("offset", offset)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsActiveBalancesResponse>(),
            ActiveBalancesGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get organization active credit balances
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsCreditBalancesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="CreditBalancesGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <b>Disclaimer:</b> This beta endpoint is evolving; the API contract may change. &lt;br /&gt;&lt;br /&gt; Returns the active credit balances for the organization, each with its own balance ID, type and remaining credits, along with the total remaining credits across all of them. A balance is active when it has started, has not expired, and has credits remaining. Balances are ordered by expiration date, soonest first. The list is always present and is empty when the organization has no active balances.
    /// </remarks>
    public Task<V1OrganizationsCreditBalancesResponse> CreditBalancesGet(Guid organizationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/creditBalances"),
            [new TemplateParam("organizationId", organizationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsCreditBalancesResponse>(),
            CreditBalancesGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);

    /// <summary>
    /// Get organization usage costs
    /// </summary>
    /// <param name="organizationId">ID of the requested organization.</param>
    /// <param name="fromDate">Start date for the report, e.g. 2024-12-19.</param>
    /// <param name="toDate">End date (inclusive) for the report, e.g. 2024-12-20. This date cannot be more than 30 days after from_date (for a maximum queried period of 31 days).</param>
    /// <param name="filter">Filter criteria to apply when retrieving the usage cost report. Currently, only filtering by resource tags is supported.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1OrganizationsUsageCostResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="UsageCostGetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a grand total and a list of daily, per-entity organization usage cost records for the organization in the queried time period (maximum 31 days). All days in both the request and the response are evaluated based on the UTC timezone.
    /// </remarks>
    public Task<V1OrganizationsUsageCostResponse> UsageCostGet(Guid organizationId,
        DateTimeOffset fromDate,
        DateTimeOffset toDate,
        IReadOnlyList<string>? filter,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/organizations/{organizationId}/usageCost"),
            [new TemplateParam("organizationId", organizationId)],
            [new Param("from_date", fromDate.ToDate()),
                new Param("to_date", toDate.ToDate()),
                new Param("filter", filter)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1OrganizationsUsageCostResponse>(),
            UsageCostGetErrorResponse.Instance,
            [_auth.BasicAuth],
            requestOptions,
            ct);
}
