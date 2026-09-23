using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Models;

namespace OpenApiSpecForClickHouseCloud.Models;

public record ServicePasswordPatchRequest
{
    /// <summary>
    /// Optional password hash. Used to avoid password transmission over network. If not provided a new password is generated and is provided in the response. Otherwise this hash is used. Algorithm: echo -n "yourpassword" | sha256sum | tr -d '-' | xxd -r -p | base64
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newPasswordHash")]
    public string? NewPasswordHash { get; init; }

    /// <summary>
    /// Optional double SHA1 password hash for MySQL protocol. If newPasswordHash is not provided this key will be ignored and the generated password will be used. Algorithm: echo -n "yourpassword" | sha1sum | tr -d '-' | xxd -r -p | sha1sum | tr -d '-'
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("newDoubleSha1Hash")]
    public string? NewDoubleSha1Hash { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
