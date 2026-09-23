
# V1 Organizations Services Clickstack Sources Click Stack Source Id Response

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `double?` | Optional | HTTP status code. |
| `RequestId` | `Guid?` | Optional | Unique id assigned to every request. UUIDv4 |
| `Result` | [`ClickStackSource`](../../doc/models/containers/click-stack-source.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Models.Containers;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse v1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse = new V1OrganizationsServicesClickstackSourcesClickStackSourceIdResponse
{
    Status = 200,
    RequestId = new Guid("0000182c-0000-0000-0000-000000000000"),
    Result = ClickStackSource.FromClickStackLogSource(
        new ClickStackLogSource
        {
            Name = "name4",
            Kind = "kind2",
            Connection = "connection2",
            From = new ClickStackSourceFrom
            {
                DatabaseName = "databaseName2",
                TableName = "tableName2",
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            DefaultTableSelectExpression = "defaultTableSelectExpression0",
            TimestampValueExpression = "timestampValueExpression4",
            Id = "id4",
            Section = "section8",
            Disabled = false,
            QuerySettings = new List<ClickStackQuerySetting>
            {
                new ClickStackQuerySetting
                {
                    Setting = "setting6",
                    MValue = "value0",
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new ClickStackQuerySetting
                {
                    Setting = "setting6",
                    MValue = "value0",
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
                new ClickStackQuerySetting
                {
                    Setting = "setting6",
                    MValue = "value0",
                    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                },
            },
            FilterSettings = new ClickStackSourceFilterSettings
            {
                DatabaseName = "databaseName4",
                TableName = "tableName4",
                Columns = new List<ClickStackFilterSettingsColumn>
                {
                    new ClickStackFilterSettingsColumn
                    {
                        Name = "name0",
                        Label = "label0",
                        ValueExpression = "valueExpression8",
                        AllowAll = false,
                        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
                    },
                },
                ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
            },
            ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
        }
    ),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

