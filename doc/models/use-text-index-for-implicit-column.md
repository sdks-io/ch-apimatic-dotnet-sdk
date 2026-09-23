
# Use Text Index for Implicit Column

Controls whether lucene rendering uses ClickHouse text indices via hasAllTokens() against the implicit column. "auto" detects a covering index at query time, "enabled" forces text index usage, "disabled" forces a LIKE/hasToken fallback.

## Enumeration

`UseTextIndexForImplicitColumn`

## Fields

| Name |
|  --- |
| `Auto` |
| `Enabled` |
| `Disabled` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

UseTextIndexForImplicitColumn useTextIndexForImplicitColumn = UseTextIndexForImplicitColumn.Enabled;
```

