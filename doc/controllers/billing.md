# Billing

```csharp
BillingApi billingApi = client.BillingApi;
```

## Class Name

`BillingApi`

## Methods

* [Usage Cost Get](../../doc/controllers/billing.md#usage-cost-get)
* [Active Balances Get](../../doc/controllers/billing.md#active-balances-get)
* [Credit Balances Get](../../doc/controllers/billing.md#credit-balances-get)


# Usage Cost Get

Returns a grand total and a list of daily, per-entity organization usage cost records for the organization in the queried time period (maximum 31 days). All days in both the request and the response are evaluated based on the UTC timezone.

```csharp
UsageCostGetAsync(
    Guid organizationId,
    DateTime fromDate,
    DateTime toDate,
    List<string> filter = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `fromDate` | `DateTime` | Query, Required | Start date for the report, e.g. 2024-12-19. |
| `toDate` | `DateTime` | Query, Required | End date (inclusive) for the report, e.g. 2024-12-20. This date cannot be more than 30 days after from_date (for a maximum queried period of 31 days). |
| `filter` | `List<string>` | Query, Optional | Filter criteria to apply when retrieving the usage cost report. Currently, only filtering by resource tags is supported. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUsageCostResponse](../../doc/models/v1-organizations-usage-cost-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
DateTime fromDate = DateTime.Parse("2016-03-13");
DateTime toDate = DateTime.Parse("2016-03-13");
List<string> filter = new List<string>
{
    "tag:Environment=Production",
    "tag:Department=Engineering",
    "tag:isActive",
};

try
{
    ApiResponse<V1OrganizationsUsageCostResponse> result = await billingApi.UsageCostGetAsync(
        organizationId,
        fromDate,
        toDate,
        filter
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUsageCost400ErrorException)
    {
       // TODO: Handle V1OrganizationsUsageCost400ErrorException exception here
    }
    if (e is V1OrganizationsUsageCost500ErrorException)
    {
       // TODO: Handle V1OrganizationsUsageCost500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUsageCost400ErrorException`](../../doc/models/v1-organizations-usage-cost-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUsageCost500ErrorException`](../../doc/models/v1-organizations-usage-cost-500-error-exception.md) |


# Active Balances Get

**This endpoint is deprecated.**

DEPRECATED. Use the `/v1/organizations/{organizationId}/creditBalances` endpoint instead. <br /><br /> Returns the active prepaid credit balances for the organization, each with its own balance ID and remaining credits, along with the total remaining credits across all active balances. A balance is active when it has started, has not expired, and has credits remaining. Balances are ordered by expiration date, soonest first, and the returned page is capped at `limit` (default and maximum 100). When `totalCount` exceeds the number of returned balances, page with `limit`/`offset` to retrieve them all. `totalRemainingPrepaidCredits` always covers every active balance, not just the returned page.

```csharp
ActiveBalancesGetAsync(
    Guid organizationId,
    int? limit = 100,
    int? offset = 0)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `limit` | `int?` | Query, Optional | Maximum number of results to return.<br><br>**Default**: `100`<br><br>**Constraints**: `>= 1`, `<= 100` |
| `offset` | `int?` | Query, Optional | Number of results to skip before returning.<br><br>**Default**: `0`<br><br>**Constraints**: `>= 0` |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsActiveBalancesResponse](../../doc/models/v1-organizations-active-balances-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
int? limit = 100;
int? offset = 0;
try
{
    ApiResponse<V1OrganizationsActiveBalancesResponse> result = await billingApi.ActiveBalancesGetAsync(
        organizationId,
        limit,
        offset
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsActiveBalances400ErrorException)
    {
       // TODO: Handle V1OrganizationsActiveBalances400ErrorException exception here
    }
    if (e is V1OrganizationsActiveBalances500ErrorException)
    {
       // TODO: Handle V1OrganizationsActiveBalances500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsActiveBalances400ErrorException`](../../doc/models/v1-organizations-active-balances-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsActiveBalances500ErrorException`](../../doc/models/v1-organizations-active-balances-500-error-exception.md) |


# Credit Balances Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the active credit balances for the organization, each with its own balance ID, type and remaining credits, along with the total remaining credits across all of them. A balance is active when it has started, has not expired, and has credits remaining. Balances are ordered by expiration date, soonest first. The list is always present and is empty when the organization has no active balances.

```csharp
CreditBalancesGetAsync(
    Guid organizationId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsCreditBalancesResponse](../../doc/models/v1-organizations-credit-balances-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsCreditBalancesResponse> result = await billingApi.CreditBalancesGetAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsCreditBalances400ErrorException)
    {
       // TODO: Handle V1OrganizationsCreditBalances400ErrorException exception here
    }
    if (e is V1OrganizationsCreditBalances500ErrorException)
    {
       // TODO: Handle V1OrganizationsCreditBalances500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsCreditBalances400ErrorException`](../../doc/models/v1-organizations-credit-balances-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsCreditBalances500ErrorException`](../../doc/models/v1-organizations-credit-balances-500-error-exception.md) |

