using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Region for which the BYOC has been configured and where it is possible to create services
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RegionId>))]
public sealed record RegionId : StringEnum<RegionId>
{
    private RegionId(string value) : base(value)
    {
    }

    public static readonly RegionId ApNortheast1 = new("ap-northeast-1");

    public static readonly RegionId ApNortheast2 = new("ap-northeast-2");

    public static readonly RegionId ApSouth1 = new("ap-south-1");

    public static readonly RegionId ApSoutheast1 = new("ap-southeast-1");

    public static readonly RegionId ApSoutheast2 = new("ap-southeast-2");

    public static readonly RegionId CaCentral1 = new("ca-central-1");

    public static readonly RegionId EuCentral1 = new("eu-central-1");

    public static readonly RegionId EuWest1 = new("eu-west-1");

    public static readonly RegionId EuWest2 = new("eu-west-2");

    public static readonly RegionId IlCentral1 = new("il-central-1");

    public static readonly RegionId UsEast1 = new("us-east-1");

    public static readonly RegionId UsEast2 = new("us-east-2");

    public static readonly RegionId UsWest2 = new("us-west-2");

    public static readonly RegionId UsEast12 = new("us-east1");

    public static readonly RegionId UsCentral1 = new("us-central1");

    public static readonly RegionId EuropeWest2 = new("europe-west2");

    public static readonly RegionId EuropeWest4 = new("europe-west4");

    public static readonly RegionId AsiaSoutheast1 = new("asia-southeast1");

    public static readonly RegionId AsiaNortheast1 = new("asia-northeast1");

    public static readonly RegionId Eastus = new("eastus");

    public static readonly RegionId Eastus2 = new("eastus2");

    public static readonly RegionId Westus3 = new("westus3");

    public static readonly RegionId Germanywestcentral = new("germanywestcentral");

    public static readonly RegionId Centralus = new("centralus");

    public static RegionId FromValue(string value) => FromValueCore(value);
}
