
# Prometheus Discovery Target Group

*This model accepts additional fields of type object.*

## Structure

`PrometheusDiscoveryTargetGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Targets` | `List<string>` | Optional | Host (and port) of the ClickHouse Cloud API. |
| `Labels` | [`PrometheusDiscoveryLabels`](../../doc/models/prometheus-discovery-labels.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example

```csharp
using OpenApiSpecForClickHouseCloud.Standard.Models;
using OpenApiSpecForClickHouseCloud.Standard.Utilities;
using System.Collections.Generic;

PrometheusDiscoveryTargetGroup prometheusDiscoveryTargetGroup = new PrometheusDiscoveryTargetGroup
{
    Targets = new List<string>
    {
        "targets0",
    },
    Labels = new PrometheusDiscoveryLabels
    {
        Scheme = "__scheme__0",
        MetricsPath = "__metrics_path__4",
        ParamFilteredMetrics = "__param_filtered_metrics0",
        ClickhouseOrgId = new Guid("000026d0-0000-0000-0000-000000000000"),
        ClickhouseServiceId = new Guid("0000074a-0000-0000-0000-000000000000"),
        ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
    },
    ["exampleAdditionalProperty"] = ApiHelper.JsonDeserialize<object>("{\"key1\":\"val1\",\"key2\":\"val2\"}"),
};
```

