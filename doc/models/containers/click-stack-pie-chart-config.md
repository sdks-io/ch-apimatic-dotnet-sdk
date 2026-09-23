
# Click Stack Pie Chart Config

## Class Name

`ClickStackPieChartConfig`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackPieBuilderChartConfig`](../../../doc/models/click-stack-pie-builder-chart-config.md) | ClickStackPieChartConfig.FromClickStackPieBuilderChartConfig(ClickStackPieBuilderChartConfig clickStackPieBuilderChartConfig) |
| [`ClickStackPieRawSqlChartConfig`](../../../doc/models/click-stack-pie-raw-sql-chart-config.md) | ClickStackPieChartConfig.FromClickStackPieRawSqlChartConfig(ClickStackPieRawSqlChartConfig clickStackPieRawSqlChartConfig) |

## ClickStackPieBuilderChartConfig

### Initialization Code

#### Example

```csharp
ClickStackPieChartConfig value = ClickStackPieChartConfig.FromClickStackPieBuilderChartConfig(
    new ClickStackPieBuilderChartConfig
    {
        DisplayType = "pie",
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
        OrderBy = "\"Count\" DESC",
        Limit = 10,
    }
);
```

## ClickStackPieRawSqlChartConfig

### Initialization Code

#### Example

```csharp
ClickStackPieChartConfig value = ClickStackPieChartConfig.FromClickStackPieRawSqlChartConfig(
    new ClickStackPieRawSqlChartConfig
    {
        ConfigType = "sql",
        ConnectionId = "65f5e4a3b9e77c001a567890",
        SqlTemplate = "SELECT count() FROM otel_logs WHERE timestamp > now() - INTERVAL 1 HOUR",
        DisplayType = "pie",
        SourceId = "65f5e4a3b9e77c001a567890",
    }
);
```

