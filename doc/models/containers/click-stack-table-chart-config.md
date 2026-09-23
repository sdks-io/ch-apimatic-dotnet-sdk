
# Click Stack Table Chart Config

## Class Name

`ClickStackTableChartConfig`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackTableBuilderChartConfig`](../../../doc/models/click-stack-table-builder-chart-config.md) | ClickStackTableChartConfig.FromClickStackTableBuilderChartConfig(ClickStackTableBuilderChartConfig clickStackTableBuilderChartConfig) |
| [`ClickStackTableRawSqlChartConfig`](../../../doc/models/click-stack-table-raw-sql-chart-config.md) | ClickStackTableChartConfig.FromClickStackTableRawSqlChartConfig(ClickStackTableRawSqlChartConfig clickStackTableRawSqlChartConfig) |

## ClickStackTableBuilderChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTableChartConfig value = ClickStackTableChartConfig.FromClickStackTableBuilderChartConfig(
    new ClickStackTableBuilderChartConfig
    {
        DisplayType = "table",
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
        Having = "count > 100",
        OrderBy = "count DESC",
        AsRatio = false,
        GroupByColumnsOnLeft = false,
    }
);
```

## ClickStackTableRawSqlChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTableChartConfig value = ClickStackTableChartConfig.FromClickStackTableRawSqlChartConfig(
    new ClickStackTableRawSqlChartConfig
    {
        ConfigType = "sql",
        ConnectionId = "65f5e4a3b9e77c001a567890",
        SqlTemplate = "SELECT count() FROM otel_logs WHERE timestamp > now() - INTERVAL 1 HOUR",
        DisplayType = "table",
        SourceId = "65f5e4a3b9e77c001a567890",
    }
);
```

