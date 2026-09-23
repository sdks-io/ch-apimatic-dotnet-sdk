using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Language of the where condition
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WhereLanguage10>))]
public sealed record WhereLanguage10 : StringEnum<WhereLanguage10>
{
    private WhereLanguage10(string value) : base(value)
    {
    }

    public static readonly WhereLanguage10 Sql = new("sql");

    public static readonly WhereLanguage10 Lucene = new("lucene");

    public static WhereLanguage10 FromValue(string value) => FromValueCore(value);
}
