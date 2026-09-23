<!-- Generated file — do not edit; regenerated with the SDK. -->

# ServiceApi — operations

Accessor: `client.ServiceApi` · Source: `Api/ServiceApi.cs` · 26 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### InstanceCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceCreate(Guid organizationId, ServicePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesResponse1`
- **Error**: `SdkException<InstanceCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServices400Error1(out V1OrganizationsServices400Error1)` [400] · `TryGetV1OrganizationsServices500Error1(out V1OrganizationsServices500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ServicePostRequest` | `Models/ServicePostRequest.cs` |
| `V1OrganizationsServicesResponse1` | `Models/V1OrganizationsServicesResponse1.cs` |
| `InstanceCreateError` | `Errors/InstanceCreateError.cs` |
| `V1OrganizationsServices400Error1` | `Models/V1OrganizationsServices400Error1.cs` |
| `V1OrganizationsServices500Error1` | `Models/V1OrganizationsServices500Error1.cs` |

### InstanceDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceDelete(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesResponse4`
- **Error**: `SdkException<InstanceDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServices400Error1(out V1OrganizationsServices400Error1)` [400] · `TryGetV1OrganizationsServices500Error1(out V1OrganizationsServices500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesResponse4` | `Models/V1OrganizationsServicesResponse4.cs` |
| `InstanceDeleteError` | `Errors/InstanceDeleteError.cs` |
| `V1OrganizationsServices400Error1` | `Models/V1OrganizationsServices400Error1.cs` |
| `V1OrganizationsServices500Error1` | `Models/V1OrganizationsServices500Error1.cs` |

