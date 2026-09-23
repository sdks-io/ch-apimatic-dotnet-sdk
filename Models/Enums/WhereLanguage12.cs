using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Language used for the where filter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WhereLanguage12>))]
public sealed record WhereLanguage12 : StringEnum<WhereLanguage12>
{
    private WhereLanguage12(string value) : base(value)
    {
    }

    public static readonly WhereLanguage12 Lucene = new("lucene");

    public static readonly WhereLanguage12 Sql = new("sql");

    public static WhereLanguage12 FromValue(string value) => FromValueCore(value);
}
