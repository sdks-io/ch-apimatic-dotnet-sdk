using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipeMutateMySqlSource
{
    /// <summary>
    /// Type of the MySQL source. Defaults to "mysql" if not specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type9? Type { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credentials")]
    public Plain? Credentials { get; init; }

    /// <summary>
    /// MySQL server hostname or IP address. To use a reverse private endpoint, pass the endpoint hostname here.
    /// </summary>
    [JsonPropertyName("host")]
    [Format(FormatKind.Hostname)]
    public required string Host { get; init; }

    /// <summary>
    /// MySQL server port.
    /// </summary>
    [JsonPropertyName("port")]
    [Minimum(1)]
    [Maximum(65535)]
    public required int Port { get; init; }

    [JsonPropertyName("settings")]
    public required ClickPipeMySqlPipeSettings Settings { get; init; }

    /// <summary>
    /// Authentication method for MySQL connection.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authentication")]
    public Authentication13? Authentication { get; init; }

    /// <summary>
    /// IAM role ARN for IAM authentication (required for IAM_ROLE authentication).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; init; }

    /// <summary>
    /// TLS/SSL host for secure connections.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tlsHost")]
    public string? TlsHost { get; init; }

    /// <summary>
    /// PEM encoded CA certificate to validate the MySQL server certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("caCertificate")]
    public string? CaCertificate { get; init; }

    /// <summary>
    /// Disable TLS for the MySQL connection. Use with caution in production environments. Defaults to false when omitted.
    /// </summary>
    [JsonPropertyName("disableTls")]
    public bool? DisableTls { get; init; } = false;

    /// <summary>
    /// Skip TLS certificate verification for the MySQL connection. Use with caution in production environments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skipCertVerification")]
    public bool? SkipCertVerification { get; init; }

    /// <summary>
    /// Optional MySQL server_id the pipe declares itself as in the MySQL replication topology. Must be unique across replicas connected to the source. If omitted, one is assigned automatically.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serverId")]
    [Minimum(1)]
    [Maximum(2147483647)]
    public int? ServerId { get; init; }

    /// <summary>
    /// List of table mappings defining which MySQL tables to replicate and how they map to ClickHouse tables.
    /// </summary>
    [JsonPropertyName("tableMappings")]
    public required IReadOnlyList<ClickPipeMySqlPipeTableMapping> TableMappings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
