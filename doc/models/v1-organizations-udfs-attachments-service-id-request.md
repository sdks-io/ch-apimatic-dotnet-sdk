
# V1 Organizations Udfs Attachments Service Id Request

*This model accepts additional fields of type object.*

## Structure

`V1OrganizationsUdfsAttachmentsServiceIdRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `int?` | Optional | Version to attach. When omitted, the latest ready version is attached.<br><br>**Constraints**: `>= 1` |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

V1OrganizationsUdfsAttachmentsServiceIdRequest v1OrganizationsUdfsAttachmentsServiceIdRequest = new V1OrganizationsUdfsAttachmentsServiceIdRequest
{
    Version = 1,
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

