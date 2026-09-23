
# Postgres Service Read Replica Request

*This model accepts additional fields of type object.*

## Structure

`PostgresServiceReadReplicaRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name of the Postgres service. Alphanumerical string with whitespaces up to 50 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `50` |
| `PgConfig` | [`PostgresConfiguration`](../../doc/models/postgres-configuration.md) | Optional | Postgres [runtime configuration](https://www.postgresql.org/docs/current/runtime-config.html) configuration. |
| `PgBouncerConfig` | `Dictionary<string, string>` | Optional | PgBouncer [runtime configuration](https://www.pgbouncer.org/config.html) configuration. |
| `Tags` | [`List<ResourceTagsV1>`](../../doc/models/resource-tags-v1.md) | Optional | Tags associated with the Postgres service. Tag keys starting with “chc_” are reserved for internal use.<br><br>**Constraints**: *Maximum Items*: `50` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

PostgresServiceReadReplicaRequest postgresServiceReadReplicaRequest = new PostgresServiceReadReplicaRequest
{
    Name = "name6",
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
    Tags = new List<ResourceTagsV1>
    {
        new ResourceTagsV1
        {
            Key = "key0",
            MValue = "value2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ResourceTagsV1
        {
            Key = "key0",
            MValue = "value2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

