using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Status of the snapshot: 'done', 'error', 'in_progress', 'throttled'. 'throttled' means snapshot creation was rate-limited and will be retried.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status2>))]
public sealed record Status2 : StringEnum<Status2>
{
    private Status2(string value) : base(value)
    {
    }

    public static readonly Status2 Done = new("done");

    public static readonly Status2 Error = new("error");

    public static readonly Status2 InProgress = new("in_progress");

    public static readonly Status2 Throttled = new("throttled");

    public static Status2 FromValue(string value) => FromValueCore(value);
}
