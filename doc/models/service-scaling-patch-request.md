
# Service Scaling Patch Request

*This model accepts additional fields of type object.*

## Structure

`ServiceScalingPatchRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MinTotalMemoryGb` | `double?` | Optional | DEPRECATED - inaccurate for services with non-default numbers of replicas. Use `minReplicaMemoryGb` instead. Minimum memory of three workers during auto-scaling in Gb. Available only for 'production' services. Must be a multiple of 12 and greater than or equal to 24. Always absent for horizontal-autoscaling services (replica count is variable).<br><br>**Constraints**: `>= 24`, `<= 1068`, *Multiple Of*: `12` |
| `MaxTotalMemoryGb` | `double?` | Optional | DEPRECATED - inaccurate for services with non-default numbers of replicas. Use `maxReplicaMemoryGb` instead. Maximum memory of three workers during auto-scaling in Gb. Available only for 'production' services. Must be a multiple of 12 and lower than or equal to 360 for non paid services or 1068 for paid services. Always absent for horizontal-autoscaling services (replica count is variable).<br><br>**Constraints**: `>= 24`, `<= 1068`, *Multiple Of*: `12` |
| `NumReplicas` | `int?` | Optional | Number of replicas for the service. The number of replicas must be between 2 and 50 for the first service in a warehouse. Services that are created in an existing warehouse can have a number of replicas as low as 1. Further restrictions may apply based on your organization's tier and its per-warehouse replica limit. It defaults to 1 for the BASIC tier and 3 for the SCALE and ENTERPRISE tiers.<br><br>**Constraints**: `>= 1`, `<= 50` |
| `IdleScaling` | `bool?` | Optional | When set to true the service is allowed to scale down to zero when idle. True by default. |
| `IdleTimeoutMinutes` | `double?` | Optional | Set minimum idling timeout (in minutes). Must be >= 5 minutes. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ServiceScalingPatchRequest serviceScalingPatchRequest = new ServiceScalingPatchRequest
{
    MinTotalMemoryGb = 48,
    MaxTotalMemoryGb = 360,
    NumReplicas = 3,
    IdleScaling = false,
    IdleTimeoutMinutes = 207.38,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

