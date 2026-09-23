
# Usage Cost Metrics

*This model accepts additional fields of type object.*

## Structure

`UsageCostMetrics`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StorageChc` | `double?` | Optional | Cost of storage in ClickHouse Credits (CHCs). Applies to dataWarehouse entities. |
| `BackupChc` | `double?` | Optional | Cost of backup in ClickHouse Credits (CHCs). Applies to dataWarehouse entities. |
| `ComputeChc` | `double?` | Optional | Cost of compute in ClickHouse Credits (CHCs). Applies to service and clickpipe entities. |
| `DataTransferChc` | `double?` | Optional | Cost of data transfer in ClickHouse Credits (CHCs). Applies to clickpipe entities. |
| `InitialLoadChc` | `double?` | Optional | Cost of initial load and resyncs in ClickHouse Credits (CHCs). Applies to clickpipe entities. |
| `PublicDataTransferChc` | `double?` | Optional | Cost of data transfer in ClickHouse Credits (CHCs). Applies to service entities. |
| `InterRegionTier1DataTransferChc` | `double?` | Optional | Cost of tier1 inter-region data transfer in ClickHouse Credits (CHCs). Applies to service entities. |
| `InterRegionTier2DataTransferChc` | `double?` | Optional | Cost of tier2 inter-region data transfer in ClickHouse Credits (CHCs). Applies to service entities. |
| `InterRegionTier3DataTransferChc` | `double?` | Optional | Cost of tier3 inter-region data transfer in ClickHouse Credits (CHCs). Applies to service entities. |
| `InterRegionTier4DataTransferChc` | `double?` | Optional | Cost of tier4 inter-region data transfer in ClickHouse Credits (CHCs). Applies to service entities. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

UsageCostMetrics usageCostMetrics = new UsageCostMetrics
{
    StorageChc = 79.1,
    BackupChc = 90.94,
    ComputeChc = 97.82,
    DataTransferChc = 177.9,
    InitialLoadChc = 121.06,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

