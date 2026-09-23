
# Click Stack Number Chart Config

## Class Name

`ClickStackNumberChartConfig`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackNumberBuilderChartConfig`](../../../doc/models/click-stack-number-builder-chart-config.md) | ClickStackNumberChartConfig.FromClickStackNumberBuilderChartConfig(ClickStackNumberBuilderChartConfig clickStackNumberBuilderChartConfig) |
| [`ClickStackNumberRawSqlChartConfig`](../../../doc/models/click-stack-number-raw-sql-chart-config.md) | ClickStackNumberChartConfig.FromClickStackNumberRawSqlChartConfig(ClickStackNumberRawSqlChartConfig clickStackNumberRawSqlChartConfig) |

## ClickStackNumberBuilderChartConfig

### Initialization Code

#### Example

```csharp
ClickStackNumberChartConfig value = ClickStackNumberChartConfig.FromClickStackNumberBuilderChartConfig(
    new ClickStackNumberBuilderChartConfig
    {
        DisplayType = "number",
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
    }
);
```

## ClickStackNumberRawSqlChartConfig

### Initialization Code

#### Example

```csharp
ClickStackNumberChartConfig value = ClickStackNumberChartConfig.FromClickStackNumberRawSqlChartConfig(
    new ClickStackNumberRawSqlChartConfig
    {
        ConfigType = "sql",
        ConnectionId = "65f5e4a3b9e77c001a567890",
        SqlTemplate = "SELECT count() FROM otel_logs WHERE timestamp > now() - INTERVAL 1 HOUR",
        DisplayType = "number",
        SourceId = "65f5e4a3b9e77c001a567890",
    }
);
```

