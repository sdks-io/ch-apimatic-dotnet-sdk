
# Credit Balances

*This model accepts additional fields of type object.*

## Structure

`CreditBalances`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalRemainingCredits` | `double?` | Optional | Total remaining credits across all active balances, in ClickHouse Credits (CHCs). |
| `Balances` | [`List<CreditBalance>`](../../doc/models/credit-balance.md) | Optional | List of active balances for the organization. Empty when the organization has none. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

CreditBalances creditBalances = new CreditBalances
{
    TotalRemainingCredits = 158.3,
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
};
```

