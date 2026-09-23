
# Click Pipe Settings Put Request

*This model accepts additional fields of type object.*

## Structure

`ClickPipeSettingsPutRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `StreamingMaxInsertWaitMs` | `int?` | Optional | Streaming max insert wait time. Configures the max wait period before inserting data into the ClickHouse.<br><br>**Constraints**: `>= 500`, `<= 60000` |
| `ObjectStorageConcurrency` | `int?` | Optional | Object storage concurrency. Number of concurrent file processing threads<br><br>**Constraints**: `>= 1`, `<= 35` |
| `ObjectStoragePollingIntervalMs` | `int?` | Optional | Object storage polling interval. Configures the refresh interval for querying continuous ingest for new object storage data<br><br>**Constraints**: `>= 100`, `<= 3600000` |
| `ObjectStorageMaxInsertBytes` | `long?` | Optional | Max insert bytes. Number of bytes to process in a single insert batch<br><br>**Constraints**: `>= 524288000`, `<= 10737418240` |
| `ObjectStorageMaxFileCount` | `int?` | Optional | Max file count. Maximum number of files to process in a single insert batch<br><br>**Constraints**: `>= 1`, `<= 10000` |
| `ClickhouseMaxThreads` | `int?` | Optional | Max threads. Maximum number of concurrent threads for file processing<br><br>**Constraints**: `>= 0`, `<= 64` |
| `ClickhouseMaxInsertThreads` | `int?` | Optional | Max insert threads. Maximum number of concurrent insert threads<br><br>**Constraints**: `>= 0`, `<= 16` |
| `ClickhouseMinInsertBlockSizeBytes` | `int?` | Optional | Min insert block size bytes. Minimum size of data block for insert (in bytes)<br><br>**Constraints**: `>= 0`, `<= 10737418240` |
| `ClickhouseMaxDownloadThreads` | `int?` | Optional | Max download threads. Maximum number of concurrent download threads<br><br>**Constraints**: `>= 0`, `<= 32` |
| `ClickhouseParallelDistributedInsertSelect` | `int?` | Optional | Parallel distributed insert select. Parallel distributed insert select setting<br><br>**Constraints**: `>= 0`, `<= 2` |
| `KafkaReadCommitted` | `bool?` | Optional | Kafka Read Committed. Whether Kafka consumers read only committed messages |
| `ObjectStorageUseClusterFunction` | `bool?` | Optional | use cluster function. Whether to use ClickHouse cluster function for distributed processing |
| `ClickhouseParallelViewProcessing` | `bool?` | Optional | parallel view processing. Whether to enable pushing to attached views concurrently instead of sequentially |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeSettingsPutRequest clickPipeSettingsPutRequest = new ClickPipeSettingsPutRequest
{
    StreamingMaxInsertWaitMs = 5000,
    ObjectStorageConcurrency = 1,
    ObjectStoragePollingIntervalMs = 30000,
    ObjectStorageMaxInsertBytes = 10737418240L,
    ObjectStorageMaxFileCount = 100,
    ClickhouseMaxThreads = 8,
    ClickhouseMaxInsertThreads = 1,
    ClickhouseMinInsertBlockSizeBytes = 1073741824,
    ClickhouseMaxDownloadThreads = 4,
    ClickhouseParallelDistributedInsertSelect = 2,
    KafkaReadCommitted = false,
    ObjectStorageUseClusterFunction = true,
    ClickhouseParallelViewProcessing = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

