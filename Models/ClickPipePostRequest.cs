using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePostRequest
{
    /// <summary>
    /// Name of the ClickPipe.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source")]
    public ClickPipePostSource? Source { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("destination")]
    public ClickPipeMutateDestination? Destination { get; init; }

    /// <summary>
    /// Field mappings of the ClickPipe. Note that all destination columns must be included in the mappings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fieldMappings")]
    public IReadOnlyList<ClickPipeFieldMapping>? FieldMappings { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaling")]
    public ClickPipeScaling? Scaling { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settings")]
    public ClickPipeSettings? Settings { get; init; }

    /// <summary>
    /// Create the ClickPipe in the Stopped state instead of starting ingestion immediately. Start it later with the state endpoint. Not supported for database ClickPipes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startPaused")]
    public bool? StartPaused { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
