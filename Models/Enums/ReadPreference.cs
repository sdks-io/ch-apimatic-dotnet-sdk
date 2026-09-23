using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// MongoDB read preference for replica set reads.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReadPreference>))]
public sealed record ReadPreference : StringEnum<ReadPreference>
{
    private ReadPreference(string value) : base(value)
    {
    }

    public static readonly ReadPreference Primary = new("primary");

    public static readonly ReadPreference PrimaryPreferred = new("primaryPreferred");

    public static readonly ReadPreference Secondary = new("secondary");

    public static readonly ReadPreference SecondaryPreferred = new("secondaryPreferred");

    public static readonly ReadPreference Nearest = new("nearest");

    public static ReadPreference FromValue(string value) => FromValueCore(value);
}
