using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeDestination
{
    /// <summary>
    /// Destination database.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("database")]
    public string? Database { get; init; }

    /// <summary>
    /// Destination table. Required field for all pipe types except database pipes (Postgres, MySQL, BigQuery).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("table")]
    public string? Table { get; init; }

    /// <summary>
    /// Is the table managed by ClickPipes? Required field for all pipe types except database pipes (Postgres, MySQL, BigQuery).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("managedTable")]
    public bool? ManagedTable { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableDefinition")]
    public ClickPipeDestinationTableDefinition? TableDefinition { get; init; }

    /// <summary>
    /// Columns of the destination table. Required field for all pipe types except database pipes (Postgres, MySQL, BigQuery).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("columns")]
    public IReadOnlyList<ClickPipeDestinationColumn>? Columns { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
