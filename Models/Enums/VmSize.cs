using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// The VM size for a Postgres service.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VmSize>))]
public sealed record VmSize : StringEnum<VmSize>
{
    private VmSize(string value) : base(value)
    {
    }

    public static readonly VmSize C6GdLarge = new("c6gd.large");

    public static readonly VmSize C6GdXlarge = new("c6gd.xlarge");

    public static readonly VmSize C6Gd2Xlarge = new("c6gd.2xlarge");

    public static readonly VmSize C6Gd4Xlarge = new("c6gd.4xlarge");

    public static readonly VmSize C6Gd8Xlarge = new("c6gd.8xlarge");

    public static readonly VmSize C6Gd16Xlarge = new("c6gd.16xlarge");

    public static readonly VmSize I7ILarge = new("i7i.large");

    public static readonly VmSize I7IXlarge = new("i7i.xlarge");

    public static readonly VmSize I7I2Xlarge = new("i7i.2xlarge");

    public static readonly VmSize I7I4Xlarge = new("i7i.4xlarge");

    public static readonly VmSize I7I8Xlarge = new("i7i.8xlarge");

    public static readonly VmSize I7I12Xlarge = new("i7i.12xlarge");

    public static readonly VmSize I7I16Xlarge = new("i7i.16xlarge");

    public static readonly VmSize I7I24Xlarge = new("i7i.24xlarge");

    public static readonly VmSize I7IeLarge = new("i7ie.large");

    public static readonly VmSize I7IeXlarge = new("i7ie.xlarge");

    public static readonly VmSize I7Ie2Xlarge = new("i7ie.2xlarge");

    public static readonly VmSize I7Ie3Xlarge = new("i7ie.3xlarge");

    public static readonly VmSize I7Ie6Xlarge = new("i7ie.6xlarge");

    public static readonly VmSize I7Ie12Xlarge = new("i7ie.12xlarge");

    public static readonly VmSize I7Ie18Xlarge = new("i7ie.18xlarge");

    public static readonly VmSize I7Ie24Xlarge = new("i7ie.24xlarge");

    public static readonly VmSize I8GLarge = new("i8g.large");

    public static readonly VmSize I8GXlarge = new("i8g.xlarge");

    public static readonly VmSize I8G2Xlarge = new("i8g.2xlarge");

    public static readonly VmSize I8G4Xlarge = new("i8g.4xlarge");

    public static readonly VmSize I8G8Xlarge = new("i8g.8xlarge");

    public static readonly VmSize I8G16Xlarge = new("i8g.16xlarge");

    public static readonly VmSize I8G24Xlarge = new("i8g.24xlarge");

    public static readonly VmSize I8GeLarge = new("i8ge.large");

    public static readonly VmSize I8GeXlarge = new("i8ge.xlarge");

    public static readonly VmSize I8Ge2Xlarge = new("i8ge.2xlarge");

    public static readonly VmSize I8Ge3Xlarge = new("i8ge.3xlarge");

    public static readonly VmSize I8Ge6Xlarge = new("i8ge.6xlarge");

    public static readonly VmSize I8Ge12Xlarge = new("i8ge.12xlarge");

    public static readonly VmSize I8Ge18Xlarge = new("i8ge.18xlarge");

    public static readonly VmSize I8Ge24Xlarge = new("i8ge.24xlarge");

    public static readonly VmSize M6GdLarge = new("m6gd.large");

    public static readonly VmSize M6GdXlarge = new("m6gd.xlarge");

    public static readonly VmSize M6Gd2Xlarge = new("m6gd.2xlarge");

    public static readonly VmSize M6Gd4Xlarge = new("m6gd.4xlarge");

    public static readonly VmSize M6Gd8Xlarge = new("m6gd.8xlarge");

    public static readonly VmSize M6Gd16Xlarge = new("m6gd.16xlarge");

    public static readonly VmSize M6IdLarge = new("m6id.large");

    public static readonly VmSize M6IdXlarge = new("m6id.xlarge");

    public static readonly VmSize M6Id2Xlarge = new("m6id.2xlarge");

