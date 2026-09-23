
# Click Pipe Big Query Service Account Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipeBigQueryServiceAccountSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SnapshotStagingPath` | `string` | Required | GCS bucket path for staging snapshot data (e.g., gs://my-bucket/staging/). Data will be automatically cleaned up after initial load. |
| `Settings` | [`ClickPipeBigQueryPipeSettings`](../../doc/models/click-pipe-big-query-pipe-settings.md) | Required | - |
| `TableMappings` | [`List<ClickPipeBigQueryPipeTableMapping>`](../../doc/models/click-pipe-big-query-pipe-table-mapping.md) | Required | Table mappings for BigQuery pipe. |
| `Authentication` | `string` | Required, Constant | Authenticated with a Google Cloud service account JSON key.<br><br>**Value**: `"SERVICE_ACCOUNT"` |
| `ProjectId` | `string` | Optional | GCP project ID that owns the BigQuery resources. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipeBigQueryServiceAccountSource clickPipeBigQueryServiceAccountSource = new ClickPipeBigQueryServiceAccountSource
{
    SnapshotStagingPath = "snapshotStagingPath0",
    Settings = new ClickPipeBigQueryPipeSettings
    {
        ReplicationMode = "snapshot",
        AllowNullableColumns = false,
        InitialLoadParallelism = 117.34,
        SnapshotNumRowsPerPartition = 43.84,
        SnapshotNumberOfParallelTables = 15.52,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    TableMappings = new List<ClickPipeBigQueryPipeTableMapping>
    {
        new ClickPipeBigQueryPipeTableMapping
        {
            SourceDatasetName = "sourceDatasetName6",
            SourceTable = "sourceTable2",
            TargetTable = "targetTable0",
            ExcludedColumns = new List<string>
            {
                "excludedColumns6",
            },
            UseCustomSortingKey = false,
            SortingKeys = new List<string>
            {
                "sortingKeys5",
                "sortingKeys6",
                "sortingKeys7",
            },
            TableEngine = TableEngine4.ReplacingMergeTree,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Authentication = "SERVICE_ACCOUNT",
    ProjectId = "my-gcp-project",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

