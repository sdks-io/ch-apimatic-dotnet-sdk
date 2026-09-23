using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Bucket provider
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BucketProvider1>))]
public sealed record BucketProvider1 : StringEnum<BucketProvider1>
{
    private BucketProvider1(string value) : base(value)
    {
    }

    public static readonly BucketProvider1 Gcp = new("GCP");

    public static BucketProvider1 FromValue(string value) => FromValueCore(value);
}
