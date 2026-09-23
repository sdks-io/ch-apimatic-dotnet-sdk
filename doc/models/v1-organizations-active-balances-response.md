
# V1 Organizations Active Balances Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsActiveBalancesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ActiveBalances`](../../doc/models/active-balances.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

V1OrganizationsActiveBalancesResponse v1OrganizationsActiveBalancesResponse = new V1OrganizationsActiveBalancesResponse
{
    Status = 200,
    RequestId = new Guid("00002180-0000-0000-0000-000000000000"),
    Result = new ActiveBalances
    {
        TotalRemainingPrepaidCredits = 66.34,
        PrepaidBalances = new List<ActiveBalance>
        {
            new ActiveBalance
            {
                Id = new Guid("00000094-0000-0000-0000-000000000000"),
                RemainingPrepaidCredits = 69.34,
                TotalAmount = 178.32,
                AmountSpent = 37.7,
                StartDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                    provider: CultureInfo.InvariantCulture,
                    DateTimeStyles.RoundtripKind),
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

