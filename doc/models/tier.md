
# Tier

DEPRECATED for BASIC, SCALE and ENTERPRISE organization tiers. Use `minReplicaMemoryGb`, `maxReplicaMemoryGb`, and `numReplicas` instead. Tier of the service: 'development', 'production', 'dedicated_high_mem', 'dedicated_high_cpu', 'dedicated_standard', 'dedicated_standard_n2d_standard_4', 'dedicated_standard_n2d_standard_8', 'dedicated_standard_n2d_standard_32', 'dedicated_standard_n2d_standard_128', 'dedicated_standard_n2d_standard_32_16SSD', 'dedicated_standard_n2d_standard_64_24SSD'. Production services scale, Development are fixed size. Azure services don't support Development tier

## Enumeration

`Tier`

## Fields

| Name |
|  --- |
| `Development` |
| `Production` |
| `DedicatedHighMem` |
| `DedicatedHighCpu` |
| `DedicatedStandard` |
| `DedicatedStandardN2DStandard4` |
| `DedicatedStandardN2DStandard8` |
| `DedicatedStandardN2DStandard32` |
| `DedicatedStandardN2DStandard128` |
| `DedicatedStandardN2DStandard3216Ssd` |
| `DedicatedStandardN2DStandard6424Ssd` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

Tier tier = Tier.DedicatedStandardN2DStandard6424Ssd;
```

