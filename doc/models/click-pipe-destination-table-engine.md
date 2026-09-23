
# Click Pipe Destination Table Engine

*This model accepts additional fields of type object.*

## Structure

`ClickPipeDestinationTableEngine`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type11?`](../../doc/models/type-11.md) | Optional | Engine type of the destination table. |
| `VersionColumnId` | `string` | Optional | Column name to use as version for ReplacingMergeTree engine. |
| `ColumnIds` | `List<string>` | Optional | Column names to sum for SummingMergeTree engine. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipeDestinationTableEngine clickPipeDestinationTableEngine = new ClickPipeDestinationTableEngine
{
    Type = Type11.MergeTree,
    VersionColumnId = "versionColumnId2",
    ColumnIds = new List<string>
    {
        "columnIds0",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

