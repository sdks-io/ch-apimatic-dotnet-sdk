using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickPipePostgresSource
{
    /// <summary>
    /// Type of the Postgres source. Defaults to "postgres" if not specified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type7? Type { get; init; }

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
    /// Authentication method for Postgres connection.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authentication")]
    public Authentication11? Authentication { get; init; }

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
    public ClickPipePostgresPipeSettings? Settings { get; init; }

    /// <summary>
    /// List of table mappings defining which PostgreSQL tables to replicate and how they map to ClickHouse tables.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tableMappings")]
    public IReadOnlyList<ClickPipePostgresPipeTableMapping>? TableMappings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
