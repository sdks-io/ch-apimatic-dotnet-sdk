
# Click Stack Tile Output

*This model accepts additional fields of type object.*

## Structure

`ClickStackTileOutput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Display name for the tile |
| `X` | `int` | Required | Horizontal position in the grid (0-based) |
| `Y` | `int` | Required | Vertical position in the grid (0-based) |
| `W` | `int` | Required | Width in grid units |
| `H` | `int` | Required | Height in grid units |
| `Config` | [`ClickStackTileConfig`](../../doc/models/containers/click-stack-tile-config.md) | Optional | - |
| `ContainerId` | `string` | Optional | References a DashboardContainer by id. Tiles without containerId render in the default ungrouped area. |
| `TabId` | `string` | Optional | References a tab inside the tile's container by id. Requires containerId to be set, and the container to declare a matching tab. |
| `Id` | `string` | Required | Unique tile ID assigned by the server. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackTileOutput clickStackTileOutput = new ClickStackTileOutput
{
    Name = "Error Rate",
    X = 0,
    Y = 0,
    W = 6,
    H = 3,
    Id = "65f5e4a3b9e77c001a901234",
    Config = ClickStackTileConfig.FromClickStackLineChartConfig(
        ClickStackLineChartConfig.FromClickStackLineBuilderChartConfig(
            new ClickStackLineBuilderChartConfig
            {
                DisplayType = "displayType2",
                SourceId = "sourceId0",
                MSelect = new List<ClickStackSelectItem>
                {
                    new ClickStackSelectItem
                    {
                        AggFn = AggFn3.Max,
                        ValueExpression = "valueExpression0",
                        MAlias = "alias4",
                        Level = Level.P50,
                        MWhere = "where6",
                        WhereLanguage = WhereLanguage4.Sql,
                        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                    },
                },
                GroupBy = "groupBy4",
                AsRatio = false,
                AlignDateRangeToGranularity = false,
                FillNulls = false,
                FitYAxisToData = false,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            }
        )
    ),
    ContainerId = "service-health",
    TabId = "errors",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

