using System.Text.Json.Serialization;
using OpenApiSpecForClickHouseCloud.Core.Enum;

namespace OpenApiSpecForClickHouseCloud.Models.Enums;

/// <summary>
/// Region in which the private endpoint is located
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Region1>))]
public sealed record Region1 : StringEnum<Region1>
{
    private Region1(string value) : base(value)
    {
    }

    public static readonly Region1 ApNortheast1 = new("ap-northeast-1");

    public static readonly Region1 ApNortheast2 = new("ap-northeast-2");

    public static readonly Region1 ApSouth1 = new("ap-south-1");

    public static readonly Region1 ApSoutheast1 = new("ap-southeast-1");

    public static readonly Region1 ApSoutheast2 = new("ap-southeast-2");

    public static readonly Region1 CaCentral1 = new("ca-central-1");

    public static readonly Region1 EuCentral1 = new("eu-central-1");

    public static readonly Region1 EuWest1 = new("eu-west-1");

    public static readonly Region1 EuWest2 = new("eu-west-2");

    public static readonly Region1 IlCentral1 = new("il-central-1");

    public static readonly Region1 UsEast1 = new("us-east-1");

    public static readonly Region1 UsEast2 = new("us-east-2");

    public static readonly Region1 UsWest2 = new("us-west-2");

    public static readonly Region1 UsEast12 = new("us-east1");

    public static readonly Region1 UsCentral1 = new("us-central1");

    public static readonly Region1 EuropeWest2 = new("europe-west2");

    public static readonly Region1 EuropeWest4 = new("europe-west4");

    public static readonly Region1 AsiaSoutheast1 = new("asia-southeast1");

    public static readonly Region1 AsiaNortheast1 = new("asia-northeast1");

    public static readonly Region1 Eastus = new("eastus");

    public static readonly Region1 Eastus2 = new("eastus2");

    public static readonly Region1 Westus3 = new("westus3");

    public static readonly Region1 Germanywestcentral = new("germanywestcentral");

    public static readonly Region1 Centralus = new("centralus");

    public static Region1 FromValue(string value) => FromValueCore(value);
}
