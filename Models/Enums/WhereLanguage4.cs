using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Query language for the where clause.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WhereLanguage4>))]
public sealed record WhereLanguage4 : StringEnum<WhereLanguage4>
{
    private WhereLanguage4(string value) : base(value)
    {
    }

    public static readonly WhereLanguage4 Sql = new("sql");

    public static readonly WhereLanguage4 Lucene = new("lucene");

    public static WhereLanguage4 FromValue(string value) => FromValueCore(value);
}
