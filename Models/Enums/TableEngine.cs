using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// ClickHouse table engine: "ReplacingMergeTree" (handles updates/deletes), "MergeTree" (append-only), or "Null" (forward data to materialized views without storing it).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TableEngine>))]
public sealed record TableEngine : StringEnum<TableEngine>
{
    private TableEngine(string value) : base(value)
    {
    }

    public static readonly TableEngine MergeTree = new("MergeTree");

    public static readonly TableEngine ReplacingMergeTree = new("ReplacingMergeTree");

    public static readonly TableEngine Null = new("Null");

    public static TableEngine FromValue(string value) => FromValueCore(value);
}
