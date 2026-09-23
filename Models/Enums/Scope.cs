using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Granularity at which the limit is applied. For example, <c>replicas-per-warehouse</c> is an organization-wide setting that limits each warehouse individually.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Scope>))]
public sealed record Scope : StringEnum<Scope>
{
    private Scope(string value) : base(value)
    {
    }

    public static readonly Scope Organization = new("organization");

    public static readonly Scope Warehouse = new("warehouse");

    public static Scope FromValue(string value) => FromValueCore(value);
}
