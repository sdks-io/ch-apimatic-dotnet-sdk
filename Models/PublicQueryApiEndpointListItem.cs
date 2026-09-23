using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Validation;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record PublicQueryApiEndpointListItem
{
    /// <summary>
    /// Unique ID of the Query API endpoint.
    /// </summary>
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    /// <summary>
    /// Name of the Query API endpoint.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Database used by the Query API endpoint.
    /// </summary>
    [JsonPropertyName("database")]
    public required string Database { get; init; }

    /// <summary>
    /// API key IDs allowed to call the endpoint.
    /// </summary>
    [JsonPropertyName("apiKeyIds")]
    public required IReadOnlyList<Guid> ApiKeyIds { get; init; }

    /// <summary>
    /// Database roles used by the endpoint.
    /// </summary>
    [JsonPropertyName("roles")]
    public required IReadOnlyList<string> Roles { get; init; }

    /// <summary>
    /// Origins allowed by the endpoint CORS policy.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public required IReadOnlyList<string> AllowedOrigins { get; init; }

    /// <summary>
    /// Public URL used to execute the endpoint.
    /// </summary>
    [JsonPropertyName("url")]
    [Format(FormatKind.Uri)]
    public required string Url { get; init; }

    /// <summary>
    /// Owner type of the Query API endpoint. Endpoints with a user owned query cannot be updated or deleted through this API.
    /// </summary>
    [JsonPropertyName("ownerType")]
    public required OwnerType OwnerType { get; init; }
}
