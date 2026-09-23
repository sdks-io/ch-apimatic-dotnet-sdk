
# Click Stack Categorical Bar Chart Config

## Class Name

`ClickStackCategoricalBarChartConfig`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackCategoricalBarBuilderChartConfig`](../../../doc/models/click-stack-categorical-bar-builder-chart-config.md) | ClickStackCategoricalBarChartConfig.FromClickStackCategoricalBarBuilderChartConfig(ClickStackCategoricalBarBuilderChartConfig clickStackCategoricalBarBuilderChartConfig) |
| [`ClickStackCategoricalBarRawSqlChartConfig`](../../../doc/models/click-stack-categorical-bar-raw-sql-chart-config.md) | ClickStackCategoricalBarChartConfig.FromClickStackCategoricalBarRawSqlChartConfig(ClickStackCategoricalBarRawSqlChartConfig clickStackCategoricalBarRawSqlChartConfig) |

## ClickStackCategoricalBarBuilderChartConfig

### Initialization Code

#### Example

```csharp
ClickStackCategoricalBarChartConfig value = ClickStackCategoricalBarChartConfig.FromClickStackCategoricalBarBuilderChartConfig(
    new ClickStackCategoricalBarBuilderChartConfig
    {
        DisplayType = "bar",
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

## ClickStackCategoricalBarRawSqlChartConfig

### Initialization Code

#### Example

```csharp
ClickStackCategoricalBarChartConfig value = ClickStackCategoricalBarChartConfig.FromClickStackCategoricalBarRawSqlChartConfig(
    new ClickStackCategoricalBarRawSqlChartConfig
    {
        ConfigType = "sql",
        ConnectionId = "65f5e4a3b9e77c001a567890",
        SqlTemplate = "SELECT count() FROM otel_logs WHERE timestamp > now() - INTERVAL 1 HOUR",
        DisplayType = "bar",
        SourceId = "65f5e4a3b9e77c001a567890",
    }
);
```

