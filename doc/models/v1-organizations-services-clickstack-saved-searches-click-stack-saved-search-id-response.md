
# V1 Organizations Services Clickstack Saved Searches Click Stack Saved Search Id Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse`

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

V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse v1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse = new V1OrganizationsServicesClickstackSavedSearchesClickStackSavedSearchIdResponse
{
    Status = 200,
    RequestId = new Guid("00000852-0000-0000-0000-000000000000"),
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

