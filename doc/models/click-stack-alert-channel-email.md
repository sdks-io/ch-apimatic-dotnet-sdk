
# Click Stack Alert Channel Email

*This model accepts additional fields of type object.*

## Structure

`ClickStackAlertChannelEmail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Type16`](../../doc/models/type-16.md) | Required | Channel type. Must be "email" for email alerts. |
| `EmailRecipients` | `List<string>` | Required | Email recipients for email alerts. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

ClickStackAlertChannelEmail clickStackAlertChannelEmail = new ClickStackAlertChannelEmail
{
    Type = Type16.Webhook,
    EmailRecipients = new List<string>
    {
        "emailRecipients9",
        "emailRecipients8",
        "emailRecipients7",
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

