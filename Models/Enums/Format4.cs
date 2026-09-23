using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Format of the files.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Format4>))]
public sealed record Format4 : StringEnum<Format4>
{
    private Format4(string value) : base(value)
    {
    }

    public static readonly Format4 JsonEachRow = new("JSONEachRow");

    public static readonly Format4 JsonAsObject = new("JSONAsObject");

    public static readonly Format4 Csv = new("CSV");

    public static readonly Format4 CsvWithNames = new("CSVWithNames");

    public static readonly Format4 TabSeparated = new("TabSeparated");

    public static readonly Format4 TabSeparatedWithNames = new("TabSeparatedWithNames");

    public static readonly Format4 Parquet = new("Parquet");

    public static readonly Format4 Avro = new("Avro");

    public static Format4 FromValue(string value) => FromValueCore(value);
}
