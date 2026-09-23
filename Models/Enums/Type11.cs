using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Engine type of the destination table.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type11>))]
public sealed record Type11 : StringEnum<Type11>
{
    private Type11(string value) : base(value)
    {
    }

    public static readonly Type11 MergeTree = new("MergeTree");

    public static readonly Type11 ReplacingMergeTree = new("ReplacingMergeTree");

    public static readonly Type11 SummingMergeTree = new("SummingMergeTree");

    public static readonly Type11 Null = new("Null");

    public static Type11 FromValue(string value) => FromValueCore(value);
}
