using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeMutateDestination
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

    /// <summary>
    /// Optional. Roles to grant to the ClickHouse user that ClickPipe creates. If omitted, the user is granted the default role (<c>default_role</c>). Add your custom roles here if required. The role names <c>clickpipes</c> and <c>clickpipes_system</c> are reserved for internal use and cannot be assigned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roles")]
    public IReadOnlyList<string>? Roles { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
