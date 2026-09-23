
# Click Pipe Patch Destination

*This model accepts additional fields of type object.*

## Structure

`ClickPipePatchDestination`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Columns` | [`List<ClickPipeDestinationColumn>`](../../doc/models/click-pipe-destination-column.md) | Optional | Columns of the destination table. This will not update the table schema, only the ClickPipe configuration. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickPipePatchDestination clickPipePatchDestination = new ClickPipePatchDestination
{
    Columns = new List<ClickPipeDestinationColumn>
    {
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

