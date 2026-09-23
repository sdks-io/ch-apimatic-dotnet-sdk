
# Active Balance

*This model accepts additional fields of type object.*

## Structure

`ActiveBalance`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique ID of the prepaid balance. |
| `RemainingPrepaidCredits` | `double?` | Optional | Remaining credits available on this balance, in ClickHouse Credits (CHCs). |
| `TotalAmount` | `double?` | Optional | Total credits granted on this balance, in ClickHouse Credits (CHCs). |
| `AmountSpent` | `double?` | Optional | Credits spent from this balance, in ClickHouse Credits (CHCs). |
| `StartDate` | `DateTime?` | Optional | Date the balance became active. ISO-8601, based on the UTC timezone. |
| `ExpirationDate` | `DateTime?` | Optional | Date the balance expires. ISO-8601, based on the UTC timezone. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

ActiveBalance activeBalance = new ActiveBalance
{
    Id = new Guid("00000ba2-0000-0000-0000-000000000000"),
    RemainingPrepaidCredits = 41.64,
    TotalAmount = 150.62,
    AmountSpent = 10,
    StartDate = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

