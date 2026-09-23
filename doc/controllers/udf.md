# UDF

```csharp
UdfApi udfApi = client.UdfApi;
```

## Class Name

`UdfApi`

## Methods

* [Udf Attach](../../doc/controllers/udf.md#udf-attach)
* [Udf Attachment Get](../../doc/controllers/udf.md#udf-attachment-get)
* [Udf Detach](../../doc/controllers/udf.md#udf-detach)
* [Udf Attachment List](../../doc/controllers/udf.md#udf-attachment-list)
* [Udf Create](../../doc/controllers/udf.md#udf-create)
* [Udf List](../../doc/controllers/udf.md#udf-list)
* [Udf Delete](../../doc/controllers/udf.md#udf-delete)
* [Udf Get](../../doc/controllers/udf.md#udf-get)
* [Udf Upload Session Create](../../doc/controllers/udf.md#udf-upload-session-create)
* [Udf Version Create](../../doc/controllers/udf.md#udf-version-create)
* [Udf Version List](../../doc/controllers/udf.md#udf-version-list)
* [Udf Version Delete](../../doc/controllers/udf.md#udf-version-delete)


# Udf Attach

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Attaches one UDF version to a service, replacing the current version when necessary. When version is omitted, the latest ready version is attached.

```csharp
UdfAttachAsync(
    Guid organizationId,
    string functionName,
    Guid serviceId,
    Models.V1OrganizationsUdfsAttachmentsServiceIdRequest body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `functionName` | `string` | Template, Required | Name of the UDF.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |
| `body` | [`V1OrganizationsUdfsAttachmentsServiceIdRequest`](../../doc/models/v1-organizations-udfs-attachments-service-id-request.md) | Body, Optional | - |

## Response Type

**200**: Current attachment state.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsAttachmentsServiceIdResponse](../../doc/models/v1-organizations-udfs-attachments-service-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string functionName = "functionName2";
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
V1OrganizationsUdfsAttachmentsServiceIdRequest body = new V1OrganizationsUdfsAttachmentsServiceIdRequest
{
    Version = 1,
};

try
{
    ApiResponse<V1OrganizationsUdfsAttachmentsServiceIdResponse> result = await udfApi.UdfAttachAsync(
        organizationId,
        functionName,
        serviceId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfsAttachmentsServiceId400ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId400ErrorException exception here
    }
    if (e is V1OrganizationsUdfsAttachmentsServiceId404ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId404ErrorException exception here
    }
    if (e is V1OrganizationsUdfsAttachmentsServiceId409ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId409ErrorException exception here
    }
    if (e is V1OrganizationsUdfsAttachmentsServiceId422ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId422ErrorException exception here
    }
    if (e is V1OrganizationsUdfsAttachmentsServiceId424ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId424ErrorException exception here
    }
    if (e is V1OrganizationsUdfsAttachmentsServiceId500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The service does not support UDFs. | [`V1OrganizationsUdfsAttachmentsServiceId400ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-400-error-exception.md) |
| 404 | UDF, version, or service not found. | [`V1OrganizationsUdfsAttachmentsServiceId404ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-404-error-exception.md) |
| 409 | The requested version is not ready or another attachment transition is in progress. | [`V1OrganizationsUdfsAttachmentsServiceId409ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-409-error-exception.md) |
| 422 | Service UDF attachment limit exceeded. | [`V1OrganizationsUdfsAttachmentsServiceId422ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-422-error-exception.md) |
| 424 | The service must be running before the UDF can be attached. | [`V1OrganizationsUdfsAttachmentsServiceId424ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-424-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfsAttachmentsServiceId500ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-500-error-exception.md) |


# Udf Attachment Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the current attachment of a UDF to one service.

```csharp
UdfAttachmentGetAsync(
    Guid organizationId,
    string functionName,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `functionName` | `string` | Template, Required | Name of the UDF.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |

## Response Type

**200**: Successful response.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsAttachmentsServiceIdResponse](../../doc/models/v1-organizations-udfs-attachments-service-id-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string functionName = "functionName2";
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsUdfsAttachmentsServiceIdResponse> result = await udfApi.UdfAttachmentGetAsync(
        organizationId,
        functionName,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfsAttachmentsServiceId400Error2Exception)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId400Error2Exception exception here
    }
    if (e is V1OrganizationsUdfsAttachmentsServiceId404ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId404ErrorException exception here
    }
    if (e is V1OrganizationsUdfsAttachmentsServiceId500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfsAttachmentsServiceId400Error2Exception`](../../doc/models/v1-organizations-udfs-attachments-service-id-400-error-2-exception.md) |
| 404 | UDF not found or not attached to this service. | [`V1OrganizationsUdfsAttachmentsServiceId404ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-404-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfsAttachmentsServiceId500ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-500-error-exception.md) |


# Udf Detach

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Detaches a UDF from a service.

```csharp
UdfDetachAsync(
    Guid organizationId,
    string functionName,
    Guid serviceId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `functionName` | `string` | Template, Required | Name of the UDF.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |
| `serviceId` | `Guid` | Template, Required | ID of the requested service. |

## Response Type

**200**: UDF detached.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsAttachmentsServiceIdResponse2](../../doc/models/v1-organizations-udfs-attachments-service-id-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string functionName = "functionName2";
Guid serviceId = new Guid("00000060-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsUdfsAttachmentsServiceIdResponse2> result = await udfApi.UdfDetachAsync(
        organizationId,
        functionName,
        serviceId
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfsAttachmentsServiceId400Error2Exception)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId400Error2Exception exception here
    }
    if (e is V1OrganizationsUdfsAttachmentsServiceId404ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId404ErrorException exception here
    }
    if (e is V1OrganizationsUdfsAttachmentsServiceId409ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId409ErrorException exception here
    }
    if (e is V1OrganizationsUdfsAttachmentsServiceId500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachmentsServiceId500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfsAttachmentsServiceId400Error2Exception`](../../doc/models/v1-organizations-udfs-attachments-service-id-400-error-2-exception.md) |
| 404 | UDF not found. | [`V1OrganizationsUdfsAttachmentsServiceId404ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-404-error-exception.md) |
| 409 | An attachment transition is already in progress. | [`V1OrganizationsUdfsAttachmentsServiceId409ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-409-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfsAttachmentsServiceId500ErrorException`](../../doc/models/v1-organizations-udfs-attachments-service-id-500-error-exception.md) |


# Udf Attachment List

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the current service attachments for a UDF, with at most one attachment per service.

```csharp
UdfAttachmentListAsync(
    Guid organizationId,
    string functionName,
    string cursor = null,
    int? limit = 100)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `functionName` | `string` | Template, Required | Name of the UDF.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |
| `cursor` | `string` | Query, Optional | Cursor returned in `pagination.nextCursor` from the previous page. |
| `limit` | `int?` | Query, Optional | Maximum number of records to return per page. Defaults to 100. Maximum is 100.<br><br>**Default**: `100`<br><br>**Constraints**: `>= 1`, `<= 100` |

## Response Type

**200**: Successful response.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsAttachmentsResponse](../../doc/models/v1-organizations-udfs-attachments-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string functionName = "functionName2";
int? limit = 100;
try
{
    ApiResponse<V1OrganizationsUdfsAttachmentsResponse> result = await udfApi.UdfAttachmentListAsync(
        organizationId,
        functionName,
        null,
        limit
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfsAttachments400ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachments400ErrorException exception here
    }
    if (e is V1OrganizationsUdfsAttachments404ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachments404ErrorException exception here
    }
    if (e is V1OrganizationsUdfsAttachments500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsAttachments500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfsAttachments400ErrorException`](../../doc/models/v1-organizations-udfs-attachments-400-error-exception.md) |
| 404 | UDF not found. | [`V1OrganizationsUdfsAttachments404ErrorException`](../../doc/models/v1-organizations-udfs-attachments-404-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfsAttachments500ErrorException`](../../doc/models/v1-organizations-udfs-attachments-500-error-exception.md) |


# Udf Create

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Creates a new UDF. See [User-defined functions in Cloud](https://clickhouse.com/docs/products/cloud/features/sql-console-features/user-defined-functions).

```csharp
UdfCreateAsync(
    Guid organizationId,
    UdfCreateRequest2 body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `body` | [`UdfCreateRequest2`](../../doc/models/containers/udf-create-request-2.md) | Body, Optional | - |

## Response Type

**201**: UDF created and building.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsResponse](../../doc/models/v1-organizations-udfs-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
UdfCreateRequest2 body = UdfCreateRequest2.FromUdfCreateRequest(
    new UdfCreateRequest
    {
        UploadId = new Guid("000017c4-0000-0000-0000-000000000000"),
        Runtime = Runtime.EnumPython311,
        Arguments = new List<UdfArgument>
        {
            new UdfArgument
            {
                Name = "name8",
                Type = "type2",
            },
        },
        ReturnType = "returnType2",
        Type = "executable",
        FunctionName = "functionName2",
        CommandReadTimeout = 10000,
        CommandWriteTimeout = 10000,
        SendChunkHeader = false,
        Deterministic = false,
        Format = "TabSeparated",
        SandboxType = SandboxType.Basic,
        SandboxVersion = SandboxVersion.V2,
    }
);

try
{
    ApiResponse<V1OrganizationsUdfsResponse> result = await udfApi.UdfCreateAsync(
        organizationId,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfs400ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs400ErrorException exception here
    }
    if (e is V1OrganizationsUdfs403ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs403ErrorException exception here
    }
    if (e is V1OrganizationsUdfs409ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs409ErrorException exception here
    }
    if (e is V1OrganizationsUdfs410ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs410ErrorException exception here
    }
    if (e is V1OrganizationsUdfs500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfs400ErrorException`](../../doc/models/v1-organizations-udfs-400-error-exception.md) |
| 403 | Requested UDF features are not enabled. | [`V1OrganizationsUdfs403ErrorException`](../../doc/models/v1-organizations-udfs-403-error-exception.md) |
| 409 | The function name already exists. | [`V1OrganizationsUdfs409ErrorException`](../../doc/models/v1-organizations-udfs-409-error-exception.md) |
| 410 | The source archive is unavailable. | [`V1OrganizationsUdfs410ErrorException`](../../doc/models/v1-organizations-udfs-410-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfs500ErrorException`](../../doc/models/v1-organizations-udfs-500-error-exception.md) |


# Udf List

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the latest version of each UDF in the organization.

```csharp
UdfListAsync(
    Guid organizationId,
    string cursor = null,
    int? limit = 100)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `cursor` | `string` | Query, Optional | Cursor returned in `pagination.nextCursor` from the previous page. |
| `limit` | `int?` | Query, Optional | Maximum number of records to return per page. Defaults to 100. Maximum is 100.<br><br>**Default**: `100`<br><br>**Constraints**: `>= 1`, `<= 100` |

## Response Type

**200**: Successful response.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsResponse1](../../doc/models/v1-organizations-udfs-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
int? limit = 100;
try
{
    ApiResponse<V1OrganizationsUdfsResponse1> result = await udfApi.UdfListAsync(
        organizationId,
        null,
        limit
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfs400ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs400ErrorException exception here
    }
    if (e is V1OrganizationsUdfs500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfs400ErrorException`](../../doc/models/v1-organizations-udfs-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfs500ErrorException`](../../doc/models/v1-organizations-udfs-500-error-exception.md) |


# Udf Delete

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Deletes every version of a UDF and detaches it from all services. Removal from services completes asynchronously.

```csharp
UdfDeleteAsync(
    Guid organizationId,
    string functionName)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `functionName` | `string` | Template, Required | Name of the UDF.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |

## Response Type

**200**: UDF deleted.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsResponse2](../../doc/models/v1-organizations-udfs-response-2.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string functionName = "functionName2";
try
{
    ApiResponse<V1OrganizationsUdfsResponse2> result = await udfApi.UdfDeleteAsync(
        organizationId,
        functionName
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfs400ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs400ErrorException exception here
    }
    if (e is V1OrganizationsUdfs404ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs404ErrorException exception here
    }
    if (e is V1OrganizationsUdfs409ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs409ErrorException exception here
    }
    if (e is V1OrganizationsUdfs500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfs400ErrorException`](../../doc/models/v1-organizations-udfs-400-error-exception.md) |
| 404 | UDF not found. | [`V1OrganizationsUdfs404ErrorException`](../../doc/models/v1-organizations-udfs-404-error-exception.md) |
| 409 | A UDF version is still building. | [`V1OrganizationsUdfs409ErrorException`](../../doc/models/v1-organizations-udfs-409-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfs500ErrorException`](../../doc/models/v1-organizations-udfs-500-error-exception.md) |


# Udf Get

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns the latest version of a UDF.

```csharp
UdfGetAsync(
    Guid organizationId,
    string functionName)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `functionName` | `string` | Template, Required | Name of the UDF.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |

## Response Type

**200**: Successful response.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsResponse](../../doc/models/v1-organizations-udfs-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string functionName = "functionName2";
try
{
    ApiResponse<V1OrganizationsUdfsResponse> result = await udfApi.UdfGetAsync(
        organizationId,
        functionName
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfs400ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs400ErrorException exception here
    }
    if (e is V1OrganizationsUdfs404ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs404ErrorException exception here
    }
    if (e is V1OrganizationsUdfs500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfs500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfs400ErrorException`](../../doc/models/v1-organizations-udfs-400-error-exception.md) |
| 404 | UDF not found. | [`V1OrganizationsUdfs404ErrorException`](../../doc/models/v1-organizations-udfs-404-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfs500ErrorException`](../../doc/models/v1-organizations-udfs-500-error-exception.md) |


# Udf Upload Session Create

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Creates an org-scoped presigned application/zip upload URL. Callers must use an upload ID for only one create or version attempt and request a new upload URL when retrying.

```csharp
UdfUploadSessionCreateAsync(
    Guid organizationId)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |

## Response Type

**201**: Upload URL created.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfUploadsUrlResponse](../../doc/models/v1-organizations-udf-uploads-url-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
try
{
    ApiResponse<V1OrganizationsUdfUploadsUrlResponse> result = await udfApi.UdfUploadSessionCreateAsync(organizationId);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfUploadsUrl400ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfUploadsUrl400ErrorException exception here
    }
    if (e is V1OrganizationsUdfUploadsUrl500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfUploadsUrl500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfUploadsUrl400ErrorException`](../../doc/models/v1-organizations-udf-uploads-url-400-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfUploadsUrl500ErrorException`](../../doc/models/v1-organizations-udf-uploads-url-500-error-exception.md) |


# Udf Version Create

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Consumes a source archive, assigns a version, and starts the UDF build. Optional configuration fields omitted from the request use the defaults documented in the request schema; values are not inherited from the previous version. Retry by requesting a new upload URL and re-uploading.

```csharp
UdfVersionCreateAsync(
    Guid organizationId,
    string functionName,
    UdfVersionCreateRequest2 body = null)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `functionName` | `string` | Template, Required | Name of the UDF.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |
| `body` | [`UdfVersionCreateRequest2`](../../doc/models/containers/udf-version-create-request-2.md) | Body, Optional | - |

## Response Type

**201**: UDF version created and building.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsVersionsResponse](../../doc/models/v1-organizations-udfs-versions-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string functionName = "functionName2";
UdfVersionCreateRequest2 body = UdfVersionCreateRequest2.FromUdfVersionCreateRequest(
    new UdfVersionCreateRequest
    {
        UploadId = new Guid("0000139a-0000-0000-0000-000000000000"),
        Runtime = Runtime.EnumPython311,
        Arguments = new List<UdfArgument>
        {
            new UdfArgument
            {
                Name = "name8",
                Type = "type2",
            },
        },
        ReturnType = "returnType6",
        Type = "executable",
        CommandReadTimeout = 10000,
        CommandWriteTimeout = 10000,
        SendChunkHeader = false,
        Deterministic = false,
        Format = "TabSeparated",
        SandboxType = SandboxType.Basic,
        SandboxVersion = SandboxVersion.V2,
    }
);

try
{
    ApiResponse<V1OrganizationsUdfsVersionsResponse> result = await udfApi.UdfVersionCreateAsync(
        organizationId,
        functionName,
        body
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfsVersions400ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersions400ErrorException exception here
    }
    if (e is V1OrganizationsUdfsVersions403ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersions403ErrorException exception here
    }
    if (e is V1OrganizationsUdfsVersions404ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersions404ErrorException exception here
    }
    if (e is V1OrganizationsUdfsVersions409ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersions409ErrorException exception here
    }
    if (e is V1OrganizationsUdfsVersions410ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersions410ErrorException exception here
    }
    if (e is V1OrganizationsUdfsVersions500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersions500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfsVersions400ErrorException`](../../doc/models/v1-organizations-udfs-versions-400-error-exception.md) |
| 403 | Requested UDF features are not enabled. | [`V1OrganizationsUdfsVersions403ErrorException`](../../doc/models/v1-organizations-udfs-versions-403-error-exception.md) |
| 404 | UDF not found. | [`V1OrganizationsUdfsVersions404ErrorException`](../../doc/models/v1-organizations-udfs-versions-404-error-exception.md) |
| 409 | A concurrent request conflicted with this request. | [`V1OrganizationsUdfsVersions409ErrorException`](../../doc/models/v1-organizations-udfs-versions-409-error-exception.md) |
| 410 | The source archive is unavailable. | [`V1OrganizationsUdfsVersions410ErrorException`](../../doc/models/v1-organizations-udfs-versions-410-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfsVersions500ErrorException`](../../doc/models/v1-organizations-udfs-versions-500-error-exception.md) |


# Udf Version List

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Returns all versions of a UDF.

```csharp
UdfVersionListAsync(
    Guid organizationId,
    string functionName,
    string cursor = null,
    int? limit = 100)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `functionName` | `string` | Template, Required | Name of the UDF.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |
| `cursor` | `string` | Query, Optional | Cursor returned in `pagination.nextCursor` from the previous page. |
| `limit` | `int?` | Query, Optional | Maximum number of records to return per page. Defaults to 100. Maximum is 100.<br><br>**Default**: `100`<br><br>**Constraints**: `>= 1`, `<= 100` |

## Response Type

**200**: Successful response.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsVersionsResponse1](../../doc/models/v1-organizations-udfs-versions-response-1.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string functionName = "functionName2";
int? limit = 100;
try
{
    ApiResponse<V1OrganizationsUdfsVersionsResponse1> result = await udfApi.UdfVersionListAsync(
        organizationId,
        functionName,
        null,
        limit
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfsVersions400ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersions400ErrorException exception here
    }
    if (e is V1OrganizationsUdfsVersions404ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersions404ErrorException exception here
    }
    if (e is V1OrganizationsUdfsVersions500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersions500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfsVersions400ErrorException`](../../doc/models/v1-organizations-udfs-versions-400-error-exception.md) |
| 404 | UDF not found. | [`V1OrganizationsUdfsVersions404ErrorException`](../../doc/models/v1-organizations-udfs-versions-404-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfsVersions500ErrorException`](../../doc/models/v1-organizations-udfs-versions-500-error-exception.md) |


# Udf Version Delete

**Disclaimer:** This beta endpoint is evolving; the API contract may change. <br /><br /> Deletes a UDF version. The UDF must not be attached to any services.

```csharp
UdfVersionDeleteAsync(
    Guid organizationId,
    string functionName,
    int version)
```

## Authentication

This endpoint requires [basicAuth](../../doc/auth/basic-authentication.md)

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `organizationId` | `Guid` | Template, Required | ID of the requested organization. |
| `functionName` | `string` | Template, Required | Name of the UDF.<br><br>**Constraints**: *Pattern*: `^[A-Za-z][A-Za-z0-9_]*$` |
| `version` | `int` | Template, Required | Version number of the UDF.<br><br>**Constraints**: `>= 1` |

## Response Type

**200**: UDF version deleted.

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.V1OrganizationsUdfsVersionsVersionResponse](../../doc/models/v1-organizations-udfs-versions-version-response.md).

## Example Usage

```csharp
Guid organizationId = new Guid("000023b8-0000-0000-0000-000000000000");
string functionName = "functionName2";
int version = 1;
try
{
    ApiResponse<V1OrganizationsUdfsVersionsVersionResponse> result = await udfApi.UdfVersionDeleteAsync(
        organizationId,
        functionName,
        version
    );
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
    if (e is V1OrganizationsUdfsVersionsVersion400ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersionsVersion400ErrorException exception here
    }
    if (e is V1OrganizationsUdfsVersionsVersion404ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersionsVersion404ErrorException exception here
    }
    if (e is V1OrganizationsUdfsVersionsVersion409ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersionsVersion409ErrorException exception here
    }
    if (e is V1OrganizationsUdfsVersionsVersion500ErrorException)
    {
       // TODO: Handle V1OrganizationsUdfsVersionsVersion500ErrorException exception here
    }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | The request cannot be processed due to a client error. Please verify your request parameters and try again. | [`V1OrganizationsUdfsVersionsVersion400ErrorException`](../../doc/models/v1-organizations-udfs-versions-version-400-error-exception.md) |
| 404 | UDF or version not found. | [`V1OrganizationsUdfsVersionsVersion404ErrorException`](../../doc/models/v1-organizations-udfs-versions-version-404-error-exception.md) |
| 409 | The UDF version is the latest version, is attached to a service, or is still building. | [`V1OrganizationsUdfsVersionsVersion409ErrorException`](../../doc/models/v1-organizations-udfs-versions-version-409-error-exception.md) |
| 500 | An internal server error has occurred. If this issue persists, please contact ClickHouse Cloud support for assistance. | [`V1OrganizationsUdfsVersionsVersion500ErrorException`](../../doc/models/v1-organizations-udfs-versions-version-500-error-exception.md) |

