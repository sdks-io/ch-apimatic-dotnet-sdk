using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackSourceFilterSettings
{
    /// <summary>
    /// ClickHouse database name
    /// </summary>
    [JsonPropertyName("databaseName")]
    public required string DatabaseName { get; init; }

    /// <summary>
    /// ClickHouse table name
    /// </summary>
    [JsonPropertyName("tableName")]
    public required string TableName { get; init; }

    /// <summary>
    /// Columns to expose as filters (max 10)
    /// </summary>
    [JsonPropertyName("columns")]
    public required IReadOnlyList<ClickStackFilterSettingsColumn> Columns { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
