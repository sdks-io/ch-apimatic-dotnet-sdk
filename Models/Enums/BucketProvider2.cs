using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Bucket provider
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BucketProvider2>))]
public sealed record BucketProvider2 : StringEnum<BucketProvider2>
{
    private BucketProvider2(string value) : base(value)
    {
    }

    public static readonly BucketProvider2 Azure = new("AZURE");

    public static BucketProvider2 FromValue(string value) => FromValueCore(value);
}
