using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Offset strategy.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Strategy>))]
public sealed record Strategy : StringEnum<Strategy>
{
    private Strategy(string value) : base(value)
    {
    }

    public static readonly Strategy FromBeginning = new("from_beginning");

    public static readonly Strategy FromLatest = new("from_latest");

    public static readonly Strategy FromTimestamp = new("from_timestamp");

    public static Strategy FromValue(string value) => FromValueCore(value);
}
