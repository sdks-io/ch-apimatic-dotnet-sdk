
# Service

*This model accepts additional fields of type object.*

## Structure

`Service`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `Guid?` | Optional | Unique service ID. |
| `Name` | `string` | Optional | Name of the service. Alphanumerical string with whitespaces up to 50 characters.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `50` |
| `Provider` | [`Provider?`](../../doc/models/provider.md) | Optional | Cloud provider |
| `Region` | [`Region?`](../../doc/models/region.md) | Optional | Service region. |
| `State` | [`State?`](../../doc/models/state.md) | Optional | Current state of the service. |
| `ClickhouseVersion` | `string` | Optional | ClickHouse version of the service. |
| `Endpoints` | [`List<ServiceEndpoint>`](../../doc/models/service-endpoint.md) | Optional | List of all service endpoints. |
| `Tier` | [`Tier?`](../../doc/models/tier.md) | Optional | DEPRECATED for BASIC, SCALE and ENTERPRISE organization tiers. Use `minReplicaMemoryGb`, `maxReplicaMemoryGb`, and `numReplicas` instead. Tier of the service: 'development', 'production', 'dedicated_high_mem', 'dedicated_high_cpu', 'dedicated_standard', 'dedicated_standard_n2d_standard_4', 'dedicated_standard_n2d_standard_8', 'dedicated_standard_n2d_standard_32', 'dedicated_standard_n2d_standard_128', 'dedicated_standard_n2d_standard_32_16SSD', 'dedicated_standard_n2d_standard_64_24SSD'. Production services scale, Development are fixed size. Azure services don't support Development tier |
| `MinTotalMemoryGb` | `double?` | Optional | DEPRECATED - inaccurate for services with non-default numbers of replicas. Use `minReplicaMemoryGb` instead. Minimum memory of three workers during auto-scaling in Gb. Available only for 'production' services. Must be a multiple of 12 and greater than or equal to 24. Always absent for horizontal-autoscaling services (replica count is variable).<br><br>**Constraints**: `>= 24`, `<= 1068`, *Multiple Of*: `12` |
| `MaxTotalMemoryGb` | `double?` | Optional | DEPRECATED - inaccurate for services with non-default numbers of replicas. Use `maxReplicaMemoryGb` instead. Maximum memory of three workers during auto-scaling in Gb. Available only for 'production' services. Must be a multiple of 12 and lower than or equal to 360 for non paid services or 1068 for paid services. Always absent for horizontal-autoscaling services (replica count is variable).<br><br>**Constraints**: `>= 24`, `<= 1068`, *Multiple Of*: `12` |
| `MinReplicaMemoryGb` | `double?` | Optional | Minimum total memory of each replica during auto-scaling in Gb. A range in vertical autoscaling; equal to maxReplicaMemoryGb in horizontal (memory is fixed while the replica count scales). Must be a multiple of 4 and greater than or equal to 8.<br><br>**Constraints**: `>= 8`, `<= 356`, *Multiple Of*: `4` |
| `MaxReplicaMemoryGb` | `double?` | Optional | Maximum total memory of each replica during auto-scaling in Gb. A range in vertical autoscaling; equal to minReplicaMemoryGb in horizontal (memory is fixed while the replica count scales). Must be a multiple of 4 and lower than or equal to 120* for non paid services or 356* for paid services.* - maximum replica size subject to cloud provider hardware availability in your selected region.<br><br>**Constraints**: `>= 8`, `<= 356`, *Multiple Of*: `4` |
| `NumReplicas` | `int?` | Optional | Number of replicas for the service. The number of replicas must be between 2 and 50 for the first service in a warehouse. Services that are created in an existing warehouse can have a number of replicas as low as 1. Further restrictions may apply based on your organization's tier and its per-warehouse replica limit. It defaults to 1 for the BASIC tier and 3 for the SCALE and ENTERPRISE tiers. Present only when the service uses vertical autoscaling. For horizontal autoscaling, use minReplicas and maxReplicas instead.<br><br>**Constraints**: `>= 1`, `<= 50` |
| `MinReplicas` | `int?` | Optional | Minimum number of replicas for horizontal autoscaling. Present only when the service uses horizontal autoscaling.<br><br>**Constraints**: `>= 1`, `<= 50` |
| `MaxReplicas` | `int?` | Optional | Maximum number of replicas for horizontal autoscaling. Present only when the service uses horizontal autoscaling.<br><br>**Constraints**: `>= 1`, `<= 50` |
| `AutoscalingMode` | [`AutoscalingMode3`](../../doc/models/autoscaling-mode-3.md) | Required | Configured autoscaling mode. "vertical" runs a fixed replica count while memory scales between minReplicaMemoryGb and maxReplicaMemoryGb; "horizontal" scales the replica count between minReplicas and maxReplicas at a fixed per-replica memory. This is the baseline configuration; the mode currently applied (which may differ while a schedule entry is active) is currentScaling.effectiveAutoscalingMode. |
| `ReplicaMemoryGb` | `double?` | Optional | Fixed memory per replica in Gb for horizontal autoscaling. Present only when the service uses horizontal autoscaling. Must be a multiple of 4, at least 8 Gb, and at most 120 Gb for non paid services or 356 Gb for paid services.<br><br>**Constraints**: `>= 8`, `<= 356`, *Multiple Of*: `4` |
| `IdleScaling` | `bool?` | Optional | When set to true the service is allowed to scale down to zero when idle. True by default. |
| `IdleTimeoutMinutes` | `double?` | Optional | Set minimum idling timeout (in minutes). Must be >= 5 minutes. |
| `IpAccessList` | [`List<IpAccessListEntry>`](../../doc/models/ip-access-list-entry.md) | Optional | List of IP addresses allowed to access the service |
| `CreatedAt` | `DateTime?` | Optional | Service creation timestamp. ISO-8601. |
| `EncryptionKey` | `string` | Optional | Optional customer provided disk encryption key |
| `EncryptionAssumedRoleIdentifier` | `string` | Optional | Optional role to use for disk encryption |
| `IamRole` | `string` | Optional | IAM role used for accessing objects in s3 |
| `PrivateEndpointIds` | `List<string>` | Optional | List of private endpoints |
| `AvailablePrivateEndpointIds` | `List<string>` | Optional | List of available private endpoints ids that can be attached to the service |
| `DataWarehouseId` | `string` | Optional | Data warehouse containing this service |
| `IsPrimary` | `bool?` | Optional | True if this service is the primary service in the data warehouse |
| `IsReadonly` | `bool?` | Optional | True if this service is read-only. It can only be read-only if a dataWarehouseId is provided. |
| `ReleaseChannel` | [`ReleaseChannel?`](../../doc/models/release-channel.md) | Optional | Select fast if you want to get new ClickHouse releases as soon as they are available. You'll get new features faster, but with a higher risk of bugs. Select slow if you would like to defer releases to give yourself more time to test. This feature is only available for production services. default is the regular release channel. |
| `ByocId` | `string` | Optional | This is the ID returned after setting up a region for Bring Your Own Cloud (BYOC). When the byocId parameter is specified, the minReplicaMemoryGb and the maxReplicaGb parameters are required too, with values included among the following sizes: 48, 116, 172, 232. |
| `HasTransparentDataEncryption` | `bool?` | Optional | True if the service should have the Transparent Data Encryption (TDE) enabled. TDE is only available for ENTERPRISE organizations tiers and can only be enabled at service creation. |
| `Profile` | `string` | Optional | Custom instance profile. Only available for ENTERPRISE and BYOC organization tiers. Standard values: 'v1-default', 'v1-highmem-xs', 'v1-highmem-s', 'v1-highmem-m', 'v1-highmem-l', 'v1-highmem-xl'. BYOC services may instead use a dynamic BYOC profile configured for their infrastructure (e.g. 'v1-standard-byoc-4'); it requires byocId, and minReplicaMemoryGb and maxReplicaMemoryGb must both equal the profile's memory size. Use the serviceProfiles endpoint to list the profiles available to the organization. |
| `TransparentDataEncryptionKeyId` | `string` | Optional | The ID of the Transparent Data Encryption key used for the service. This is only available if hasTransparentDataEncryption is true. |
| `EncryptionRoleId` | `string` | Optional | The ID of the IAM role used for encryption. This is only available if hasTransparentDataEncryption is true. |
| `ComplianceType` | [`ComplianceType?`](../../doc/models/compliance-type.md) | Optional | Type of regulatory compliance for service. |
| `Tags` | [`List<ResourceTagsV1>`](../../doc/models/resource-tags-v1.md) | Optional | Tags associated with the service.<br><br>**Constraints**: *Maximum Items*: `50` |
| `EnableCoreDumps` | `bool?` | Optional | True if the service's underline infra is enabled for collecting core dumps. This is an experimental feature |
| `ScalingSchedule` | [`ScalingSchedule`](../../doc/models/scaling-schedule.md) | Optional | - |
| `CurrentScaling` | [`CurrentScaling`](../../doc/models/current-scaling.md) | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

Service service = new Service
{
    AutoscalingMode = AutoscalingMode3.Vertical,
    CurrentScaling = new CurrentScaling
    {
        EffectiveAutoscalingMode = EffectiveAutoscalingMode.Vertical,
        EffectiveMinReplicaMemoryGb = 39.2,
        EffectiveMaxReplicaMemoryGb = 21.08,
        EffectiveMinReplicas = 124,
        EffectiveMaxReplicas = 40,
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    Id = new Guid("000023dc-0000-0000-0000-000000000000"),
    Name = "name0",
    Provider = Provider.Aws,
    Region = Region.Apnortheast1,
    State = State.Terminating,
    MinTotalMemoryGb = 48,
    MaxTotalMemoryGb = 360,
    MinReplicaMemoryGb = 16,
    MaxReplicaMemoryGb = 120,
    NumReplicas = 3,
    MinReplicas = 1,
    MaxReplicas = 5,
    ReplicaMemoryGb = 32,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

