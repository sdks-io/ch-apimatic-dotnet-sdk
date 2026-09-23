
# Click Pipe Postgres Source

*This model accepts additional fields of type object.*

## Structure

`ClickPipePostgresSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type7?`](../../doc/models/type-7.md) | Optional | Type of the Postgres source. Defaults to "postgres" if not specified. |
| `Host` | `string` | Optional | PostgreSQL server hostname or IP address. To use a reverse private endpoint, pass the endpoint hostname here. |
| `Port` | `int?` | Optional | PostgreSQL server port.<br><br>**Constraints**: `>= 1`, `<= 65535` |
| `Database` | `string` | Optional | PostgreSQL database name to replicate from. |
| `Authentication` | [`Authentication11?`](../../doc/models/authentication-11.md) | Optional | Authentication method for Postgres connection. |
| `IamRole` | `string` | Optional | IAM role ARN for IAM authentication (required for IAM_ROLE authentication). |
| `TlsHost` | `string` | Optional | TLS/SSL host for secure connections. |
| `CaCertificate` | `string` | Optional | PEM encoded CA certificate to validate the Postgres server certificate. |
| `DisableTls` | `bool?` | Optional | Disable TLS for the Postgres connection. Use with caution in production environments. |
| `SkipCertVerification` | `bool?` | Optional | Skip TLS certificate verification for the Postgres connection. Use with caution in production environments. |
| `Settings` | [`ClickPipePostgresPipeSettings`](../../doc/models/click-pipe-postgres-pipe-settings.md) | Optional | - |
| `TableMappings` | [`List<ClickPipePostgresPipeTableMapping>`](../../doc/models/click-pipe-postgres-pipe-table-mapping.md) | Optional | List of table mappings defining which PostgreSQL tables to replicate and how they map to ClickHouse tables. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickPipePostgresSource clickPipePostgresSource = new ClickPipePostgresSource
{
    Type = Type7.Neon,
    Host = "my-postgres-server.example.com",
    Port = 5432,
    Database = "production_db",
    Authentication = Authentication11.IamRole,
    IamRole = "arn:aws:iam::123456789012:role/MyApplicationRole",
    TlsHost = "my-postgres-server.example.com",
    CaCertificate = "-----BEGIN CERTIFICATE-----\n...",
    DisableTls = false,
    SkipCertVerification = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

