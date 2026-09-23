using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresSlowQueryPatternDetail
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aggregate")]
    public PostgresSlowQueryPattern? Aggregate { get; init; }

    /// <summary>
    /// Recent individual executions matching the pattern.
    /// </summary>
    [JsonPropertyName("recentExecutions")]
    public required IReadOnlyList<PostgresQueryExecution> RecentExecutions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
