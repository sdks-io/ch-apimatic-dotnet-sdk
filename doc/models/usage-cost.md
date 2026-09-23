
# Usage Cost

*This model accepts additional fields of type object.*

## Structure

`UsageCost`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GrandTotalChc` | `double?` | Optional | Grand total cost of usage in ClickHouse Credits (CHCs). |
| `Costs` | [`List<UsageCostRecord>`](../../doc/models/usage-cost-record.md) | Optional | List of daily, per-entity usage cost records. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

UsageCost usageCost = new UsageCost
{
    GrandTotalChc = 86.04,
    Costs = new List<UsageCostRecord>
    {
        new UsageCostRecord
        {
            DataWarehouseId = new Guid("00001eea-0000-0000-0000-000000000000"),
            ServiceId = new Guid("000004d4-0000-0000-0000-000000000000"),
            Date = DateTime.Parse("2016-03-13"),
            EntityType = EntityType.Clickpipe,
            EntityId = new Guid("000006d6-0000-0000-0000-000000000000"),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new UsageCostRecord
        {
            DataWarehouseId = new Guid("00001eea-0000-0000-0000-000000000000"),
            ServiceId = new Guid("000004d4-0000-0000-0000-000000000000"),
            Date = DateTime.Parse("2016-03-13"),
            EntityType = EntityType.Clickpipe,
            EntityId = new Guid("000006d6-0000-0000-0000-000000000000"),
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

