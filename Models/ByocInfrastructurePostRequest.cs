using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ByocInfrastructurePostRequest
{
    /// <summary>
    /// Region in which the BYOC infrastructure will be located
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("regionId")]
    public RegionId1? RegionId { get; init; }

    /// <summary>
    /// Cloud account ID the BYOC infrastructure is configured for
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountId")]
    public string? AccountId { get; init; }

    /// <summary>
    /// List of availability zone suffixes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("availabilityZoneSuffixes")]
    public IReadOnlyList<AvailabilityZoneSuffix>? AvailabilityZoneSuffixes { get; init; }

    /// <summary>
    /// CIDR range for VPC
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vpcCidrRange")]
    public string? VpcCidrRange { get; init; }

    /// <summary>
    /// Human readable name for infrastructure
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
