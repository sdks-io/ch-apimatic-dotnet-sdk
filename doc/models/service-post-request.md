
# Service Post Request

*This model accepts additional fields of type object.*

## Structure

`ServicePostRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the service. Alphanumerical string with whitespaces up to 50 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `50` |
| `Provider` | [`Provider?`](../../doc/models/provider.md) | Optional | Cloud provider |
| `Region` | [`Region?`](../../doc/models/region.md) | Optional | Service region. |
| `Tier` | [`Tier?`](../../doc/models/tier.md) | Optional | DEPRECATED for BASIC, SCALE and ENTERPRISE organization tiers. Use `minReplicaMemoryGb`, `maxReplicaMemoryGb`, and `numReplicas` instead. Tier of the service: 'development', 'production', 'dedicated_high_mem', 'dedicated_high_cpu', 'dedicated_standard', 'dedicated_standard_n2d_standard_4', 'dedicated_standard_n2d_standard_8', 'dedicated_standard_n2d_standard_32', 'dedicated_standard_n2d_standard_128', 'dedicated_standard_n2d_standard_32_16SSD', 'dedicated_standard_n2d_standard_64_24SSD'. Production services scale, Development are fixed size. Azure services don't support Development tier |
| `IpAccessList` | [`List<IpAccessListEntry>`](../../doc/models/ip-access-list-entry.md) | Optional | List of IP addresses allowed to access the service |
| `MinTotalMemoryGb` | `double?` | Optional | DEPRECATED - inaccurate for services with non-default numbers of replicas. Use `minReplicaMemoryGb` instead. Minimum memory of three workers during auto-scaling in Gb. Available only for 'production' services. Must be a multiple of 12 and greater than or equal to 24. Always absent for horizontal-autoscaling services (replica count is variable).<br><br>**Constraints**: `>= 24`, `<= 1068`, *Multiple Of*: `12` |
| `MaxTotalMemoryGb` | `double?` | Optional | DEPRECATED - inaccurate for services with non-default numbers of replicas. Use `maxReplicaMemoryGb` instead. Maximum memory of three workers during auto-scaling in Gb. Available only for 'production' services. Must be a multiple of 12 and lower than or equal to 360 for non paid services or 1068 for paid services. Always absent for horizontal-autoscaling services (replica count is variable).<br><br>**Constraints**: `>= 24`, `<= 1068`, *Multiple Of*: `12` |
| `AutoscalingMode` | [`AutoscalingMode4?`](../../doc/models/autoscaling-mode-4.md) | Optional | Autoscaling mode. "vertical" (the default when omitted) runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory (minReplicaMemoryGb equal to maxReplicaMemoryGb). Horizontal requires the feature to be enabled for the organization. |
| `MinReplicaMemoryGb` | `double?` | Optional | Minimum total memory of each replica during auto-scaling in Gb. A range in vertical autoscaling; equal to maxReplicaMemoryGb in horizontal (memory is fixed while the replica count scales). Must be a multiple of 4 and greater than or equal to 8.<br><br>**Constraints**: `>= 8`, `<= 356`, *Multiple Of*: `4` |
| `MaxReplicaMemoryGb` | `double?` | Optional | Maximum total memory of each replica during auto-scaling in Gb. A range in vertical autoscaling; equal to minReplicaMemoryGb in horizontal (memory is fixed while the replica count scales). Must be a multiple of 4 and lower than or equal to 120* for non paid services or 356* for paid services.* - maximum replica size subject to cloud provider hardware availability in your selected region.<br><br>**Constraints**: `>= 8`, `<= 356`, *Multiple Of*: `4` |
| `NumReplicas` | `int?` | Optional | Fixed replica count for vertical autoscaling (autoscalingMode "vertical" or omitted). Mutually exclusive with minReplicas/maxReplicas.<br><br>**Constraints**: `>= 1`, `<= 50` |
| `MinReplicas` | `int?` | Optional | Minimum number of replicas. A minReplicas/maxReplicas band scales the replica count in horizontal autoscaling (autoscalingMode "horizontal"). Must be provided together with maxReplicas. Mutually exclusive with numReplicas. Requires horizontal autoscaling to be enabled for the organization, unless autoscalingMode is omitted or "vertical" and minReplicas equals maxReplicas (an equal band is then an accepted vertical fixed count and needs no horizontal entitlement).<br><br>**Constraints**: `>= 1`, `<= 50` |
| `MaxReplicas` | `int?` | Optional | Maximum number of replicas. A minReplicas/maxReplicas band scales the replica count in horizontal autoscaling (autoscalingMode "horizontal"). Must be provided together with minReplicas. Mutually exclusive with numReplicas. Requires horizontal autoscaling to be enabled for the organization, unless autoscalingMode is omitted or "vertical" and minReplicas equals maxReplicas (an equal band is then an accepted vertical fixed count and needs no horizontal entitlement).<br><br>**Constraints**: `>= 1`, `<= 50` |
| `IdleScaling` | `bool?` | Optional | When set to true the service is allowed to scale down to zero when idle. True by default. |
| `IdleTimeoutMinutes` | `double?` | Optional | Set minimum idling timeout (in minutes). Must be >= 5 minutes. |
| `IsReadonly` | `bool?` | Optional | True if this service is read-only. It can only be read-only if a dataWarehouseId is provided. |
| `DataWarehouseId` | `string` | Optional | Data warehouse containing this service |
| `BackupId` | `Guid?` | Optional | Optional backup ID used as an initial state for the new service. When used the region and the tier of the new instance must be the same as the values of the original instance. |
| `EncryptionKey` | `string` | Optional | Optional customer provided disk encryption key |
| `EncryptionAssumedRoleIdentifier` | `string` | Optional | Optional role to use for disk encryption |
| `PrivateEndpointIds` | `List<string>` | Optional | DEPRECATED. To associate the service with private endpoints, first create the service, then use the `Update Service Basic Details` endpoint with the `privateEndpointIds` field to modify private endpoints. |
| `PrivatePreviewTermsChecked` | `bool?` | Optional | Accept the private preview terms and conditions. It is only needed when creating the first service in the organization in case of a private preview |
| `ReleaseChannel` | [`ReleaseChannel?`](../../doc/models/release-channel.md) | Optional | Select fast if you want to get new ClickHouse releases as soon as they are available. You'll get new features faster, but with a higher risk of bugs. Select slow if you would like to defer releases to give yourself more time to test. This feature is only available for production services. default is the regular release channel. |
| `ByocId` | `string` | Optional | This is the ID returned after setting up a region for Bring Your Own Cloud (BYOC). When the byocId parameter is specified, the minReplicaMemoryGb and the maxReplicaGb parameters are required too, with values included among the following sizes: 48, 116, 172, 232. |
| `HasTransparentDataEncryption` | `bool?` | Optional | True if the service should have the Transparent Data Encryption (TDE) enabled. TDE is only available for ENTERPRISE organizations tiers and can only be enabled at service creation. |
| `Endpoints` | [`List<ServiceEndpointChange>`](../../doc/models/service-endpoint-change.md) | Optional | List of service endpoints to enable or disable |
| `Profile` | `string` | Optional | Custom instance profile. Only available for ENTERPRISE and BYOC organization tiers. Standard values: 'v1-default', 'v1-highmem-xs', 'v1-highmem-s', 'v1-highmem-m', 'v1-highmem-l', 'v1-highmem-xl'. BYOC services may instead use a dynamic BYOC profile configured for their infrastructure (e.g. 'v1-standard-byoc-4'); it requires byocId, and minReplicaMemoryGb and maxReplicaMemoryGb must both equal the profile's memory size. Use the serviceProfiles endpoint to list the profiles available to the organization. |
| `ComplianceType` | [`ComplianceType?`](../../doc/models/compliance-type.md) | Optional | Type of regulatory compliance for service. |
| `Tags` | [`List<ResourceTagsV1>`](../../doc/models/resource-tags-v1.md) | Optional | Tags associated with the service.<br><br>**Constraints**: *Maximum Items*: `50` |
| `EnableCoreDumps` | `bool?` | Optional | Enables the underlying infra for collecting core dumps. Default is enabled. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ServicePostRequest servicePostRequest = new ServicePostRequest
{
    Name = "name2",
    Provider = Provider.Azure,
    Region = Region.Europewest4,
    Tier = Tier.DedicatedStandardN2DStandard4,
    IpAccessList = new List<IpAccessListEntry>
    {
        new IpAccessListEntry
        {
            Source = "source4",
            Description = "description8",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new IpAccessListEntry
        {
            Source = "source4",
            Description = "description8",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new IpAccessListEntry
        {
            Source = "source4",
            Description = "description8",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    MinTotalMemoryGb = 48,
    MaxTotalMemoryGb = 360,
    AutoscalingMode = AutoscalingMode4.Vertical,
    MinReplicaMemoryGb = 16,
    MaxReplicaMemoryGb = 120,
    NumReplicas = 3,
    MinReplicas = 1,
    MaxReplicas = 5,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

