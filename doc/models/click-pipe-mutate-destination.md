
# Click Pipe Mutate Destination

*This model accepts additional fields of type object.*

## Structure

`ClickPipeMutateDestination`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Database` | `string` | Optional | Destination database. |
| `Table` | `string` | Optional | Destination table. Required field for all pipe types except database pipes (Postgres, MySQL, BigQuery). |
| `ManagedTable` | `bool?` | Optional | Is the table managed by ClickPipes? Required field for all pipe types except database pipes (Postgres, MySQL, BigQuery). |
| `TableDefinition` | [`ClickPipeDestinationTableDefinition`](../../doc/models/click-pipe-destination-table-definition.md) | Optional | - |
| `Columns` | [`List<ClickPipeDestinationColumn>`](../../doc/models/click-pipe-destination-column.md) | Optional | Columns of the destination table. Required field for all pipe types except database pipes (Postgres, MySQL, BigQuery). |
| `Roles` | `List<string>` | Optional | Optional. Roles to grant to the ClickHouse user that ClickPipe creates. If omitted, the user is granted the default role (`default_role`). Add your custom roles here if required. The role names `clickpipes` and `clickpipes_system` are reserved for internal use and cannot be assigned. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipeMutateDestination clickPipeMutateDestination = new ClickPipeMutateDestination
{
    Database = "database8",
    Table = "table4",
    ManagedTable = false,
    TableDefinition = new ClickPipeDestinationTableDefinition
    {
        Engine = new ClickPipeDestinationTableEngine
        {
            Type = Type11.MergeTree,
            VersionColumnId = "versionColumnId2",
            ColumnIds = new List<string>
            {
                "columnIds0",
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        SortingKey = new List<string>
        {
            "sortingKey0",
        },
        PartitionBy = "partitionBy0",
        PrimaryKey = "primaryKey2",
        Ttl = "ttl2",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Columns = new List<ClickPipeDestinationColumn>
    {
        new ClickPipeDestinationColumn
        {
            Name = "name0",
            Type = "type0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickPipeDestinationColumn
        {
            Name = "name0",
            Type = "type0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickPipeDestinationColumn
        {
            Name = "name0",
            Type = "type0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

