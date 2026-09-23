
# V1 Organizations Services Clickstack Dashboards Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickstackDashboardsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickStackDashboardResponse`](../../doc/models/click-stack-dashboard-response.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickstackDashboardsResponse1 v1OrganizationsServicesClickstackDashboardsResponse1 = new V1OrganizationsServicesClickstackDashboardsResponse1
{
    Status = 200,
    RequestId = new Guid("00002262-0000-0000-0000-000000000000"),
    Result = new ClickStackDashboardResponse
    {
        Id = "id6",
        Name = "name6",
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
            "tags1",
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
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

