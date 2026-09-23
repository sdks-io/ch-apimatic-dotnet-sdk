using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UdfAttachment
{
    /// <summary>
    /// Name of the UDF.
    /// </summary>
    [JsonPropertyName("functionName")]
    public required string FunctionName { get; init; }

    /// <summary>
    /// ID of the attached service.
    /// </summary>
    [JsonPropertyName("serviceId")]
    public required Guid ServiceId { get; init; }

    /// <summary>
    /// Current attachment lifecycle state.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status3 Status { get; init; }

    /// <summary>
    /// Attached UDF version.
    /// </summary>
    [JsonPropertyName("version")]
    [Minimum(1)]
    public required int Version { get; init; }
}
