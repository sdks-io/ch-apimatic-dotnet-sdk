using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UpgradeWindow
{
    /// <summary>
    /// Day of the week the upgrade window starts. 0 = Sunday, 1 = Monday, …, 6 = Saturday.
    /// </summary>
    [JsonPropertyName("weekday")]
    [Minimum(0)]
    [Maximum(6)]
    public required int Weekday { get; init; }

    /// <summary>
    /// UTC hour when the upgrade window starts. Must be one of 0, 6, 12, or 18.
    /// </summary>
    [JsonPropertyName("startHourUtc")]
    public required StartHourUtc StartHourUtc { get; init; }

    /// <summary>
    /// Length of the upgrade window in hours. Currently only a 6-hour window is supported.
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; } = 6;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
