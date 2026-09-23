
# Click Pipe Big Query Workload Identity Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipeBigQueryWorkloadIdentitySource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SnapshotStagingPath` | `string` | Required | GCS bucket path for staging snapshot data (e.g., gs://my-bucket/staging/). Data will be automatically cleaned up after initial load. |
| `Settings` | [`ClickPipeBigQueryPipeSettings`](../../doc/models/click-pipe-big-query-pipe-settings.md) | Required | - |
| `TableMappings` | [`List<ClickPipeBigQueryPipeTableMapping>`](../../doc/models/click-pipe-big-query-pipe-table-mapping.md) | Required | Table mappings for BigQuery pipe. |
| `Authentication` | `string` | Required, Constant | Authenticated with the ClickPipes service tenant identity. SERVICE_ACCOUNT_WORKLOAD_IDENTITY is in Private Preview. ClickPipes uses the GCP service account returned in gcpWorkloadIdentity.principal by the operation with operationId clickPipesServiceContextGet; grant it access to the source resources.<br><br>**Value**: `"SERVICE_ACCOUNT_WORKLOAD_IDENTITY"` |
| `ProjectId` | `string` | Optional | GCP project ID that owns the BigQuery resources. Older pipes created outside OpenAPI may omit this field. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipeBigQueryWorkloadIdentitySource clickPipeBigQueryWorkloadIdentitySource = new ClickPipeBigQueryWorkloadIdentitySource
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
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

