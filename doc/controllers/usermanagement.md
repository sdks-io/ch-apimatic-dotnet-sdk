# Usermanagement

```csharp
UsermanagementApi usermanagementApi = client.UsermanagementApi;
```

## Class Name

`UsermanagementApi`

## Methods

* [Member Get List](../../doc/controllers/usermanagement.md#member-get-list)
* [Member Get](../../doc/controllers/usermanagement.md#member-get)
* [Member Update](../../doc/controllers/usermanagement.md#member-update)
* [Member Delete](../../doc/controllers/usermanagement.md#member-delete)
* [Invitation Get List](../../doc/controllers/usermanagement.md#invitation-get-list)
* [Invitation Create](../../doc/controllers/usermanagement.md#invitation-create)
* [Invitation Get](../../doc/controllers/usermanagement.md#invitation-get)
* [Invitation Delete](../../doc/controllers/usermanagement.md#invitation-delete)


# Member Get List

Returns a list of all members in the organization.

```csharp
MemberGetListAsync(
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

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsMembersResponse](../../doc/models/v1-organizations-members-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsMembersResponse> result = await userManagementApi.MemberGetListAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsMembers400ErrorException)
    {
       // TODO: Handle V1OrganizationsMembers400ErrorException exception here
    }
    if (e is V1OrganizationsMembers500ErrorException)
    {
       // TODO: Handle V1OrganizationsMembers500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsMembers400ErrorException`](../../doc/models/v1-organizations-members-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsMembers500ErrorException`](../../doc/models/v1-organizations-members-500-error-exception.md) |


# Member Get

Returns a single organization member details.

```csharp
MemberGetAsync(
    Guid organizationId,
    Guid userId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization the member is part of. |
| `userId` | `Guid` | Template, Required | ID of the requested user. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsMembersResponse1](../../doc/models/v1-organizations-members-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid userId = new Guid("000013ec-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsMembersResponse1> result = await userManagementApi.MemberGetAsync(
        organizationId,
        userId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsMembers400ErrorException)
    {
       // TODO: Handle V1OrganizationsMembers400ErrorException exception here
    }
    if (e is V1OrganizationsMembers500ErrorException)
    {
       // TODO: Handle V1OrganizationsMembers500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsMembers400ErrorException`](../../doc/models/v1-organizations-members-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsMembers500ErrorException`](../../doc/models/v1-organizations-members-500-error-exception.md) |


# Member Update

Updates organization member role.

```csharp
MemberUpdateAsync(
    Guid organizationId,
    Guid userId,
    Models.MemberPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization the member is part of. |
| `userId` | `Guid` | Template, Required | ID of the user to patch |
| `body` | [`MemberPatchRequest`](../../doc/models/member-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsMembersResponse1](../../doc/models/v1-organizations-members-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid userId = new Guid("000013ec-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsMembersResponse1> result = await userManagementApi.MemberUpdateAsync(
        organizationId,
        userId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsMembers400ErrorException)
    {
       // TODO: Handle V1OrganizationsMembers400ErrorException exception here
    }
    if (e is V1OrganizationsMembers500ErrorException)
    {
       // TODO: Handle V1OrganizationsMembers500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsMembers400ErrorException`](../../doc/models/v1-organizations-members-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsMembers500ErrorException`](../../doc/models/v1-organizations-members-500-error-exception.md) |


# Member Delete

Removes a user from the organization

```csharp
MemberDeleteAsync(
    Guid organizationId,
    Guid userId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `userId` | `Guid` | Template, Required | ID of the requested user. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsMembersResponse3](../../doc/models/v1-organizations-members-response-3.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid userId = new Guid("000013ec-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsMembersResponse3> result = await userManagementApi.MemberDeleteAsync(
        organizationId,
        userId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsMembers400ErrorException)
    {
       // TODO: Handle V1OrganizationsMembers400ErrorException exception here
    }
    if (e is V1OrganizationsMembers500ErrorException)
    {
       // TODO: Handle V1OrganizationsMembers500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsMembers400ErrorException`](../../doc/models/v1-organizations-members-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsMembers500ErrorException`](../../doc/models/v1-organizations-members-500-error-exception.md) |


# Invitation Get List

Returns list of all organization invitations.

```csharp
InvitationGetListAsync(
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

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsInvitationsResponse](../../doc/models/v1-organizations-invitations-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsInvitationsResponse> result = await userManagementApi.InvitationGetListAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsInvitations400ErrorException)
    {
       // TODO: Handle V1OrganizationsInvitations400ErrorException exception here
    }
    if (e is V1OrganizationsInvitations500ErrorException)
    {
       // TODO: Handle V1OrganizationsInvitations500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsInvitations400ErrorException`](../../doc/models/v1-organizations-invitations-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsInvitations500ErrorException`](../../doc/models/v1-organizations-invitations-500-error-exception.md) |


# Invitation Create

Creates organization invitation.

```csharp
InvitationCreateAsync(
    Guid organizationId,
    Models.InvitationPostRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization to invite a user to. |
| `body` | [`InvitationPostRequest`](../../doc/models/invitation-post-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsInvitationsResponse1](../../doc/models/v1-organizations-invitations-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsInvitationsResponse1> result = await userManagementApi.InvitationCreateAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsInvitations400ErrorException)
    {
       // TODO: Handle V1OrganizationsInvitations400ErrorException exception here
    }
    if (e is V1OrganizationsInvitations500ErrorException)
    {
       // TODO: Handle V1OrganizationsInvitations500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsInvitations400ErrorException`](../../doc/models/v1-organizations-invitations-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsInvitations500ErrorException`](../../doc/models/v1-organizations-invitations-500-error-exception.md) |


# Invitation Get

Returns details for a single organization invitation.

```csharp
InvitationGetAsync(
    Guid organizationId,
    Guid invitationId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `invitationId` | `Guid` | Template, Required | ID of the requested organization. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsInvitationsResponse1](../../doc/models/v1-organizations-invitations-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid invitationId = new Guid("0000032c-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsInvitationsResponse1> result = await userManagementApi.InvitationGetAsync(
        organizationId,
        invitationId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsInvitations400ErrorException)
    {
       // TODO: Handle V1OrganizationsInvitations400ErrorException exception here
    }
    if (e is V1OrganizationsInvitations500ErrorException)
    {
       // TODO: Handle V1OrganizationsInvitations500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsInvitations400ErrorException`](../../doc/models/v1-organizations-invitations-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsInvitations500ErrorException`](../../doc/models/v1-organizations-invitations-500-error-exception.md) |


# Invitation Delete

Deletes a single organization invitation.

```csharp
InvitationDeleteAsync(
    Guid organizationId,
    Guid invitationId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that has the invitation. |
| `invitationId` | `Guid` | Template, Required | ID of the requested organization. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsInvitationsResponse3](../../doc/models/v1-organizations-invitations-response-3.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid invitationId = new Guid("0000032c-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsInvitationsResponse3> result = await userManagementApi.InvitationDeleteAsync(
        organizationId,
        invitationId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsInvitations400ErrorException)
    {
       // TODO: Handle V1OrganizationsInvitations400ErrorException exception here
    }
    if (e is V1OrganizationsInvitations500ErrorException)
    {
       // TODO: Handle V1OrganizationsInvitations500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsInvitations400ErrorException`](../../doc/models/v1-organizations-invitations-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsInvitations500ErrorException`](../../doc/models/v1-organizations-invitations-500-error-exception.md) |

