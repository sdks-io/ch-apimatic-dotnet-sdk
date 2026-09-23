using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePatchMongoDbSource
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credentials")]
    public Plain? Credentials { get; init; }

    /// <summary>
    /// MongoDB connection URI (mongodb:// or mongodb+srv://). Credentials are redacted in responses; a masked value is never saved as a credential, so a real credential equal to [REDACTED] cannot be set. To change the connection, send the full URI with real credentials; omit this field or resend the redacted value to leave it unchanged.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string? Uri { get; init; }

    /// <summary>
    /// MongoDB read preference for replica set reads.
    /// </summary>
    [JsonPropertyName("readPreference")]
    public required ReadPreference? ReadPreference { get; init; }

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
    public ClickPipePatchMongoDbPipeSettings? Settings { get; init; }

    /// <summary>
    /// Collection mappings to add to the pipe. Can be an empty array if no collections are being added.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableMappingsToAdd")]
    [MinLength(0)]
    public IReadOnlyList<ClickPipeMongoDbPipeTableMapping>? TableMappingsToAdd { get; init; }

    /// <summary>
    /// Collection mappings to remove from the pipe. Only sourceDatabaseName, sourceCollection, and targetTable are required for removal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableMappingsToRemove")]
    [MinLength(0)]
    public IReadOnlyList<ClickPipePatchMongoDbPipeRemoveTableMapping>? TableMappingsToRemove { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
