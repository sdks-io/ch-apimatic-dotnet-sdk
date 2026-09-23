
# V1 Organizations Services Clickstack Saved Searches Response 1

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickstackSavedSearchesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickStackSavedSearch`](../../doc/models/click-stack-saved-search.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickstackSavedSearchesResponse1 v1OrganizationsServicesClickstackSavedSearchesResponse1 = new V1OrganizationsServicesClickstackSavedSearchesResponse1
{
    Status = 200,
    RequestId = new Guid("000019b6-0000-0000-0000-000000000000"),
    Result = new ClickStackSavedSearch
    {
        Id = "id6",
        Name = "name6",
        SourceId = "sourceId0",
        MSelect = "select6",
        MWhere = "where0",
        WhereLanguage = WhereLanguage12.Lucene,
        OrderBy = "orderBy8",
        Tags = new List<string>
        {
            "tags1",
        },
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

