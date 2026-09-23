
# Click Stack Create Dashboard Request

*This model accepts additional fields of type object.*

## Structure

`ClickStackCreateDashboardRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Dashboard name. |
| `Tiles` | [`List<ClickStackTileInput>`](../../doc/models/click-stack-tile-input.md) | Required | List of tiles/charts to include in the dashboard. |
| `Tags` | `List<string>` | Optional | Tags for organizing and filtering dashboards. |
| `Filters` | [`List<ClickStackFilterInput>`](../../doc/models/click-stack-filter-input.md) | Optional | Dropdown filters added to the dashboard. Each one broadcasts its selected value as a condition, acts as a variable which can be referenced in tile queries, or both. |
| `SavedQuery` | `string` | Optional | Optional default dashboard query to persist on the dashboard. |
| `SavedQueryLanguage` | [`SavedQueryLanguage?`](../../doc/models/saved-query-language.md) | Optional | Query language used by savedQuery. |
| `SavedFilterValues` | [`List<ClickStackSavedFilterValue>`](../../doc/models/containers/click-stack-saved-filter-value.md) | Optional | Optional default dashboard filter values to persist on the dashboard. |
| `Containers` | [`List<ClickStackDashboardContainer>`](../../doc/models/click-stack-dashboard-container.md) | Optional | Optional grouping containers. Each tile may join a container via tile.containerId, and a tab inside it via tile.tabId. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackCreateDashboardRequest clickStackCreateDashboardRequest = new ClickStackCreateDashboardRequest
{
    Name = "New Dashboard",
    Tiles = new List<ClickStackTileInput>
    {
        new ClickStackTileInput
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
        },
    },
    Tags = new List<string>
    {
        "development",
    },
    Filters = new List<ClickStackFilterInput>
    {
        new ClickStackFilterInput
        {
            Type = "type0",
            Name = "name0",
            Expression = "expression2",
            SourceId = "sourceId4",
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
        new ClickStackFilterInput
        {
            Type = "type0",
            Name = "name0",
            Expression = "expression2",
            SourceId = "sourceId4",
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
        new ClickStackFilterInput
        {
            Type = "type0",
            Name = "name0",
            Expression = "expression2",
            SourceId = "sourceId4",
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
    SavedFilterValues = new List<ClickStackSavedFilterValue>
    {
        ClickStackSavedFilterValue.FromClickStackSqlSavedFilterValue(
            new ClickStackSqlSavedFilterValue
            {
                Condition = "condition4",
                Type = Type18.Sql,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            }
        ),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

