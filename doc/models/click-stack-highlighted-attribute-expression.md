
# Click Stack Highlighted Attribute Expression

*This model accepts additional fields of type object.*

## Structure

`ClickStackHighlightedAttributeExpression`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SqlExpression` | `string` | Required | SQL expression for the attribute |
| `LuceneExpression` | `string` | Optional | An optional, Lucene version of the sqlExpression expression. If provided, it is used when searching for this attribute value. |
| `Alias` | `string` | Optional | Optional alias for the attribute |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

ClickStackHighlightedAttributeExpression clickStackHighlightedAttributeExpression = new ClickStackHighlightedAttributeExpression
{
    SqlExpression = "SpanAttributes['http.status_code']",
    LuceneExpression = "http.status_code",
    MAlias = "HTTP Status Code",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

