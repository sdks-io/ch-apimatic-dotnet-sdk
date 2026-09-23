using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// The cloud provider for a Postgres service.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CloudProvider>))]
public sealed record CloudProvider : StringEnum<CloudProvider>
{
    private CloudProvider(string value) : base(value)
    {
    }

    public static readonly CloudProvider Aws = new("aws");

    public static readonly CloudProvider Gcp = new("gcp");

    public static CloudProvider FromValue(string value) => FromValueCore(value);
}
