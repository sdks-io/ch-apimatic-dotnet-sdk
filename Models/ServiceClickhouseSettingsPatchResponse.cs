using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ServiceClickhouseSettingsPatchResponse
{
    /// <summary>
    /// Nonempty object mapping configurable setting names to their values. Use DELETE to reset a setting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("settings")]
    [MinProperties(1)]
    public IReadOnlyDictionary<string, ServiceClickhouseSettingValue>? Settings { get; init; }

    /// <summary>
    /// Warnings for settings that may have disruptive effects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<ServiceClickhouseSettingWarning>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
