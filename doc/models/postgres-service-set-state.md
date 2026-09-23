
# Postgres Service Set State

*This model accepts additional fields of type object.*

## Structure

`PostgresServiceSetState`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Command` | [`Command?`](../../doc/models/command.md) | Optional | Postgres status, which initiates a process. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

PostgresServiceSetState postgresServiceSetState = new PostgresServiceSetState
{
    Command = Command.Switchover,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

