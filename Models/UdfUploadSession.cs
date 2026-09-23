using System;
using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Validation;
using OpenApiSpecForClickHouseCloud.Core.Validation.Attributes;

namespace OpenApiSpecForClickHouseCloud.Models;

public record UdfUploadSession
{
    /// <summary>
    /// Identifier of the uploaded source archive.
    /// </summary>
    [JsonPropertyName("uploadId")]
    public required Guid UploadId { get; init; }

    /// <summary>
    /// Presigned URL for uploading the source archive.
    /// </summary>
    [JsonPropertyName("uploadUrl")]
    [Format(FormatKind.Uri)]
    public required string UploadUrl { get; init; }

    /// <summary>
    /// Presigned-URL expiry timestamp.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public required DateTimeOffset ExpiresAt { get; init; }
}
