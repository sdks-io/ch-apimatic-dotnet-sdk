using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Table engine to use for the target table.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TableEngine4>))]
public sealed record TableEngine4 : StringEnum<TableEngine4>
{
    private TableEngine4(string value) : base(value)
    {
    }

    public static readonly TableEngine4 MergeTree = new("MergeTree");

    public static readonly TableEngine4 ReplacingMergeTree = new("ReplacingMergeTree");

    public static readonly TableEngine4 Null = new("Null");

    public static TableEngine4 FromValue(string value) => FromValueCore(value);
}
