
# V1 Organizations Usage Cost Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsUsageCostResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`UsageCost`](../../doc/models/usage-cost.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsUsageCostResponse v1OrganizationsUsageCostResponse = new V1OrganizationsUsageCostResponse
{
    Status = 200,
    RequestId = new Guid("00001f2e-0000-0000-0000-000000000000"),
    Result = new UsageCost
    {
        GrandTotalChc = 51.94,
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
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

