
# Prometheus Discovery Labels

*This model accepts additional fields of type object.*

## Structure

`PrometheusDiscoveryLabels`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Scheme` | `string` | Optional | URL scheme Prometheus must scrape the target with. |
| `MetricsPath` | `string` | Optional | Path of the per-service Prometheus metrics endpoint. |
| `ParamFilteredMetrics` | `string` | Optional | Value passed as the filtered_metrics query parameter on each scrape. |
| `ClickhouseOrgId` | `Guid?` | Optional | Organization ID the service belongs to. |
| `ClickhouseServiceId` | `Guid?` | Optional | Service ID. |
| `ClickhouseDiscoveryServiceName` | `string` | Optional | Service name. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;

PrometheusDiscoveryLabels prometheusDiscoveryLabels = new PrometheusDiscoveryLabels
{
    Scheme = "__scheme__0",
    MetricsPath = "__metrics_path__4",
    ParamFilteredMetrics = "__param_filtered_metrics0",
    ClickhouseOrgId = new Guid("00000416-0000-0000-0000-000000000000"),
    ClickhouseServiceId = new Guid("00000ba0-0000-0000-0000-000000000000"),
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

