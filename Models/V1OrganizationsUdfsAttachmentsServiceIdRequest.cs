using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record V1OrganizationsUdfsAttachmentsServiceIdRequest
{
    /// <summary>
    /// Version to attach. When omitted, the latest ready version is attached.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    [Minimum(1)]
    public int? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
