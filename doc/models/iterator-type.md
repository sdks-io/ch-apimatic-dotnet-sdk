
# Iterator Type

Type of iterator to use when reading from the Kinesis stream. If AT_TIMESTAMP is used, the timestamp field must be provided.

## Enumeration

`IteratorType`

## Fields

| Name |
|  --- |
| `TrimHorizon` |
| `Latest` |
| `AtTimestamp` |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;

IteratorType iteratorType = IteratorType.AtTimestamp;
```

