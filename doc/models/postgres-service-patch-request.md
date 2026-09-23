
# Postgres Service Patch Request

*This model accepts additional fields of type object.*

## Structure

`PostgresServicePatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the Postgres service. Alphanumerical string with whitespaces up to 50 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `50` |
| `Size` | [`VmSize?`](../../doc/models/vm-size.md) | Optional | The VM size for a Postgres service. |
| `HaType` | [`PgHaType?`](../../doc/models/pg-ha-type.md) | Optional | Type of high availability: “none” for no replication, “async” for asynchronous replication to a single standby, and “sync” for synchronous replication to two standbys. |
| `Tags` | [`List<ResourceTagsV1>`](../../doc/models/resource-tags-v1.md) | Optional | Tags associated with the Postgres service. Tag keys starting with “chc_” are reserved for internal use.<br><br>**Constraints**: *Maximum Items*: `50` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

PostgresServicePatchRequest postgresServicePatchRequest = new PostgresServicePatchRequest
{
    Name = "name2",
    Size = VmSize.EnumI8G4Xlarge,
    HaType = PgHaType.Sync,
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