### InstanceGet

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesResponse2`
- **Error**: `SdkException<InstanceGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServices400Error1(out V1OrganizationsServices400Error1)` [400] · `TryGetV1OrganizationsServices500Error1(out V1OrganizationsServices500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesResponse2` | `Models/V1OrganizationsServicesResponse2.cs` |
| `InstanceGetError` | `Errors/InstanceGetError.cs` |
| `V1OrganizationsServices400Error1` | `Models/V1OrganizationsServices400Error1.cs` |
| `V1OrganizationsServices500Error1` | `Models/V1OrganizationsServices500Error1.cs` |

### InstanceGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceGetList(Guid organizationId, IReadOnlyList<string>? filter, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `filter` ← `filter`
- **Returns**: `V1OrganizationsServicesResponse`
- **Error**: `SdkException<InstanceGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServices400Error1(out V1OrganizationsServices400Error1)` [400] · `TryGetV1OrganizationsServices500Error1(out V1OrganizationsServices500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesResponse` | `Models/V1OrganizationsServicesResponse.cs` |
| `InstanceGetListError` | `Errors/InstanceGetListError.cs` |
| `V1OrganizationsServices400Error1` | `Models/V1OrganizationsServices400Error1.cs` |
| `V1OrganizationsServices500Error1` | `Models/V1OrganizationsServices500Error1.cs` |

### InstancePasswordUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `InstancePasswordUpdate(Guid organizationId, Guid serviceId, ServicePasswordPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesPasswordResponse`
- **Error**: `SdkException<InstancePasswordUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesPassword400Error1(out V1OrganizationsServicesPassword400Error1)` [400] · `TryGetV1OrganizationsServicesPassword500Error1(out V1OrganizationsServicesPassword500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ServicePasswordPatchRequest` | `Models/ServicePasswordPatchRequest.cs` |
| `V1OrganizationsServicesPasswordResponse` | `Models/V1OrganizationsServicesPasswordResponse.cs` |
| `InstancePasswordUpdateError` | `Errors/InstancePasswordUpdateError.cs` |
| `V1OrganizationsServicesPassword400Error1` | `Models/V1OrganizationsServicesPassword400Error1.cs` |
| `V1OrganizationsServicesPassword500Error1` | `Models/V1OrganizationsServicesPassword500Error1.cs` |

### InstancePrivateEndpointConfigGet

- **Auth**: `options.BasicAuth`
- **Signature**: `InstancePrivateEndpointConfigGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesPrivateEndpointConfigResponse`
- **Error**: `SdkException<InstancePrivateEndpointConfigGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesPrivateEndpointConfig400Error1(out V1OrganizationsServicesPrivateEndpointConfig400Error1)` [400] · `TryGetV1OrganizationsServicesPrivateEndpointConfig500Error1(out V1OrganizationsServicesPrivateEndpointConfig500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesPrivateEndpointConfigResponse` | `Models/V1OrganizationsServicesPrivateEndpointConfigResponse.cs` |
| `InstancePrivateEndpointConfigGetError` | `Errors/InstancePrivateEndpointConfigGetError.cs` |
| `V1OrganizationsServicesPrivateEndpointConfig400Error1` | `Models/V1OrganizationsServicesPrivateEndpointConfig400Error1.cs` |
| `V1OrganizationsServicesPrivateEndpointConfig500Error1` | `Models/V1OrganizationsServicesPrivateEndpointConfig500Error1.cs` |

### InstancePrivateEndpointCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `InstancePrivateEndpointCreate(Guid organizationId, Guid serviceId, ServicPrivateEndpointePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesPrivateEndpointResponse`
- **Error**: `SdkException<InstancePrivateEndpointCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesPrivateEndpoint400Error1(out V1OrganizationsServicesPrivateEndpoint400Error1)` [400] · `TryGetV1OrganizationsServicesPrivateEndpoint500Error1(out V1OrganizationsServicesPrivateEndpoint500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ServicPrivateEndpointePostRequest` | `Models/ServicPrivateEndpointePostRequest.cs` |
| `V1OrganizationsServicesPrivateEndpointResponse` | `Models/V1OrganizationsServicesPrivateEndpointResponse.cs` |
| `InstancePrivateEndpointCreateError` | `Errors/InstancePrivateEndpointCreateError.cs` |
| `V1OrganizationsServicesPrivateEndpoint400Error1` | `Models/V1OrganizationsServicesPrivateEndpoint400Error1.cs` |
| `V1OrganizationsServicesPrivateEndpoint500Error1` | `Models/V1OrganizationsServicesPrivateEndpoint500Error1.cs` |

### InstanceQueryEndpointDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceQueryEndpointDelete(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesServiceQueryEndpointResponse1`
- **Error**: `SdkException<InstanceQueryEndpointDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesServiceQueryEndpoint400Error1(out V1OrganizationsServicesServiceQueryEndpoint400Error1)` [400] · `TryGetV1OrganizationsServicesServiceQueryEndpoint500Error1(out V1OrganizationsServicesServiceQueryEndpoint500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesServiceQueryEndpointResponse1` | `Models/V1OrganizationsServicesServiceQueryEndpointResponse1.cs` |
| `InstanceQueryEndpointDeleteError` | `Errors/InstanceQueryEndpointDeleteError.cs` |
| `V1OrganizationsServicesServiceQueryEndpoint400Error1` | `Models/V1OrganizationsServicesServiceQueryEndpoint400Error1.cs` |
| `V1OrganizationsServicesServiceQueryEndpoint500Error1` | `Models/V1OrganizationsServicesServiceQueryEndpoint500Error1.cs` |

### InstanceQueryEndpointGet

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceQueryEndpointGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesServiceQueryEndpointResponse`
- **Error**: `SdkException<InstanceQueryEndpointGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesServiceQueryEndpoint400Error1(out V1OrganizationsServicesServiceQueryEndpoint400Error1)` [400] · `TryGetV1OrganizationsServicesServiceQueryEndpoint500Error1(out V1OrganizationsServicesServiceQueryEndpoint500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesServiceQueryEndpointResponse` | `Models/V1OrganizationsServicesServiceQueryEndpointResponse.cs` |
| `InstanceQueryEndpointGetError` | `Errors/InstanceQueryEndpointGetError.cs` |
| `V1OrganizationsServicesServiceQueryEndpoint400Error1` | `Models/V1OrganizationsServicesServiceQueryEndpoint400Error1.cs` |
| `V1OrganizationsServicesServiceQueryEndpoint500Error1` | `Models/V1OrganizationsServicesServiceQueryEndpoint500Error1.cs` |

### InstanceQueryEndpointUpsert

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceQueryEndpointUpsert(Guid organizationId, Guid serviceId, InstanceServiceQueryApiEndpointsPostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesServiceQueryEndpointResponse`
- **Error**: `SdkException<InstanceQueryEndpointUpsertError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesServiceQueryEndpoint400Error1(out V1OrganizationsServicesServiceQueryEndpoint400Error1)` [400] · `TryGetV1OrganizationsServicesServiceQueryEndpoint500Error1(out V1OrganizationsServicesServiceQueryEndpoint500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `InstanceServiceQueryApiEndpointsPostRequest` | `Models/InstanceServiceQueryApiEndpointsPostRequest.cs` |
| `V1OrganizationsServicesServiceQueryEndpointResponse` | `Models/V1OrganizationsServicesServiceQueryEndpointResponse.cs` |
| `InstanceQueryEndpointUpsertError` | `Errors/InstanceQueryEndpointUpsertError.cs` |
| `V1OrganizationsServicesServiceQueryEndpoint400Error1` | `Models/V1OrganizationsServicesServiceQueryEndpoint400Error1.cs` |
| `V1OrganizationsServicesServiceQueryEndpoint500Error1` | `Models/V1OrganizationsServicesServiceQueryEndpoint500Error1.cs` |

### InstanceReplicaScalingUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceReplicaScalingUpdate(Guid organizationId, Guid serviceId, ServiceReplicaScalingPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesReplicaScalingResponse`
- **Error**: `SdkException<InstanceReplicaScalingUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesReplicaScaling400Error1(out V1OrganizationsServicesReplicaScaling400Error1)` [400] · `TryGetV1OrganizationsServicesReplicaScaling500Error1(out V1OrganizationsServicesReplicaScaling500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ServiceReplicaScalingPatchRequest` | `Models/ServiceReplicaScalingPatchRequest.cs` |
| `V1OrganizationsServicesReplicaScalingResponse` | `Models/V1OrganizationsServicesReplicaScalingResponse.cs` |
| `InstanceReplicaScalingUpdateError` | `Errors/InstanceReplicaScalingUpdateError.cs` |
| `V1OrganizationsServicesReplicaScaling400Error1` | `Models/V1OrganizationsServicesReplicaScaling400Error1.cs` |
| `V1OrganizationsServicesReplicaScaling500Error1` | `Models/V1OrganizationsServicesReplicaScaling500Error1.cs` |

### InstanceScalingUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceScalingUpdate(Guid organizationId, Guid serviceId, ServiceScalingPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesScalingResponse`
- **Error**: `SdkException<InstanceScalingUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesScaling400Error1(out V1OrganizationsServicesScaling400Error1)` [400] · `TryGetV1OrganizationsServicesScaling500Error1(out V1OrganizationsServicesScaling500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ServiceScalingPatchRequest` | `Models/ServiceScalingPatchRequest.cs` |
| `V1OrganizationsServicesScalingResponse` | `Models/V1OrganizationsServicesScalingResponse.cs` |
| `InstanceScalingUpdateError` | `Errors/InstanceScalingUpdateError.cs` |
| `V1OrganizationsServicesScaling400Error1` | `Models/V1OrganizationsServicesScaling400Error1.cs` |
| `V1OrganizationsServicesScaling500Error1` | `Models/V1OrganizationsServicesScaling500Error1.cs` |

### InstanceStateUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceStateUpdate(Guid organizationId, Guid serviceId, ServiceStatePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesStateResponse`
- **Error**: `SdkException<InstanceStateUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesState400Error1(out V1OrganizationsServicesState400Error1)` [400] · `TryGetV1OrganizationsServicesState500Error1(out V1OrganizationsServicesState500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ServiceStatePatchRequest` | `Models/ServiceStatePatchRequest.cs` |
| `V1OrganizationsServicesStateResponse` | `Models/V1OrganizationsServicesStateResponse.cs` |
| `InstanceStateUpdateError` | `Errors/InstanceStateUpdateError.cs` |
| `V1OrganizationsServicesState400Error1` | `Models/V1OrganizationsServicesState400Error1.cs` |
| `V1OrganizationsServicesState500Error1` | `Models/V1OrganizationsServicesState500Error1.cs` |

### InstanceUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `InstanceUpdate(Guid organizationId, Guid serviceId, ServicePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesResponse2`
- **Error**: `SdkException<InstanceUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServices400Error1(out V1OrganizationsServices400Error1)` [400] · `TryGetV1OrganizationsServices500Error1(out V1OrganizationsServices500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ServicePatchRequest` | `Models/ServicePatchRequest.cs` |
| `V1OrganizationsServicesResponse2` | `Models/V1OrganizationsServicesResponse2.cs` |
| `InstanceUpdateError` | `Errors/InstanceUpdateError.cs` |
| `V1OrganizationsServices400Error1` | `Models/V1OrganizationsServices400Error1.cs` |
| `V1OrganizationsServices500Error1` | `Models/V1OrganizationsServices500Error1.cs` |

### ScalingScheduleDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `ScalingScheduleDelete(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesScalingScheduleResponse2`
- **Error**: `SdkException<ScalingScheduleDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesScalingSchedule400Error1(out V1OrganizationsServicesScalingSchedule400Error1)` [400] · `TryGetV1OrganizationsServicesScalingSchedule500Error1(out V1OrganizationsServicesScalingSchedule500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesScalingScheduleResponse2` | `Models/V1OrganizationsServicesScalingScheduleResponse2.cs` |
| `ScalingScheduleDeleteError` | `Errors/ScalingScheduleDeleteError.cs` |
| `V1OrganizationsServicesScalingSchedule400Error1` | `Models/V1OrganizationsServicesScalingSchedule400Error1.cs` |
| `V1OrganizationsServicesScalingSchedule500Error1` | `Models/V1OrganizationsServicesScalingSchedule500Error1.cs` |

### ScalingScheduleGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ScalingScheduleGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesScalingScheduleResponse`
- **Error**: `SdkException<ScalingScheduleGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesScalingSchedule400Error1(out V1OrganizationsServicesScalingSchedule400Error1)` [400] · `TryGetV1OrganizationsServicesScalingSchedule500Error1(out V1OrganizationsServicesScalingSchedule500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesScalingScheduleResponse` | `Models/V1OrganizationsServicesScalingScheduleResponse.cs` |
| `ScalingScheduleGetError` | `Errors/ScalingScheduleGetError.cs` |
| `V1OrganizationsServicesScalingSchedule400Error1` | `Models/V1OrganizationsServicesScalingSchedule400Error1.cs` |
| `V1OrganizationsServicesScalingSchedule500Error1` | `Models/V1OrganizationsServicesScalingSchedule500Error1.cs` |

### ScalingScheduleUpsert

- **Auth**: `options.BasicAuth`
- **Signature**: `ScalingScheduleUpsert(Guid organizationId, Guid serviceId, ScalingSchedulePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesScalingScheduleResponse`
- **Error**: `SdkException<ScalingScheduleUpsertError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesScalingSchedule400Error1(out V1OrganizationsServicesScalingSchedule400Error1)` [400] · `TryGetV1OrganizationsServicesScalingSchedule500Error1(out V1OrganizationsServicesScalingSchedule500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ScalingSchedulePostRequest` | `Models/ScalingSchedulePostRequest.cs` |
| `V1OrganizationsServicesScalingScheduleResponse` | `Models/V1OrganizationsServicesScalingScheduleResponse.cs` |
| `ScalingScheduleUpsertError` | `Errors/ScalingScheduleUpsertError.cs` |
| `V1OrganizationsServicesScalingSchedule400Error1` | `Models/V1OrganizationsServicesScalingSchedule400Error1.cs` |
| `V1OrganizationsServicesScalingSchedule500Error1` | `Models/V1OrganizationsServicesScalingSchedule500Error1.cs` |

### ServiceClickhouseSettingDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `ServiceClickhouseSettingDelete(Guid organizationId, Guid serviceId, string settingName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickhouseSettingsSettingNameResponse1`
- **Error**: `SdkException<ServiceClickhouseSettingDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickhouseSettingsSettingName400Error1(out V1OrganizationsServicesClickhouseSettingsSettingName400Error1)` [400] · `TryGetV1OrganizationsServicesClickhouseSettingsSettingName500Error1(out V1OrganizationsServicesClickhouseSettingsSettingName500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickhouseSettingsSettingNameResponse1` | `Models/V1OrganizationsServicesClickhouseSettingsSettingNameResponse1.cs` |
| `ServiceClickhouseSettingDeleteError` | `Errors/ServiceClickhouseSettingDeleteError.cs` |
| `V1OrganizationsServicesClickhouseSettingsSettingName400Error1` | `Models/V1OrganizationsServicesClickhouseSettingsSettingName400Error1.cs` |
| `V1OrganizationsServicesClickhouseSettingsSettingName500Error1` | `Models/V1OrganizationsServicesClickhouseSettingsSettingName500Error1.cs` |

### ServiceClickhouseSettingGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ServiceClickhouseSettingGet(Guid organizationId, Guid serviceId, string settingName, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickhouseSettingsSettingNameResponse`
- **Error**: `SdkException<ServiceClickhouseSettingGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickhouseSettingsSettingName400Error1(out V1OrganizationsServicesClickhouseSettingsSettingName400Error1)` [400] · `TryGetV1OrganizationsServicesClickhouseSettingsSettingName500Error1(out V1OrganizationsServicesClickhouseSettingsSettingName500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickhouseSettingsSettingNameResponse` | `Models/V1OrganizationsServicesClickhouseSettingsSettingNameResponse.cs` |
| `ServiceClickhouseSettingGetError` | `Errors/ServiceClickhouseSettingGetError.cs` |
| `V1OrganizationsServicesClickhouseSettingsSettingName400Error1` | `Models/V1OrganizationsServicesClickhouseSettingsSettingName400Error1.cs` |
| `V1OrganizationsServicesClickhouseSettingsSettingName500Error1` | `Models/V1OrganizationsServicesClickhouseSettingsSettingName500Error1.cs` |

### ServiceClickhouseSettingsListGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ServiceClickhouseSettingsListGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickhouseSettingsResponse`
- **Error**: `SdkException<ServiceClickhouseSettingsListGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickhouseSettings400Error1(out V1OrganizationsServicesClickhouseSettings400Error1)` [400] · `TryGetV1OrganizationsServicesClickhouseSettings500Error1(out V1OrganizationsServicesClickhouseSettings500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickhouseSettingsResponse` | `Models/V1OrganizationsServicesClickhouseSettingsResponse.cs` |
| `ServiceClickhouseSettingsListGetError` | `Errors/ServiceClickhouseSettingsListGetError.cs` |
| `V1OrganizationsServicesClickhouseSettings400Error1` | `Models/V1OrganizationsServicesClickhouseSettings400Error1.cs` |
| `V1OrganizationsServicesClickhouseSettings500Error1` | `Models/V1OrganizationsServicesClickhouseSettings500Error1.cs` |

### ServiceClickhouseSettingsSchemaGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ServiceClickhouseSettingsSchemaGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickhouseSettingsSchemaResponse`
- **Error**: `SdkException<ServiceClickhouseSettingsSchemaGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickhouseSettingsSchema400Error1(out V1OrganizationsServicesClickhouseSettingsSchema400Error1)` [400] · `TryGetV1OrganizationsServicesClickhouseSettingsSchema500Error1(out V1OrganizationsServicesClickhouseSettingsSchema500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickhouseSettingsSchemaResponse` | `Models/V1OrganizationsServicesClickhouseSettingsSchemaResponse.cs` |
| `ServiceClickhouseSettingsSchemaGetError` | `Errors/ServiceClickhouseSettingsSchemaGetError.cs` |
| `V1OrganizationsServicesClickhouseSettingsSchema400Error1` | `Models/V1OrganizationsServicesClickhouseSettingsSchema400Error1.cs` |
| `V1OrganizationsServicesClickhouseSettingsSchema500Error1` | `Models/V1OrganizationsServicesClickhouseSettingsSchema500Error1.cs` |

### ServiceClickhouseSettingsUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `ServiceClickhouseSettingsUpdate(Guid organizationId, Guid serviceId, ServiceClickhouseSettingsPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickhouseSettingsResponse1`
- **Error**: `SdkException<ServiceClickhouseSettingsUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickhouseSettings400Error1(out V1OrganizationsServicesClickhouseSettings400Error1)` [400] · `TryGetV1OrganizationsServicesClickhouseSettings500Error1(out V1OrganizationsServicesClickhouseSettings500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ServiceClickhouseSettingsPatchRequest` | `Models/ServiceClickhouseSettingsPatchRequest.cs` |
| `V1OrganizationsServicesClickhouseSettingsResponse1` | `Models/V1OrganizationsServicesClickhouseSettingsResponse1.cs` |
| `ServiceClickhouseSettingsUpdateError` | `Errors/ServiceClickhouseSettingsUpdateError.cs` |
| `V1OrganizationsServicesClickhouseSettings400Error1` | `Models/V1OrganizationsServicesClickhouseSettings400Error1.cs` |
| `V1OrganizationsServicesClickhouseSettings500Error1` | `Models/V1OrganizationsServicesClickhouseSettings500Error1.cs` |

### ServiceProfilesList

- **Auth**: `options.BasicAuth`
- **Signature**: `ServiceProfilesList(Guid organizationId, string? regionId, Guid? byocId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `regionId` — nullable, no default → **must pass explicitly**
  - `byocId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `region_id` ← `regionId`, `byoc_id` ← `byocId`
- **Returns**: `V1OrganizationsServiceProfilesResponse`
- **Error**: `SdkException<ServiceProfilesListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServiceProfiles400Error1(out V1OrganizationsServiceProfiles400Error1)` [400] · `TryGetV1OrganizationsServiceProfiles500Error1(out V1OrganizationsServiceProfiles500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServiceProfilesResponse` | `Models/V1OrganizationsServiceProfilesResponse.cs` |
| `ServiceProfilesListError` | `Errors/ServiceProfilesListError.cs` |
| `V1OrganizationsServiceProfiles400Error1` | `Models/V1OrganizationsServiceProfiles400Error1.cs` |
| `V1OrganizationsServiceProfiles500Error1` | `Models/V1OrganizationsServiceProfiles500Error1.cs` |

### UpgradeWindowDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `UpgradeWindowDelete(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesUpgradeWindowResponse2`
- **Error**: `SdkException<UpgradeWindowDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesUpgradeWindow400Error1(out V1OrganizationsServicesUpgradeWindow400Error1)` [400] · `TryGetV1OrganizationsServicesUpgradeWindow500Error1(out V1OrganizationsServicesUpgradeWindow500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesUpgradeWindowResponse2` | `Models/V1OrganizationsServicesUpgradeWindowResponse2.cs` |
| `UpgradeWindowDeleteError` | `Errors/UpgradeWindowDeleteError.cs` |
| `V1OrganizationsServicesUpgradeWindow400Error1` | `Models/V1OrganizationsServicesUpgradeWindow400Error1.cs` |
| `V1OrganizationsServicesUpgradeWindow500Error1` | `Models/V1OrganizationsServicesUpgradeWindow500Error1.cs` |

### UpgradeWindowGet

- **Auth**: `options.BasicAuth`
- **Signature**: `UpgradeWindowGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesUpgradeWindowResponse`
- **Error**: `SdkException<UpgradeWindowGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesUpgradeWindow400Error1(out V1OrganizationsServicesUpgradeWindow400Error1)` [400] · `TryGetV1OrganizationsServicesUpgradeWindow500Error1(out V1OrganizationsServicesUpgradeWindow500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesUpgradeWindowResponse` | `Models/V1OrganizationsServicesUpgradeWindowResponse.cs` |
| `UpgradeWindowGetError` | `Errors/UpgradeWindowGetError.cs` |
| `V1OrganizationsServicesUpgradeWindow400Error1` | `Models/V1OrganizationsServicesUpgradeWindow400Error1.cs` |
| `V1OrganizationsServicesUpgradeWindow500Error1` | `Models/V1OrganizationsServicesUpgradeWindow500Error1.cs` |

### UpgradeWindowUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `UpgradeWindowUpdate(Guid organizationId, Guid serviceId, UpgradeWindowPutRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesUpgradeWindowResponse`
- **Error**: `SdkException<UpgradeWindowUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesUpgradeWindow400Error1(out V1OrganizationsServicesUpgradeWindow400Error1)` [400] · `TryGetV1OrganizationsServicesUpgradeWindow500Error1(out V1OrganizationsServicesUpgradeWindow500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpgradeWindowPutRequest` | `Models/UpgradeWindowPutRequest.cs` |
| `V1OrganizationsServicesUpgradeWindowResponse` | `Models/V1OrganizationsServicesUpgradeWindowResponse.cs` |
| `UpgradeWindowUpdateError` | `Errors/UpgradeWindowUpdateError.cs` |
| `V1OrganizationsServicesUpgradeWindow400Error1` | `Models/V1OrganizationsServicesUpgradeWindow400Error1.cs` |
| `V1OrganizationsServicesUpgradeWindow500Error1` | `Models/V1OrganizationsServicesUpgradeWindow500Error1.cs` |

