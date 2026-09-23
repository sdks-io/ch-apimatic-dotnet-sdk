using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackLogSource
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
    /// Source kind discriminator. Must be "log" for log sources.
    /// </summary>
    [JsonPropertyName("kind")]
    public string Kind { get; } = "log";

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
    /// DateTime column or expression that is part of your table's primary key.
    /// </summary>
    [JsonPropertyName("timestampValueExpression")]
    public required string TimestampValueExpression { get; init; }

    /// <summary>
    /// Expression to extract the service name from log rows.
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
    /// Expression to extract the severity/log level text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("severityTextExpression")]
    public string? SeverityTextExpression { get; init; }

    /// <summary>
    /// Expression to extract the log message body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bodyExpression")]
    public string? BodyExpression { get; init; }

    /// <summary>
    /// Expression to extract event-level attributes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eventAttributesExpression")]
    public string? EventAttributesExpression { get; init; }

    /// <summary>
    /// Expression to extract resource-level attributes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resourceAttributesExpression")]
    public string? ResourceAttributesExpression { get; init; }

    /// <summary>
    /// This DateTime column is used to display and order search results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayedTimestampValueExpression")]
    public string? DisplayedTimestampValueExpression { get; init; }

    /// <summary>
    /// HyperDX Source for metrics associated with logs. Optional
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metricSourceId")]
    public string? MetricSourceId { get; init; }

    /// <summary>
    /// HyperDX Source for traces associated with logs. Optional
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("traceSourceId")]
    public string? TraceSourceId { get; init; }

    /// <summary>
    /// Expression to extract the trace ID for correlating logs with traces.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("traceIdExpression")]
    public string? TraceIdExpression { get; init; }

    /// <summary>
    /// Expression to extract the span ID for correlating logs with traces.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("spanIdExpression")]
    public string? SpanIdExpression { get; init; }

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
    /// Expressions defining row-level attributes which are displayed in the row side panel for the selected row.
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
    public ClickStackLogSourceMetadataMaterializedViews? MetadataMaterializedViews { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
