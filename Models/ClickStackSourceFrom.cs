using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackSourceFrom
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
