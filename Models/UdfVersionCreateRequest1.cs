using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UdfVersionCreateRequest1
{
    /// <summary>
    /// Identifier of the uploaded source archive.
    /// </summary>
    [JsonPropertyName("uploadId")]
    public required Guid UploadId { get; init; }

    [JsonPropertyName("runtime")]
    public required Runtime Runtime { get; init; }

    [JsonPropertyName("arguments")]
    public required IReadOnlyList<UdfArgument> Arguments { get; init; }

    [JsonPropertyName("returnType")]
    public required string ReturnType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("returnName")]
    public ReturnName? ReturnName { get; init; }

    [JsonPropertyName("commandReadTimeout")]
    [Minimum(1)]
    public int? CommandReadTimeout { get; init; } = 10000;

    [JsonPropertyName("commandWriteTimeout")]
    [Minimum(1)]
    public int? CommandWriteTimeout { get; init; } = 10000;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("memoryLimitMib")]
    public MemoryLimitMib? MemoryLimitMib { get; init; }

    [JsonPropertyName("sendChunkHeader")]
    public bool? SendChunkHeader { get; init; } = false;

    /// <summary>
    /// Marks the UDF as deterministic so ClickHouse can reuse cached query results. Only set this when the UDF always returns the same result for the same arguments.
    /// </summary>
    [JsonPropertyName("deterministic")]
    public bool? Deterministic { get; init; } = false;

    [JsonPropertyName("format")]
    public string? Format { get; init; } = "TabSeparated";

    [JsonPropertyName("sandboxType")]
    public SandboxType? SandboxType { get; init; } = SandboxType.Basic;

    [JsonPropertyName("sandboxVersion")]
    public SandboxVersion? SandboxVersion { get; init; } = SandboxVersion.V2;

    [JsonPropertyName("type")]
    public string Type { get; } = "executable_pool";

    [JsonPropertyName("poolSize")]
    [Minimum(1)]
    public int? PoolSize { get; init; } = 3;

    [JsonPropertyName("maxCommandExecutionTime")]
    [Minimum(1)]
    public int? MaxCommandExecutionTime { get; init; } = 10;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
