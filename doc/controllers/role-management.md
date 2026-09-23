# Role Management

```csharp
RoleManagementApi roleManagementApi = client.RoleManagementApi;
```

## Class Name

`RoleManagementApi`

## Methods

* [Organization Roles Get List](../../doc/controllers/role-management.md#organization-roles-get-list)
* [Organization Role Post](../../doc/controllers/role-management.md#organization-role-post)
* [Organization Role Get](../../doc/controllers/role-management.md#organization-role-get)
* [Organization Role Patch](../../doc/controllers/role-management.md#organization-role-patch)
* [Organization Role Delete](../../doc/controllers/role-management.md#organization-role-delete)


# Organization Roles Get List

Returns all available roles (system + custom) for an organization.

```csharp
OrganizationRolesGetListAsync(
    Guid organizationId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsRolesResponse](../../doc/models/v1-organizations-roles-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsRolesResponse> result = await roleManagementApi.OrganizationRolesGetListAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsRoles400ErrorException)
    {
       // TODO: Handle V1OrganizationsRoles400ErrorException exception here
    }
    if (e is V1OrganizationsRoles500ErrorException)
    {
       // TODO: Handle V1OrganizationsRoles500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsRoles400ErrorException`](../../doc/models/v1-organizations-roles-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsRoles500ErrorException`](../../doc/models/v1-organizations-roles-500-error-exception.md) |


# Organization Role Post

Creates a new custom role for an organization with specified policies and actors.

```csharp
OrganizationRolePostAsync(
    Guid organizationId,
    Models.RoleCreateRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `body` | [`RoleCreateRequest`](../../doc/models/role-create-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsRolesResponse1](../../doc/models/v1-organizations-roles-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
RoleCreateRequest body = new RoleCreateRequest
{
    Name = "name6",
    Actors = new List<string>
    {
        "actors9",
        "actors0",
        "actors1",
    },
    Policies = new List<RbacPolicyCreateRequest>
    {
        new RbacPolicyCreateRequest
        {
            AllowDeny = AllowDeny.Allow,
            Permissions = new List<string>
            {
                "permissions5",
            },
            Resources = new List<string>
            {
                "resources3",
                "resources2",
                "resources1",
            },
        },
    },
};

try
{
    ApiResponse<V1OrganizationsRolesResponse1> result = await roleManagementApi.OrganizationRolePostAsync(
        organizationId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsRoles400ErrorException)
    {
       // TODO: Handle V1OrganizationsRoles400ErrorException exception here
    }
    if (e is V1OrganizationsRoles500ErrorException)
    {
       // TODO: Handle V1OrganizationsRoles500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsRoles400ErrorException`](../../doc/models/v1-organizations-roles-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsRoles500ErrorException`](../../doc/models/v1-organizations-roles-500-error-exception.md) |


# Organization Role Get

Returns details for a specific role.

```csharp
OrganizationRoleGetAsync(
    Guid organizationId,
    Guid roleId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `roleId` | `Guid` | Template, Required | ID of the requested role. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsRolesResponse1](../../doc/models/v1-organizations-roles-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid roleId = new Guid("00000178-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsRolesResponse1> result = await roleManagementApi.OrganizationRoleGetAsync(
        organizationId,
        roleId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsRoles400ErrorException)
    {
       // TODO: Handle V1OrganizationsRoles400ErrorException exception here
    }
    if (e is V1OrganizationsRoles500ErrorException)
    {
       // TODO: Handle V1OrganizationsRoles500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsRoles400ErrorException`](../../doc/models/v1-organizations-roles-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsRoles500ErrorException`](../../doc/models/v1-organizations-roles-500-error-exception.md) |


# Organization Role Patch

Updates an existing custom role. System roles cannot be updated. All fields are optional - only provided fields will be updated.

```csharp
OrganizationRolePatchAsync(
    Guid organizationId,
    Guid roleId,
    Models.RoleUpdateRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `roleId` | `Guid` | Template, Required | ID of the requested role. |
| `body` | [`RoleUpdateRequest`](../../doc/models/role-update-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsRolesResponse1](../../doc/models/v1-organizations-roles-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid roleId = new Guid("00000178-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsRolesResponse1> result = await roleManagementApi.OrganizationRolePatchAsync(
        organizationId,
        roleId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsRoles400ErrorException)
    {
       // TODO: Handle V1OrganizationsRoles400ErrorException exception here
    }
    if (e is V1OrganizationsRoles500ErrorException)
    {
       // TODO: Handle V1OrganizationsRoles500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsRoles400ErrorException`](../../doc/models/v1-organizations-roles-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsRoles500ErrorException`](../../doc/models/v1-organizations-roles-500-error-exception.md) |


# Organization Role Delete

Deletes an existing custom role. System roles cannot be deleted. This operation will remove the role and all its associated policies.

```csharp
OrganizationRoleDeleteAsync(
    Guid organizationId,
    Guid roleId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `roleId` | `Guid` | Template, Required | ID of the requested role. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsRolesResponse4](../../doc/models/v1-organizations-roles-response-4.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid roleId = new Guid("00000178-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsRolesResponse4> result = await roleManagementApi.OrganizationRoleDeleteAsync(
        organizationId,
        roleId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsRoles400ErrorException)
    {
       // TODO: Handle V1OrganizationsRoles400ErrorException exception here
    }
    if (e is V1OrganizationsRoles500ErrorException)
    {
       // TODO: Handle V1OrganizationsRoles500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsRoles400ErrorException`](../../doc/models/v1-organizations-roles-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsRoles500ErrorException`](../../doc/models/v1-organizations-roles-500-error-exception.md) |

