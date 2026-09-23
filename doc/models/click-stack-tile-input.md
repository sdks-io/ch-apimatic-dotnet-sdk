
# Click Stack Tile Input

*This model accepts additional fields of type object.*

## Structure

`ClickStackTileInput`

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
| `Id` | `string` | Optional | Optional tile ID. Omit to generate a new ID. |
| `AsRatio` | `bool?` | Optional | Display two series as a ratio (series[0] / series[1]). Only applicable when providing "series". Deprecated in favor of "config.asRatio". |
| `Series` | [`List<ClickStackDashboardChartSeries>`](../../doc/models/containers/click-stack-dashboard-chart-series.md) | Optional | Data series to display in this tile (all must be the same type). Deprecated; use "config" instead. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackTileInput clickStackTileInput = new ClickStackTileInput
{
    Name = "Error Rate",
    X = 0,
    Y = 0,
    W = 6,
    H = 3,
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
    Id = "65f5e4a3b9e77c001a901234",
    AsRatio = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

