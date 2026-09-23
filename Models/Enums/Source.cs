using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Alert source type (tile-based or saved search).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Source>))]
public sealed record Source : StringEnum<Source>
{
    private Source(string value) : base(value)
    {
    }

    public static readonly Source SavedSearch = new("saved_search");

    public static readonly Source Tile = new("tile");

    public static Source FromValue(string value) => FromValueCore(value);
}
