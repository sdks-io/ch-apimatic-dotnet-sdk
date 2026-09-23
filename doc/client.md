
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(30)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](../doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| LogBuilder | [`LogBuilder`](../doc/log-builder.md) | Represents the logging configuration builder for API calls |
| BasicAuthCredentials | [`BasicAuthCredentials`](auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |

The API client can be initialized as follows:

## Code-Based Initialization

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

## Configuration-Based Initialization

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

See the [Configuration-Based Initialization](../doc/configuration-based-initialization.md) section for details.

## OpenAPI spec for ClickHouse CloudClient Class

The gateway for the SDK. This class acts as a factory for the Apis and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| OrganizationApi | Gets OrganizationApi. |
| UserManagementApi | Gets UserManagementApi. |
| BillingApi | Gets BillingApi. |
| RoleManagementApi | Gets RoleManagementApi. |
| ServiceApi | Gets ServiceApi. |
| BackupApi | Gets BackupApi. |
| SnapshotApi | Gets SnapshotApi. |
| ApiKeysApi | Gets ApiKeysApi. |
| PrometheusApi | Gets PrometheusApi. |
| ClickPipesApi | Gets ClickPipesApi. |
| ClickStackApi | Gets ClickStackApi. |
| PostgresApi | Gets PostgresApi. |
| UdfApi | Gets UdfApi. |
| QueryApiEndpointsApi | Gets QueryApiEndpointsApi. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](../doc/http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| BasicAuthCredentials | Gets the credentials to use with BasicAuth. | [`IBasicAuthCredentials`](auth/basic-authentication.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the OpenAPI spec for ClickHouse CloudClient using the values provided for the builder. | `Builder` |

## OpenAPI spec for ClickHouse CloudClient Builder Class

Class to build instances of OpenAPI spec for ClickHouse CloudClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](../doc/http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `BasicAuthCredentials(Action<BasicAuthModel.Builder> action)` | Sets credentials for BasicAuth. | `Builder` |