    public static readonly VmSize M6Id4Xlarge = new("m6id.4xlarge");

    public static readonly VmSize M6Id8Xlarge = new("m6id.8xlarge");

    public static readonly VmSize M6Id16Xlarge = new("m6id.16xlarge");

    public static readonly VmSize M8GdLarge = new("m8gd.large");

    public static readonly VmSize M8GdXlarge = new("m8gd.xlarge");

    public static readonly VmSize M8Gd2Xlarge = new("m8gd.2xlarge");

    public static readonly VmSize M8Gd4Xlarge = new("m8gd.4xlarge");

    public static readonly VmSize M8Gd8Xlarge = new("m8gd.8xlarge");

    public static readonly VmSize M8Gd16Xlarge = new("m8gd.16xlarge");

    public static readonly VmSize R6GdMedium = new("r6gd.medium");

    public static readonly VmSize R6GdLarge = new("r6gd.large");

    public static readonly VmSize R6GdXlarge = new("r6gd.xlarge");

    public static readonly VmSize R6Gd2Xlarge = new("r6gd.2xlarge");

    public static readonly VmSize R6Gd4Xlarge = new("r6gd.4xlarge");

    public static readonly VmSize R6Gd8Xlarge = new("r6gd.8xlarge");

    public static readonly VmSize R6Gd12Xlarge = new("r6gd.12xlarge");

    public static readonly VmSize R6Gd16Xlarge = new("r6gd.16xlarge");

    public static readonly VmSize R6IdLarge = new("r6id.large");

    public static readonly VmSize R6IdXlarge = new("r6id.xlarge");

    public static readonly VmSize R6Id2Xlarge = new("r6id.2xlarge");

    public static readonly VmSize R6Id4Xlarge = new("r6id.4xlarge");

    public static readonly VmSize R6Id8Xlarge = new("r6id.8xlarge");

    public static readonly VmSize R6Id12Xlarge = new("r6id.12xlarge");

    public static readonly VmSize R6Id16Xlarge = new("r6id.16xlarge");

    public static readonly VmSize R6Id24Xlarge = new("r6id.24xlarge");

    public static readonly VmSize R6Id32Xlarge = new("r6id.32xlarge");

    public static readonly VmSize R8GdMedium = new("r8gd.medium");

    public static readonly VmSize R8GdLarge = new("r8gd.large");

    public static readonly VmSize R8GdXlarge = new("r8gd.xlarge");

    public static readonly VmSize R8Gd2Xlarge = new("r8gd.2xlarge");

    public static readonly VmSize R8Gd4Xlarge = new("r8gd.4xlarge");

    public static readonly VmSize R8Gd8Xlarge = new("r8gd.8xlarge");

    public static readonly VmSize R8Gd12Xlarge = new("r8gd.12xlarge");

    public static readonly VmSize R8Gd16Xlarge = new("r8gd.16xlarge");

    public static readonly VmSize R8Gd24Xlarge = new("r8gd.24xlarge");

    public static readonly VmSize R8Gd48Xlarge = new("r8gd.48xlarge");

    public static readonly VmSize C4AHighmem4 = new("c4a-highmem-4");

    public static readonly VmSize C4AHighmem8 = new("c4a-highmem-8");

    public static readonly VmSize C4AHighmem16 = new("c4a-highmem-16");

    public static readonly VmSize C4AHighmem32 = new("c4a-highmem-32");

    public static readonly VmSize C4AHighmem48 = new("c4a-highmem-48");

    public static readonly VmSize C4AHighmem64 = new("c4a-highmem-64");

    public static readonly VmSize C4AHighmem72 = new("c4a-highmem-72");

    public static readonly VmSize C4AStandard4 = new("c4a-standard-4");

    public static readonly VmSize C4AStandard8 = new("c4a-standard-8");

    public static readonly VmSize C4AStandard16 = new("c4a-standard-16");

    public static readonly VmSize C4AStandard32 = new("c4a-standard-32");

    public static readonly VmSize C4AStandard48 = new("c4a-standard-48");

