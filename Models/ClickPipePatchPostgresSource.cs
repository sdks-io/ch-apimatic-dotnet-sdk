using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePatchPostgresSource
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credentials")]
    public Plain? Credentials { get; init; }

    /// <summary>
    /// PostgreSQL server hostname or IP address. To use a reverse private endpoint, pass the endpoint hostname here.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("host")]
    [Format(FormatKind.Hostname)]
    public string? Host { get; init; }

    /// <summary>
    /// PostgreSQL server port.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("port")]
    [Minimum(1)]
    [Maximum(65535)]
    public int? Port { get; init; }

    /// <summary>
    /// PostgreSQL database name to replicate from.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("database")]
    public string? Database { get; init; }

    /// <summary>
    /// TLS/SSL host for secure connections.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tlsHost")]
    public string? TlsHost { get; init; }

    /// <summary>
    /// PEM encoded CA certificate to validate the Postgres server certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; init; }

    /// <summary>
    /// Disable TLS for the Postgres connection. Use with caution in production environments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disableTls")]
    public bool? DisableTls { get; init; }

    /// <summary>
    /// Skip TLS certificate verification for the Postgres connection. Use with caution in production environments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skipCertVerification")]
    public bool? SkipCertVerification { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settings")]
    public ClickPipePatchPostgresPipeSettings? Settings { get; init; }

    /// <summary>
    /// Table mappings to add to the pipe. Can be an empty array if no tables are being added.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableMappingsToAdd")]
    [MinLength(0)]
    public IReadOnlyList<ClickPipePostgresPipeTableMapping>? TableMappingsToAdd { get; init; }

    /// <summary>
    /// Table mappings to remove from the pipe. Only sourceSchemaName, sourceTable, and targetTable are required for removal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableMappingsToRemove")]
    [MinLength(0)]
    public IReadOnlyList<ClickPipePatchPostgresPipeRemoveTableMapping>? TableMappingsToRemove { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
