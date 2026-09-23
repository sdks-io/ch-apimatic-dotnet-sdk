
# Click Stack Trace Source

*This model accepts additional fields of type object.*

## Structure

`ClickStackTraceSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique source ID. Server-generated; ignored if sent in create/update requests. |
| `Name` | `string` | Required | Display name for the source. |
| `Section` | `string` | Optional | Optional grouping label used to organize sources in the source selector. Sources that share a section value are displayed together. |
| `Disabled` | `bool?` | Optional | When true, the source is hidden from source selectors in the UI. Defaults to false. |
| `Kind` | `string` | Required, Constant | Source kind discriminator. Must be "trace" for trace sources.<br><br>**Value**: `"trace"` |
| `Connection` | `string` | Required | ID of the ClickHouse connection used by this source. |
| `From` | [`ClickStackSourceFrom`](../../doc/models/click-stack-source-from.md) | Required | - |
| `QuerySettings` | [`List<ClickStackQuerySetting>`](../../doc/models/click-stack-query-setting.md) | Optional | Optional ClickHouse query settings applied when querying this source. |
| `FilterSettings` | [`ClickStackSourceFilterSettings`](../../doc/models/click-stack-source-filter-settings.md) | Optional | - |
| `DefaultTableSelectExpression` | `string` | Required | Default columns selected in search results (this can be customized per search later) |
| `TimestampValueExpression` | `string` | Required | DateTime column or expression defines the start of the span |
| `DurationExpression` | `string` | Required | Expression to extract span duration. |
| `DurationPrecision` | `int` | Required | Number of decimal digits in the duration value (e.g., 3 for milliseconds, 6 for microseconds, 9 for nanoseconds). |
| `TraceIdExpression` | `string` | Required | Expression to extract the trace ID. |
| `SpanIdExpression` | `string` | Required | Expression to extract the span ID. |
| `ParentSpanIdExpression` | `string` | Required | Expression to extract the parent span ID. |
| `SpanNameExpression` | `string` | Required | Expression to extract the span name. |
| `SpanKindExpression` | `string` | Required | Expression to extract the span kind (e.g., client, server, internal). |
| `LogSourceId` | `string` | Optional | HyperDX Source for logs associated with traces. Optional |
| `SessionSourceId` | `string` | Optional | HyperDX Source for sessions associated with traces. Optional |
| `MetricSourceId` | `string` | Optional | HyperDX Source for metrics associated with traces. Optional |
| `StatusCodeExpression` | `string` | Optional | Expression to extract the span status code. |
| `StatusMessageExpression` | `string` | Optional | Expression to extract the span status message. |
| `ServiceNameExpression` | `string` | Optional | Expression to extract the service name from trace rows. |
| `ServiceVersionExpression` | `string` | Optional | Expression identifying the running release of a service. Defaults to the OpenTelemetry service.version resource attribute when unset. Where services carry the release on different attributes, fall back across them with coalesce(nullIf(a, ''), nullIf(b, '')). |
| `ResourceAttributesExpression` | `string` | Optional | Expression to extract resource-level attributes. |
| `EventAttributesExpression` | `string` | Optional | Expression to extract event-level attributes. |
| `SpanEventsValueExpression` | `string` | Optional | Expression to extract span events. Used to capture events associated with spans. Expected to be Nested ( Timestamp DateTime64(9), Name LowCardinality(String), Attributes Map(LowCardinality(String), String) |
| `ImplicitColumnExpression` | `string` | Optional | Column used for full text search if no property is specified in a Lucene-based search. Typically the message body of a log. |
| `KnownColumnsListExpression` | `string` | Optional | For Distributed table sources whose target tables have non-matching column sets. A list of columns supported across all target tables, used instead of SELECT * when fetching full row data. Leave blank to select all columns. |
| `UseTextIndexForImplicitColumn` | [`UseTextIndexForImplicitColumn?`](../../doc/models/use-text-index-for-implicit-column.md) | Optional | Controls whether lucene rendering uses ClickHouse text indices via hasAllTokens() against the implicit column. "auto" detects a covering index at query time, "enabled" forces text index usage, "disabled" forces a LIKE/hasToken fallback. |
| `HighlightedTraceAttributeExpressions` | [`List<ClickStackHighlightedAttributeExpression>`](../../doc/models/click-stack-highlighted-attribute-expression.md) | Optional | Expressions defining trace-level attributes which are displayed in the trace view for the selected trace. |
| `HighlightedRowAttributeExpressions` | [`List<ClickStackHighlightedAttributeExpression>`](../../doc/models/click-stack-highlighted-attribute-expression.md) | Optional | Expressions defining row-level attributes which are displayed in the row side panel for the selected row |
| `MaterializedViews` | [`List<ClickStackMaterializedView>`](../../doc/models/click-stack-materialized-view.md) | Optional | Configure materialized views for query optimization. These pre-aggregated views can significantly improve query performance on aggregation queries. |
| `MetadataMaterializedViews` | [`ClickStackTraceSourceMetadataMaterializedViews`](../../doc/models/click-stack-trace-source-metadata-materialized-views.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackTraceSource clickStackTraceSource = new ClickStackTraceSource
{
    Name = "Traces",
    Kind = "trace",
    Connection = "507f1f77bcf86cd799439012",
    From = new ClickStackSourceFrom
    {
        DatabaseName = "otel",
        TableName = "otel_logs",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    DefaultTableSelectExpression = "Timestamp, SpanName, ServiceName, Duration",
    TimestampValueExpression = "Timestamp",
    DurationExpression = "Duration",
    DurationPrecision = 202,
    TraceIdExpression = "TraceId",
    SpanIdExpression = "SpanId",
    ParentSpanIdExpression = "ParentSpanId",
    SpanNameExpression = "SpanName",
    SpanKindExpression = "SpanKind",
    Id = "507f1f77bcf86cd799439021",
    Section = "Billing",
    Disabled = false,
    QuerySettings = new List<ClickStackQuerySetting>
    {
        new ClickStackQuerySetting
        {
            Setting = "setting6",
            MValue = "value0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackQuerySetting
        {
            Setting = "setting6",
            MValue = "value0",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    FilterSettings = new ClickStackSourceFilterSettings
    {
        DatabaseName = "databaseName4",
        TableName = "tableName4",
        Columns = new List<ClickStackFilterSettingsColumn>
        {
            new ClickStackFilterSettingsColumn
            {
                Name = "name0",
                Label = "label0",
                ValueExpression = "valueExpression8",
                AllowAll = false,
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
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
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

