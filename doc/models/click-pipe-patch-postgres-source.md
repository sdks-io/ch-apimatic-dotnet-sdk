
# Click Pipe Patch Postgres Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchPostgresSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Plain`](../../doc/models/plain.md) | Optional | - |
| `Host` | `string` | Optional | PostgreSQL server hostname or IP address. To use a reverse private endpoint, pass the endpoint hostname here. |
| `Port` | `int?` | Optional | PostgreSQL server port.<br><br>**Constraints**: `>= 1`, `<= 65535` |
| `Database` | `string` | Optional | PostgreSQL database name to replicate from. |
| `TlsHost` | `string` | Optional | TLS/SSL host for secure connections. |
| `CaCertificate` | `string` | Optional | PEM encoded CA certificate to validate the Postgres server certificate. |
| `DisableTls` | `bool?` | Optional | Disable TLS for the Postgres connection. Use with caution in production environments. |
| `SkipCertVerification` | `bool?` | Optional | Skip TLS certificate verification for the Postgres connection. Use with caution in production environments. |
| `Settings` | [`ClickPipePatchPostgresPipeSettings`](../../doc/models/click-pipe-patch-postgres-pipe-settings.md) | Optional | - |
| `TableMappingsToAdd` | [`List<ClickPipePostgresPipeTableMapping>`](../../doc/models/click-pipe-postgres-pipe-table-mapping.md) | Optional | Table mappings to add to the pipe. Can be an empty array if no tables are being added.<br><br>**Constraints**: *Minimum Items*: `0` |
| `TableMappingsToRemove` | [`List<ClickPipePatchPostgresPipeRemoveTableMapping>`](../../doc/models/click-pipe-patch-postgres-pipe-remove-table-mapping.md) | Optional | Table mappings to remove from the pipe. Only sourceSchemaName, sourceTable, and targetTable are required for removal.<br><br>**Constraints**: *Minimum Items*: `0` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePatchPostgresSource clickPipePatchPostgresSource = new ClickPipePatchPostgresSource
{
    Credentials = new Plain
    {
        Username = "username4",
        Password = "password0",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Host = "my-postgres-server.example.com",
    Port = 5432,
    Database = "production_db",
    TlsHost = "my-postgres-server.example.com",
    CaCertificate = "-----BEGIN CERTIFICATE-----\n...",
    DisableTls = false,
    SkipCertVerification = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

