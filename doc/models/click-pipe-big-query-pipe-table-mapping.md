
# Click Pipe Big Query Pipe Table Mapping

*This model accepts additional fields of type object.*

## Structure

`ClickPipeBigQueryPipeTableMapping`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SourceDatasetName` | `string` | Required | Source BigQuery dataset name. |
| `SourceTable` | `string` | Required | Source table name. |
| `TargetTable` | `string` | Required | Target ClickHouse table name. |
| `ExcludedColumns` | `List<string>` | Optional | Columns to exclude from the target table. |
| `UseCustomSortingKey` | `bool?` | Optional | Whether to use a custom sorting key for the target table. |
| `SortingKeys` | `List<string>` | Optional | Ordered list of columns to use as sorting key for the target table. |
| `TableEngine` | [`TableEngine4?`](../../doc/models/table-engine-4.md) | Optional | Table engine to use for the target table. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipeBigQueryPipeTableMapping clickPipeBigQueryPipeTableMapping = new ClickPipeBigQueryPipeTableMapping
{
    SourceDatasetName = "sourceDatasetName8",
    SourceTable = "sourceTable0",
    TargetTable = "targetTable2",
    ExcludedColumns = new List<string>
    {
        "excludedColumns4",
        "excludedColumns5",
    },
    UseCustomSortingKey = false,
    SortingKeys = new List<string>
    {
        "sortingKeys7",
        "sortingKeys8",
    },
    TableEngine = TableEngine4.MergeTree,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

