
# Click Stack Saved Search Filter

*This model accepts additional fields of type object.*

## Structure

`ClickStackSavedSearchFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type20?`](../../doc/models/type-20.md) | Optional | Always `sql`. Only SQL predicate filters render in the sidebar. |
| `Condition` | `string` | Required | SQL predicate applied to the search, in `<column> IN (...)` form. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackSavedSearchFilter clickStackSavedSearchFilter = new ClickStackSavedSearchFilter
{
    Condition = "ServiceName IN ('checkout', 'payments')",
    Type = Type20.Sql,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

