using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Controls whether lucene rendering uses ClickHouse text indices via hasAllTokens() against the implicit column. "auto" detects a covering index at query time, "enabled" forces text index usage, "disabled" forces a LIKE/hasToken fallback.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UseTextIndexForImplicitColumn>))]
public sealed record UseTextIndexForImplicitColumn : StringEnum<UseTextIndexForImplicitColumn>
{
    private UseTextIndexForImplicitColumn(string value) : base(value)
    {
    }

    public static readonly UseTextIndexForImplicitColumn Auto = new("auto");

    public static readonly UseTextIndexForImplicitColumn Enabled = new("enabled");

    public static readonly UseTextIndexForImplicitColumn Disabled = new("disabled");

    public static UseTextIndexForImplicitColumn FromValue(string value) => FromValueCore(value);
}
