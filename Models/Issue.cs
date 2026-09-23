using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;

namespace OpenApiSpecForClickHouseCloud.Models;

public record Issue
{
    /// <summary>
    /// Path to the invalid field.
    /// </summary>
    [JsonPropertyName("path")]
    public required IReadOnlyList<PathModel> Path { get; init; }

    /// <summary>
    /// Validation issue code.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// Human-readable description of the issue.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }
}
