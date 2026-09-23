<!-- Generated file — do not edit; regenerated with the SDK. -->

# ClickPipes — operations

Accessor: `client.ClickPipes` · Source: `Api/ClickPipes.cs` · 18 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ClickPipeCdcScalingGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeCdcScalingGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickpipesCdcScalingResponse`
- **Error**: `SdkException<ClickPipeCdcScalingGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesCdcScaling400Error1(out V1OrganizationsServicesClickpipesCdcScaling400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesCdcScaling500Error1(out V1OrganizationsServicesClickpipesCdcScaling500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickpipesCdcScalingResponse` | `Models/V1OrganizationsServicesClickpipesCdcScalingResponse.cs` |
| `ClickPipeCdcScalingGetError` | `Errors/ClickPipeCdcScalingGetError.cs` |
| `V1OrganizationsServicesClickpipesCdcScaling400Error1` | `Models/V1OrganizationsServicesClickpipesCdcScaling400Error1.cs` |
| `V1OrganizationsServicesClickpipesCdcScaling500Error1` | `Models/V1OrganizationsServicesClickpipesCdcScaling500Error1.cs` |

### ClickPipeCdcScalingUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeCdcScalingUpdate(Guid organizationId, Guid serviceId, ClickPipesCdcScalingPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickpipesCdcScalingResponse`
- **Error**: `SdkException<ClickPipeCdcScalingUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesCdcScaling400Error1(out V1OrganizationsServicesClickpipesCdcScaling400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesCdcScaling500Error1(out V1OrganizationsServicesClickpipesCdcScaling500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickPipesCdcScalingPatchRequest` | `Models/ClickPipesCdcScalingPatchRequest.cs` |
| `V1OrganizationsServicesClickpipesCdcScalingResponse` | `Models/V1OrganizationsServicesClickpipesCdcScalingResponse.cs` |
| `ClickPipeCdcScalingUpdateError` | `Errors/ClickPipeCdcScalingUpdateError.cs` |
| `V1OrganizationsServicesClickpipesCdcScaling400Error1` | `Models/V1OrganizationsServicesClickpipesCdcScaling400Error1.cs` |
| `V1OrganizationsServicesClickpipesCdcScaling500Error1` | `Models/V1OrganizationsServicesClickpipesCdcScaling500Error1.cs` |

### ClickPipeCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeCreate(Guid organizationId, Guid serviceId, ClickPipePostRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickpipesResponse1`
- **Error**: `SdkException<ClickPipeCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipes400Error1(out V1OrganizationsServicesClickpipes400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipes500Error1(out V1OrganizationsServicesClickpipes500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickPipePostRequest` | `Models/ClickPipePostRequest.cs` |
| `V1OrganizationsServicesClickpipesResponse1` | `Models/V1OrganizationsServicesClickpipesResponse1.cs` |
| `ClickPipeCreateError` | `Errors/ClickPipeCreateError.cs` |
| `V1OrganizationsServicesClickpipes400Error1` | `Models/V1OrganizationsServicesClickpipes400Error1.cs` |
| `V1OrganizationsServicesClickpipes500Error1` | `Models/V1OrganizationsServicesClickpipes500Error1.cs` |

### ClickPipeDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeDelete(Guid organizationId, Guid serviceId, Guid clickPipeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickpipesClickPipeIdResponse2`
- **Error**: `SdkException<ClickPipeDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesClickPipeId400Error1(out V1OrganizationsServicesClickpipesClickPipeId400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesClickPipeId500Error1(out V1OrganizationsServicesClickpipesClickPipeId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickpipesClickPipeIdResponse2` | `Models/V1OrganizationsServicesClickpipesClickPipeIdResponse2.cs` |
| `ClickPipeDeleteError` | `Errors/ClickPipeDeleteError.cs` |
| `V1OrganizationsServicesClickpipesClickPipeId400Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeId400Error1.cs` |
| `V1OrganizationsServicesClickpipesClickPipeId500Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeId500Error1.cs` |

### ClickPipeGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeGet(Guid organizationId, Guid serviceId, Guid clickPipeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickpipesClickPipeIdResponse`
- **Error**: `SdkException<ClickPipeGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesClickPipeId400Error1(out V1OrganizationsServicesClickpipesClickPipeId400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesClickPipeId500Error1(out V1OrganizationsServicesClickpipesClickPipeId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickpipesClickPipeIdResponse` | `Models/V1OrganizationsServicesClickpipesClickPipeIdResponse.cs` |
| `ClickPipeGetError` | `Errors/ClickPipeGetError.cs` |
| `V1OrganizationsServicesClickpipesClickPipeId400Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeId400Error1.cs` |
| `V1OrganizationsServicesClickpipesClickPipeId500Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeId500Error1.cs` |

### ClickPipeGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeGetList(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickpipesResponse`
- **Error**: `SdkException<ClickPipeGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipes400Error1(out V1OrganizationsServicesClickpipes400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipes500Error1(out V1OrganizationsServicesClickpipes500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickpipesResponse` | `Models/V1OrganizationsServicesClickpipesResponse.cs` |
| `ClickPipeGetListError` | `Errors/ClickPipeGetListError.cs` |
| `V1OrganizationsServicesClickpipes400Error1` | `Models/V1OrganizationsServicesClickpipes400Error1.cs` |
| `V1OrganizationsServicesClickpipes500Error1` | `Models/V1OrganizationsServicesClickpipes500Error1.cs` |

### ClickPipeReversePrivateEndpointCreate

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeReversePrivateEndpointCreate(Guid organizationId, Guid serviceId, CreateReversePrivateEndpoint? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1`
- **Error**: `SdkException<ClickPipeReversePrivateEndpointCreateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateReversePrivateEndpoint` | `Models/CreateReversePrivateEndpoint.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse1.cs` |
| `ClickPipeReversePrivateEndpointCreateError` | `Errors/ClickPipeReversePrivateEndpointCreateError.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1.cs` |

### ClickPipeReversePrivateEndpointDelete

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeReversePrivateEndpointDelete(Guid organizationId, Guid serviceId, Guid reversePrivateEndpointId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1`
- **Error**: `SdkException<ClickPipeReversePrivateEndpointDeleteError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse1.cs` |
| `ClickPipeReversePrivateEndpointDeleteError` | `Errors/ClickPipeReversePrivateEndpointDeleteError.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1.cs` |

### ClickPipeReversePrivateEndpointGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeReversePrivateEndpointGet(Guid organizationId, Guid serviceId, Guid reversePrivateEndpointId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse`
- **Error**: `SdkException<ClickPipeReversePrivateEndpointGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse.cs` |
| `ClickPipeReversePrivateEndpointGetError` | `Errors/ClickPipeReversePrivateEndpointGetError.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1.cs` |

### ClickPipeReversePrivateEndpointGetList

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeReversePrivateEndpointGetList(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse`
- **Error**: `SdkException<ClickPipeReversePrivateEndpointGetListError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsResponse.cs` |
| `ClickPipeReversePrivateEndpointGetListError` | `Errors/ClickPipeReversePrivateEndpointGetListError.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpoints400Error1.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpoints500Error1.cs` |

### ClickPipeReversePrivateEndpointUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeReversePrivateEndpointUpdate(Guid organizationId, Guid serviceId, Guid reversePrivateEndpointId, UpdateReversePrivateEndpoint? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse`
- **Error**: `SdkException<ClickPipeReversePrivateEndpointUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1(out V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateReversePrivateEndpoint` | `Models/UpdateReversePrivateEndpoint.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointIdResponse.cs` |
| `ClickPipeReversePrivateEndpointUpdateError` | `Errors/ClickPipeReversePrivateEndpointUpdateError.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId400Error1.cs` |
| `V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1` | `Models/V1OrganizationsServicesClickpipesReversePrivateEndpointsReversePrivateEndpointId500Error1.cs` |

### ClickPipeScalingUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeScalingUpdate(Guid organizationId, Guid serviceId, Guid clickPipeId, ClickPipeScalingPatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickpipesClickPipeIdScalingResponse`
- **Error**: `SdkException<ClickPipeScalingUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesClickPipeIdScaling400Error1(out V1OrganizationsServicesClickpipesClickPipeIdScaling400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesClickPipeIdScaling500Error1(out V1OrganizationsServicesClickpipesClickPipeIdScaling500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickPipeScalingPatchRequest` | `Models/ClickPipeScalingPatchRequest.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdScalingResponse` | `Models/V1OrganizationsServicesClickpipesClickPipeIdScalingResponse.cs` |
| `ClickPipeScalingUpdateError` | `Errors/ClickPipeScalingUpdateError.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdScaling400Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeIdScaling400Error1.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdScaling500Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeIdScaling500Error1.cs` |

### ClickPipeSchemaDiscovery

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeSchemaDiscovery(Guid organizationId, Guid serviceId, ClickPipeSchemaDiscoveryRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickpipesSchemaDiscoveryResponse`
- **Error**: `SdkException<ClickPipeSchemaDiscoveryError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesSchemaDiscovery400Error1(out V1OrganizationsServicesClickpipesSchemaDiscovery400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesSchemaDiscovery500Error1(out V1OrganizationsServicesClickpipesSchemaDiscovery500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickPipeSchemaDiscoveryRequest` | `Models/ClickPipeSchemaDiscoveryRequest.cs` |
| `V1OrganizationsServicesClickpipesSchemaDiscoveryResponse` | `Models/V1OrganizationsServicesClickpipesSchemaDiscoveryResponse.cs` |
| `ClickPipeSchemaDiscoveryError` | `Errors/ClickPipeSchemaDiscoveryError.cs` |
| `V1OrganizationsServicesClickpipesSchemaDiscovery400Error1` | `Models/V1OrganizationsServicesClickpipesSchemaDiscovery400Error1.cs` |
| `V1OrganizationsServicesClickpipesSchemaDiscovery500Error1` | `Models/V1OrganizationsServicesClickpipesSchemaDiscovery500Error1.cs` |

### ClickPipeSettingsGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeSettingsGet(Guid organizationId, Guid serviceId, Guid clickPipeId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse`
- **Error**: `SdkException<ClickPipeSettingsGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesClickPipeIdSettings400Error1(out V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesClickPipeIdSettings500Error1(out V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse` | `Models/V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse.cs` |
| `ClickPipeSettingsGetError` | `Errors/ClickPipeSettingsGetError.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1.cs` |

### ClickPipeSettingsUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeSettingsUpdate(Guid organizationId, Guid serviceId, Guid clickPipeId, ClickPipeSettingsPutRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse`
- **Error**: `SdkException<ClickPipeSettingsUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesClickPipeIdSettings400Error1(out V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesClickPipeIdSettings500Error1(out V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickPipeSettingsPutRequest` | `Models/ClickPipeSettingsPutRequest.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse` | `Models/V1OrganizationsServicesClickpipesClickPipeIdSettingsResponse.cs` |
| `ClickPipeSettingsUpdateError` | `Errors/ClickPipeSettingsUpdateError.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeIdSettings400Error1.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeIdSettings500Error1.cs` |

### ClickPipeStateUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeStateUpdate(Guid organizationId, Guid serviceId, Guid clickPipeId, ClickPipeStatePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickpipesClickPipeIdStateResponse`
- **Error**: `SdkException<ClickPipeStateUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesClickPipeIdState400Error1(out V1OrganizationsServicesClickpipesClickPipeIdState400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesClickPipeIdState500Error1(out V1OrganizationsServicesClickpipesClickPipeIdState500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickPipeStatePatchRequest` | `Models/ClickPipeStatePatchRequest.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdStateResponse` | `Models/V1OrganizationsServicesClickpipesClickPipeIdStateResponse.cs` |
| `ClickPipeStateUpdateError` | `Errors/ClickPipeStateUpdateError.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdState400Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeIdState400Error1.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdState500Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeIdState500Error1.cs` |

### ClickPipeUpdate

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipeUpdate(Guid organizationId, Guid serviceId, Guid clickPipeId, ClickPipePatchRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `V1OrganizationsServicesClickpipesClickPipeIdResponse`
- **Error**: `SdkException<ClickPipeUpdateError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesClickPipeId400Error1(out V1OrganizationsServicesClickpipesClickPipeId400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesClickPipeId500Error1(out V1OrganizationsServicesClickpipesClickPipeId500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ClickPipePatchRequest` | `Models/ClickPipePatchRequest.cs` |
| `V1OrganizationsServicesClickpipesClickPipeIdResponse` | `Models/V1OrganizationsServicesClickpipesClickPipeIdResponse.cs` |
| `ClickPipeUpdateError` | `Errors/ClickPipeUpdateError.cs` |
| `V1OrganizationsServicesClickpipesClickPipeId400Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeId400Error1.cs` |
| `V1OrganizationsServicesClickpipesClickPipeId500Error1` | `Models/V1OrganizationsServicesClickpipesClickPipeId500Error1.cs` |

### ClickPipesServiceContextGet

- **Auth**: `options.BasicAuth`
- **Signature**: `ClickPipesServiceContextGet(Guid organizationId, Guid serviceId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `V1OrganizationsServicesClickpipesContextResponse`
- **Error**: `SdkException<ClickPipesServiceContextGetError>` — **Case A (typed)**
- **Error accessors**: `TryGetV1OrganizationsServicesClickpipesContext400Error1(out V1OrganizationsServicesClickpipesContext400Error1)` [400] · `TryGetV1OrganizationsServicesClickpipesContext500Error1(out V1OrganizationsServicesClickpipesContext500Error1)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `V1OrganizationsServicesClickpipesContextResponse` | `Models/V1OrganizationsServicesClickpipesContextResponse.cs` |
| `ClickPipesServiceContextGetError` | `Errors/ClickPipesServiceContextGetError.cs` |
| `V1OrganizationsServicesClickpipesContext400Error1` | `Models/V1OrganizationsServicesClickpipesContext400Error1.cs` |
| `V1OrganizationsServicesClickpipesContext500Error1` | `Models/V1OrganizationsServicesClickpipesContext500Error1.cs` |

