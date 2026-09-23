
# Table Engine

ClickHouse table engine: "ReplacingMergeTree" (handles updates/deletes), "MergeTree" (append-only), or "Null" (forward data to materialized views without storing it).

## Enumeration

`TableEngine`

## Fields

| Name |
|  --- |
| `MergeTree` |
| `ReplacingMergeTree` |
| `Null` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

TableEngine tableEngine = TableEngine.MergeTree;
```

