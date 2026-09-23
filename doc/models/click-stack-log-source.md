
# Click Stack Log Source

*This model accepts additional fields of type object.*

## Structure

`ClickStackLogSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique source ID. Server-generated; ignored if sent in create/update requests. |
| `Name` | `string` | Required | Display name for the source. |
| `Section` | `string` | Optional | Optional grouping label used to organize sources in the source selector. Sources that share a section value are displayed together. |
| `Disabled` | `bool?` | Optional | When true, the source is hidden from source selectors in the UI. Defaults to false. |
| `Kind` | `string` | Required, Constant | Source kind discriminator. Must be "log" for log sources.<br><br>**Value**: `"log"` |
| `Connection` | `string` | Required | ID of the ClickHouse connection used by this source. |
| `From` | [`ClickStackSourceFrom`](../../doc/models/click-stack-source-from.md) | Required | - |
| `QuerySettings` | [`List<ClickStackQuerySetting>`](../../doc/models/click-stack-query-setting.md) | Optional | Optional ClickHouse query settings applied when querying this source. |
| `FilterSettings` | [`ClickStackSourceFilterSettings`](../../doc/models/click-stack-source-filter-settings.md) | Optional | - |
| `DefaultTableSelectExpression` | `string` | Required | Default columns selected in search results (this can be customized per search later) |
| `TimestampValueExpression` | `string` | Required | DateTime column or expression that is part of your table's primary key. |
| `ServiceNameExpression` | `string` | Optional | Expression to extract the service name from log rows. |
| `ServiceVersionExpression` | `string` | Optional | Expression identifying the running release of a service. Defaults to the OpenTelemetry service.version resource attribute when unset. Where services carry the release on different attributes, fall back across them with coalesce(nullIf(a, ''), nullIf(b, '')). |
| `SeverityTextExpression` | `string` | Optional | Expression to extract the severity/log level text. |
| `BodyExpression` | `string` | Optional | Expression to extract the log message body. |
| `EventAttributesExpression` | `string` | Optional | Expression to extract event-level attributes. |
| `ResourceAttributesExpression` | `string` | Optional | Expression to extract resource-level attributes. |
| `DisplayedTimestampValueExpression` | `string` | Optional | This DateTime column is used to display and order search results. |
| `MetricSourceId` | `string` | Optional | HyperDX Source for metrics associated with logs. Optional |
| `TraceSourceId` | `string` | Optional | HyperDX Source for traces associated with logs. Optional |
| `TraceIdExpression` | `string` | Optional | Expression to extract the trace ID for correlating logs with traces. |
| `SpanIdExpression` | `string` | Optional | Expression to extract the span ID for correlating logs with traces. |
| `ImplicitColumnExpression` | `string` | Optional | Column used for full text search if no property is specified in a Lucene-based search. Typically the message body of a log. |
| `KnownColumnsListExpression` | `string` | Optional | For Distributed table sources whose target tables have non-matching column sets. A list of columns supported across all target tables, used instead of SELECT * when fetching full row data. Leave blank to select all columns. |
| `UseTextIndexForImplicitColumn` | [`UseTextIndexForImplicitColumn?`](../../doc/models/use-text-index-for-implicit-column.md) | Optional | Controls whether lucene rendering uses ClickHouse text indices via hasAllTokens() against the implicit column. "auto" detects a covering index at query time, "enabled" forces text index usage, "disabled" forces a LIKE/hasToken fallback. |
| `HighlightedTraceAttributeExpressions` | [`List<ClickStackHighlightedAttributeExpression>`](../../doc/models/click-stack-highlighted-attribute-expression.md) | Optional | Expressions defining trace-level attributes which are displayed in the trace view for the selected trace. |
| `HighlightedRowAttributeExpressions` | [`List<ClickStackHighlightedAttributeExpression>`](../../doc/models/click-stack-highlighted-attribute-expression.md) | Optional | Expressions defining row-level attributes which are displayed in the row side panel for the selected row. |
| `MaterializedViews` | [`List<ClickStackMaterializedView>`](../../doc/models/click-stack-materialized-view.md) | Optional | Configure materialized views for query optimization. These pre-aggregated views can significantly improve query performance on aggregation queries. |
| `MetadataMaterializedViews` | [`ClickStackLogSourceMetadataMaterializedViews`](../../doc/models/click-stack-log-source-metadata-materialized-views.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackLogSource clickStackLogSource = new ClickStackLogSource
{
    Name = "Logs",
    Kind = "log",
    Connection = "507f1f77bcf86cd799439012",
    From = new ClickStackSourceFrom
    {
        DatabaseName = "otel",
        TableName = "otel_logs",
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    DefaultTableSelectExpression = "Timestamp, ServiceName, SeverityText, Body",
    TimestampValueExpression = "Timestamp",
    Id = "507f1f77bcf86cd799439011",
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
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

