using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PostgresLogEntry
{
    /// <summary>
    /// Time the entry was logged (RFC 3339).
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// PostgreSQL severity of the entry (for example, LOG, WARNING, ERROR, FATAL, PANIC).
    /// </summary>
    [JsonPropertyName("severity")]
    public required string Severity { get; init; }

    /// <summary>
    /// Raw log entry body as emitted by PostgreSQL. Structured bodies are returned as a JSON-encoded string.
    /// </summary>
    [JsonPropertyName("body")]
    public required string Body { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
