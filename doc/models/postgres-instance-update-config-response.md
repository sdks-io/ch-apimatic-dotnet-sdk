
# Postgres Instance Update Config Response

*This model accepts additional fields of type object.*

## Structure

`PostgresInstanceUpdateConfigResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PgConfig` | [`PostgresConfiguration`](../../doc/models/postgres-configuration.md) | Required | Postgres [runtime configuration](https://www.postgresql.org/docs/current/runtime-config.html) configuration. |
| `PgBouncerConfig` | `Dictionary<string, string>` | Required | PgBouncer [runtime configuration](https://www.pgbouncer.org/config.html) configuration. |
| `Message` | `string` | Optional | Informational message about the configuration update, such as restart requirements. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

PostgresInstanceUpdateConfigResponse postgresInstanceUpdateConfigResponse = new PostgresInstanceUpdateConfigResponse
{
    PgConfig = new PostgresConfiguration
    {
        MaxConnections = PostgresConfigurationMaxConnections.FromNumber(100),
        DefaultTransactionIsolation = DefaultTransactionIsolation.EnumReadCommitted,
        SslMinProtocolVersion = SslMinProtocolVersion.EnumTlSv12,
        MaintenanceWorkMem = PostgresConfigurationMaintenanceWorkMem.FromString("String3"),
        WorkMem = PostgresConfigurationWorkMem.FromString("String7"),
    },
    PgBouncerConfig = new Dictionary<string, string>
    {
        ["default_pool_size"] = "16",
    },
    Message = "message4",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

