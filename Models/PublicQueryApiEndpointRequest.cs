using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PublicQueryApiEndpointRequest
{
    /// <summary>
    /// Name of the Query API endpoint.
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    [RegularExpression("\\S")]
    public required string Name { get; init; }

    /// <summary>
    /// SQL executed by the endpoint.
    /// </summary>
    [JsonPropertyName("sql")]
    [MaxLength(4194304)]
    [RegularExpression("\\S")]
    public required string Sql { get; init; }

    /// <summary>
    /// Database used by the Query API endpoint.
    /// </summary>
    [JsonPropertyName("database")]
    [RegularExpression("\\S")]
    public required string Database { get; init; }

    /// <summary>
    /// Default query parameters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parameters")]
    public IReadOnlyDictionary<string, string>? Parameters { get; init; }

    /// <summary>
    /// API key IDs allowed to call the endpoint.
    /// </summary>
    [JsonPropertyName("apiKeyIds")]
    [MinLength(1)]
    public required IReadOnlyList<Guid> ApiKeyIds { get; init; }

    /// <summary>
    /// Database roles used by the endpoint.
    /// </summary>
    [JsonPropertyName("roles")]
    [MinLength(1)]
    public required IReadOnlyList<string> Roles { get; init; }

    /// <summary>
    /// Origins allowed by the endpoint CORS policy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedOrigins")]
    public IReadOnlyList<string>? AllowedOrigins { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
