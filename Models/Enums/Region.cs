using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Service region.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Region>))]
public sealed record Region : StringEnum<Region>
{
    private Region(string value) : base(value)
    {
    }

    public static readonly Region ApNortheast1 = new("ap-northeast-1");

    public static readonly Region ApNortheast2 = new("ap-northeast-2");

    public static readonly Region ApSouth1 = new("ap-south-1");

    public static readonly Region ApSoutheast1 = new("ap-southeast-1");

    public static readonly Region ApSoutheast2 = new("ap-southeast-2");

    public static readonly Region CaCentral1 = new("ca-central-1");

    public static readonly Region EuCentral1 = new("eu-central-1");

    public static readonly Region EuWest1 = new("eu-west-1");

    public static readonly Region EuWest2 = new("eu-west-2");

    public static readonly Region IlCentral1 = new("il-central-1");

    public static readonly Region UsEast1 = new("us-east-1");

    public static readonly Region UsEast2 = new("us-east-2");

    public static readonly Region UsWest2 = new("us-west-2");

    public static readonly Region UsEast12 = new("us-east1");

    public static readonly Region UsCentral1 = new("us-central1");

    public static readonly Region EuropeWest2 = new("europe-west2");

    public static readonly Region EuropeWest4 = new("europe-west4");

    public static readonly Region AsiaSoutheast1 = new("asia-southeast1");

    public static readonly Region AsiaNortheast1 = new("asia-northeast1");

    public static readonly Region Eastus = new("eastus");

    public static readonly Region Eastus2 = new("eastus2");

    public static readonly Region Westus3 = new("westus3");

    public static readonly Region Germanywestcentral = new("germanywestcentral");

    public static readonly Region Centralus = new("centralus");

    public static Region FromValue(string value) => FromValueCore(value);
}
