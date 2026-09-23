
# Base Postgres Service

*This model accepts additional fields of type object.*

## Structure

`BasePostgresService`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the Postgres service. Alphanumerical string with whitespaces up to 50 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `50` |
| `Provider` | [`CloudProvider?`](../../doc/models/cloud-provider.md) | Optional | The cloud provider for a Postgres service. |
| `Region` | `string` | Optional | The cloud region for a Postgres service. |
| `PostgresVersion` | [`PostgresMajorVersion?`](../../doc/models/postgres-major-version.md) | Optional | - |
| `Size` | [`VmSize?`](../../doc/models/vm-size.md) | Optional | The VM size for a Postgres service. |
| `HaType` | [`PgHaType?`](../../doc/models/pg-ha-type.md) | Optional | Type of high availability: “none” for no replication, “async” for asynchronous replication to a single standby, and “sync” for synchronous replication to two standbys. |
| `Tags` | [`List<ResourceTagsV1>`](../../doc/models/resource-tags-v1.md) | Optional | Tags associated with the Postgres service. Tag keys starting with “chc_” are reserved for internal use.<br><br>**Constraints**: *Maximum Items*: `50` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

BasePostgresService basePostgresService = new BasePostgresService
{
    Name = "name8",
    Provider = CloudProvider.Aws,
    Region = "region4",
    PostgresVersion = PostgresMajorVersion.Postgres18,
    Size = VmSize.C4Ahighmem48,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

