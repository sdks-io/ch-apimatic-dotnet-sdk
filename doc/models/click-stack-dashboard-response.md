
# Click Stack Dashboard Response

*This model accepts additional fields of type object.*

## Structure

`ClickStackDashboardResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Dashboard ID |
| `Name` | `string` | Optional | Dashboard name |
| `Tiles` | [`List<ClickStackTileOutput>`](../../doc/models/click-stack-tile-output.md) | Optional | List of tiles/charts in the dashboard |
| `Tags` | `List<string>` | Optional | Tags for organizing and filtering dashboards |
| `Filters` | [`List<ClickStackFilter>`](../../doc/models/click-stack-filter.md) | Optional | Dropdown filters added to the dashboard. Each one broadcasts its selected value as a condition, acts as a variable which can be referenced in tile queries, or both. |
| `SavedQuery` | `string` | Optional | Optional default dashboard query restored when loading the dashboard. |
| `SavedQueryLanguage` | [`SavedQueryLanguage?`](../../doc/models/saved-query-language.md) | Optional | Query language used by savedQuery. |
| `SavedFilterValues` | [`List<ClickStackSavedFilterValue>`](../../doc/models/containers/click-stack-saved-filter-value.md) | Optional | Optional default dashboard filter values restored when loading the dashboard. |
| `Containers` | [`List<ClickStackDashboardContainer>`](../../doc/models/click-stack-dashboard-container.md) | Optional | Optional grouping containers. Each tile may join a container via tile.containerId, and a tab inside it via tile.tabId. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackDashboardResponse clickStackDashboardResponse = new ClickStackDashboardResponse
{
    Id = "65f5e4a3b9e77c001a567890",
    Name = "Service Overview",
    Tiles = new List<ClickStackTileOutput>
    {
        new ClickStackTileOutput
        {
            Name = "name6",
            X = 0,
            Y = 72,
            W = 168,
            H = 16,
            Id = "id6",
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
            ContainerId = "containerId2",
            TabId = "tabId2",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    Tags = new List<string>
    {
        "production",
        "monitoring",
    },
    Filters = new List<ClickStackFilter>
    {
        new ClickStackFilter
        {
            Type = "type0",
            Name = "name0",
            Expression = "expression2",
            SourceId = "sourceId4",
            Id = "id0",
            SourceMetricType = SourceMetricType.Histogram,
            MWhere = "where4",
            WhereLanguage = WhereLanguage10.Sql,
            AppliesToSourceIds = new List<string>
            {
                "appliesToSourceIds1",
                "appliesToSourceIds2",
                "appliesToSourceIds3",
            },
            IsBroadcastEnabled = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackFilter
        {
            Type = "type0",
            Name = "name0",
            Expression = "expression2",
            SourceId = "sourceId4",
            Id = "id0",
            SourceMetricType = SourceMetricType.Histogram,
            MWhere = "where4",
            WhereLanguage = WhereLanguage10.Sql,
            AppliesToSourceIds = new List<string>
            {
                "appliesToSourceIds1",
                "appliesToSourceIds2",
                "appliesToSourceIds3",
            },
            IsBroadcastEnabled = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackFilter
        {
            Type = "type0",
            Name = "name0",
            Expression = "expression2",
            SourceId = "sourceId4",
            Id = "id0",
            SourceMetricType = SourceMetricType.Histogram,
            MWhere = "where4",
            WhereLanguage = WhereLanguage10.Sql,
            AppliesToSourceIds = new List<string>
            {
                "appliesToSourceIds1",
                "appliesToSourceIds2",
                "appliesToSourceIds3",
            },
            IsBroadcastEnabled = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    SavedQuery = "service.name = 'api'",
    SavedQueryLanguage = SavedQueryLanguage.Sql,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

