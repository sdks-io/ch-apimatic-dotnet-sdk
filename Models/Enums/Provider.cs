using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Cloud provider
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Provider>))]
public sealed record Provider : StringEnum<Provider>
{
    private Provider(string value) : base(value)
    {
    }

    public static readonly Provider Aws = new("aws");

    public static readonly Provider Gcp = new("gcp");

    public static readonly Provider Azure = new("azure");

    public static Provider FromValue(string value) => FromValueCore(value);
}
