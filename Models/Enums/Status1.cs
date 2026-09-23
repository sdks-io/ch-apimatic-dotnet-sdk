using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Status of the backup: 'done', 'error', 'in_progress'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : StringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Done = new("done");

    public static readonly Status1 Error = new("error");

    public static readonly Status1 InProgress = new("in_progress");

    public static Status1 FromValue(string value) => FromValueCore(value);
}
