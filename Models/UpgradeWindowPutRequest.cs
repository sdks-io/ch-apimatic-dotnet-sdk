using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UpgradeWindowPutRequest
{
    /// <summary>
    /// Day of the week the upgrade window starts. 0 = Sunday, 1 = Monday, …, 6 = Saturday.
    /// </summary>
    [JsonPropertyName("weekday")]
    [Minimum(0)]
    [Maximum(6)]
    public required int Weekday { get; init; }

    /// <summary>
    /// UTC hour when the upgrade window starts. Must be one of 0, 6, 12, or 18. The upgrade window currently lasts 6 hours from this start time.
    /// </summary>
    [JsonPropertyName("startHourUtc")]
    public required StartHourUtc1 StartHourUtc { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
