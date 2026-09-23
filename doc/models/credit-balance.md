
# Credit Balance

*This model accepts additional fields of type object.*

## Structure

`CreditBalance`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique ID of the balance. |
| `Type` | [`Type21?`](../../doc/models/type-21.md) | Optional | Type of the balance. |
| `RemainingCredits` | `double?` | Optional | Remaining credits available on this balance, in ClickHouse Credits (CHCs). |
| `TotalAmount` | `double?` | Optional | Total credits granted on this balance, in ClickHouse Credits (CHCs). |
| `AmountSpent` | `double?` | Optional | Credits spent from this balance, in ClickHouse Credits (CHCs). |
| `StartDate` | `DateTime?` | Optional | Date the balance became active. ISO-8601, based on the UTC timezone. |
| `ExpirationDate` | `DateTime?` | Optional | Date the balance expires. ISO-8601, based on the UTC timezone. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

CreditBalance creditBalance = new CreditBalance
{
    Id = new Guid("000021d8-0000-0000-0000-000000000000"),
    Type = Type21.Prepaid,
    RemainingCredits = 80.98,
    TotalAmount = 251.48,
    AmountSpent = 110.86,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

