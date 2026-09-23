
# Click Stack Source

## Class Name

`ClickStackSource`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`ClickStackLogSource`](../../../doc/models/click-stack-log-source.md) | ClickStackSource.FromClickStackLogSource(ClickStackLogSource clickStackLogSource) |
| [`ClickStackTraceSource`](../../../doc/models/click-stack-trace-source.md) | ClickStackSource.FromClickStackTraceSource(ClickStackTraceSource clickStackTraceSource) |
| [`ClickStackMetricSource`](../../../doc/models/click-stack-metric-source.md) | ClickStackSource.FromClickStackMetricSource(ClickStackMetricSource clickStackMetricSource) |
| [`ClickStackSessionSource`](../../../doc/models/click-stack-session-source.md) | ClickStackSource.FromClickStackSessionSource(ClickStackSessionSource clickStackSessionSource) |
| [`ClickStackPromqlSource`](../../../doc/models/click-stack-promql-source.md) | ClickStackSource.FromClickStackPromqlSource(ClickStackPromqlSource clickStackPromqlSource) |

## ClickStackLogSource

### Initialization Code

#### Example

```csharp
ClickStackSource value = ClickStackSource.FromClickStackLogSource(
    new ClickStackLogSource
    {
        Name = "Logs",
        Kind = "log",
        Connection = "507f1f77bcf86cd799439012",
        From = new ClickStackSourceFrom
        {
            DatabaseName = "otel",
            TableName = "otel_logs",
        },
        DefaultTableSelectExpression = "Timestamp, ServiceName, SeverityText, Body",
        TimestampValueExpression = "Timestamp",
        Id = "507f1f77bcf86cd799439011",
        Section = "Billing",
        Disabled = false,
        ServiceNameExpression = "ServiceName",
        ServiceVersionExpression = "ResourceAttributes['service.version']",
        SeverityTextExpression = "SeverityText",
        BodyExpression = "Body",
        EventAttributesExpression = "LogAttributes",
        ResourceAttributesExpression = "ResourceAttributes",
        DisplayedTimestampValueExpression = "TimestampTime",
        MetricSourceId = "507f1f77bcf86cd799439013",
        TraceSourceId = "507f1f77bcf86cd799439014",
        TraceIdExpression = "TraceId",
        SpanIdExpression = "SpanId",
        ImplicitColumnExpression = "Body",
        KnownColumnsListExpression = "Timestamp, Body, ServiceName",
        UseTextIndexForImplicitColumn = UseTextIndexForImplicitColumn.Auto,
    }
);
```

## ClickStackTraceSource

### Initialization Code

#### Example

```csharp
ClickStackSource value = ClickStackSource.FromClickStackTraceSource(
    new ClickStackTraceSource
    {
        Name = "Traces",
        Kind = "trace",
        Connection = "507f1f77bcf86cd799439012",
        From = new ClickStackSourceFrom
        {
            DatabaseName = "otel",
            TableName = "otel_logs",
        },
        DefaultTableSelectExpression = "Timestamp, SpanName, ServiceName, Duration",
        TimestampValueExpression = "Timestamp",
        DurationExpression = "Duration",
        DurationPrecision = 2,
        TraceIdExpression = "TraceId",
        SpanIdExpression = "SpanId",
        ParentSpanIdExpression = "ParentSpanId",
        SpanNameExpression = "SpanName",
        SpanKindExpression = "SpanKind",
        Id = "507f1f77bcf86cd799439021",
        Section = "Billing",
        Disabled = false,
        LogSourceId = "507f1f77bcf86cd799439011",
        SessionSourceId = "507f1f77bcf86cd799439031",
        MetricSourceId = "507f1f77bcf86cd799439041",
        StatusCodeExpression = "StatusCode",
        StatusMessageExpression = "StatusMessage",
        ServiceNameExpression = "ServiceName",
        ServiceVersionExpression = "ResourceAttributes['service.version']",
        ResourceAttributesExpression = "ResourceAttributes",
        EventAttributesExpression = "SpanAttributes",
        SpanEventsValueExpression = "Events",
        ImplicitColumnExpression = "SpanName",
        KnownColumnsListExpression = "Timestamp, Body, ServiceName",
        UseTextIndexForImplicitColumn = UseTextIndexForImplicitColumn.Auto,
    }
);
```

## ClickStackMetricSource

### Initialization Code

#### Example

```csharp
ClickStackSource value = ClickStackSource.FromClickStackMetricSource(
    new ClickStackMetricSource
    {
        Name = "Metrics",
        Kind = "metric",
        Connection = "507f1f77bcf86cd799439012",
        From = new ClickStackMetricSourceFrom
        {
            DatabaseName = "otel",
            TableName = "otel_metrics_gauge",
        },
        MetricTables = new ClickStackMetricTables
        {
            Gauge = "otel_metrics_gauge",
            Histogram = "otel_metrics_histogram",
            Sum = "otel_metrics_sum",
            Summary = "otel_metrics_summary",
            ExponentialHistogram = "otel_metrics_exponential_histogram",
        },
        TimestampValueExpression = "TimeUnix",
        ResourceAttributesExpression = "ResourceAttributes",
        Id = "507f1f77bcf86cd799439041",
        Section = "Billing",
        Disabled = false,
        LogSourceId = "507f1f77bcf86cd799439011",
    }
);
```

## ClickStackSessionSource

### Initialization Code

#### Example

```csharp
ClickStackSource value = ClickStackSource.FromClickStackSessionSource(
    new ClickStackSessionSource
    {
        Name = "Sessions",
        Kind = "session",
        Connection = "507f1f77bcf86cd799439012",
        From = new ClickStackSourceFrom
        {
            DatabaseName = "otel",
            TableName = "otel_logs",
        },
        TraceSourceId = "507f1f77bcf86cd799439021",
        Id = "507f1f77bcf86cd799439031",
        Section = "Billing",
        Disabled = false,
        TimestampValueExpression = "TimestampTime",
    }
);
```

## ClickStackPromqlSource

### Initialization Code

#### Example

```csharp
ClickStackSource value = ClickStackSource.FromClickStackPromqlSource(
    new ClickStackPromqlSource
    {
        Name = "Prometheus Metrics",
        Kind = "promql",
        Connection = "507f1f77bcf86cd799439012",
        From = new ClickStackSourceFrom
        {
            DatabaseName = "otel",
            TableName = "otel_logs",
        },
        TimestampValueExpression = "timestamp",
        Id = "507f1f77bcf86cd799439051",
        Section = "Billing",
        Disabled = false,
    }
);
```

