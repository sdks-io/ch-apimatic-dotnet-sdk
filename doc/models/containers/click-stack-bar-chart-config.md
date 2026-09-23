
# Click Stack Bar Chart Config

## Class Name

`ClickStackBarChartConfig`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackBarBuilderChartConfig`](../../../doc/models/click-stack-bar-builder-chart-config.md) | ClickStackBarChartConfig.FromClickStackBarBuilderChartConfig(ClickStackBarBuilderChartConfig clickStackBarBuilderChartConfig) |
| [`ClickStackBarRawSqlChartConfig`](../../../doc/models/click-stack-bar-raw-sql-chart-config.md) | ClickStackBarChartConfig.FromClickStackBarRawSqlChartConfig(ClickStackBarRawSqlChartConfig clickStackBarRawSqlChartConfig) |

## ClickStackBarBuilderChartConfig

### Initialization Code

#### Example

```csharp
ClickStackBarChartConfig value = ClickStackBarChartConfig.FromClickStackBarBuilderChartConfig(
    new ClickStackBarBuilderChartConfig
    {
        DisplayType = "stacked_bar",
        SourceId = "65f5e4a3b9e77c001a111111",
        MSelect = new List<ClickStackSelectItem>
        {
            new ClickStackSelectItem
            {
                AggFn = AggFn3.Count,
                ValueExpression = "Duration",
                MAlias = "Request Duration",
                MWhere = "service:api",
                MetricName = "http.server.duration",
                PeriodAggFn = PeriodAggFn.Delta,
            },
        },
        GroupBy = "service",
        SeriesLimit = 5,
    }
);
```

## ClickStackBarRawSqlChartConfig

### Initialization Code

#### Example

```csharp
ClickStackBarChartConfig value = ClickStackBarChartConfig.FromClickStackBarRawSqlChartConfig(
    new ClickStackBarRawSqlChartConfig
    {
        ConfigType = "sql",
        ConnectionId = "65f5e4a3b9e77c001a567890",
        SqlTemplate = "SELECT count() FROM otel_logs WHERE timestamp > now() - INTERVAL 1 HOUR",
        DisplayType = "stacked_bar",
        SourceId = "65f5e4a3b9e77c001a567890",
    }
);
```

