using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Always <c>sql</c>. Only SQL predicate filters render in the sidebar.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type20>))]
public sealed record Type20 : StringEnum<Type20>
{
    private Type20(string value) : base(value)
    {
    }

    public static readonly Type20 Sql = new("sql");

    public static Type20 FromValue(string value) => FromValueCore(value);
}
