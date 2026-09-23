using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Type of the Postgres source. Defaults to "postgres" if not specified.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type7>))]
public sealed record Type7 : StringEnum<Type7>
{
    private Type7(string value) : base(value)
    {
    }

    public static readonly Type7 Postgres = new("postgres");

    public static readonly Type7 Supabase = new("supabase");

    public static readonly Type7 Neon = new("neon");

    public static readonly Type7 Alloydb = new("alloydb");

    public static readonly Type7 Planetscale = new("planetscale");

    public static readonly Type7 Rdspostgres = new("rdspostgres");

    public static readonly Type7 Aurorapostgres = new("aurorapostgres");

    public static readonly Type7 Cloudsqlpostgres = new("cloudsqlpostgres");

    public static readonly Type7 Azurepostgres = new("azurepostgres");

    public static readonly Type7 Crunchybridge = new("crunchybridge");

    public static readonly Type7 Tigerdata = new("tigerdata");

    public static Type7 FromValue(string value) => FromValueCore(value);
}
