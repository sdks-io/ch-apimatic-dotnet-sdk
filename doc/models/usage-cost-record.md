
# Usage Cost Record

*This model accepts additional fields of type object.*

## Structure

`UsageCostRecord`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DataWarehouseId` | `Guid?` | Optional | ID of the dataWarehouse this entity belongs to (or is). |
| `ServiceId` | `Guid?` | Optional | ID of the service this entity belongs to (or is). Set to null for dataWarehouse entities. |
| `Date` | `DateTime?` | Optional | Date of the usage. ISO-8601 date, based on the UTC timezone. |
| `EntityType` | [`EntityType?`](../../doc/models/entity-type.md) | Optional | Type of the entity. |
| `EntityId` | `Guid?` | Optional | Unique ID of the entity. |
| `EntityName` | `string` | Optional | Name of the entity. |
| `Metrics` | [`UsageCostMetrics`](../../doc/models/usage-cost-metrics.md) | Optional | - |
| `TotalChc` | `double?` | Optional | Total cost of usage in ClickHouse Credits (CHCs) for this entity. |
| `Locked` | `bool?` | Optional | When true, the record is immutable. Unlocked records are subject to change until locked. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

UsageCostRecord usageCostRecord = new UsageCostRecord
{
    DataWarehouseId = new Guid("0000268a-0000-0000-0000-000000000000"),
    ServiceId = new Guid("00000c74-0000-0000-0000-000000000000"),
    Date = DateTime.Parse("2016-03-13"),
    EntityType = EntityType.Datawarehouse,
    EntityId = new Guid("0000189a-0000-0000-0000-000000000000"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

