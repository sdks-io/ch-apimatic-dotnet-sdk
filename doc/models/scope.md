
# Scope

Granularity at which the limit is applied. For example, `replicas-per-warehouse` is an organization-wide setting that limits each warehouse individually.

## Enumeration

`Scope`

## Fields

| Name |
|  --- |
| `Organization` |
| `Warehouse` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

Scope scope = Scope.Organization;
```

