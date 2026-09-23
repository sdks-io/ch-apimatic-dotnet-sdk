
# Activity

*This model accepts additional fields of type object.*

## Structure

`Activity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | Unique activity ID. |
| `CreatedAt` | `DateTime?` | Optional | Timestamp of the activity. ISO-8601. |
| `Type` | [`Type12?`](../../doc/models/type-12.md) | Optional | Type of the activity. |
| `ActorType` | [`ActorType?`](../../doc/models/actor-type.md) | Optional | Type of the actor: 'user', 'support', 'system', 'api'. |
| `ActorId` | `string` | Optional | Unique actor ID. |
| `ActorDetails` | `string` | Optional | Additional information about the actor. |
| `ActorIpAddress` | `string` | Optional | IP address of the actor. Defined for 'user' and 'api' actor types. |
| `OrganizationId` | `string` | Optional | Scope of the activity: organization ID this activity is related to. |
| `ServiceId` | `string` | Optional | Scope of the activity: service ID this activity is related to. |
| `UserAgent` | `string` | Optional | User agent of the actor |
| `TargetKeyId` | `string` | Optional | For 'openapi_key_update' activities: the ID of the API key that was updated. |
| `KeyUpdateType` | [`KeyUpdateType?`](../../doc/models/key-update-type.md) | Optional | For 'openapi_key_update' activities: the type of update that was performed. |
| `TargetRoleIds` | `List<string>` | Optional | For role and actor-role activities: IDs of the affected roles. |
| `TargetRoleNames` | `List<string>` | Optional | For role and actor-role activities: names of the affected roles, when recorded. |
| `TargetActorIds` | `List<string>` | Optional | For 'organization_member_update_roles' and 'organization_member_remove_roles' activities: IDs of the affected actors (e.g. 'user/<id>'). |
| `TargetResourceIds` | `List<string>` | Optional | For 'role_resources_delete' activities: IDs of the deleted resources the roles referenced. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Globalization;

Activity activity = new Activity
{
    Id = "id8",
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    Type = Type12.UdfDetach,
    ActorType = ActorType.MSystem,
    ActorId = "actorId8",
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

