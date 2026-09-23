using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Cloud provider of the region
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CloudProvider2>))]
public sealed record CloudProvider2 : StringEnum<CloudProvider2>
{
    private CloudProvider2(string value) : base(value)
    {
    }

    public static readonly CloudProvider2 Gcp = new("gcp");

    public static readonly CloudProvider2 Aws = new("aws");

    public static readonly CloudProvider2 Azure = new("azure");

    public static CloudProvider2 FromValue(string value) => FromValueCore(value);
}