    public static readonly VmSize C4AStandard64 = new("c4a-standard-64");

    public static readonly VmSize C4AStandard72 = new("c4a-standard-72");

    public static readonly VmSize C4Highmem4 = new("c4-highmem-4");

    public static readonly VmSize C4Highmem8 = new("c4-highmem-8");

    public static readonly VmSize C4Highmem16 = new("c4-highmem-16");

    public static readonly VmSize C4Highmem24 = new("c4-highmem-24");

    public static readonly VmSize C4Highmem32 = new("c4-highmem-32");

    public static readonly VmSize C4Highmem48 = new("c4-highmem-48");

    public static readonly VmSize C4Highmem96 = new("c4-highmem-96");

    public static readonly VmSize C4Highmem144 = new("c4-highmem-144");

    public static readonly VmSize C4Highmem192 = new("c4-highmem-192");

    public static readonly VmSize C4Highmem288 = new("c4-highmem-288");

    public static readonly VmSize C4Standard4 = new("c4-standard-4");

    public static readonly VmSize C4Standard8 = new("c4-standard-8");

    public static readonly VmSize C4Standard16 = new("c4-standard-16");

    public static readonly VmSize C4Standard24 = new("c4-standard-24");

    public static readonly VmSize C4Standard32 = new("c4-standard-32");

    public static readonly VmSize C4Standard48 = new("c4-standard-48");

    public static readonly VmSize C4Standard96 = new("c4-standard-96");

    public static readonly VmSize C4Standard144 = new("c4-standard-144");

    public static readonly VmSize C4Standard192 = new("c4-standard-192");

    public static readonly VmSize C4Standard288 = new("c4-standard-288");

    public static readonly VmSize C4DHighmem8 = new("c4d-highmem-8");

    public static readonly VmSize C4DHighmem16 = new("c4d-highmem-16");

    public static readonly VmSize C4DHighmem32 = new("c4d-highmem-32");

    public static readonly VmSize C4DHighmem48 = new("c4d-highmem-48");

    public static readonly VmSize C4DHighmem64 = new("c4d-highmem-64");

    public static readonly VmSize C4DHighmem96 = new("c4d-highmem-96");

    public static readonly VmSize C4DHighmem192 = new("c4d-highmem-192");

    public static readonly VmSize C4DHighmem384 = new("c4d-highmem-384");

    public static readonly VmSize C4DStandard8 = new("c4d-standard-8");

    public static readonly VmSize C4DStandard16 = new("c4d-standard-16");

    public static readonly VmSize C4DStandard32 = new("c4d-standard-32");

    public static readonly VmSize C4DStandard48 = new("c4d-standard-48");

    public static readonly VmSize C4DStandard64 = new("c4d-standard-64");

    public static readonly VmSize C4DStandard96 = new("c4d-standard-96");

    public static readonly VmSize C4DStandard192 = new("c4d-standard-192");

    public static readonly VmSize C4DStandard384 = new("c4d-standard-384");

    public static readonly VmSize Z3Highlssd8 = new("z3-highlssd-8");

    public static readonly VmSize Z3Highlssd16 = new("z3-highlssd-16");

    public static readonly VmSize Z3Highlssd22 = new("z3-highlssd-22");

    public static readonly VmSize Z3Highlssd32 = new("z3-highlssd-32");

    public static readonly VmSize Z3Highlssd44 = new("z3-highlssd-44");

    public static readonly VmSize Z3Highlssd88 = new("z3-highlssd-88");

    public static readonly VmSize Z3Standardlssd14 = new("z3-standardlssd-14");

    public static readonly VmSize Z3Standardlssd22 = new("z3-standardlssd-22");

    public static readonly VmSize Z3Standardlssd44 = new("z3-standardlssd-44");

    public static readonly VmSize Z3Standardlssd88 = new("z3-standardlssd-88");

    public static readonly VmSize Z3Standardlssd176 = new("z3-standardlssd-176");

    public static VmSize FromValue(string value) => FromValueCore(value);
}
