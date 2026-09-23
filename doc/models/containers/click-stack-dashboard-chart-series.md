
# Click Stack Dashboard Chart Series

## Class Name

`ClickStackDashboardChartSeries`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackTimeChartSeries`](../../../doc/models/click-stack-time-chart-series.md) | ClickStackDashboardChartSeries.FromClickStackTimeChartSeries(ClickStackTimeChartSeries clickStackTimeChartSeries) |
| [`ClickStackTableChartSeries`](../../../doc/models/click-stack-table-chart-series.md) | ClickStackDashboardChartSeries.FromClickStackTableChartSeries(ClickStackTableChartSeries clickStackTableChartSeries) |
| [`ClickStackNumberChartSeries`](../../../doc/models/click-stack-number-chart-series.md) | ClickStackDashboardChartSeries.FromClickStackNumberChartSeries(ClickStackNumberChartSeries clickStackNumberChartSeries) |
| [`ClickStackSearchChartSeries`](../../../doc/models/click-stack-search-chart-series.md) | ClickStackDashboardChartSeries.FromClickStackSearchChartSeries(ClickStackSearchChartSeries clickStackSearchChartSeries) |
| [`ClickStackMarkdownChartSeries`](../../../doc/models/click-stack-markdown-chart-series.md) | ClickStackDashboardChartSeries.FromClickStackMarkdownChartSeries(ClickStackMarkdownChartSeries clickStackMarkdownChartSeries) |

## ClickStackTimeChartSeries

### Initialization Code

#### Example

```csharp
ClickStackDashboardChartSeries value = ClickStackDashboardChartSeries.FromClickStackTimeChartSeries(
    new ClickStackTimeChartSeries
    {
        Type = "time",
        SourceId = "65f5e4a3b9e77c001a567890",
        AggFn = AggFn.Count,
        MWhere = "service:api",
        WhereLanguage = WhereLanguage.Lucene,
        GroupBy = new List<string>
        {
            "host",
        },
        Level = 0.95,
        Field = "duration",
        MAlias = "Request Duration",
        MetricDataType = MetricDataType.Sum,
        MetricName = "http.server.duration",
        DisplayType = DisplayType.Line,
    }
);
```

## ClickStackTableChartSeries

### Initialization Code

#### Example

```csharp
ClickStackDashboardChartSeries value = ClickStackDashboardChartSeries.FromClickStackTableChartSeries(
    new ClickStackTableChartSeries
    {
        Type = "table",
        SourceId = "65f5e4a3b9e77c001a567890",
        AggFn = AggFn.Count,
        MWhere = "level:error",
        WhereLanguage = WhereLanguage.Lucene,
        GroupBy = new List<string>
        {
            "errorType",
        },
        Level = 0.95,
        Field = "duration",
        MAlias = "Total Count",
        SortOrder = SortOrder.Desc,
        MetricDataType = MetricDataType.Sum,
        MetricName = "http.server.duration",
    }
);
```

## ClickStackNumberChartSeries

### Initialization Code

#### Example

```csharp
ClickStackDashboardChartSeries value = ClickStackDashboardChartSeries.FromClickStackNumberChartSeries(
    new ClickStackNumberChartSeries
    {
        Type = "number",
        SourceId = "65f5e4a3b9e77c001a567890",
        AggFn = AggFn.Count,
        MWhere = "service:api",
        WhereLanguage = WhereLanguage.Lucene,
        Level = 0.95,
        Field = "duration",
        MAlias = "Total Requests",
        MetricDataType = MetricDataType.Sum,
        MetricName = "http.server.duration",
    }
);
```

## ClickStackSearchChartSeries

### Initialization Code

#### Example

```csharp
ClickStackDashboardChartSeries value = ClickStackDashboardChartSeries.FromClickStackSearchChartSeries(
    new ClickStackSearchChartSeries
    {
        Type = "search",
        SourceId = "65f5e4a3b9e77c001a567890",
        Fields = new List<string>
        {
            "timestamp",
            "level",
            "message",
        },
        MWhere = "level:error",
        WhereLanguage = WhereLanguage.Lucene,
    }
);
```

## ClickStackMarkdownChartSeries

### Initialization Code

#### Example

```csharp
ClickStackDashboardChartSeries value = ClickStackDashboardChartSeries.FromClickStackMarkdownChartSeries(
    new ClickStackMarkdownChartSeries
    {
        Type = "markdown",
        Content = "# Dashboard Title\n\nThis is a markdown widget.",
    }
);
```

