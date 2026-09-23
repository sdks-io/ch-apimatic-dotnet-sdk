using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Bucket provider
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BucketProvider>))]
public sealed record BucketProvider : StringEnum<BucketProvider>
{
    private BucketProvider(string value) : base(value)
    {
    }

    public static readonly BucketProvider Aws = new("AWS");

    public static BucketProvider FromValue(string value) => FromValueCore(value);
}
