using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace OpenApiSpecForClickHouseCloud;

public static class ServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddOpenApiSpecForClickHouseCloudClient(Action<OpenApiSpecForClickHouseCloudClientOptions>? configure = null)
        {
            var options = new OpenApiSpecForClickHouseCloudClientOptions();
            configure?.Invoke(options);
            services.AddHttpClient();
            services.AddSingleton(sp =>
                {
                    options.Logging =
                        options.Logging with
                        {
                            LoggerFactory = options.Logging.LoggerFactory ?? sp.GetService<ILoggerFactory>()
                        };
                    var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                    var httpClient = httpClientFactory.CreateClient();
                    return new OpenApiSpecForClickHouseCloudClient(httpClient, options);
                });
            return services;
        }
    }
}
