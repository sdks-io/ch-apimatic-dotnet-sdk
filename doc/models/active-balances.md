
# Active Balances

*This model accepts additional fields of type object.*

## Structure

`ActiveBalances`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TotalRemainingPrepaidCredits` | `double?` | Optional | Total remaining credits across all active prepaid balances, in ClickHouse Credits (CHCs). |
| `PrepaidBalances` | [`List<ActiveBalance>`](../../doc/models/active-balance.md) | Optional | List of active prepaid balances for the organization. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;
using System.Globalization;

ActiveBalances activeBalances = new ActiveBalances
{
    TotalRemainingPrepaidCredits = 149.52,
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
};
```

