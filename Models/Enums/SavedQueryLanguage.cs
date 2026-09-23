using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Query language used by savedQuery.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SavedQueryLanguage>))]
public sealed record SavedQueryLanguage : StringEnum<SavedQueryLanguage>
{
    private SavedQueryLanguage(string value) : base(value)
    {
    }

    public static readonly SavedQueryLanguage Sql = new("sql");

    public static readonly SavedQueryLanguage Lucene = new("lucene");

    public static SavedQueryLanguage FromValue(string value) => FromValueCore(value);
}
