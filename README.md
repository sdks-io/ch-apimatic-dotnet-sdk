
# Getting Started with OpenAPI spec for ClickHouse Cloud

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package ChApimaticSDK --version 0.0.1
```

You can also view the package at:
https://www.nuget.org/packages/ChApimaticSDK/0.0.1

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(30)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/log-builder.md) | Represents the logging configuration builder for API calls |
| BasicAuthCredentials | [`BasicAuthCredentials`](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |

The API client can be initialized as follows:

### Code-Based Initialization

```csharp
using Microsoft.Extensions.Logging;
using OpenApiSpecForClickHouseCloud.Standard;
using OpenApiSpecForClickHouseCloud.Standard.Authentication;

namespace ConsoleApp;

OpenApiSpecForClickHouseCloudClient client = new OpenApiSpecForClickHouseCloudClient.Builder()
    .BasicAuthCredentials(
        new BasicAuthModel.Builder(
            "BasicAuthUserName",
            "BasicAuthPassword"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

### Configuration-Based Initialization

```csharp
using OpenApiSpecForClickHouseCloud.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = OpenApiSpecForClickHouseCloudClient
    .FromConfiguration(configuration.GetSection("OpenApiSpecForClickHouseCloud"));
```

See the [Configuration-Based Initialization](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/configuration-based-initialization.md) section for details.

## Authorization

This API uses the following authentication schemes.

* [`basicAuth (Basic Authentication)`](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/auth/basic-authentication.md)

## List of APIs

* [Usermanagement](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/usermanagement.md)
* [Role Management](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/role-management.md)
* [AP Ikeys](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/ap-ikeys.md)
* [Query AP Iendpoints](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/query-ap-iendpoints.md)
* [Organization](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/organization.md)
* [Billing](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/billing.md)
* [Service](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/service.md)
* [Backup](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/backup.md)
* [Snapshot](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/snapshot.md)
* [Prometheus](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/prometheus.md)
* [Click Pipes](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/click-pipes.md)
* [Click Stack](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/click-stack.md)
* [Postgres](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/postgres.md)
* [UDF](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/controllers/udf.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/configuration-based-initialization.md)
* [HttpClientConfiguration](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/http-client-configuration-builder.md)
* [LogBuilder](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/log-response-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/http-callback.md)
* [HttpContext](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/http-context.md)
* [HttpRequest](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/http-request.md)
* [HttpResponse](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/api-exception.md)
* [ApiResponse](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/api-response.md)
* [ApiHelper](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/api-helper.md)
* [CustomDateTimeConverter](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](https://www.github.com/sdks-io/ch-apimatic-dotnet-sdk/tree/0.0.1/doc/unix-date-time-converter.md)

