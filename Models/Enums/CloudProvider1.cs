using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Cloud provider in which the private endpoint is lcoated
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CloudProvider1>))]
public sealed record CloudProvider1 : StringEnum<CloudProvider1>
{
    private CloudProvider1(string value) : base(value)
    {
    }

    public static readonly CloudProvider1 Gcp = new("gcp");

    public static readonly CloudProvider1 Aws = new("aws");

    public static readonly CloudProvider1 Azure = new("azure");

    public static CloudProvider1 FromValue(string value) => FromValueCore(value);
}
