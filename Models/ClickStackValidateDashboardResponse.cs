using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ClickStackValidateDashboardResponse
{
    /// <summary>
    /// True when the body passes all validation rules.
    /// </summary>
    [JsonPropertyName("valid")]
    public required bool Valid { get; init; }

    /// <summary>
    /// Validation errors. Empty when valid is true.
    /// </summary>
    [JsonPropertyName("errors")]
    public required IReadOnlyList<ClickStackValidateDashboardError> Errors { get; init; }

    [JsonPropertyName("normalized")]
    public required object? Normalized { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
