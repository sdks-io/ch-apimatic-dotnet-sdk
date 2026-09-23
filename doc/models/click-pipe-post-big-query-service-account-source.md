
# Click Pipe Post Big Query Service Account Source

## Structure

`ClickPipePostBigQueryServiceAccountSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SnapshotStagingPath` | `string` | Required | GCS bucket path for staging snapshot data (e.g., gs://my-bucket/staging/). Data will be automatically cleaned up after initial load. |
| `Settings` | [`ClickPipeBigQueryPipeSettings`](../../doc/models/click-pipe-big-query-pipe-settings.md) | Required | - |
| `TableMappings` | [`List<ClickPipeBigQueryPipeTableMapping>`](../../doc/models/click-pipe-big-query-pipe-table-mapping.md) | Required | Table mappings for BigQuery pipe. |
| `Authentication` | [`Authentication16?`](../../doc/models/authentication-16.md) | Optional | Authenticate with a Google Cloud service account JSON key. Defaults to SERVICE_ACCOUNT when omitted. |
| `ProjectId` | `string` | Optional | GCP project ID that owns the BigQuery resources. |
| `Credentials` | [`ServiceAccount`](../../doc/models/service-account.md) | Required | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipePostBigQueryServiceAccountSource clickPipePostBigQueryServiceAccountSource = new ClickPipePostBigQueryServiceAccountSource
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
    Credentials = new ServiceAccount
    {
        ServiceAccountFile = "serviceAccountFile6",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Authentication = Authentication16.ServiceAccount,
    ProjectId = "my-gcp-project",
};
```

