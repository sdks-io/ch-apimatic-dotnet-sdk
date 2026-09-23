using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Language of the rendered whereTemplate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WhereLanguage5>))]
public sealed record WhereLanguage5 : StringEnum<WhereLanguage5>
{
    private WhereLanguage5(string value) : base(value)
    {
    }

    public static readonly WhereLanguage5 Sql = new("sql");

    public static readonly WhereLanguage5 Lucene = new("lucene");

    public static WhereLanguage5 FromValue(string value) => FromValueCore(value);
}
