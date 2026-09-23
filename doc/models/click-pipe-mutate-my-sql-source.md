
# Click Pipe Mutate My Sql Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipeMutateMySqlSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type9?`](../../doc/models/type-9.md) | Optional | Type of the MySQL source. Defaults to "mysql" if not specified. |
| `Credentials` | [`Plain`](../../doc/models/plain.md) | Optional | - |
| `Host` | `string` | Required | MySQL server hostname or IP address. To use a reverse private endpoint, pass the endpoint hostname here. |
| `Port` | `int` | Required | MySQL server port.<br><br>**Constraints**: `>= 1`, `<= 65535` |
| `Settings` | [`ClickPipeMySqlPipeSettings`](../../doc/models/click-pipe-my-sql-pipe-settings.md) | Required | - |
| `Authentication` | [`Authentication13?`](../../doc/models/authentication-13.md) | Optional | Authentication method for MySQL connection. |
| `IamRole` | `string` | Optional | IAM role ARN for IAM authentication (required for IAM_ROLE authentication). |
| `TlsHost` | `string` | Optional | TLS/SSL host for secure connections. |
| `CaCertificate` | `string` | Optional | PEM encoded CA certificate to validate the MySQL server certificate. |
| `DisableTls` | `bool?` | Optional | Disable TLS for the MySQL connection. Use with caution in production environments. Defaults to false when omitted.<br><br>**Default**: `false` |
| `SkipCertVerification` | `bool?` | Optional | Skip TLS certificate verification for the MySQL connection. Use with caution in production environments. |
| `ServerId` | `int?` | Optional | Optional MySQL server_id the pipe declares itself as in the MySQL replication topology. Must be unique across replicas connected to the source. If omitted, one is assigned automatically.<br><br>**Constraints**: `>= 1`, `<= 4294967295` |
| `TableMappings` | [`List<ClickPipeMySqlPipeTableMapping>`](../../doc/models/click-pipe-my-sql-pipe-table-mapping.md) | Required | List of table mappings defining which MySQL tables to replicate and how they map to ClickHouse tables. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipeMutateMySqlSource clickPipeMutateMySqlSource = new ClickPipeMutateMySqlSource
{
    Host = "my-mysql-server.example.com",
    Port = 3306,
    Settings = new ClickPipeMySqlPipeSettings
    {
        ReplicationMode = ReplicationMode.Cdc,
        SyncIntervalSeconds = 60,
        PullBatchSize = 1000,
        ReplicationMechanism = ReplicationMechanism.Gtid,
        UseCompression = false,
        AllowNullableColumns = false,
        InitialLoadParallelism = 1,
        SnapshotNumRowsPerPartition = 100000,
        SnapshotNumberOfParallelTables = 1,
        DeleteOnMerge = false,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    TableMappings = new List<ClickPipeMySqlPipeTableMapping>
    {
        new ClickPipeMySqlPipeTableMapping
        {
            SourceSchemaName = "my_database",
            SourceTable = "users",
            TargetTable = "my_database_users",
            ExcludedColumns = new List<string>
            {
                "internal_id",
                "temp_data",
            },
            UseCustomSortingKey = false,
            SortingKeys = new List<string>
            {
                "created_at_date",
                "event_id",
            },
            TableEngine = TableEngine.ReplacingMergeTree,
            PartitionKey = "id",
            PartitionByExpr = "toYYYYMM(created_at)",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Type = Type9.Rdsmysql,
    Credentials = new Plain
    {
        Username = "username4",
        Password = "password0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Authentication = Authentication13.Basic,
    IamRole = "arn:aws:iam::123456789012:role/MyApplicationRole",
    TlsHost = "my-mysql-server.example.com",
    CaCertificate = "-----BEGIN CERTIFICATE-----\n...",
    DisableTls = false,
    SkipCertVerification = false,
    ServerId = 4242,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

