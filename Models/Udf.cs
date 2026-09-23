using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record Udf
{
    /// <summary>
    /// Name of the UDF. Unique within the organization.
    /// </summary>
    [JsonPropertyName("functionName")]
    public required string FunctionName { get; init; }

    /// <summary>
    /// Version number of the UDF.
    /// </summary>
    [JsonPropertyName("version")]
    [Minimum(1)]
    public required int Version { get; init; }

    /// <summary>
    /// Build state of this UDF version.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status4 Status { get; init; }

    /// <summary>
    /// Runtime used to execute the UDF command.
    /// </summary>
    [JsonPropertyName("runtime")]
    public required Runtime4 Runtime { get; init; }

    /// <summary>
    /// Executable UDF type.
    /// </summary>
    [JsonPropertyName("type")]
    public required Type22 Type { get; init; }

    /// <summary>
    /// Arguments passed to the UDF command.
    /// </summary>
    [JsonPropertyName("arguments")]
    public required IReadOnlyList<UdfArgumentOutput> Arguments { get; init; }

    /// <summary>
    /// ClickHouse data type of the returned value.
    /// </summary>
    [JsonPropertyName("returnType")]
    public required string ReturnType { get; init; }

    /// <summary>
    /// Name of the returned value, or null when unnamed.
    /// </summary>
    [JsonPropertyName("returnName")]
    public required ReturnName4 ReturnName { get; init; }

    /// <summary>
    /// Command pool size for executable_pool UDFs.
    /// </summary>
    [JsonPropertyName("poolSize")]
    public required PoolSize PoolSize { get; init; }

    /// <summary>
    /// Command stdout read timeout in milliseconds.
    /// </summary>
    [JsonPropertyName("commandReadTimeout")]
    [Minimum(1)]
    public required int CommandReadTimeout { get; init; }

    /// <summary>
    /// Command stdin write timeout in milliseconds.
    /// </summary>
    [JsonPropertyName("commandWriteTimeout")]
    [Minimum(1)]
    public required int CommandWriteTimeout { get; init; }

    /// <summary>
    /// Maximum command execution time in seconds for executable_pool UDFs.
    /// </summary>
    [JsonPropertyName("maxCommandExecutionTime")]
    public required MaxCommandExecutionTime2 MaxCommandExecutionTime { get; init; }

    /// <summary>
    /// Maximum memory, in MiB, available to each UDF sandbox process. Null uses the sandbox default.
    /// </summary>
    [JsonPropertyName("memoryLimitMib")]
    public required MemoryLimitMib4 MemoryLimitMib { get; init; }

    /// <summary>
    /// Whether ClickHouse sends a row-count chunk header.
    /// </summary>
    [JsonPropertyName("sendChunkHeader")]
    public required bool SendChunkHeader { get; init; }

    /// <summary>
    /// Whether ClickHouse may reuse cached query results for this UDF.
    /// </summary>
    [JsonPropertyName("deterministic")]
    public required bool Deterministic { get; init; }

    /// <summary>
    /// Input and output format used by the UDF command.
    /// </summary>
    [JsonPropertyName("format")]
    public required string Format { get; init; }

    /// <summary>
    /// Sandbox isolation level.
    /// </summary>
    [JsonPropertyName("sandboxType")]
    public required SandboxType4 SandboxType { get; init; }

    /// <summary>
    /// Sandbox runtime version.
    /// </summary>
    [JsonPropertyName("sandboxVersion")]
    public required SandboxVersion4 SandboxVersion { get; init; }

    /// <summary>
    /// Build error, or null when no build error is present.
    /// </summary>
    [JsonPropertyName("error")]
    public required Error Error { get; init; }

    /// <summary>
    /// Creation timestamp.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Last-update timestamp.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTimeOffset UpdatedAt { get; init; }
}
