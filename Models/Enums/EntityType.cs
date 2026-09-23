using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of the entity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityType>))]
public sealed record EntityType : StringEnum<EntityType>
{
    private EntityType(string value) : base(value)
    {
    }

    public static readonly EntityType Datawarehouse = new("datawarehouse");

    public static readonly EntityType Service = new("service");

    public static readonly EntityType Clickpipe = new("clickpipe");

    public static EntityType FromValue(string value) => FromValueCore(value);
}
