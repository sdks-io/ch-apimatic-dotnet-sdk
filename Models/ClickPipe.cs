using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipe
{
    /// <summary>
    /// Unique ClickPipe ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public Guid? Id { get; init; }

    /// <summary>
    /// ID of the service this ClickPipe belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceId")]
    public Guid? ServiceId { get; init; }

    /// <summary>
    /// Name of the ClickPipe.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [StringLength(255, MinimumLength = 1)]
    public string? Name { get; init; }

    /// <summary>
    /// Current lifecycle state of the ClickPipe. For database pipes: "Provisioning" (initial setup), "Setup" (configuring replication), "Snapshot" (initial data load), "Running" (actively replicating), "Pausing" (transitioning to paused state), "Paused" (temporarily paused), "Modifying" (applying configuration updates), "Resync" (swapping resync tables with original tables), "Failed" (error occurred), "Unknown". For streaming/object storage pipes (Kafka, Kinesis, S3): "Unknown" (initial state), "Provisioning" (setting up resources), "Running" (actively ingesting data), "Stopping" (transitioning to stopped state), "Stopped" (manually stopped, can be restarted), "Completed" (batch ingestion finished for object storage), "Failed" (error occurred, pipe stopped), "InternalError" (internal system error).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("state")]
    public State2? State { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaling")]
    public ClickPipeScaling? Scaling { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source")]
    public ClickPipeSource? Source { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destination")]
    public ClickPipeDestination? Destination { get; init; }

    /// <summary>
    /// Field mappings of the ClickPipe. Note that all destination columns must be included in the mappings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fieldMappings")]
    public IReadOnlyList<ClickPipeFieldMapping>? FieldMappings { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settings")]
    public ClickPipeSettings? Settings { get; init; }

    /// <summary>
    /// Creation timestamp of the ClickPipe in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// Last update timestamp of the ClickPipe in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
