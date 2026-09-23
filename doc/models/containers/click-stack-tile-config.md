
# Click Stack Tile Config

## Class Name

`ClickStackTileConfig`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackLineChartConfig`](../../../doc/models/containers/click-stack-line-chart-config.md) | ClickStackTileConfig.FromClickStackLineChartConfig(ClickStackLineChartConfig clickStackLineChartConfig) |
| [`ClickStackBarChartConfig`](../../../doc/models/containers/click-stack-bar-chart-config.md) | ClickStackTileConfig.FromClickStackBarChartConfig(ClickStackBarChartConfig clickStackBarChartConfig) |
| [`ClickStackTableChartConfig`](../../../doc/models/containers/click-stack-table-chart-config.md) | ClickStackTileConfig.FromClickStackTableChartConfig(ClickStackTableChartConfig clickStackTableChartConfig) |
| [`ClickStackNumberChartConfig`](../../../doc/models/containers/click-stack-number-chart-config.md) | ClickStackTileConfig.FromClickStackNumberChartConfig(ClickStackNumberChartConfig clickStackNumberChartConfig) |
| [`ClickStackPieChartConfig`](../../../doc/models/containers/click-stack-pie-chart-config.md) | ClickStackTileConfig.FromClickStackPieChartConfig(ClickStackPieChartConfig clickStackPieChartConfig) |
| [`ClickStackCategoricalBarChartConfig`](../../../doc/models/containers/click-stack-categorical-bar-chart-config.md) | ClickStackTileConfig.FromClickStackCategoricalBarChartConfig(ClickStackCategoricalBarChartConfig clickStackCategoricalBarChartConfig) |
| [`ClickStackHeatmapChartConfig`](../../../doc/models/click-stack-heatmap-chart-config.md) | ClickStackTileConfig.FromClickStackHeatmapChartConfig(ClickStackHeatmapChartConfig clickStackHeatmapChartConfig) |
| [`ClickStackSearchChartConfig`](../../../doc/models/click-stack-search-chart-config.md) | ClickStackTileConfig.FromClickStackSearchChartConfig(ClickStackSearchChartConfig clickStackSearchChartConfig) |
| [`ClickStackEventPatternsChartConfig`](../../../doc/models/click-stack-event-patterns-chart-config.md) | ClickStackTileConfig.FromClickStackEventPatternsChartConfig(ClickStackEventPatternsChartConfig clickStackEventPatternsChartConfig) |
| [`ClickStackMarkdownChartConfig`](../../../doc/models/click-stack-markdown-chart-config.md) | ClickStackTileConfig.FromClickStackMarkdownChartConfig(ClickStackMarkdownChartConfig clickStackMarkdownChartConfig) |

## ClickStackLineChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTileConfig value = ClickStackTileConfig.FromClickStackLineChartConfig(
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
                },
            },
        }
    )
);
```

## ClickStackBarChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTileConfig value = ClickStackTileConfig.FromClickStackBarChartConfig(
    ClickStackBarChartConfig.FromClickStackBarBuilderChartConfig(
        new ClickStackBarBuilderChartConfig
        {
            DisplayType = "displayType8",
            SourceId = "sourceId0",
            MSelect = new List<ClickStackSelectItem>
            {
                new ClickStackSelectItem
                {
                    AggFn = AggFn3.Max,
                },
                new ClickStackSelectItem
                {
                    AggFn = AggFn3.Max,
                },
            },
        }
    )
);
```

## ClickStackTableChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTileConfig value = ClickStackTileConfig.FromClickStackTableChartConfig(
    ClickStackTableChartConfig.FromClickStackTableBuilderChartConfig(
        new ClickStackTableBuilderChartConfig
        {
            DisplayType = "displayType2",
            SourceId = "sourceId6",
            MSelect = new List<ClickStackSelectItem>
            {
                new ClickStackSelectItem
                {
                    AggFn = AggFn3.Max,
                },
                new ClickStackSelectItem
                {
                    AggFn = AggFn3.Max,
                },
            },
        }
    )
);
```

## ClickStackNumberChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTileConfig value = ClickStackTileConfig.FromClickStackNumberChartConfig(
    ClickStackNumberChartConfig.FromClickStackNumberBuilderChartConfig(
        new ClickStackNumberBuilderChartConfig
        {
            DisplayType = "displayType2",
            SourceId = "sourceId6",
            MSelect = new List<ClickStackSelectItem>
            {
                new ClickStackSelectItem
                {
                    AggFn = AggFn3.Max,
                },
                new ClickStackSelectItem
                {
                    AggFn = AggFn3.Max,
                },
            },
        }
    )
);
```

## ClickStackPieChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTileConfig value = ClickStackTileConfig.FromClickStackPieChartConfig(
    ClickStackPieChartConfig.FromClickStackPieBuilderChartConfig(
        new ClickStackPieBuilderChartConfig
        {
            DisplayType = "displayType0",
            SourceId = "sourceId8",
            MSelect = new List<ClickStackSelectItem>
            {
                new ClickStackSelectItem
                {
                    AggFn = AggFn3.Max,
                },
                new ClickStackSelectItem
                {
                    AggFn = AggFn3.Max,
                },
                new ClickStackSelectItem
                {
                    AggFn = AggFn3.Max,
                },
            },
        }
    )
);
```

## ClickStackCategoricalBarChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTileConfig value = ClickStackTileConfig.FromClickStackCategoricalBarChartConfig(
    ClickStackCategoricalBarChartConfig.FromClickStackCategoricalBarBuilderChartConfig(
        new ClickStackCategoricalBarBuilderChartConfig
        {
            DisplayType = "displayType4",
            SourceId = "sourceId4",
            MSelect = new List<ClickStackSelectItem>
            {
                new ClickStackSelectItem
                {
                    AggFn = AggFn3.Max,
                },
            },
        }
    )
);
```

## ClickStackHeatmapChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTileConfig value = ClickStackTileConfig.FromClickStackHeatmapChartConfig(
    new ClickStackHeatmapChartConfig
    {
        DisplayType = "heatmap",
        SourceId = "65f5e4a3b9e77c001a111111",
        MSelect = new List<ClickStackHeatmapSelectItem>
        {
            new ClickStackHeatmapSelectItem
            {
                ValueExpression = "Duration",
                CountExpression = "count()",
                HeatmapScaleType = HeatmapScaleType.Log,
            },
        },
        MWhere = "ServiceName = 'api'",
    }
);
```

## ClickStackSearchChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTileConfig value = ClickStackTileConfig.FromClickStackSearchChartConfig(
    new ClickStackSearchChartConfig
    {
        DisplayType = "search",
        SourceId = "65f5e4a3b9e77c001a111111",
        MSelect = "timestamp, level, message",
        WhereLanguage = WhereLanguage4.Sql,
        MWhere = "level:error",
    }
);
```

## ClickStackEventPatternsChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTileConfig value = ClickStackTileConfig.FromClickStackEventPatternsChartConfig(
    new ClickStackEventPatternsChartConfig
    {
        DisplayType = "event_patterns",
        SourceId = "65f5e4a3b9e77c001a111111",
        MSelect = "Body",
        MWhere = "level:error",
    }
);
```

## ClickStackMarkdownChartConfig

### Initialization Code

#### Example

```csharp
ClickStackTileConfig value = ClickStackTileConfig.FromClickStackMarkdownChartConfig(
    new ClickStackMarkdownChartConfig
    {
        DisplayType = "markdown",
        Markdown = "# Dashboard Title\n\nThis is a markdown widget.",
    }
);
```

