
# Msk Authentication

MSK cluster authentication type. Required for MSK_MULTI_VPC type.

## Enumeration

`MskAuthentication`

## Fields

| Name |
|  --- |
| `SaslIam` |
| `SaslScram` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

MskAuthentication mskAuthentication = MskAuthentication.SaslIam;
```

