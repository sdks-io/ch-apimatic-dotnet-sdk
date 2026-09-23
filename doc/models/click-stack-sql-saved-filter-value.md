
# Click Stack Sql Saved Filter Value

*This model accepts additional fields of type object.*

## Structure

`ClickStackSqlSavedFilterValue`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type18?`](../../doc/models/type-18.md) | Optional | Filter type. |
| `Condition` | `string` | Required | SQL filter condition. For example use expressions in the form "column IN ('value')". |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackSqlSavedFilterValue clickStackSqlSavedFilterValue = new ClickStackSqlSavedFilterValue
{
    Condition = "ServiceName IN ('hdx-oss-dev-api')",
    Type = Type18.Sql,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

