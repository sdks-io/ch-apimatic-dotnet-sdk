
# Quota Code

Stable identifier of the quota. Use it to request a single quota by code.

## Enumeration

`QuotaCode`

## Fields

| Name |
|  --- |
| `Servicesperorganization` |
| `Postgresservicesperorganization` |
| `Replicasperwarehouse` |
| `Apikeysperorganization` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

QuotaCode quotaCode = QuotaCode.Servicesperorganization;
```

