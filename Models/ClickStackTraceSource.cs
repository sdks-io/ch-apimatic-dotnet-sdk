using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackTraceSource
{
    /// <summary>
    /// Unique source ID. Server-generated; ignored if sent in create/update requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Display name for the source.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Optional grouping label used to organize sources in the source selector. Sources that share a section value are displayed together.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("section")]
    public string? Section { get; init; }

    /// <summary>
    /// When true, the source is hidden from source selectors in the UI. Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; init; }

    /// <summary>
    /// Source kind discriminator. Must be "trace" for trace sources.
    /// </summary>
    [JsonPropertyName("kind")]
    public string Kind { get; } = "trace";

    /// <summary>
    /// ID of the ClickHouse connection used by this source.
    /// </summary>
    [JsonPropertyName("connection")]
    public required string Connection { get; init; }

    [JsonPropertyName("from")]
    public required ClickStackSourceFrom From { get; init; }

    /// <summary>
    /// Optional ClickHouse query settings applied when querying this source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("querySettings")]
    public IReadOnlyList<ClickStackQuerySetting>? QuerySettings { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filterSettings")]
    public ClickStackSourceFilterSettings? FilterSettings { get; init; }

    /// <summary>
    /// Default columns selected in search results (this can be customized per search later)
    /// </summary>
    [JsonPropertyName("defaultTableSelectExpression")]
    public required string DefaultTableSelectExpression { get; init; }

    /// <summary>
    /// DateTime column or expression defines the start of the span
    /// </summary>
    [JsonPropertyName("timestampValueExpression")]
    public required string TimestampValueExpression { get; init; }

    /// <summary>
    /// Expression to extract span duration.
    /// </summary>
    [JsonPropertyName("durationExpression")]
    public required string DurationExpression { get; init; }

    /// <summary>
    /// Number of decimal digits in the duration value (e.g., 3 for milliseconds, 6 for microseconds, 9 for nanoseconds).
    /// </summary>
    [JsonPropertyName("durationPrecision")]
    public required int DurationPrecision { get; init; }

    /// <summary>
    /// Expression to extract the trace ID.
    /// </summary>
    [JsonPropertyName("traceIdExpression")]
    public required string TraceIdExpression { get; init; }

    /// <summary>
    /// Expression to extract the span ID.
    /// </summary>
    [JsonPropertyName("spanIdExpression")]
    public required string SpanIdExpression { get; init; }

    /// <summary>
    /// Expression to extract the parent span ID.
    /// </summary>
    [JsonPropertyName("parentSpanIdExpression")]
    public required string ParentSpanIdExpression { get; init; }

    /// <summary>
    /// Expression to extract the span name.
    /// </summary>
    [JsonPropertyName("spanNameExpression")]
    public required string SpanNameExpression { get; init; }

    /// <summary>
    /// Expression to extract the span kind (e.g., client, server, internal).
    /// </summary>
    [JsonPropertyName("spanKindExpression")]
    public required string SpanKindExpression { get; init; }

    /// <summary>
    /// HyperDX Source for logs associated with traces. Optional
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logSourceId")]
    public string? LogSourceId { get; init; }

    /// <summary>
    /// HyperDX Source for sessions associated with traces. Optional
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sessionSourceId")]
    public string? SessionSourceId { get; init; }

    /// <summary>
    /// HyperDX Source for metrics associated with traces. Optional
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metricSourceId")]
    public string? MetricSourceId { get; init; }

    /// <summary>
    /// Expression to extract the span status code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusCodeExpression")]
    public string? StatusCodeExpression { get; init; }

    /// <summary>
    /// Expression to extract the span status message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusMessageExpression")]
    public string? StatusMessageExpression { get; init; }

    /// <summary>
    /// Expression to extract the service name from trace rows.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceNameExpression")]
    public string? ServiceNameExpression { get; init; }

    /// <summary>
    /// Expression identifying the running release of a service. Defaults to the OpenTelemetry service.version resource attribute when unset. Where services carry the release on different attributes, fall back across them with coalesce(nullIf(a, ''), nullIf(b, '')).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceVersionExpression")]
    public string? ServiceVersionExpression { get; init; }

    /// <summary>
    /// Expression to extract resource-level attributes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resourceAttributesExpression")]
    public string? ResourceAttributesExpression { get; init; }

    /// <summary>
    /// Expression to extract event-level attributes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventAttributesExpression")]
    public string? EventAttributesExpression { get; init; }

    /// <summary>
    /// Expression to extract span events. Used to capture events associated with spans. Expected to be Nested ( Timestamp DateTime64(9), Name LowCardinality(String), Attributes Map(LowCardinality(String), String)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("spanEventsValueExpression")]
    public string? SpanEventsValueExpression { get; init; }

    /// <summary>
    /// Column used for full text search if no property is specified in a Lucene-based search. Typically the message body of a log.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("implicitColumnExpression")]
    public string? ImplicitColumnExpression { get; init; }

    /// <summary>
    /// For Distributed table sources whose target tables have non-matching column sets. A list of columns supported across all target tables, used instead of SELECT * when fetching full row data. Leave blank to select all columns.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("knownColumnsListExpression")]
    public string? KnownColumnsListExpression { get; init; }

    /// <summary>
    /// Controls whether lucene rendering uses ClickHouse text indices via hasAllTokens() against the implicit column. "auto" detects a covering index at query time, "enabled" forces text index usage, "disabled" forces a LIKE/hasToken fallback.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("useTextIndexForImplicitColumn")]
    public UseTextIndexForImplicitColumn? UseTextIndexForImplicitColumn { get; init; }

    /// <summary>
    /// Expressions defining trace-level attributes which are displayed in the trace view for the selected trace.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("highlightedTraceAttributeExpressions")]
    public IReadOnlyList<ClickStackHighlightedAttributeExpression>? HighlightedTraceAttributeExpressions { get; init; }

    /// <summary>
    /// Expressions defining row-level attributes which are displayed in the row side panel for the selected row
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("highlightedRowAttributeExpressions")]
    public IReadOnlyList<ClickStackHighlightedAttributeExpression>? HighlightedRowAttributeExpressions { get; init; }

    /// <summary>
    /// Configure materialized views for query optimization. These pre-aggregated views can significantly improve query performance on aggregation queries.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("materializedViews")]
    public IReadOnlyList<ClickStackMaterializedView>? MaterializedViews { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadataMaterializedViews")]
    public ClickStackTraceSourceMetadataMaterializedViews? MetadataMaterializedViews { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
