
# Click Pipe Post Big Query Workload Identity Source

## Structure

`ClickPipePostBigQueryWorkloadIdentitySource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SnapshotStagingPath` | `string` | Required | GCS bucket path for staging snapshot data (e.g., gs://my-bucket/staging/). Data will be automatically cleaned up after initial load. |
| `Settings` | [`ClickPipeBigQueryPipeSettings`](../../doc/models/click-pipe-big-query-pipe-settings.md) | Required | - |
| `TableMappings` | [`List<ClickPipeBigQueryPipeTableMapping>`](../../doc/models/click-pipe-big-query-pipe-table-mapping.md) | Required | Table mappings for BigQuery pipe. |
| `Authentication` | `string` | Required, Constant | Authenticate with the ClickPipes service tenant identity. Customer credentials must not be provided. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources.<br><br>**Value**: `"SERVICE_ACCOUNT_WORKLOAD_IDENTITY"` |
| `ProjectId` | `string` | Required | GCP project ID that owns the BigQuery resources. |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipePostBigQueryWorkloadIdentitySource clickPipePostBigQueryWorkloadIdentitySource = new ClickPipePostBigQueryWorkloadIdentitySource
{
    SnapshotStagingPath = "snapshotStagingPath2",
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
    Authentication = "SERVICE_ACCOUNT_WORKLOAD_IDENTITY",
    ProjectId = "my-gcp-project",
};
```

