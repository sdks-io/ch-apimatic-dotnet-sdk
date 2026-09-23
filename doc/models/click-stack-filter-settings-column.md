
# Click Stack Filter Settings Column

*This model accepts additional fields of type object.*

## Structure

`ClickStackFilterSettingsColumn`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Column of the source's table that selected filter values are matched against. Also the key the selection is persisted under in links, saved searches, and dashboards. |
| `Label` | `string` | Required | Display label for the column |
| `ValueExpression` | `string` | Optional | Optional SQL expression, evaluated against the filter-values table, that produces the available filter options. Use it when the options live in a differently-named column, or must be transformed to match the values stored in the source table. Defaults to reading `name` as a plain column when omitted. |
| `AllowAll` | `bool?` | Optional | Whether to offer an "All" option that expands to every available value at query time. Best suited to low-cardinality columns. Defaults to false. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackFilterSettingsColumn clickStackFilterSettingsColumn = new ClickStackFilterSettingsColumn
{
    Name = "ServiceName",
    Label = "Service Name",
    ValueExpression = "lower(service_name)",
    AllowAll = false,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

