
# Click Pipe Mutate Mongo Db Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipeMutateMongoDbSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Plain`](../../doc/models/plain.md) | Optional | - |
| `Uri` | `string` | Required | MongoDB connection URI. Supports both standard URIs (mongodb://...) and SRV URIs (mongodb+srv://...). Embedded credentials are redacted from API responses, so the returned value can differ from what was submitted. |
| `ReadPreference` | [`ReadPreference`](../../doc/models/read-preference.md) | Required | MongoDB read preference for replica set reads. |
| `TlsHost` | `string` | Optional | TLS/SSL host for secure connections. |
| `DisableTls` | `bool?` | Optional | Disable TLS for the MongoDB connection. Defaults to false (TLS enabled).<br><br>**Default**: `false` |
| `SkipCertVerification` | `bool?` | Optional | Skip TLS certificate verification for the MongoDB connection. Use with caution in production environments. |
| `CaCertificate` | `string` | Optional | PEM encoded CA certificate to validate the MongoDB server certificate. |
| `Settings` | [`ClickPipeMongoDbPipeSettings`](../../doc/models/click-pipe-mongo-db-pipe-settings.md) | Required | - |
| `TableMappings` | [`List<ClickPipeMongoDbPipeTableMapping>`](../../doc/models/click-pipe-mongo-db-pipe-table-mapping.md) | Required | List of collection mappings defining which MongoDB collections to replicate and how they map to ClickHouse tables. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipeMutateMongoDbSource clickPipeMutateMongoDbSource = new ClickPipeMutateMongoDbSource
{
    Uri = "mongodb+srv://cluster0.example.mongodb.net/mydb",
    ReadPreference = ReadPreference.SecondaryPreferred,
    Settings = new ClickPipeMongoDbPipeSettings
    {
        ReplicationMode = ReplicationMode.Cdc,
        SyncIntervalSeconds = 60,
        PullBatchSize = 100000,
        InitialLoadParallelism = 1,
        SnapshotNumRowsPerPartition = 100000,
        SnapshotNumberOfParallelTables = 1,
        DeleteOnMerge = false,
        UseJsonNativeFormat = true,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    TableMappings = new List<ClickPipeMongoDbPipeTableMapping>
    {
        new ClickPipeMongoDbPipeTableMapping
        {
            SourceDatabaseName = "mydb",
            SourceCollection = "users",
            TargetTable = "mydb_users",
            TableEngine = TableEngine.ReplacingMergeTree,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Credentials = new Plain
    {
        Username = "username4",
        Password = "password0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    TlsHost = "cluster0.example.mongodb.net",
    DisableTls = false,
    SkipCertVerification = false,
    CaCertificate = "-----BEGIN CERTIFICATE-----\n...",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

