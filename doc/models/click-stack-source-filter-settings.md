
# Click Stack Source Filter Settings

*This model accepts additional fields of type object.*

## Structure

`ClickStackSourceFilterSettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DatabaseName` | `string` | Required | ClickHouse database name |
| `TableName` | `string` | Required | ClickHouse table name |
| `Columns` | [`List<ClickStackFilterSettingsColumn>`](../../doc/models/click-stack-filter-settings-column.md) | Required | Columns to expose as filters (max 10) |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackSourceFilterSettings clickStackSourceFilterSettings = new ClickStackSourceFilterSettings
{
    DatabaseName = "default",
    TableName = "otel_logs",
    Columns = new List<ClickStackFilterSettingsColumn>
    {
        new ClickStackFilterSettingsColumn
        {
            Name = "ServiceName",
            Label = "Service Name",
            ValueExpression = "lower(service_name)",
            AllowAll = false,
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

