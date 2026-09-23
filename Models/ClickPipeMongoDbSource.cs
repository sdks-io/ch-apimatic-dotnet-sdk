using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeMongoDbSource
{
    /// <summary>
    /// MongoDB connection URI. Supports both standard URIs (mongodb://...) and SRV URIs (mongodb+srv://...). Embedded credentials are redacted from API responses, so the returned value can differ from what was submitted.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// MongoDB read preference for replica set reads.
    /// </summary>
    [JsonPropertyName("readPreference")]
    public required ReadPreference ReadPreference { get; init; }

    /// <summary>
    /// TLS/SSL host for secure connections.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tlsHost")]
    public string? TlsHost { get; init; }

    /// <summary>
    /// Disable TLS for the MongoDB connection. Defaults to false (TLS enabled).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disableTls")]
    public bool? DisableTls { get; init; }

    /// <summary>
    /// Skip TLS certificate verification for the MongoDB connection. Use with caution in production environments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skipCertVerification")]
    public bool? SkipCertVerification { get; init; }

    /// <summary>
    /// PEM encoded CA certificate to validate the MongoDB server certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settings")]
    public ClickPipeMongoDbPipeSettings? Settings { get; init; }

    /// <summary>
    /// List of collection mappings defining which MongoDB collections to replicate and how they map to ClickHouse tables.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableMappings")]
    public IReadOnlyList<ClickPipeMongoDbPipeTableMapping>? TableMappings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
