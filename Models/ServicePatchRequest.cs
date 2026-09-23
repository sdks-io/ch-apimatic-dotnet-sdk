using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Models.Enums;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ServicePatchRequest
{
    /// <summary>
    /// Name of the service. Alphanumerical string with whitespaces up to 50 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [StringLength(50, MinimumLength = 1)]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAccessList")]
    public IpAccessListPatch? IpAccessList { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privateEndpointIds")]
    public InstancePrivateEndpointsPatch? PrivateEndpointIds { get; init; }

    /// <summary>
    /// Select fast if you want to get new ClickHouse releases as soon as they are available. You'll get new features faster, but with a higher risk of bugs. Select slow if you would like to defer releases to give yourself more time to test. This feature is only available for production services. default is the regular release channel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("releaseChannel")]
    public ReleaseChannel? ReleaseChannel { get; init; }

    /// <summary>
    /// List of service endpoints to change
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("endpoints")]
    public IReadOnlyList<ServiceEndpointChange>? Endpoints { get; init; }

    /// <summary>
    /// The id of the key to rotate
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transparentDataEncryptionKeyId")]
    public string? TransparentDataEncryptionKeyId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tags")]
    public InstanceTagsPatch? Tags { get; init; }

    /// <summary>
    /// If true, the underlying infra is enabled for collecting core dumps.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableCoreDumps")]
    public bool? EnableCoreDumps { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
