
# Click Stack on Click Search

*This model accepts additional fields of type object.*

## Structure

`ClickStackOnClickSearch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | OnClick variant discriminator. Must be "search" for search link-outs.<br><br>**Value**: `"search"` |
| `Target` | [`ClickStackOnClickTarget`](../../doc/models/containers/click-stack-on-click-target.md) | Required | - |
| `WhereTemplate` | `string` | Optional | Optional WHERE clause template applied to the destination search. |
| `WhereLanguage` | [`WhereLanguage5?`](../../doc/models/where-language-5.md) | Optional | Language of the rendered whereTemplate. |
| `Filters` | [`List<ClickStackOnClickFilterTemplate>`](../../doc/models/click-stack-on-click-filter-template.md) | Optional | Optional dashboard filter templates rendered against the clicked row. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackOnClickSearch clickStackOnClickSearch = new ClickStackOnClickSearch
{
    Type = "search",
    Target = ClickStackOnClickTarget.FromClickStackOnClickTargetIdVariant(
        new ClickStackOnClickTargetIdVariant
        {
            Mode = "id",
            Id = "65f5e4a3b9e77c001a567890",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        }
    ),
    WhereTemplate = "ServiceName = '{{ServiceName}}'",
    WhereLanguage = WhereLanguage5.Sql,
    Filters = new List<ClickStackOnClickFilterTemplate>
    {
        new ClickStackOnClickFilterTemplate
        {
            Kind = "kind8",
            Expression = "expression2",
            Template = "template4",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
        new ClickStackOnClickFilterTemplate
        {
            Kind = "kind8",
            Expression = "expression2",
            Template = "template4",
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        },
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

