using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.AnyOf;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ServiceClickhouseSettingsPatchRequest
{
    /// <summary>
    /// Nonempty object mapping configurable setting names to their values. Use DELETE to reset a setting.
    /// </summary>
    [JsonPropertyName("settings")]
    [MinProperties(1)]
    public required IReadOnlyDictionary<string, ServiceClickhouseSettingValue> Settings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
