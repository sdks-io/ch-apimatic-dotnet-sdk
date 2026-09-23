
# V1 Organizations Credit Balances Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsCreditBalancesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`CreditBalances`](../../doc/models/credit-balances.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsCreditBalancesResponse v1OrganizationsCreditBalancesResponse = new V1OrganizationsCreditBalancesResponse
{
    Status = 200,
    RequestId = new Guid("00000aa6-0000-0000-0000-000000000000"),
    Result = new CreditBalances
    {
        TotalRemainingCredits = 9.1,
        Balances = new List<CreditBalance>
        {
            new CreditBalance
            {
                Id = new Guid("000008c0-0000-0000-0000-000000000000"),
                Type = Type21.Prepaid,
                RemainingCredits = 172.74,
                TotalAmount = 87.24,
                AmountSpent = 202.62,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

