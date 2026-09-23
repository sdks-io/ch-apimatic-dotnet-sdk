
# Click Pipe Mongo Db Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipeMongoDbSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uri` | `string` | Required | MongoDB connection URI. Supports both standard URIs (mongodb://...) and SRV URIs (mongodb+srv://...). Embedded credentials are redacted from API responses, so the returned value can differ from what was submitted. |
| `ReadPreference` | [`ReadPreference`](../../doc/models/read-preference.md) | Required | MongoDB read preference for replica set reads. |
| `TlsHost` | `string` | Optional | TLS/SSL host for secure connections. |
| `DisableTls` | `bool?` | Optional | Disable TLS for the MongoDB connection. Defaults to false (TLS enabled). |
| `SkipCertVerification` | `bool?` | Optional | Skip TLS certificate verification for the MongoDB connection. Use with caution in production environments. |
| `CaCertificate` | `string` | Optional | PEM encoded CA certificate to validate the MongoDB server certificate. |
| `Settings` | [`ClickPipeMongoDbPipeSettings`](../../doc/models/click-pipe-mongo-db-pipe-settings.md) | Optional | - |
| `TableMappings` | [`List<ClickPipeMongoDbPipeTableMapping>`](../../doc/models/click-pipe-mongo-db-pipe-table-mapping.md) | Optional | List of collection mappings defining which MongoDB collections to replicate and how they map to ClickHouse tables. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipeMongoDbSource clickPipeMongoDbSource = new ClickPipeMongoDbSource
{
    Uri = "mongodb+srv://cluster0.example.mongodb.net/mydb",
    ReadPreference = ReadPreference.SecondaryPreferred,
    TlsHost = "cluster0.example.mongodb.net",
    DisableTls = false,
    SkipCertVerification = false,
    CaCertificate = "-----BEGIN CERTIFICATE-----\n...",
    Settings = new ClickPipeMongoDbPipeSettings
    {
        ReplicationMode = ReplicationMode.Snapshot,
        SyncIntervalSeconds = 190,
        PullBatchSize = 248,
        InitialLoadParallelism = 214,
        SnapshotNumRowsPerPartition = 1000,
        SnapshotNumberOfParallelTables = 16,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

