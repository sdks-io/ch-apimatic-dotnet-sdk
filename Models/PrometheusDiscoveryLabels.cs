using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PrometheusDiscoveryLabels
{
    /// <summary>
    /// URL scheme Prometheus must scrape the target with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("__scheme__")]
    public string? Scheme { get; init; }

    /// <summary>
    /// Path of the per-service Prometheus metrics endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("__metrics_path__")]
    public string? MetricsPath { get; init; }

    /// <summary>
    /// Value passed as the filtered_metrics query parameter on each scrape.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("__param_filtered_metrics")]
    public string? ParamFilteredMetrics { get; init; }

    /// <summary>
    /// Organization ID the service belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickhouse_org_id")]
    public Guid? ClickhouseOrgId { get; init; }

    /// <summary>
    /// Service ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickhouse_service_id")]
    public Guid? ClickhouseServiceId { get; init; }

    /// <summary>
    /// Service name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clickhouse_discovery_service_name")]
    public string? ClickhouseDiscoveryServiceName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
