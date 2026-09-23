
# Click Stack Source From

*This model accepts additional fields of type object.*

## Structure

`ClickStackSourceFrom`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DatabaseName` | `string` | Required | ClickHouse database name |
| `TableName` | `string` | Required | ClickHouse table name |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackSourceFrom clickStackSourceFrom = new ClickStackSourceFrom
{
    DatabaseName = "otel",
    TableName = "otel_logs",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

