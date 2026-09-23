# Backup

```csharp
BackupApi backupApi = client.BackupApi;
```

## Class Name

`BackupApi`

## Methods

* [Backup Get List](../../doc/controllers/backup.md#backup-get-list)
* [Backup Get](../../doc/controllers/backup.md#backup-get)
* [Backup Configuration Get](../../doc/controllers/backup.md#backup-configuration-get)
* [Backup Configuration Update](../../doc/controllers/backup.md#backup-configuration-update)
* [Backup Bucket Get](../../doc/controllers/backup.md#backup-bucket-get)
* [Backup Bucket Create](../../doc/controllers/backup.md#backup-bucket-create)
* [Backup Bucket Update](../../doc/controllers/backup.md#backup-bucket-update)
* [Backup Bucket Delete](../../doc/controllers/backup.md#backup-bucket-delete)


# Backup Get List

Returns a list of all backups for the service. The most recent backups comes first in the list.

```csharp
BackupGetListAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the backup. |
| `serviceId` | `Guid` | Template, Required | ID of the service the backup was created from. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesBackupsResponse](../../doc/models/v1-organizations-services-backups-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesBackupsResponse> result = await backupApi.BackupGetListAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesBackups400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackups400ErrorException exception here
    }
    if (e is V1OrganizationsServicesBackups500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackups500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesBackups400ErrorException`](../../doc/models/v1-organizations-services-backups-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesBackups500ErrorException`](../../doc/models/v1-organizations-services-backups-500-error-exception.md) |


# Backup Get

Returns a single backup info.

```csharp
BackupGetAsync(
    Guid organizationId,
    Guid serviceId,
    Guid backupId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the backup. |
| `serviceId` | `Guid` | Template, Required | ID of the service the backup was created from. |
| `backupId` | `Guid` | Template, Required | ID of the requested backup. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesBackupsBackupIdResponse](../../doc/models/v1-organizations-services-backups-backup-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
Guid backupId = new Guid("00000c90-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesBackupsBackupIdResponse> result = await backupApi.BackupGetAsync(
        organizationId,
        serviceId,
        backupId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesBackupsBackupId400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupsBackupId400ErrorException exception here
    }
    if (e is V1OrganizationsServicesBackupsBackupId500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupsBackupId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesBackupsBackupId400ErrorException`](../../doc/models/v1-organizations-services-backups-backup-id-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesBackupsBackupId500ErrorException`](../../doc/models/v1-organizations-services-backups-backup-id-500-error-exception.md) |


# Backup Configuration Get

Returns the service backup configuration.

```csharp
BackupConfigurationGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesBackupConfigurationResponse](../../doc/models/v1-organizations-services-backup-configuration-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesBackupConfigurationResponse> result = await backupApi.BackupConfigurationGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesBackupConfiguration400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupConfiguration400ErrorException exception here
    }
    if (e is V1OrganizationsServicesBackupConfiguration500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupConfiguration500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesBackupConfiguration400ErrorException`](../../doc/models/v1-organizations-services-backup-configuration-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesBackupConfiguration500ErrorException`](../../doc/models/v1-organizations-services-backup-configuration-500-error-exception.md) |


# Backup Configuration Update

Updates service backup configuration. Requires ADMIN auth key role. Setting the properties with null value, will reset the properties to theirs default values.

```csharp
BackupConfigurationUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    Models.BackupConfigurationPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |
| `body` | [`BackupConfigurationPatchRequest`](../../doc/models/backup-configuration-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesBackupConfigurationResponse](../../doc/models/v1-organizations-services-backup-configuration-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesBackupConfigurationResponse> result = await backupApi.BackupConfigurationUpdateAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesBackupConfiguration400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupConfiguration400ErrorException exception here
    }
    if (e is V1OrganizationsServicesBackupConfiguration500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupConfiguration500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesBackupConfiguration400ErrorException`](../../doc/models/v1-organizations-services-backup-configuration-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesBackupConfiguration500ErrorException`](../../doc/models/v1-organizations-services-backup-configuration-500-error-exception.md) |


# Backup Bucket Get

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Returns the service backup bucket.

```csharp
BackupBucketGetAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the organization that owns the service. |
| `serviceId` | `Guid` | Template, Required | ID of the service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesBackupBucketResponse](../../doc/models/v1-organizations-services-backup-bucket-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesBackupBucketResponse> result = await backupApi.BackupBucketGetAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesBackupBucket400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupBucket400ErrorException exception here
    }
    if (e is V1OrganizationsServicesBackupBucket500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupBucket500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesBackupBucket400ErrorException`](../../doc/models/v1-organizations-services-backup-bucket-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesBackupBucket500ErrorException`](../../doc/models/v1-organizations-services-backup-bucket-500-error-exception.md) |


# Backup Bucket Create

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Create service backup bucket. Requires ADMIN auth key role.

```csharp
BackupBucketCreateAsync(
    Guid organizationId,
    Guid serviceId,
    BackupBucketPostRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `body` | [`BackupBucketPostRequest`](../../doc/models/containers/backup-bucket-post-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesBackupBucketResponse](../../doc/models/v1-organizations-services-backup-bucket-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesBackupBucketResponse> result = await backupApi.BackupBucketCreateAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesBackupBucket400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupBucket400ErrorException exception here
    }
    if (e is V1OrganizationsServicesBackupBucket500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupBucket500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesBackupBucket400ErrorException`](../../doc/models/v1-organizations-services-backup-bucket-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesBackupBucket500ErrorException`](../../doc/models/v1-organizations-services-backup-bucket-500-error-exception.md) |


# Backup Bucket Update

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Update service backup bucket. Requires ADMIN auth key role. The secrets of the specified bucket provider are always required

```csharp
BackupBucketUpdateAsync(
    Guid organizationId,
    Guid serviceId,
    BackupBucketPatchRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `body` | [`BackupBucketPatchRequest`](../../doc/models/containers/backup-bucket-patch-request.md) | Body, Optional | - |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesBackupBucketResponse](../../doc/models/v1-organizations-services-backup-bucket-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesBackupBucketResponse> result = await backupApi.BackupBucketUpdateAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesBackupBucket400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupBucket400ErrorException exception here
    }
    if (e is V1OrganizationsServicesBackupBucket500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupBucket500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesBackupBucket400ErrorException`](../../doc/models/v1-organizations-services-backup-bucket-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesBackupBucket500ErrorException`](../../doc/models/v1-organizations-services-backup-bucket-500-error-exception.md) |


# Backup Bucket Delete

**This endpoint is in beta.** API contract is stable, and no breaking changes are expected in the future. <br /><br /> Delete service backup bucket. Requires ADMIN auth key role.

```csharp
BackupBucketDeleteAsync(
    Guid organizationId,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |

## Response Type

**200**: Successful response

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsServicesBackupBucketResponse3](../../doc/models/v1-organizations-services-backup-bucket-response-3.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsServicesBackupBucketResponse3> result = await backupApi.BackupBucketDeleteAsync(
        organizationId,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsServicesBackupBucket400ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupBucket400ErrorException exception here
    }
    if (e is V1OrganizationsServicesBackupBucket500ErrorException)
    {
       // TODO: Handle V1OrganizationsServicesBackupBucket500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsServicesBackupBucket400ErrorException`](../../doc/models/v1-organizations-services-backup-bucket-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsServicesBackupBucket500ErrorException`](../../doc/models/v1-organizations-services-backup-bucket-500-error-exception.md) |

