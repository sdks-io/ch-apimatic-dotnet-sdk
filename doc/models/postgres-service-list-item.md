
# Postgres Service List Item

*This model accepts additional fields of type object.*

## Structure

`PostgresServiceListItem`

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
| `Id` | `Guid?` | Optional | - |
| `State` | [`PostgresServiceState?`](../../doc/models/postgres-service-state.md) | Optional | Current state of the service |
| `CreatedAt` | `DateTime?` | Optional | - |
| `IsPrimary` | `bool?` | Optional | True if this service is the primary service in the data warehouse<br><br>**Default**: `false` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

PostgresServiceListItem postgresServiceListItem = new PostgresServiceListItem
{
    Name = "name4",
    Provider = CloudProvider.Aws,
    Region = "region0",
    PostgresVersion = PostgresMajorVersion.Postgres18,
    Size = VmSize.EnumR8Gd8Xlarge,
    Id = new Guid("f71df78e-ddad-82d0-8dfa-abbec741b82e"),
    CreatedAt = DateTime.ParseExact("2026-03-26T20:51:16.384Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    IsPrimary = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

