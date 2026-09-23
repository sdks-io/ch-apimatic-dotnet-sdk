
# Click Stack Line Chart Config

## Class Name

`ClickStackLineChartConfig`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackLineBuilderChartConfig`](../../../doc/models/click-stack-line-builder-chart-config.md) | ClickStackLineChartConfig.FromClickStackLineBuilderChartConfig(ClickStackLineBuilderChartConfig clickStackLineBuilderChartConfig) |
| [`ClickStackLineRawSqlChartConfig`](../../../doc/models/click-stack-line-raw-sql-chart-config.md) | ClickStackLineChartConfig.FromClickStackLineRawSqlChartConfig(ClickStackLineRawSqlChartConfig clickStackLineRawSqlChartConfig) |

## ClickStackLineBuilderChartConfig

### Initialization Code

#### Example

```csharp
ClickStackLineChartConfig value = ClickStackLineChartConfig.FromClickStackLineBuilderChartConfig(
    new ClickStackLineBuilderChartConfig
    {
        DisplayType = "line",
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
        GroupBy = "host",
        SeriesLimit = 5,
    }
);
```

## ClickStackLineRawSqlChartConfig

### Initialization Code

#### Example

```csharp
ClickStackLineChartConfig value = ClickStackLineChartConfig.FromClickStackLineRawSqlChartConfig(
    new ClickStackLineRawSqlChartConfig
    {
        ConfigType = "sql",
        ConnectionId = "65f5e4a3b9e77c001a567890",
        SqlTemplate = "SELECT count() FROM otel_logs WHERE timestamp > now() - INTERVAL 1 HOUR",
        DisplayType = "line",
        SourceId = "65f5e4a3b9e77c001a567890",
    }
);
```

