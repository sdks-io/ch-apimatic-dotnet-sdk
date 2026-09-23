using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Query language for the where clause
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WhereLanguage>))]
public sealed record WhereLanguage : StringEnum<WhereLanguage>
{
    private WhereLanguage(string value) : base(value)
    {
    }

    public static readonly WhereLanguage Sql = new("sql");

    public static readonly WhereLanguage Lucene = new("lucene");

    public static WhereLanguage FromValue(string value) => FromValueCore(value);
}
